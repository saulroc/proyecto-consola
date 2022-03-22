using System;
using System.Threading.Tasks;

public class Tarea
{
    public string Nombre { get; set; }

    public Tarea(string nombre)
    {
        Nombre = nombre; 
    }
    public Task EjecutarTarea()
    {
        for(var i = 0; i < 10000; i++)
        {
            Console.WriteLine($"Ejecutando {Nombre}: {i}%");
        } 
        return Task.CompletedTask;       
    }
}