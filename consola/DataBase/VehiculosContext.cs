using IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos;
using Microsoft.EntityFrameworkCore;

namespace IESPeñasNegras.ProyectoEjemplo.Consola
{
    public class VehiculosContext : DbContext
    {
        public DbSet<Turismo> Turismos { get; set; }
        public DbSet<Camion> Camiones { get; set; }
        public DbSet<Rueda> Ruedas { get; set; }

        public string ConnectionString { get; }

        public VehiculosContext()
        {
            ConnectionString="Server=DESKTOP-OGC34KG;Database=Vehiculos;Trusted_Connection=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(ConnectionString);
        
    }
}