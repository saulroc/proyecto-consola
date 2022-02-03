using System;

public class MiPrimeraClase
{
    public string MensajeDeSalida { get; set; }
    public string MensajeDeEntrada { get; set; }
    public void Ejecutar()
    {
        Console.WriteLine(this.MensajeDeSalida);

        this.MensajeDeEntrada = Console.ReadLine();

        Console.WriteLine (this.MensajeDeSalida + this.MensajeDeEntrada);
        
    }
}