using WebVeterinaria.Datos;

namespace WebVeterinaria.Repositorios.Atencion
{
    public class AtencionRepository
    {
       
            private readonly TodoContext _context;

        public AtencionRepository(TodoContext context)
        {
            _context = context;
        }
        public Datos.Clase.Atencion ObtenerAtencion(int id)
        {
            return _context.Atencions.FirstOrDefault(x => x.IdAtencion == id);
        }
        public void Eliminar(WebVeterinaria.Datos.Clase.Atencion atencion)
        {
            _context.Atencions.Remove(atencion);
            _context.SaveChanges();
        }
        public void Agregar(WebVeterinaria.Datos.Clase.Atencion atencion)
        {
            _context.Atencions.Add(atencion);
            _context.SaveChanges();
        }
        public void Actualizar(WebVeterinaria.Datos.Clase.Atencion atencion)
        {
            _context.Atencions.Update(atencion);
            _context.SaveChanges();
        }

    }
}
