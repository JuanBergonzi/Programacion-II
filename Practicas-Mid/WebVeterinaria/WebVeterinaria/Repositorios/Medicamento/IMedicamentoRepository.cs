namespace WebVeterinaria.Repositorios.Medicamento
{
    public interface IMedicamentoRepository
    {
        WebVeterinaria.Datos.Clase.Medicamento ObtenerMedicamento(int id);
        void Eliminar(WebVeterinaria.Datos.Clase.Medicamento medicamento);
        void Agregar(WebVeterinaria.Datos.Clase.Medicamento medicamento);
        void Actualizar(WebVeterinaria.Datos.Clase.Medicamento medicamento);
    }
}
