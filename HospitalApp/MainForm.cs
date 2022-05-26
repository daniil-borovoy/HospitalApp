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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip
            {
                // Set up the delays for the ToolTip.
                AutoPopDelay = 5000,
                InitialDelay = 600,
                ReshowDelay = 500,
                // Force the ToolTip text to be displayed whether or not the form is active.
                ShowAlways = true
            };
           
            // Set up the ToolTip text for the Button and Checkbox.
             toolTip.SetToolTip(this.button4, "Дополнительная информация");
             toolTip.SetToolTip(this.button5, "Показать гистограмму");
             toolTip.SetToolTip(this.button3, "Закрыть программу");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["About"] as About != null) return;
            About about = new About();
            about.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BarChart"] as BarChart != null) return;
            BarChart barChart = new BarChart();
            barChart.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TabularForms.HRDepartmentRequestTabularForm hrDepartmentRequestTabularForm = new TabularForms.HRDepartmentRequestTabularForm();
            hrDepartmentRequestTabularForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TapeForms.PatientsTapeForm patientsTapeForm = new TapeForms.PatientsTapeForm();
            patientsTapeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TapeForms.EmployeesTapeForm employeesTapeForm = new TapeForms.EmployeesTapeForm();
            employeesTapeForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TapeForms.MedicinesTapeForm medicinesTapeForm = new TapeForms.MedicinesTapeForm();
            medicinesTapeForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TapeForms.PostsTapeForm postsTapeForm = new TapeForms.PostsTapeForm();
            postsTapeForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TapeForms.DiseasesTapeForm diseasesTapeForm = new TapeForms.DiseasesTapeForm();
            diseasesTapeForm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TabularForms.PatientsTabularForm patientsTabularForm = new TabularForms.PatientsTabularForm();
            patientsTabularForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TabularForms.EmployeesTabularForm employeesTabularForm = new TabularForms.EmployeesTabularForm();
            employeesTabularForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TabularForms.MedicinesTabularForm medicinesTabularForm = new TabularForms.MedicinesTabularForm();
            medicinesTabularForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TabularForms.PostsTabularForm postsTabularForm = new TabularForms.PostsTabularForm();
            postsTabularForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TabularForms.DiseasesTabularForm diseasesTabularForm = new TabularForms.DiseasesTabularForm();
            diseasesTabularForm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TabularForms.DiseasesRequestTabularForm diseasesRequestTabularForm = new TabularForms.DiseasesRequestTabularForm();
            diseasesRequestTabularForm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TabularForms.PatientsRequestTabularForm patientsRequestTabularForm = new TabularForms.PatientsRequestTabularForm();
            patientsRequestTabularForm.Show();
        }
    }
}
