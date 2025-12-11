using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Moto:Vehiculo
    {
        public string cilindrada { get; set; }
        public string tipo { get; set; }
        public int tarifa = 600;

        public override int Precio()
        {
            return tarifa;
        }

    }
}
