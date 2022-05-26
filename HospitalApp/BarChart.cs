using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class BarChart : Form
    {
        public BarChart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarChart_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.ОтделКадров". При необходимости она может быть перемещена или удалена.
            this.отделКадровTableAdapter.Fill(this.hospitalDataSet.ОтделКадров);
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void gunaChart1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
