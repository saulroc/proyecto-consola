using System;
using IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos;

public class Camion : Vehiculo
{
    public int CapacidadDeCarga { get; set; }
    public Camion() : base(90)
    {
        Tipo = nameof(Camion);
    }

    public override string ToString()
    {
        return base.ToString() + $", Capacidad de carga: {CapacidadDeCarga}";
    }

    public override void Mover()
    {
        Console.WriteLine("Moviendo un camión");
    }
    
}