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
    public partial class PatientsRequestTabularForm : Form
    {
        public PatientsRequestTabularForm()
        {
            InitializeComponent();
        }

        private void PatientsRequestTabularForm_Load(object sender, EventArgs e)
        {
            this.listBox1.SelectedIndex = 0;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.ПациентыЗапрос". При необходимости она может быть перемещена или удалена.
            this.пациентыЗапросTableAdapter.Fill(this.hospitalDataSet.ПациентыЗапрос);

            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
            {
                if (!comboBox1.Items.Contains(this.dataGridView1.Rows[i].Cells[1].Value))
                    comboBox1.Items.Add(this.dataGridView1.Rows[i].Cells[1].Value);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.пациентыЗапросBindingSource.Filter = $"Наименование LIKE '{comboBox1.Text}'";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.пациентыЗапросBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.пациентыЗапросBindingSource.Filter = "";
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = пациентыФИОDataGridViewTextBoxColumn;
                    break;
                case 1:
                    Col = наименованиеDataGridViewTextBoxColumn;
                    break;
                case 2:
                    Col = сотрудникиФИОDataGridViewTextBoxColumn;
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
    }
}
