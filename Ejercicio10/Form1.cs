namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                label1.Text = "Resultado: " + fahrenheit.ToString("0.00") + " °F";
            }
            else
            {
                MessageBox.Show("Ingresa un número válido en Celsius",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
