using System;

namespace consola
{
    enum CaraOCruz
    {
        Cara,
        Cruz,
        DeCanto
    }
    class Program
    {
         static void Main(string[] args)
        {
            var moneda = new Random();
            CaraOCruz tiradaDeMoneda = (CaraOCruz)moneda.Next(0, 2);
            Console.WriteLine($"¿{CaraOCruz.Cara} (0) o {CaraOCruz.Cruz} (1)?");
            CaraOCruz opcionUsuario = (CaraOCruz)Int32.Parse(Console.ReadLine());

            if (opcionUsuario == tiradaDeMoneda)
            {
                Console.WriteLine($"¡¡Ha acertado!!, ha salido {tiradaDeMoneda}");                 
            }
            else
            {
                Console.WriteLine($"Ha fallado, la moneda ha salido {tiradaDeMoneda}");
            }

            foreach( var name in Enum.GetNames(tiradaDeMoneda.GetType()))
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
        
    }    
    
}
