using System;

namespace IESPeñasNegras.ProyectoEjemplo.Consola
{

    class Program
    {
         static void Main(string[] args)
        {
            //declaración e instancia de las variables
            var fechaActual = DateTime.Now;
            var fecha = new DateTime(1992, 10, 13);
            
            //uso de método
            Console.WriteLine(fechaActual.AddYears(-10));
            //fechaActual = fechaActual.AddYears(-10);
            //Propiedad Date
            Console.WriteLine(fechaActual.Date);
            Console.WriteLine(fechaActual.Date.ToString("dd-MM-yyyy"));
            
            //Parte time
            Console.WriteLine(fechaActual.TimeOfDay);

            Console.ReadLine();
        }
        
    }    
    
}
