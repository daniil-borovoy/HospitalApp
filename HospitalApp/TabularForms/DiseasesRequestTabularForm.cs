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
    public partial class DiseasesRequestTabularForm : Form
    {
        public DiseasesRequestTabularForm()
        {
            InitializeComponent();
        }

        private void DiseasesRequestTabularForm_Load(object sender, EventArgs e)
        {
            this.listBox1.SelectedIndex = 0;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.ЗапросБолезни". При необходимости она может быть перемещена или удалена.
            this.запросБолезниTableAdapter.Fill(this.hospitalDataSet.ЗапросБолезни);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = болезниНаименованиеDataGridViewTextBoxColumn;
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
                    Col = лекарстваНаименованиеDataGridViewTextBoxColumn;
                    break;
                case 5:
                    Col = лекарства1НаименованиеDataGridViewTextBoxColumn;
                    break;
                case 6:
                    Col = лекарства2НаименованиеDataGridViewTextBoxColumn;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.запросБолезниBindingSource.Filter = "Симптомы LIKE '%" + textBox1.Text + "%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.запросБолезниBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
