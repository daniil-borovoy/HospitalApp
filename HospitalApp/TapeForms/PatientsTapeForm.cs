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
    public partial class PatientsTapeForm : Form
    {
        public PatientsTapeForm()
        {
            InitializeComponent();
        }

        private void пациентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пациентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void PatientsTapeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.hospitalDataSet.Пациенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.пациентыBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.пациентыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                MessageBox.Show("Изменения успешно сохранены!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.пациентыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.пациентыBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.пациентыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.пациентыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.пациентыBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TabularForms.PatientsTabularForm patientsTabularForm = new TabularForms.PatientsTabularForm();
            patientsTabularForm.Show();
            this.Close();
        }
    }
}
