
using ConsoleApp2;
Estacionamiento estacionamiento = new Estacionamiento();
int sel = 1;

while (sel != 0)
{ 
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Agregar vehículo");
    Console.WriteLine("2. Mostrar vehículos");
    Console.WriteLine("3. Mostrar total recaudado");
    Console.WriteLine("0. Salir");
    sel = int.Parse(Console.ReadLine());
    switch (sel)
    {
        case 1:
            int selec = 1;
            Console.WriteLine("Seleccione el tipo de vehículo a agregar:");
            Console.WriteLine("1. Camión");
            Console.WriteLine("2. Auto");
            Console.WriteLine("3. Camioneta");
            Console.WriteLine("4. Bicicleta");
            Console.WriteLine("5. Moto");
            Console.WriteLine("0. Volver al menú principal");
            selec = int.Parse(Console.ReadLine());
            switch (selec)
            {
                case 1:
                    cargarCamion();
                    break;
                case 2:
                    cargarAuto();
                    break;
                case 3:
                    cargarcamioneta();
                    break;
                case 4:
                    cargarbicicleta();
                    break;
                case 5:
                    cargarmoto();
                    break;
                case 0:    
                    selec = 0;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            break;
        case 2:
            estacionamiento.MuestraVehiculos();
            break;
        case 3:
            estacionamiento.totalrecaudado();
            break;
        case 0:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

}
void cargarCamion()
{
    camion cam = new camion();
    Console.WriteLine("Ingrese ID del camión:");
    cam.id = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese dueño del camión:");
    cam.dueño = Console.ReadLine();
    Console.WriteLine("Ingrese número de ejes:");
    cam.numeroDeEjes = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese peso máximo admitido:");
    cam.PesoMaximoAdmitido = int.Parse(Console.ReadLine());

    estacionamiento.vehiculos.Add(cam);
}
void cargarAuto()
{
    Auto aut = new Auto();
    Console.WriteLine("Ingrese ID del auto:");
    aut.id = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese dueño del auto:");
    aut.dueño = Console.ReadLine();
    Console.WriteLine("Ingrese número de puertas:");
    aut.CantidadDePuertas = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese tipo de combustible (electrico, diesel, etc.):");
    aut.combustible = Console.ReadLine();
    estacionamiento.vehiculos.Add(aut);
}
void cargarcamioneta()
{
     Camioneta camio = new Camioneta();
    Console.WriteLine("Ingrese ID de la camioneta:");
    camio.id = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese dueño de la camioneta:");
    camio.dueño = Console.ReadLine();
    Console.WriteLine("Ingrese capacidad de carga:");
    camio.capacidadDeCarga = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese si es 4x4 (true/false):");
    camio.es4x4 = bool.Parse(Console.ReadLine());
    estacionamiento.vehiculos.Add(camio);
}
void cargarbicicleta()
{
    Bicicleta bic = new Bicicleta();
    Console.WriteLine("Ingrese ID de la bicicleta:");
    bic.id = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese dueño de la bicicleta:");
    bic.dueño = Console.ReadLine();
    Console.WriteLine("Ingrese tipo de bicicleta (montaña, ruta, etc.):");
    bic.tipo = Console.ReadLine();
    Console.WriteLine("ingrese el material del cuadro:");
    bic.MaterialDelCuadro = Console.ReadLine();
    estacionamiento.vehiculos.Add(bic);
}
void cargarmoto()
{
    Moto mot = new Moto();
    Console.WriteLine("Ingrese ID de la moto:");
    mot.id = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese dueño de la moto:");
    mot.dueño = Console.ReadLine();
    Console.WriteLine("Ingrese cilindrada:");
    mot.cilindrada = Console.ReadLine();
    Console.WriteLine("ingrese el tipo de moto(calle, enduro, etc.):");
    mot.tipo = Console.ReadLine();
    estacionamiento.vehiculos.Add(mot);
}


