namespace IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos
{
    public interface IVehiculo
    {
        public int Id { get; set; }
        public int LimiteMaximoDeVelocidad { get; }
        public string Tipo { get; set; }

        public void Arrancar();
        public void Mover();
    }
}
