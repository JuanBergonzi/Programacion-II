namespace WebVeterinaria.Repositorios.Duenio
{
    public interface IDuenioRepository
    {
        WebVeterinaria.Datos.Clase.Duenio ObtenerDuenio(int id);
        void Eliminar(WebVeterinaria.Datos.Clase.Duenio duenio);
        void Agregar(WebVeterinaria.Datos.Clase.Duenio duenio);
        void Actualizar(WebVeterinaria.Datos.Clase.Duenio duenio);
    }
}
