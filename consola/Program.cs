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
          
            List<Task> tareas = new List<Task>();
            for(var i = 0; i <10; i++)
            {
                var tarea = new Tarea($"Tarea {i+1}");
                tareas.Add(tarea.EjecutarTarea());
            }
            Task.WaitAll(tareas.ToArray());
            Console.ReadLine();
        }   
        
    }    
    
}
