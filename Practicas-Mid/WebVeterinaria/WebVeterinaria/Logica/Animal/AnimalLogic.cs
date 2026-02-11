using WebVeterinaria.Datos.Dtos;
using WebVeterinaria.Repositorios.Animal;

namespace WebVeterinaria.Logica.AnimalLogic
{
    public class AnimalLogic : IAnimalLogic
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalLogic(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }
        public DtoAnimal ObtenerAnimal(int id)
        {
            Datos.Clase.Animal animal = _animalRepository.ObtenerAnimal(id);

            if (animal == null)
            {
                return null;
            }

            return new DtoAnimal
            {
                IdAnimal = animal.IdAnimal,
                Nombre = animal.Nombre,
                Raza = animal.Raza,
                Edad = animal.Edad,
                Sexo = animal.Sexo,
            };
        }
        public bool EliminarAnimal(int id)
        {
            var animal = _animalRepository.ObtenerAnimal(id);
            if (animal == null) return false;

            _animalRepository.Eliminar(animal);
            return true;
        }
        public bool AgregarAnimal(DtoAnimal nuevoAnimal)
        {
            if (nuevoAnimal == null)
            {
                return false;
            }

            var animalEntidad = new Datos.Clase.Animal
            {
                IdAnimal = nuevoAnimal.IdAnimal,
                Nombre = nuevoAnimal.Nombre,
                Raza = nuevoAnimal.Raza,
                Edad = nuevoAnimal.Edad,
                Sexo = nuevoAnimal.Sexo
                //IdDuenio = nuevoAnimal.IdDuenio,
            };

            _animalRepository.Agregar(animalEntidad);
            return true;
        }
        public bool ActualizarAnimal(int id, DtoAnimal animalDto)
        {
            if (animalDto == null)
            {
                return false;
            }
            var animalExistente = _animalRepository.ObtenerAnimal(id);
            if (animalExistente == null)
            {
                return false;
            }
            animalExistente.Nombre = animalDto.Nombre; 
            animalExistente.Raza = animalDto.Raza;
            animalExistente.Edad = animalDto.Edad;
            animalExistente.Sexo = animalDto.Sexo;
            _animalRepository.Actualizar(animalExistente);
            return true;
        }


    }
}
