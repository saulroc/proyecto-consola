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
            if (NumeroEntrada >= 0)
            {
                NumeroEntrada++;
            }
        }

        public void PintarLetras()
        {
            for(int i = 0; i < Mensaje.Length; i++)
            {
                Console.WriteLine(Mensaje[i]);
            }
        }

        public void PintarLetras2()
        {
            foreach(var letra in Mensaje)
            {
                Console.WriteLine(letra);
            }
            
        }

        public void IncremetarCinco()
        {
            for (int x = 1; x < 6; x++ )
            {
                NumeroEntrada++;
                Console.WriteLine(NumeroEntrada);
            }
            /**
            int incremento = 1;
            while(incremento < 6)
            {
                NumeroEntrada++;
                Console.WriteLine(NumeroEntrada);
                incremento++;
            }
            **/
        }

        public void AlejarDelCero()
        {
            if (NumeroEntrada > 0)
            {
                NumeroEntrada++;
            }
            else if (NumeroEntrada < 0)
            {
                NumeroEntrada--;
            }
            else
            {
                Console.WriteLine("Numero entrada es cero");
            }
        }

        public void Escribir()
        {
            if (String.IsNullOrEmpty(Mensaje))
                return;
                
            Console.WriteLine(Mensaje + NumeroEntrada.ToString());
        }

    }
}