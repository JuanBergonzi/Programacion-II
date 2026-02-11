using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public class Indumentaria : Producto
    {
        public string Talle { get; set; }
        public string Color { get; set; }
      
      /*  public Indumentaria(int codProducto, string nombre, string descripcion, int stock, string talle, string color)
            : base(codProducto, nombre, descripcion, stock)
        {
            Talle = talle;
            Color = color;
        } */ 
    }
}
