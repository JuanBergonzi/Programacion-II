using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public class Notis : INotificacion
    {
            public void Enviar(string Mensaje)
            {
                Console.WriteLine("Enviando notificación por NotisWsp");
            }
    }
}
