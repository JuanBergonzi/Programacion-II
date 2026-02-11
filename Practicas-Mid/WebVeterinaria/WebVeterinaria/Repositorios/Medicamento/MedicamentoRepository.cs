using WebVeterinaria.Datos;

namespace WebVeterinaria.Repositorios.Medicamento
{
    public class MedicamentoRepository
    {
        private readonly TodoContext _context;

        public MedicamentoRepository(TodoContext context)
        {
            _context = context;
        }
        public Datos.Clase.Medicamento ObtenerMedicamento(int id)
        {
            return _context.Medicamentos.FirstOrDefault(x => x.IdMedicamento == id);
        }
        public void Eliminar(WebVeterinaria.Datos.Clase.Medicamento medicamento)
        {
            _context.Medicamentos.Remove(medicamento);
            _context.SaveChanges();
        }
        public void Agregar(WebVeterinaria.Datos.Clase.Medicamento medicamento)
        {
            _context.Medicamentos.Add(medicamento);
            _context.SaveChanges();
        }
        public void Actualizar(WebVeterinaria.Datos.Clase.Medicamento medicamento)
        {
            _context.Medicamentos.Update(medicamento);
            _context.SaveChanges();
        }
    }
}
