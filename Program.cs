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
            coche.Matricula = "0000AAA";
            Console.WriteLine(coche);

            var camion = new Camion();
            camion.Matricula = "1111BBB";
            Console.WriteLine(camion);
            Console.WriteLine(camion.Ruedas.Count);
            Console.ReadLine();
        }
        
    }    
    
}
