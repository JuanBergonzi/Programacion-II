using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Actividad
    {
        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public void DarDeAltaActividad()
        {
            Nombre = Nombre;
            Descripcion = Descripcion;
            IdActividad = IdActividad ++;
        }
    }
}
