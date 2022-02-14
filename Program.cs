using System;

namespace consola
{
    class Program
    {
        const string MENSAJE_INICIAL = "Este es el número de entrada: ";
        const int NUMERO_ENTRADA_INICIAL = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero: ");
            int numeroIntroducido;
            try
            {
                numeroIntroducido = Int32.Parse(Console.ReadLine());  
                Console.WriteLine("El numero introducido es: " + numeroIntroducido.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error genérico");
                // throw ex;
            }
            // catch (System.FormatException ex)
            // {
            //     Console.WriteLine("El valor introducido no tiene formato de número");
            //     throw ex;
            // }
            // catch (System.OverflowException)
            // {
            //     Console.WriteLine("El número introducido es demasiado grande o demasiado pequeño");
            // }
            // catch(System.ArgumentNullException)
            // {
            //     Console.WriteLine("No ha introducido un valor");
            // }
            finally
            {
                Console.WriteLine("Esto se ejecuta siempre");
            }
            Console.ReadLine();
        }
    }
    
}
