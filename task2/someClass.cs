using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   
    class someClass : iPropertychanged
    {
        public event Propertyhandler PropertyChanged = Program.propHandler;

        public int prop = 0;
        public int someproperty
        {
            get { return prop; }

            set
            {
                if (prop != value)
                {
                    PropertyChanged.Invoke();
                    prop = value;

                }
            }
        }
    }
}
