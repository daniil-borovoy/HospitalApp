using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.TapeForms
{
    public partial class DiseasesTapeForm : Form
    {
        public DiseasesTapeForm()
        {
            InitializeComponent();
        }

        private void болезниBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.болезниBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void DiseasesTapeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.hospitalDataSet.Пациенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.hospitalDataSet.Пациенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.hospitalDataSet.Пациенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Болезни". При необходимости она может быть перемещена или удалена.
            this.болезниTableAdapter.Fill(this.hospitalDataSet.Болезни);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void пациентыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.болезниBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TabularForms.DiseasesTabularForm diseasesTabularForm = new TabularForms.DiseasesTabularForm();
            diseasesTabularForm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.болезниBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                MessageBox.Show("Изменения успешно сохранены!");
            } catch (System.Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений!");
            }
        }
    }
}
