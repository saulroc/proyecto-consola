using System;

namespace consola
{
    class Program
    {
        const string MENSAJE_INICIAL = "Este es el número de entrada: ";
        const int NUMERO_ENTRADA_INICIAL = 1;
        static void Main(string[] args)
        {
            int[] miArrayDeEnteros = new int[] { 3, 4, 5, 6, 7};
            string[] miArrayDeCadenas = new string[] {"hola", "adios", "hasta pronto"};

            Console.WriteLine("Primer entero: " + miArrayDeEnteros[0]);
            Console.WriteLine("Quinto entero: " + miArrayDeEnteros[4]);
            //Esta línea provocaria un error de indice fuera de rango
            //Console.WriteLine("Quinto entero: " + miArrayDeEnteros[5]);
            miArrayDeEnteros[0]++;
            
            Console.WriteLine("Primer entero: " + miArrayDeEnteros[0]);

            Console.WriteLine("Primera cadena de texto: " + miArrayDeCadenas[0]);
            Console.WriteLine("La cuarta letra de la primera cadena de texto: " + miArrayDeCadenas[0][3]);

            foreach(var cadena in miArrayDeCadenas)
            {
                Console.WriteLine(cadena);
            }

            Array.Resize(ref miArrayDeCadenas, miArrayDeCadenas.Length+1);
            miArrayDeCadenas[miArrayDeCadenas.Length-1] = "Hasta luego";
            Console.WriteLine("Añadimos un elemento al array: ");
            foreach(var cadena in miArrayDeCadenas)
            {
                Console.WriteLine(cadena);
            }
            Console.ReadLine();
        }
    }
    
}
