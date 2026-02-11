using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Socio : Persona
    {
        public int IdSocio { get; set; }
        public DateTime FechaAlta { get; set; }
        public Socio()
        {
            FechaAlta = DateTime.Now;
        }
    }
}
