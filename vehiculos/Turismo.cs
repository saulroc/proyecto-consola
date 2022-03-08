namespace IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos
{
    public class Turismo : Vehiculo
    {
        public string Modelo { get; set; }
        public Turismo() : base(120)
        {
            Tipo = nameof(Turismo);
        }

        public override string ToString()
        {
            return base.ToString() + $", Modelo: {Modelo}";
        }
    }
}