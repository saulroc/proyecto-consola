namespace IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos
{
    public class ListaVehiculos<T> where T : IVehiculo
    {
        public void AñadirVehiculo(T item)
        {
            item.Arrancar();
        }
    }
}