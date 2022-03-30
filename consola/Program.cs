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
                System.Console.WriteLine("Insertando un turismo");
                dbContext.Add(new Turismo(default) { Modelo = "Ford Focus"});
                dbContext.SaveChanges();
            }
            Console.ReadLine();
        }   
        
    }    
    
}
