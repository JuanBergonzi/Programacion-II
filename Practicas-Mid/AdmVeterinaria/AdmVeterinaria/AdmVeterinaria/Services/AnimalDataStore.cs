using System.Data.Common;
using AdmVeterinaria.Datos.Clases;

namespace AdmVeterinaria.Services
{
    public class AnimalDataStore
    {
        public static AnimalDataStore Current { get; } = new AnimalDataStore();
        public List<Animal> Animales { get; set; }
        private int _currentId; // Contador para IDs autoincrementales

        public AnimalDataStore()
        {
            _currentId = 1; // Inicializamos el contador
            Animales = new List<Animal>();
            Animales.Add(new Animal
            {
                IdAnimal = _currentId,
                Nombre = "Cata",
                Raza = "Caniche",
                Edad = "10",
                Sexo = "Hembra",
            });
            _currentId++; // Incrementamos el contador
        }

        public int GetNextId()
        {
            return _currentId++;
        }
    }

}
