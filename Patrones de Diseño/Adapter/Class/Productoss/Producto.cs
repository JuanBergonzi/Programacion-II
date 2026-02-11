namespace Class.Productos
{
    public class Producto
    {
        public string CodProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        
        public void DarDeAltaProducto()
        {
            Nombre = Nombre;
            Descripcion = Descripcion;
            Stock = Stock;
        }
    }
}
