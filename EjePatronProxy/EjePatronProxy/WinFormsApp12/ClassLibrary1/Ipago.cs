using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Ipago
    {
        public bool pagar(double monto);
        public bool devolver(double monto);
        public double consultar();
        public bool AgregarMp(string Nombre); // Método específico del proxy

    }
}
