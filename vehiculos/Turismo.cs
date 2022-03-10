using System;

namespace IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos
{
    public class Turismo : IVehiculo
    {
        public int LimiteMaximoDeVelocidad { get; }
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public Turismo()
        {
            Tipo = nameof(Turismo);
            LimiteMaximoDeVelocidad = 120;
        }

        public override string ToString()
        {
            return base.ToString() + $", Modelo: {Modelo}";
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