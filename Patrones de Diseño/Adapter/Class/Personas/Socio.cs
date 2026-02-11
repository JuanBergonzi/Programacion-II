using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Socio : Persona, IGrilla
    {
        public string IdSocio { get; set; }
        public DateTime FechaAlta { get; set; }
        public string ObtenerNombre()
        {
            return  Nombre + " " + Apellido;
        }
        public string ObtenerCodigo()
        {
            return IdSocio.ToString();
        }
        public void DarAltaSocio()
        {
            Nombre = Nombre;
            Apellido = Apellido;
            Dni = Dni;
            Direccion = Direccion;
            FechaAlta = DateTime.Now;
        }
    }
}
