using System;

namespace consola
{
    public class MiSegundaClase
    {
        public MiSegundaClase()
        {
        }

        public MiSegundaClase(int numeroEntrada, string mensaje)
        {
            this.NumeroEntrada = numeroEntrada;
            this.Mensaje = mensaje;
        }

        public int NumeroEntrada { get; set; }
        public string Mensaje { get; set; }

        public void Incremetar()
        {
            NumeroEntrada++;
        }
        public void Escribir()
        {
            Console.WriteLine(Mensaje + NumeroEntrada.ToString());
        }

    }
}