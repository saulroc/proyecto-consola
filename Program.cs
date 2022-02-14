using System;

namespace consola
{
    class Program
    {
        const string MENSAJE_INICIAL = "Este es el número de entrada: ";
        const int NUMERO_ENTRADA_INICIAL = 1;
        static void Main(string[] args)
        {
            MiSegundaClase miSegundaClase = new MiSegundaClase();
            miSegundaClase.Mensaje = MENSAJE_INICIAL;
            
            miSegundaClase.NumeroEntrada = NUMERO_ENTRADA_INICIAL;
            miSegundaClase.IncremetarCinco();
            miSegundaClase.PintarLetras2();
            miSegundaClase.Escribir();

            Console.WriteLine(MENSAJE_INICIAL);

            Console.ReadKey();
        }
    }
    
}
