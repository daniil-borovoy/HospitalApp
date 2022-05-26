using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.TabularForms
{
    public partial class DiseasesTabularForm : Form
    {
        public DiseasesTabularForm()
        {
            InitializeComponent();
        }

        private void DiseasesTabularForm_Load(object sender, EventArgs e)
        {
            this.listBox1.SelectedIndex = 0;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.hospitalDataSet.Пациенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Болезни". При необходимости она может быть перемещена или удалена.
            this.болезниTableAdapter.Fill(this.hospitalDataSet.Болезни);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.Filter = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for (i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.White;
                    dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (j = 0; j < dataGridView1.RowCount; j++)
                {
                    var value = dataGridView1.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox2.Text) > -1)
                        {
                            dataGridView1.Rows[j].Cells[i].Style.BackColor =
                            Color.Aqua;
                            dataGridView1.Rows[j].Cells[i].Style.ForeColor =
                            Color.Blue;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.Filter = "Наименование LIKE '%" + textBox1.Text + "%'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = наименованиеDataGridViewTextBoxColumn;
                    break;
                case 1:
                    Col = симптомыDataGridViewTextBoxColumn;
                    break;
                case 2:
                    Col = продолжительностьDataGridViewTextBoxColumn;
                    break;
                case 3:
                    Col = последствияDataGridViewTextBoxColumn;
                    break;
                case 4:
                    Col = кодЛекартства1DataGridViewTextBoxColumn;
                    break;
                case 5:
                    Col = кодЛекартства2DataGridViewTextBoxColumn;
                    break;
                case 6:
                    Col = кодЛекартства3DataGridViewTextBoxColumn;
                    break;
                default: break;
            }
            if (radioButton1.Checked)
            {
                dataGridView1.Sort(Col,
                System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                dataGridView1.Sort(Col,
                System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
