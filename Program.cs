using System;
using System.Collections.Generic;
using System.Linq;
using IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos;

namespace IESPeñasNegras.ProyectoEjemplo.Consola
{

    class Program
    {
         static void Main(string[] args)
        {
            List<Turismo> turismos = new List<Turismo>() {
                new Turismo(1) { Modelo = "Seat" },
                new Turismo(2) { Modelo = "Peugeot" },
                new Turismo(3) { Modelo = "Opel"},
                new Turismo(4) { Modelo = "Seat"}
            };

            foreach(var turismo in turismos.Where(t => t.Id > 1).Select(t => new { Modelo = t.Modelo, Limite = t.LimiteMaximoDeVelocidad } ))
            {
                System.Console.WriteLine(turismo);
            }

            foreach(var turismo in turismos.Where(t => t.Modelo == "Seat"))
            {
                System.Console.WriteLine(turismo);
            }
            
            Console.ReadLine();
        }   
        
    }    
    
}
