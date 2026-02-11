using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasess
{
    public class CondImpos
    {
        public int IdCondicion { get; set; }
        public string Descripcion { get; set; }
        public List<Cliente> clientes { get; set; }
    }
}
