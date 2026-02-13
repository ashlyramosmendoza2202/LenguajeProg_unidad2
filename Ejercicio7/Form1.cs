namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        {
            int numero;

            if (int.TryParse(textBox1.Text, out numero))
            {
                MessageBox.Show("✅ Es un número válido",
                                "Correcto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("❌ Error: Debes ingresar un número entero",
                                "Entrada inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

    }
}
}
