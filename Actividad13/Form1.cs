namespace Actividad13
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
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = System.IO.File.ReadAllText(ofd.FileName);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, textBox1.Text);
                MessageBox.Show("Archivo guardado correctamente ✅");
            }
        }

    }
}
}
