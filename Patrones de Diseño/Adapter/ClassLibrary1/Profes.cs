using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Profes : Persona
    {
        public int IdProfes { get; set; }
        public string Legajo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Profes()
        {
            FechaNacimiento = DateTime.Now;
        }
    }
}
