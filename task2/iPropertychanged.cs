using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public delegate void Propertyhandler();
    interface iPropertychanged
    {
        event Propertyhandler PropertyChanged;
        int someproperty { get; set; }
    }
}
