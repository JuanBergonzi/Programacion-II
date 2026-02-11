namespace WebVeterinaria.Datos.Clase
{
    public class TipoAnimal
    {
        public int IdTipoAnimal { get; set; } // ID autoincremental
        public string Tipoanimal { get; set; }
        public List<Animal> Animal { get; set; }
    }
}
