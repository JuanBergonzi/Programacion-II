namespace WebVeterinaria.Repositorios.Atencion
{
    public interface IAtencionRepository
    {
        WebVeterinaria.Datos.Clase.Atencion ObtenerAtencion(int id);
        void Eliminar(WebVeterinaria.Datos.Clase.Atencion atencion);
        void Agregar(WebVeterinaria.Datos.Clase.Atencion atencion);
        void Actualizar(WebVeterinaria.Datos.Clase.Atencion atencion);
    }
}
