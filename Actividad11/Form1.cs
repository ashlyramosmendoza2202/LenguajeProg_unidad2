namespace Actividad11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;   // avanza de 5 en 5
            }
            else
            {

                timer1.Stop();


      {            
        private void button1_Click(object sender, EventArgs e)
        {

            {
                progressBar1.Value = 0;
                timer1.Start();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
