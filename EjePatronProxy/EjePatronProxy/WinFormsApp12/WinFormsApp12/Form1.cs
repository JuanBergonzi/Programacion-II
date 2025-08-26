using ClassLibrary1;

namespace WinFormsApp12
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

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigSingleton.DameInstancia().procesarPago(Convert.ToDouble(textBox1.Text));
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigSingleton.DameInstancia().procesarDevol(Convert.ToDouble(textBox1.Text));
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ConfigSingleton.DameInstancia().AgregarMp(tbmp.Text);
            tbmp.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ConfigSingleton.DameInstancia().procesarConsulta(0);
        }
    }
}
