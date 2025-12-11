using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  class camion:Vehiculo
    {
        public int numeroDeEjes { get; set; }
        public int PesoMaximoAdmitido { get; set; }
        public int tarifa = 2500;

        public override int Precio()
        {
            return tarifa;
        }
        public override string ToString()
        {
            return $"Camion";
        }
    }
}
