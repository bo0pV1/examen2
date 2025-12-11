using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Vehiculo
    {
       public int id { get; set; }
        public string dueño {get; set;}

        public abstract int Precio();
        
    }
}
