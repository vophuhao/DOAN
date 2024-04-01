using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCUOIKI
{
    public partial class MainForm : Form
    {
        private Form currentFormChild;
        public MainForm()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

       

        private void AppoimentBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new appoiment());
        }

        private void TreatmentBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new treatmentList());
        }

        private void FinanceBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Finance());
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Report());
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListPatient());
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddPatient());
        }
    }
}
