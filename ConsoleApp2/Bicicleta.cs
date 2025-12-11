using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Bicicleta: Vehiculo
    {
        public string tipo { get; set; }
        public string MaterialDelCuadro { get; set; }
        public int tarifa = 200;

        public override int Precio()
        {
            return tarifa;
        }
    }
}
