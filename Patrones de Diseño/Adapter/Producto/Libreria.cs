using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public class Libreria : Producto
    {
        public Tipo Tipos { get; set; }
        public string Tamanio { get; set; }

        /*public Libreria(int codProducto, string nombre, string descripcion, int stock,)
            : base(codProducto, nombre, descripcion, stock)
        {
        Tipos = tipos;
        Tamanio = tamanio;
        }*/
    }
}
