using System;
using IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos;

public class Camion : IVehiculo
{
    public int CapacidadDeCarga { get; set; }
    public int Id { get; set; }

    public int LimiteMaximoDeVelocidad { get; }

    public string Tipo { get; set; }

    public Camion()
    {
        Tipo = nameof(Camion);
        LimiteMaximoDeVelocidad = 90;
    }

    public override string ToString()
    {
        return base.ToString() + $", Capacidad de carga: {CapacidadDeCarga}";
    }

    public void Mover()
    {
        Console.WriteLine("Moviendo un camión");
    }

    public void Arrancar()
    {
        Console.WriteLine($"Arrancando un {Tipo}");
    }
}