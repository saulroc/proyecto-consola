namespace IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos
{
    public class Rueda
    {
        public int Diametro { get; set; }
        public int Id { get; set; }
        public int TurismoId { get; set;}
        public virtual Turismo Turismo { get; set; }

        public Rueda(int id, int diametro, int turismoId)
        {
            Id = id;
            Diametro = diametro;
            TurismoId = turismoId;
        }
    }
}