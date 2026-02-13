namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                contador++;
                label1.Text = "Veces presionado: " + contador;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
