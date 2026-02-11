using ClassLibrary1;

namespace WinFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void refrescame()
        {

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = ListaMensajes.Instance.mensajes ;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            refrescame();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaMensajes.Instance.agregarMensaje(new Mensaje
            {
                sender = "Cacho",
                receiver = "Maria",
                subject = "Hola",
                body = "¿Cómo estás?"
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
