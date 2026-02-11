using ClassLibrary1;
using System.Text.Json;

namespace WinFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();

            formLogin.ShowDialog();

            if (formLogin.usuLoggeado != null)
            {
                // si el usuario se loguea correctamente, abro el formulario de reportes.
                ABMClientes elForm = new ABMClientes();
                elForm.ShowDialog();
            }
            else
            {
                // si no se loguea, muestro un mensaje de error.
                MessageBox.Show("Usuario o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void escribeBase()
        {
            List<Usuarios> list = new List<Usuarios>();
            Usuarios usuario1 = new Usuarios
            {
                nombre = "Juan",
                id = 1,
                direccion = "por ahí ",
                clave = "12345"
            };
            list.Add(usuario1);
            Usuarios usuario2 = new Usuarios
            {
                nombre = "Pedro",
                id = 2,
                direccion = "mas allá ",
                clave = "666666"
            };
            list.Add(usuario2);

            string json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });

            // Guardamos el JSON en un archivo
            File.WriteAllText("usuarios.txt", json);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();

            formLogin.ShowDialog();

            if (formLogin.usuLoggeado != null)
            {
                // si el usuario se loguea correctamente, abro el formulario de reportes.
                FormVentas elForm = new FormVentas();
                elForm.ShowDialog();
            }
            else
            {
                // si no se loguea, muestro un mensaje de error.
                MessageBox.Show("Usuario o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();

            formLogin.ShowDialog();

            if (formLogin.usuLoggeado != null)
            {
                // si el usuario se loguea correctamente, abro el formulario de reportes.
                FormReportes elForm = new FormReportes();
                elForm.ShowDialog();
            }
            else
            {
                // si no se loguea, muestro un mensaje de error.
                MessageBox.Show("Usuario o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar el sistema");
            this.Close();

        }
    }
}
