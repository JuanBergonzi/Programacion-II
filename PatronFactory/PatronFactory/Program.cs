using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar tipo de notificación (WhatsApp/SMS): ");
            string tipoNotificacion = Console.ReadLine();
            // Pedido de un producto físico
            if (tipoNotificacion != "WhatsApp" && tipoNotificacion != "SMS")
            {
                Console.WriteLine("Tipo de notificación no válido. Por favor ingrese 'WhatsApp' o 'SMS'.");
                return;
            }
            else if (tipoNotificacion == "WhatsApp")
            {
                INotificacion notificacionwsp = NotificacionFactory.CrearNotificacion("WhatsApp");
                notificacionwsp.Enviar("Mensaje de prueba"); // Se llama al método del objeto físico con el argumento requerido
            }
            else if (tipoNotificacion == "SMS")
            {
                INotificacion notisms = NotificacionFactory.CrearNotificacion("SMS");
                notisms.Enviar("Mensaje desde SMS"); // Se llama al método del objeto digital
            }
        }
    }
}
