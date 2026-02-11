namespace WebVeterinaria.Datos.Clase
{
    public class Medicamento
    {
        public int IdMedicamento { get; set; }
        public string Nombre { get; set; }
        public List<Animal> Animales { get; set; }
    }
}
