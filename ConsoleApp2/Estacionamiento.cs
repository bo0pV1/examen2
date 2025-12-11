using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Estacionamiento
    {

        public List<Vehiculo> vehiculos = new List<Vehiculo>();

        public void MuestraVehiculos()
        {
            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine($"Vehiculo:{vehiculo}, ID: {vehiculo.id}, Dueño: {vehiculo.dueño}");
            }
        }
        public void totalrecaudado()
        {
            int total = 0;
            foreach (var vehiculo in vehiculos)
            {
                total += vehiculo.Precio();
            }
            Console.WriteLine($"Total recaudado: {total}");
        }

        

    }
}
