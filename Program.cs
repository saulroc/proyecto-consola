using System;
using System.Collections.Generic;
using IESPeñasNegras.ProyectoEjemplo.Consola.Vehiculos;
using IESPeñasNegrreturnas.ProyectoEjemplo.Consola.Extensions;

namespace IESPeñasNegras.ProyectoEjemplo.Consola
{

    class Program
    {
         static void Main(string[] args)
        {
            //Genericos <T> de tipo string
            List<string> mensajes = new List<string>();
            mensajes.Add("Un mensaje");
            string miMensaje = "¡Hola mundo!";

            //Genericos <T> donde T es IVehiculo de tipo Turismo
            var listaVehiculos = new ListaVehiculos<Turismo>();
            listaVehiculos.AñadirVehiculo(new Turismo());

            var procesadorDeFotos = new ProcesadorDeFotos();
            var fotoFiltros = new FotoFiltros();
            Action<Foto> filtrosHandler = fotoFiltros.AplicarBrillo;
            filtrosHandler += fotoFiltros.AjustarTamaño;
            filtrosHandler += fotoFiltros.AplicarContraste;
            filtrosHandler += QuitarOjosRojos;
            
            procesadorDeFotos.Procesar("", filtrosHandler);

            Console.ReadLine();
        }  

        public static void QuitarOjosRojos(Foto foto)    
        {
            System.Console.WriteLine("Quitando ojos rojos");
        }  
        
    }    
    
}
