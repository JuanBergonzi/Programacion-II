using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20
{
    public partial class ABMClientes : Form
    {
        public ABMClientes()
        {
            InitializeComponent();
        }

        private void ABMClientes_Load(object sender, EventArgs e)
        {
            Clientes cliente1 = new Clientes { direccion = "Calle Falsa 123", id = 1, nombre = "Juan Perez" };
            Clientes cliente2 = new Clientes { direccion = "Avda eee 234", id = 2, nombre = "Ernesto Perez" };
            List<Clientes> listita = new List<Clientes>();
            listita.Add(cliente1);
            listita.Add(cliente2);

            dataGridView1.DataSource = listita;
            
        }
    }
}
