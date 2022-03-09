using System;
using System.Collections.Generic;

namespace IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos
{
    public abstract class Vehiculo
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Tipo { get; set; }
        public int LimiteMaximoDeVelocidad { get; }
        public List<Rueda> Ruedas { get; set; }

        public Vehiculo(int limiteMaximoDeVelocidad)
        {
            LimiteMaximoDeVelocidad = limiteMaximoDeVelocidad;
        }

        public void Arrancar()
        {
            Console.WriteLine("Bron, Bron!...");
        }

        public abstract void Mover();

        public void Mover(int metros)
        {

        }

        public void Mover(string direccion)
        {
            
        }
    }
}

