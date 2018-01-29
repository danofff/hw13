using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{
    class Truck:Car
    {
        public Truck()
        {
            Name = "Truck";
            maxSpeed = 250;
            rnd = new Random();
        }
        public override void Move()
        {
            Position += rnd.Next(50,maxSpeed+1) / 100;
        }
    }
}
