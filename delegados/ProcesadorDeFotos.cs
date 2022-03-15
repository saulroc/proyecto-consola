using System;

public class ProcesadorDeFotos
{
    public delegate void FotoFilterHandler(Foto foto);
    public void Procesar(string ruta, Action<Foto> fotoFilterHandler)
    {
        //System.Action<Foto>
        //System.Func<out Foto>;
        var foto = Foto.Cargar(ruta);

        var filtros = new FotoFiltros();
        
        fotoFilterHandler(foto);

        foto.Guardar();
    }
}