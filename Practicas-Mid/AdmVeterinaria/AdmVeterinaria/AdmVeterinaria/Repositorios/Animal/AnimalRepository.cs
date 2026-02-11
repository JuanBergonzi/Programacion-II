using AdmVeterinaria.Datos;
using AdmVeterinaria.Repositorios.Animal;

namespace AdmVeterinaria.Repositorios.Animal
{
    public class AnimalRepository : IAnimalRepository
    {
            private readonly TodoContext _context;

            public AnimalRepository(TodoContext context)
            {
                _context = context;
            }
            public List<AdmVeterinaria.Datos.Clases.Animal> ObtenerAnimales()
            {
                return _context.Animals.ToList();
            }
            public AdmVeterinaria.Datos.Clases.Animal ObtenerAnimal(int id)
            {
                return _context.Animals.FirstOrDefault(x => x.IdAnimal == id);
            }
            public void Eliminar(AdmVeterinaria.Datos.Clases.Animal animal)
            {
                _context.Animals.Remove(animal);
                _context.SaveChanges();
            }
            public void Agregar(AdmVeterinaria.Datos.Clases.Animal animal)
            {
                _context.Animals.Add(animal);
                _context.SaveChanges();
            }
            public void Actualizar(AdmVeterinaria.Datos.Clases.Animal animal)
            {
                _context.Animals.Update(animal);
                _context.SaveChanges();
            }
    }
}
