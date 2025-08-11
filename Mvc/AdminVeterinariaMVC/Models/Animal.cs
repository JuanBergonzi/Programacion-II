namespace AdminVeterinariaMVC.Models
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }

        public Animal(string nombre, string especie, string raza, string color)
        {
            Nombre = nombre;
            Especie = especie;
            Raza = raza;
            Color = color;
        }
    }
}
