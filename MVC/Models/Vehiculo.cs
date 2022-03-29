namespace MVC.Models
{
    public class Vehiculo
    {
        public Vehiculo(int id, string name)
        {  
            Id = id;
            Name = name;
        }

        public Vehiculo()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
