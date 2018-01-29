using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{
    class Bus:Car
    {
        public Bus()
        {
            Name = "Bus";
            maxSpeed = 230;
            rnd = new Random();
        }
        public override void Move()
        {
            Position += rnd.Next(50, maxSpeed + 1) / 100;
        }
    }
}
