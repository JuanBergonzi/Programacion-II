using WebVeterinaria.Datos;
using static WebVeterinaria.Repositorios.Animal.AnimalRepository;

namespace WebVeterinaria.Repositorios.Animal
{
    public class AnimalRepository : IAnimalRepository
    {
            private readonly TodoContext _context;

            public AnimalRepository(TodoContext context)
            {
                _context = context;
            }
            public Datos.Clase.Animal ObtenerAnimal(int id)
            {
                return _context.Animals.FirstOrDefault(x => x.IdAnimal == id);
            }
            public void Eliminar(WebVeterinaria.Datos.Clase.Animal animal)
            {
                _context.Animals.Remove(animal);
                _context.SaveChanges();
            }
            public void Agregar(WebVeterinaria.Datos.Clase.Animal animal)
            {
                _context.Animals.Add(animal);
                _context.SaveChanges();
            }
            public void Actualizar(WebVeterinaria.Datos.Clase.Animal animal)
            {
                _context.Animals.Update(animal);
                _context.SaveChanges();
            }
    }
}
