using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Productos
{
    public class Libreria : Producto, ICompra
    {
        public Tipo Tipos { get; set; }
        public string Tamanio { get; set; }

        public double CalcularTotal()
        {
            return Precio * 1.21; 
        }
        public void DarDeAltaLibreria()
        {
            CodProducto = CodProducto;
            Nombre = Nombre;
            Descripcion = Descripcion;
            Stock = Stock;
            Tipos = Tipos;
            Tamanio = Tamanio;
        }
    }
}
