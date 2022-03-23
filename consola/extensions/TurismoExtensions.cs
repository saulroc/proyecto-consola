using System;
using IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos;

namespace IESPeñasNegras.ProyectoEjemplo.Consola.Extensions
{
    public static class TurismoExtensions
    {
        public static void HacerAlgo(this Turismo turismo)
        {
            Console.WriteLine(turismo.ToString());
        }
    }
}