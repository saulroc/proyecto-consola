using System;

public class Vehiculo
{
    public string Matricula { get; set; }
    public string Tipo { get; set; }
    public int LimiteMaximoDeVelocidad { get; }

    public Vehiculo(int limiteMaximoDeVelocidad)
    {
        LimiteMaximoDeVelocidad = limiteMaximoDeVelocidad;
    }

    public void Arrancar()
    {
        Console.WriteLine("Bron, Bron!...");
    }

    public void Mover()
    {

    }

    public void Mover(int metros)
    {

    }

    public void Mover(string direccion)
    {
        
    }
}
