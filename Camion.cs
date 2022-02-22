public class Camion : Vehiculo
{
    public int CapacidadDeCarga { get; set; }
    public Camion() : base(90)
    {
        Tipo = nameof(Camion);
    }
}