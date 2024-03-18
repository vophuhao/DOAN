using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCUOIKI
{
    public partial class AddPatient : Form
    {
        Patient patient=new Patient();
        public AddPatient()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void listPatientLoad()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PATIENT");
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 50;
            DataGridView1.DataSource = patient.getPatient(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }
  

        private void AddPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nHAKHOADataSet.PATIENT' table. You can move, or remove it, as needed.
            listPatientLoad();


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            int id = Convert.ToInt32(txtboxID.Text);
            string name = txtName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = txtPhone.Text;
            string adrs = txtAddress.Text;
            string gender = comboBox1.Text;
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            //  sv tu 10-100,  co the thay doi
            if (((this_year - born_year) < 0) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Patient Age Must Be Between 0 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBoxPatient.Image.Save(pic, pictureBoxPatient.Image.RawFormat);
                if (patient.insertPatient(id, name, adrs, bdate, gender, phone, pic))
                {
                    MessageBox.Show("New Patient Added", "Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Patient Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            listPatientLoad();
        }
        bool verif()
        {
            if (
                            (txtName.Text.Trim() == "")
                        || (txtAddress.Text.Trim() == "")
                        || (txtPhone.Text.Trim() == "")
                         || (pictureBoxPatient.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";

            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxPatient.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
