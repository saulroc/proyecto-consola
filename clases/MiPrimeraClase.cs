using System;

namespace IESPeñasNegras.ProyectoEjemplo.Consola.Clases
{
    public class MiPrimeraClase
    {
        public string MensajeDeSalida { get; set; }
        public string MensajeDeEntrada { get; set; }
        public void Ejecutar()
        {
            Console.WriteLine(MensajeDeSalida);

            MensajeDeEntrada = Console.ReadLine();

            Console.WriteLine (MensajeDeSalida + MensajeDeEntrada);
            
        }
    }
}