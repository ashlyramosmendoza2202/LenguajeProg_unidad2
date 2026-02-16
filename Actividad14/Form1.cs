using System;
using System.IO;
using System.Windows.Forms;

namespace Actividad14
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

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            {
                using (OpenFileDialog abrir = new OpenFileDialog())
                {

                    abrir.Filter = "Archivos de texto (*.txt)|*.txt";

                    if (abrir.ShowDialog() == DialogResult.OK)
                    {

                        txtContenido.Text = File.ReadAllText(abrir.FileName);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                using (SaveFileDialog guardar = new SaveFileDialog())
                {
                    guardar.Filter = "Archivos de texto (*.txt)|*.txt";

                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        // Toma el texto del TextBox y lo guarda en el disco
                        File.WriteAllText(guardar.FileName, txtContenido.Text);
                        MessageBox.Show("Archivo guardado con éxito", "Información");
                    }
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
    




