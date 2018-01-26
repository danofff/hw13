using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{
    public delegate void FinishAction(object Winner);
    public abstract class Car
    {
        public FinishAction Finish;
        string Name { get; set; }
        int maxSpeed { get; set; }

        void move()
        {

        }

    }
}
