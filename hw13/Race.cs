using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{
    public delegate void MoveTo();
    public delegate void setPosition(int Position); 

    public class Race
    {
        protected bool isGameStarted = false;

        public event MoveTo Move;
        public event setPosition setPos;

        public Car Winner;

        public void Run()
        {
            // все на страте
            setPos(0);

            // перемещаем машины к финишу
            isGameStarted = true;

            while (isGameStarted)
            {
                Move();

                System.Threading.Thread.Sleep(300);
                Console.Clear();
            }
        }

        public void onFinish(Car Winner)
        {
            // финиш
            isGameStarted = false;
            this.Winner = Winner;
        }
    }
}
