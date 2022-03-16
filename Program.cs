using System;
using System.Collections.Generic;
using IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos;
using IESPeñasNegrreturnas.ProyectoEjemplo.Consola.Extensions;

namespace IESPeñasNegras.ProyectoEjemplo.Consola
{

    class Program
    {
         static async void Main(string[] args)
        {
            List<Turismo> turismos = new List<Turismo>() {
                new Turismo() { Modelo = "Seat" },
                new Turismo() { Modelo = "Peugeot" },
                new Turismo() { Modelo = "Opel"}
            };

            turismos.Find(EncontrarPeugeot);
            
            Func<Turismo, bool> encontrarTodos = t => t.Modelo == "Peugeot";
            //turismos.FindAll(encontrarTodos);
            turismos.FindAll(t => t.Modelo == "Peugeot" || t.Modelo == "Seat");
            
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));
            
            Console.ReadLine();
        }  

        public static bool EncontrarPeugeot(Turismo turismo)
        {
            // if (turismo.Modelo == "Peugeot")
            // {
            //     return true;
            // }
            // else 
            // {
            //     return false;
            // }
            Console.WriteLine(turismo);
            return turismo.Modelo == "Peugeot";
        }

        public static void QuitarOjosRojos(Foto foto)    
        {
            System.Console.WriteLine("Quitando ojos rojos");
        }  
        
    }    
    
}
