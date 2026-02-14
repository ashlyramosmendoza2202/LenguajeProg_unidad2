namespace Actividad14
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        string operacion = "";
        bool nuevoNumero = true;
        double numero1 = 0;
        string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            public partial class Form1 : Form
        {
            double numero1 = 0;
            string operacion = "";

            public Form1()
            {
                InitializeComponent();
            }

            // NÚMEROS (0–9)
            private void buttonNumero_Click(object sender, EventArgs e)
            {
                Button b = sender as Button;

                if (txtPantalla.Text == "0")
                    txtPantalla.Text = "";

                txtPantalla.Text += b.Text;
            }

            // OPERACIONES (+ - * /)
            private void buttonOperacion_Click(object sender, EventArgs e)
            {
                Button b = sender as Button;
                numero1 = double.Parse(txtPantalla.Text);
                operacion = b.Text;
                txtPantalla.Text = "0";
            }

            // IGUAL (=)
            private void buttonIgual_Click(object sender, EventArgs e)
            {
                double numero2 = double.Parse(txtPantalla.Text);
                double resultado = 0;

                if (operacion == "+") resultado = numero1 + numero2;
                else if (operacion == "-") resultado = numero1 - numero2;
                else if (operacion == "*") resultado = numero1 * numero2;
                else if (operacion == "/") resultado = numero1 / numero2;

                txtPantalla.Text = resultado.ToString();
            }

            // LIMPIAR (C)
            private void buttonC_Click(object sender, EventArgs e)
            {
                txtPantalla.Text = "0";
                numero1 = 0;
                operacion = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
}

