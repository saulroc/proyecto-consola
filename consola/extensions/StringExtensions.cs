
using System;

namespace IESPeñasNegrreturnas.ProyectoEjemplo.Consola.Extensions
{
    public static class StringExtensions
    {
        public static int ContarPalabras(this String cadena)
        {
            return cadena.Split(' ').Length;
        }

        public static string AñadirTexto(this String cadena, string texto)
        {
            return cadena + texto;
        }
    }
}