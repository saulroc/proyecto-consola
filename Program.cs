using System;
using IESPeñasNegrreturnas.ProyectoEjemplo.Consola.Extensions;

namespace IESPeñasNegras.ProyectoEjemplo.Consola
{

    class Program
    {
         static void Main(string[] args)
        {
            string miMensaje = "¡Hola mundo!";

            Console.WriteLine($"El mensaje tiene {miMensaje.ContarPalabras()} palabras");
            System.Console.WriteLine("Introduzca un mensaje:");
            miMensaje = Console.ReadLine();
            Console.WriteLine("El mensaje tiene {0} palabras", miMensaje.ContarPalabras());
            
            System.Console.WriteLine("Introduzca un texto a añadir:");
            string mensajeMasTexto = miMensaje.AñadirTexto(Console.ReadLine());
            Console.WriteLine("El mensaje con el texto añadido tiene {0} palabras", mensajeMasTexto.ContarPalabras());
            Console.WriteLine("El mensaje es " + mensajeMasTexto);
            Console.ReadLine();
        }        
        
    }    
    
}
