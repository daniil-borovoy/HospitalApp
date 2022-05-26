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
    public partial class PostsTapeForm : Form
    {
        public PostsTapeForm()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void PostsTapeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.hospitalDataSet.Должности);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.должностиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                MessageBox.Show("Изменения успешно сохранены!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TabularForms.PostsTabularForm postsTabularForm = new TabularForms.PostsTabularForm();
            postsTabularForm.Show();
            this.Close();
        }
    }
}
