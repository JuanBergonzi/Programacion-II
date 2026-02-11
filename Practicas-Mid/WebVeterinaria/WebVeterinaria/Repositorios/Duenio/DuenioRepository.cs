using WebVeterinaria.Datos;

namespace WebVeterinaria.Repositorios.Duenio
{
    public class DuenioRepository
    {
        private readonly TodoContext _context;

        public DuenioRepository(TodoContext context)
        {
            _context = context;
        }
        public Datos.Clase.Duenio ObtenerDuenio(int id)
        {
            return _context.Duenios.FirstOrDefault(x => x.IdDuenio == id);
        }
        public void Eliminar(WebVeterinaria.Datos.Clase.Duenio duenio)
        {
            _context.Duenios.Remove(duenio);
            _context.SaveChanges();
        }
        public void Agregar(WebVeterinaria.Datos.Clase.Duenio duenio)
        {
            _context.Duenios.Add(duenio);
            _context.SaveChanges();
        }
        public void Actualizar(WebVeterinaria.Datos.Clase.Duenio duenio)
        {
            _context.Duenios.Update(duenio);
            _context.SaveChanges();
        }
    }
}
