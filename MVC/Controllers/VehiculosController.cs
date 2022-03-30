using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class VehiculosController : Controller
    {
        public IActionResult Index()
        {
            var vehiculo = new Vehiculo(1, "Ford Scort");

            var vehiculo2 = new Vehiculo();
            vehiculo2.Id = 2;
            vehiculo2.Name = "Ford Fiesta";

            var vehiculo3 = new Vehiculo() { Id = 3, Name = "Ford Focus" };

           // return View(vehiculo);
            return this.Redirect("/home");
        }

        public IActionResult Edit(int id)
        {
            return Content("ID: " + id);
        }
    }
}
