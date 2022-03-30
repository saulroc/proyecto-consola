using System;
using System.Collections.Generic;

namespace IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos
{
    public class Turismo : IVehiculo
    {
        public int LimiteMaximoDeVelocidad { get; }
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public List<Rueda> Ruedas { get; set; }
        public Turismo(int id)
        {
            Id = id;
            Tipo = nameof(Turismo);
            LimiteMaximoDeVelocidad = 120;
            Ruedas = new List<Rueda>();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Modelo: {Modelo}";
        }

        public void Mover()
        {
            Console.WriteLine("Moviendo un turismo");
        }

        public void Arrancar()
        {
            Console.WriteLine($"Arrancando {Tipo}");
        }
    }
}