using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Productos
{
    public class Indumentaria : Producto, ICompra
    {
        public string Talle { get; set; }
        public string Color { get; set; }
        public double CalcularTotal()
        {
            return Precio * 1.41; 
        }
        public void DarDeAltaIndumentaria()
        {
            Nombre = Nombre;
            Descripcion = Descripcion;
            Stock = Stock;
            Talle = Talle;
            Color = Color;
        }
    }
}
