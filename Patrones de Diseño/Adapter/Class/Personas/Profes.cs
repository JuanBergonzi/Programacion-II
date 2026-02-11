using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Profes : Persona, IGrilla
    {
        public string IdProfes { get; set; }
        public string Legajo { get; set; }
        public DateTime FechaNacimiento { get; set; }
         
        public string ObtenerNombre()
        {
            return "Profe " + Nombre + Apellido;
        }
        public string ObtenerCodigo()
        {
            return Legajo.ToString();
        }
        public void DarDeAltaProfe()
        {
            Nombre = Nombre;
            Apellido = Apellido;
            Dni = Dni;
            Direccion = Direccion;
            FechaNacimiento = FechaNacimiento;
            Legajo = Legajo;
        }
    }
}
