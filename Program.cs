using System;

namespace consola
{
    class Program
    {
        const string MENSAJE_INICIAL = "Este es el número de entrada: ";
        const int NUMERO_ENTRADA_INICIAL = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una opción: ");
            int opcion = Int32.Parse(Console.ReadLine());
            // if (opcion == 1)
            // {
            //     //hago algo
            // }
            // else if (opcion == 2)
            // {
            //     // hago otra cosa
            // }
            // else if (opcion == 3)
            // {
            //     //otra operación distinta
            // }
            // else
            // {
            //     //operación por defecto
            // }
            switch (opcion)
            {
                case 1:
                case 3:
                case 4:
                    //hacer algo
                    break;
                case 2:
                    // hacer otra cosa
                    break;
                default:
                    // operación por defecto
                    break;
            }
            Console.ReadLine();
        }
    }
    
}
