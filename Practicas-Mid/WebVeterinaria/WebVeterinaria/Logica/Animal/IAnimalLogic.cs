using WebVeterinaria.Datos.Dtos;

namespace WebVeterinaria.Logica.AnimalLogic
{
    public interface IAnimalLogic
    {
        DtoAnimal ObtenerAnimal(int id);
        bool EliminarAnimal (int id);
        bool AgregarAnimal (DtoAnimal nuevoAnimal);
        bool ActualizarAnimal(int id, DtoAnimal animalDtos);
    }
}
