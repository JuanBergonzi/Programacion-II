using WebVeterinaria.Datos.Clase;

namespace WebVeterinaria.Datos.Dtos
{
    public class DtoTipoAnimal
    {
        public int IdTipoAnimal { get; set; } // ID autoincremental
        public string Tipoanimal { get; set; }
        public List<Animal> Animal { get; set; }
    }
}
