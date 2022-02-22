using System;
using System.Collections.Generic;

namespace consola
{
    class Program
    {
        const string MENSAJE_INICIAL = "Este es el número de entrada: ";
        const int NUMERO_ENTRADA_INICIAL = 1;
        static void Main(string[] args)
        {
            //string[] diasDeLaSemana = new string[] {"Lunes", "Martes"};
            //Vehiculo[] listaDeVehiculos = new Vehiculo[2];

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            var turismo = new Turismo();
            turismo.Matricula = "0000AAA";
            turismo.Modelo = "Toyota Celica";

            vehiculos.Add(turismo);

            var segundoTurismo = new Turismo() {
                Matricula = "0001BBB",
                Modelo = "Lancia Stratos"
            };

            vehiculos.Add(segundoTurismo);

            vehiculos.Add(new Camion() { Matricula = "0002CCC" });

            foreach(var vehiculo in vehiculos)
            {
                EscribirVehiculo(vehiculo);
            }

            Console.ReadLine();
        }

        public static void EscribirVehiculo(Vehiculo vehiculo)
        {
            Console.WriteLine("Vehiculo con matricula: " + vehiculo.Matricula);
            Console.WriteLine("Del tipo: " + vehiculo.Tipo);
        }
        
    }    
    
}
