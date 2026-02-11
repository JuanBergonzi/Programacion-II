using AdminVeterinariaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminVeterinariaMVC.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConsultarAnimal(string nombre, string especie, string raza, string color)
        {

            var animal = new Animal("Taquiño", "Pegriloso", "Canishe", "VerdeAqua");


            //ViewData["nombre"] = nombre;

            return View(animal);
        }
    }
}
