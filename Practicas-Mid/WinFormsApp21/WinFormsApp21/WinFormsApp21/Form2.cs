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

namespace WinFormsApp21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaMensajes.Instance.agregarMensaje(new Mensaje
            {
                sender = "el form 2 ",
                receiver = "vos ",
                subject = "Hola desde otro form ",
                body = "¿Cómo estás?"
            });
        }
    }
}
