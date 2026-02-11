using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ListaMensajes
    {
        public static ListaMensajes Instance { get; } = new ListaMensajes();


        public int id { get; set; }
        public List<Mensaje> mensajes { get; set; }

        public void agregarMensaje(Mensaje mensaje)
        {
            if (mensajes == null)
            {
                mensajes = new List<Mensaje>();
            }
            mensajes.Add(mensaje);
        }

        public void eliminarMensaje(Mensaje mensaje)
        {
            if (mensajes != null && mensajes.Contains(mensaje))
            {
                mensajes.Remove(mensaje);
            }
        }
    }
}
