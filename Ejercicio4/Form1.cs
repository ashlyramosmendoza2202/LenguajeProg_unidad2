namespace Ejercicio4
{
    using System.Drawing;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            {
                comboBox1.Items.Add("Rojo");
                comboBox1.Items.Add("Verde");
                comboBox1.Items.Add("Azul");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        {
            if (comboBox1.Text == "Rojo")
                this.BackColor = Color.Red;
            else if (comboBox1.Text == "Verde")
                this.BackColor = Color.Green;
            else if (comboBox1.Text == "Azul")
                this.BackColor = Color.Blue;
        }

    }
}
}
