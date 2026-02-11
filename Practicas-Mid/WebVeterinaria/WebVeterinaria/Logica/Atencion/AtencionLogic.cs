using WebVeterinaria.Datos.Dtos;
using WebVeterinaria.Repositorios.Animal;
using WebVeterinaria.Repositorios.Atencion;

namespace WebVeterinaria.Logica.AtencionLogic
{
    public class AtencionLogic : IAtencionLogic
    {
        private readonly IAtencionRepository _atencionRepository;
        public AtencionLogic(IAtencionRepository atencionRepository)
        {
            _atencionRepository = atencionRepository;
        }
        public DtoAtencion ObtenerAtencion(int id)
        {
            Datos.Clase.Atencion atencion = _atencionRepository.ObtenerAtencion(id);

            if (atencion == null)
            {
                return null;
            }

            return new DtoAtencion
            {
                IdAtencion = atencion.IdAtencion,
                TipoAtencion = atencion.TipoAtencion,
                Motivo = atencion.Motivo,
                TratamientoRebicido = atencion.TratamientoRebicido,
                Medicamentos = atencion.Medicamentos,
                Fecha = atencion.Fecha,
                Animal = atencion.Animal,
            };
        }
        public bool EliminarAtencion(int id)
        {
            var atencion = _atencionRepository.ObtenerAtencion(id);
            if (atencion == null) return false;

            _atencionRepository.Eliminar(atencion);
            return true;
        }
        public bool AgregarAtencion(DtoAtencion nuevaAtencion)
        {
            if (nuevaAtencion == null)
            {
                return false;
            }

            var atencionEntidad = new Datos.Clase.Atencion
            {
                IdAtencion = nuevaAtencion.IdAtencion,
                TipoAtencion = nuevaAtencion.TipoAtencion,
                Motivo = nuevaAtencion.Motivo,
                TratamientoRebicido = nuevaAtencion.TratamientoRebicido,
                Medicamentos = nuevaAtencion.Medicamentos,
                Fecha = nuevaAtencion.Fecha,
                Animal = nuevaAtencion.Animal,
            };

            _atencionRepository.Agregar(atencionEntidad);
            return true;
        }
        public bool ActualizarAtencion(int id, DtoAtencion atencionDtos)
        {
            if (atencionDtos == null)
            {
                return false;
            }
            var atencionExist = _atencionRepository.ObtenerAtencion(id);
            if (atencionExist == null)
            {
                return false;
            }
            atencionExist.TipoAtencion = atencionExist.TipoAtencion;
            atencionExist.Motivo = atencionExist.Motivo;
            atencionExist.TratamientoRebicido = atencionExist.TratamientoRebicido;
            atencionExist.Medicamentos = atencionExist.Medicamentos;
            atencionExist.Fecha = atencionExist.Fecha;
            atencionExist.Animal = atencionExist.Animal;
            _atencionRepository.Actualizar(atencionExist);
            return true;
        }


    }
}
