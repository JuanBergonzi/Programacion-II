using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public interface INotificacion
    {
        void Enviar(string Mensaje);
    }
}
