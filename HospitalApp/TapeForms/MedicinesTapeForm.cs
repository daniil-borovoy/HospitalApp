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
    public partial class MedicinesTapeForm : Form
    {
        public MedicinesTapeForm()
        {
            InitializeComponent();
        }

        private void лекарстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.лекарстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void MedicinesTapeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Лекарства". При необходимости она может быть перемещена или удалена.
            this.лекарстваTableAdapter.Fill(this.hospitalDataSet.Лекарства);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.лекарстваBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.лекарстваBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.лекарстваBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.лекарстваBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.лекарстваBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.лекарстваBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.лекарстваBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                MessageBox.Show("Изменения успешно сохранены!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TabularForms.MedicinesTabularForm medicinesTabularForm = new TabularForms.MedicinesTabularForm();
            medicinesTabularForm.Show();
            this.Close();
        }
    }
}
