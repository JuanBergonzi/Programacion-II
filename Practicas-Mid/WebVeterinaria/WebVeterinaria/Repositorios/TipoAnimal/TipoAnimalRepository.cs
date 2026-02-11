using WebVeterinaria.Datos;

namespace WebVeterinaria.Repositorios.TipoAnimal
{
    public class TipoAnimalRepository
    {
        private readonly TodoContext _context;

        public TipoAnimalRepository(TodoContext context)
        {
            _context = context;
        }
        public Datos.Clase.TipoAnimal ObtenerTipoAnimal(int id)
        {
            return _context.TipoAnimals.FirstOrDefault(x => x.IdTipoAnimal == id);
        }
        public void Eliminar(WebVeterinaria.Datos.Clase.TipoAnimal tipoAnimal)
        {
            _context.TipoAnimals.Remove(tipoAnimal);
            _context.SaveChanges();
        }
        public void Agregar(WebVeterinaria.Datos.Clase.TipoAnimal tipoAnimal)
        {
            _context.TipoAnimals.Add(tipoAnimal);
            _context.SaveChanges();
        }
        public void Actualizar(WebVeterinaria.Datos.Clase.TipoAnimal tipoAnimal)
        {
            _context.TipoAnimals.Update(tipoAnimal);
            _context.SaveChanges();
        }
    }
}
