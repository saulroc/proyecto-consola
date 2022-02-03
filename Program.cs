using System;

namespace consola
{
    class Program
    {
        static void Main(string[] args)
        {
             
            MiPrimeraClase objetoMiPrimeraClase = new MiPrimeraClase();
            objetoMiPrimeraClase.MensajeDeSalida = "Hola Mundo";
            objetoMiPrimeraClase.Ejecutar();

            Console.WriteLine("Escrito desde Program: " + objetoMiPrimeraClase.MensajeDeEntrada);
        }
    }
    
}
