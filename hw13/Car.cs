using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{
    public delegate void FinishAction(Car Winner);
    public abstract class Car
    {
        public Random rnd;
        public event FinishAction Finish;
        public string Name { get; set; }
        public int maxSpeed { get; set; }

        private double pos;
        public double Position
        {
            get { return pos; }
            set
            {
                pos = value;
                Console.WriteLine(this + " на позиции " + pos);
                if (pos >= 50)
                {
                    Console.WriteLine(this + " прошел половину дистанции");                  
                }
                if (pos >= 100) Finish(this);
            }
        }
        public override string ToString()
        {
            return Name;
        }

        public void JoinGame(Race r)
        {
            // Подписываемся на игру
            r.Move += this.Move;
            r.setPos += this.MoveTo;
            Finish = r.onFinish;
        }

        public abstract void Move();

        public void MoveTo(int Position)
        {
            this.Position = Position;
        }

    }
}
