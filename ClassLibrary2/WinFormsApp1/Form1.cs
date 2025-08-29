using ClassLibrary2;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Pelicula catalogo;
        private List<Persona> personas;
        public Form1()
        {
            InitializeComponent();
            catalogo = new Pelicula();
            personas = new List<Persona>();
        }
        private void RefrescarLista()
        {
            Lista.Items.Clear();
            foreach (var persona in personas)
            {
                Lista.Items.Add(persona.ToString());
            }
        }

        private void btnPeli_Click(object sender, EventArgs e)
        {
            string titulo = tbTitulo.Text;
            catalogo.AgregarPelicula(titulo);
            tbTitulo.Clear();

            RefrescarLista();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string dni = tbDni.Text;

            var persona = new Persona(nombre, dni);
            personas.Add(persona);
            catalogo.Attach(persona);
            tbDni.Clear();
           tbNombre.Clear();

            RefrescarLista();
        }
    }

}
