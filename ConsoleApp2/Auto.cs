using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Auto:Vehiculo
    {
        public int CantidadDePuertas { get; set; }
        public string combustible { get; set; }
        public int tarifa = 1000;
        public override int Precio()
        {
            return tarifa;
            
        }
        public override string ToString()
        {
            return $"Auto";
        }

    }
}
