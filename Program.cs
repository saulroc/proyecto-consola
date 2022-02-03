using System;

namespace consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensajeDeSalida;

            mensajeDeSalida = "Hello Mora!";
            Console.WriteLine(mensajeDeSalida);

            mensajeDeSalida = "Estamos programando";
            Console.Write(mensajeDeSalida);
            mensajeDeSalida = Console.ReadLine();
            Console.WriteLine("Tu mensaje es:" + mensajeDeSalida);
            Console.ReadLine(); //Esto es una pausa
             
            
        }
    }
}
