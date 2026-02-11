using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasess
{
    public class Cliente
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public TipoDoc Doc { get; set; }
        public CondImpos Condicion { get; set; }
    }
}
