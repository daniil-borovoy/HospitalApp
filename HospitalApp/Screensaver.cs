using System;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class Screensaver : Form
    {

        public Screensaver()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                return;
            }
            Opacity += 0.01;
            progressBar1.Value++;
        }

        private void Screensaver_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
