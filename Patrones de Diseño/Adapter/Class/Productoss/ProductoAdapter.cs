using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Productos
{
    public class ProductoAdapter : IGrilla
    {
        private Producto _producto;
        public ProductoAdapter(Producto producto)
        {
            _producto = producto;
        }
        public string ObtenerNombre()
        {
            return _producto.Descripcion;
        }
        public string ObtenerCodigo()
        {
            return _producto.CodProducto;
        }
    }
}
