using Class;
using Class.Productos;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<IGrilla> grilla = new List<IGrilla>();
        List<ICompra> compra = new List<ICompra>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Socio unSoc = new Socio { IdSocio = "10", Nombre = "Juan", IdPersona = 1 };
            grilla.Add(unSoc);

            Profes unProfe = new Profes { Legajo = "1001", Nombre = "Ana", IdPersona = 2 };
            grilla.Add(unProfe);

            llenarGrilla();
        }

        public void llenarGrilla()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in grilla)
            {
                string codigo = item.ObtenerCodigo();
                string nombre = item.ObtenerNombre();

                dataGridView1.Rows.Add(codigo, nombre);
            }
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;

            foreach (ICompra compra in compra)
            {
                total += compra.CalcularTotal();
            }

            MessageBox.Show("deba pagar: " + total.ToString());
        }

        private void btnComprarIndu_Click(object sender, EventArgs e)
        {
            Indumentaria Remera = new Indumentaria { CodProducto = "22", Precio = 100, Descripcion = "Remera", Talle = "44" };
            compra.Add(Remera);
            MessageBox.Show("Se agrego Remera de: " + Remera.Precio.ToString());

        }

        private void btnComprarLibre_Click(object sender, EventArgs e)
        {
            Libreria Hojas = new Libreria { CodProducto = "22", Precio = 200, Descripcion = "Hojas" };
            compra.Add(Hojas);
            MessageBox.Show("Se agrego hojas de: " + Hojas.Precio.ToString());
        }

        private void btnAdapter_Click(object sender, EventArgs e)
        {
            foreach (Producto compra in compra)
            {
                grilla.Add(new ProductoAdapter(compra));
            }

            llenarGrilla();
        }
    }
}
