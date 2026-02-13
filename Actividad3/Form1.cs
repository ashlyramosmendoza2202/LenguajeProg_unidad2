namespace Actividad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Seleccionaste: Opción 1";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Seleccionaste: Opción 2";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "Seleccionaste: Opción 3";
            }
            else
            {
                label1.Text = "No seleccionaste ninguna opción";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
