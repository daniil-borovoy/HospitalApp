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
    public partial class PatientsTabularForm : Form
    {
        public PatientsTabularForm()
        {
            InitializeComponent();
        }

        private void PatientsTabularForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.ForeColor = Color.Black;
            }
            this.listBox1.SelectedIndex = 0;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.hospitalDataSet.Пациенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.пациентыBindingSource.Filter = "ФИО LIKE '%" + textBox1.Text + "%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.пациентыBindingSource.Filter = "";
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
                    Col = фИОDataGridViewTextBoxColumn;
                    break;
                case 1:
                    Col = возрастDataGridViewTextBoxColumn;
                    break;
                case 2:
                    Col = полDataGridViewTextBoxColumn;
                    break;
                case 3:
                    Col = адресDataGridViewTextBoxColumn;
                    break;
                case 4:
                    Col = телефонDataGridViewTextBoxColumn;
                    break;
                case 5:
                    Col = датаОбращенияDataGridViewTextBoxColumn;
                    break;
                case 6:
                    Col = кодБолезниDataGridViewTextBoxColumn;
                    break;
                case 7:
                    Col = кодСотрудникаDataGridViewTextBoxColumn;
                    break;
                case 8:
                    Col = результатЛеченияDataGridViewTextBoxColumn;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
