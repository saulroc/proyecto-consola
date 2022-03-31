using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos;

namespace IESPeñasNegras.ProyectoEjemplo.Consola
{

    class Program
    {
         static void Main(string[] args)
        {
          
            using(var dbContext = new VehiculosContext())
            {
                // System.Console.WriteLine("Insertando un turismo");
                // dbContext.Add(new Turismo(default) { Modelo = "Ford Cugart"});
                // dbContext.SaveChanges();

                // var turismo = dbContext.Set<Turismo>().Where(t => t.Modelo == "Ford Scort").FirstOrDefault();
                // System.Console.WriteLine(turismo);

                // turismo.Modelo = "Nuevo Modelo";
                // dbContext.SaveChanges();

                var turismo = dbContext.Set<Turismo>().Where(t => t.Modelo == "Nuevo Modelo").FirstOrDefault();
                System.Console.WriteLine(turismo);

                System.Console.WriteLine("Borrando el turismo");
                dbContext.Remove(turismo);
                dbContext.SaveChanges();


            }
            Console.ReadLine();
        }   
        
    }    
    
}
