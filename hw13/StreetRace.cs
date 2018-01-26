using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{
    delegate void MoveAction(); // делегат перемещения
    delegate void PosSetter(int Position); // установка позиции

    class Game
    {
        protected bool isGameStarted = false;

        public MoveAction Move;
        public PosSetter MoveTo;

        public object Winner;

        public void Run()
        {
            // перемещаем всех на старт
            MoveTo(0);

            // тикаем всех вперед пока кто-нибудь не приедет к финишу
            isGameStarted = true;
            while (isGameStarted)
            {
                Move();

                System.Threading.Thread.Sleep(500);
                // Console.Clear();
            }
        }

        public void OnFinis(object Winner)
        {
            // кто-то приехал к финишу
            isGameStarted = false;
            this.Winner = Winner;
        }
    }

    // Абстракный класс машинок (можно без него)
    abstract class MovableObject
    {
        public FinishAction Finish;
        public string Name;

        int _pos;
        public int Position
        {
            get { return _pos; }
            set
            {
                _pos = value;
                Console.WriteLine(this + " на позиции " + _pos);
                if (_pos >= 100) Finish(this);
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public void JoinGame(Game Game)
        {
            // Подписываемся на игру
            Game.Move += this.Move;
            Game.MoveTo += this.MoveTo;
            Finish = Game.OnFinis;
        }

        public abstract void Move();

        public void MoveTo(int Position)
        {
            this.Position = Position;
        }
    }

   /* class Car : MovableObject
    {
        public int Speed;
        public override void Move()
        {
            Position += Speed;
        }
    }*/

    class RandomCar : MovableObject
    {
        Random rnd = new Random();
        public override void Move()
        {
            Position += rnd.Next(0, 6);
        }
    }

    static class TaskClass
    {
        static void Main()
        {
            // Создаем игру
            Game game = new Game();

            // Создаем машинки
            MovableObject car1 = new Car() { Name = "car1", Speed = 2 };
            MovableObject car2 = new Car() { Name = "car2", Speed = 4 };
            MovableObject r = new RandomCar() { Name = "Коняшка" };

            // Подписываемся на участие в игре
            car1.JoinGame(game);
            car2.JoinGame(game);
            r.JoinGame(game);

            // Запуск игры
            game.Run();

            // Печатаем победителя
            Console.WriteLine("Победил " + game.Winner);

            Console.ReadLine();
        }

    }
}
