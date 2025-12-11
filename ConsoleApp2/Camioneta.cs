using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Camioneta:Vehiculo
    {
        public int capacidadDeCarga;
        public bool es4x4;
        public int tarifa = 1500;
        public override int Precio()
        {
           
            return tarifa;
        }
        public override string ToString()
        {
            return $"Camioneta";
        }


    }
}
