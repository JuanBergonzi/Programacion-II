using WebVeterinaria.Datos.Dtos;

namespace WebVeterinaria.Logica.AtencionLogic
{
    public interface IAtencionLogic
    {
        DtoAtencion ObtenerAtencion(int id);
        bool EliminarAtencion(int id);
        bool AgregarAtencion(DtoAtencion nuevaAtencion);
        bool ActualizarAtencion(int id, DtoAtencion atencionDtos);
    }
}
