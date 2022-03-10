using System;
using IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos;

namespace IESPeñasNegras.ProyectoEjemplo.Consola
{

    class Program
    {
         static void Main(string[] args)
        {
            //Vehiculo vehiculo = new Vehiculo(60);

            var coche = new Turismo();
            
            Console.WriteLine(coche);
            ArrancarYMover(coche);

            var camion = new Camion();
            Console.WriteLine(camion);
            ArrancarYMover(camion);
            
            Console.ReadLine();
        }

        static void ArrancarYMover(IVehiculo vehiculo)
        {
            vehiculo.Arrancar();
            vehiculo.Mover();
        }
        
    }    
    
}
