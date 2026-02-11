using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public class NotificacionFactory
    {
            // Método estático que actúa como la fábrica
            public static INotificacion CrearNotificacion(string mensaje)
            {
                if (mensaje == "WhatsApp")
                {
                    return new Notis();
                }
                else if (mensaje == "SMS")
                {
                    return new NotisSMS();
                }
                else { throw new ArgumentException("Tipo de mensaje no válido."); }
            }
        }
    }
