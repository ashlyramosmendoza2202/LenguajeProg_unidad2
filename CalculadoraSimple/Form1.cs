namespace CalculadoraSimple
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        char operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
        private void Numeros_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textPantalla.Text += b.Text;
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            textPantalla.Clear();
        }

        private void Operacion_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            num1 = Convert.ToDouble(textPantalla.Text);
            operacion = b.Text[0];
            textPantalla.Clear();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textPantalla.Text);

            double resultado = 0;

         
            switch (operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        resultado = double.NaN; // División por cero
                    break;
                default:
                    resultado = double.NaN;
                    break;
            }

            textPantalla.Text = resultado.ToString();
        }

    }
}
