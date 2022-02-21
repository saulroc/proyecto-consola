using System;

namespace consola
{
    class Program
    {
        const string MENSAJE_INICIAL = "Este es el número de entrada: ";
        const int NUMERO_ENTRADA_INICIAL = 1;
        static void Main(string[] args)
        {
            int opcion = 1;
            
            // CONDICION ? verdadero : falso;
            string mensaje = opcion == 1 
                ? "Es opción 1" 
                : "No es opción 1";

            //return opcion == 1 ? "Es opción 1" : "No es opción 1";
            //return opcion == 1 || opcion == 2 ? "Es opción 1" : "No es opción 1";

            Console.WriteLine(mensaje);

            var vehiculo = new Vehiculo(80);
            Console.WriteLine("Mi límite de velocidad es: " + vehiculo.LimiteMaximoDeVelocidad);
            vehiculo = new Turismo();
            Console.WriteLine("Mi nuevo límite de velocidad es: " + vehiculo.LimiteMaximoDeVelocidad);

            Vehiculo[] vehiculos = new Vehiculo[2];
            vehiculos[0] = new Camion();
            vehiculos[1] = new Turismo();

            vehiculos[0].Matricula = "0000AAA";
            Console.WriteLine("La matrícula es: " + vehiculos[0].Matricula);
            
            //Cast -> Conversión de un tipo genérico a un tipo específico
            Camion camion = (Camion)vehiculos[0];
            camion.CapacidadDeCarga = 1000;
            Console.WriteLine("La capacidad de carga es: " + camion.CapacidadDeCarga);

            Console.ReadLine();
        }
    }
    
}
