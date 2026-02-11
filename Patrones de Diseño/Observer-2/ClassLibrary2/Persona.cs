using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Persona : IObserver
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public List<string> Peliculas { get; set; }

        public Persona(string nombre, string dni)
        {
            Nombre = nombre;
            DNI = dni;
            Peliculas = new List<string>();
        }

        public void Update(string pelicula)
        {
            Peliculas.Add(pelicula);
        }

        public override string ToString()
        {
            return $"{Nombre} ({DNI}) - Pelis: {string.Join(", ", Peliculas)}";
        }
    }
}
