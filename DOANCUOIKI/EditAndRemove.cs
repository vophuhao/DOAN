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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DOANCUOIKI
{
    public partial class EditAndRemove : Form
    {
        Patient patient=new Patient();
        public EditAndRemove()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int id;
            string name = txtName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = txtPhone.Text;
            string adrs = txtAddress.Text;
            string gender = comboBox1.Text;

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            // allow only students age between 10 100;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(txtboxID.Text);
                    pictureBoxPatient.Image.Save(pic, pictureBoxPatient.Image.RawFormat);
                    if (patient.updatePatient(id, name, adrs, bdate, gender, phone, pic))
                    {
                        MessageBox.Show("Student information updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try

            {
                int studentId = Convert.ToInt32(txtboxID.Text);
                // display a confirmation message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Patient", "Delete Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (patient.deletePatient(studentId))
                    {
                        MessageBox.Show("Patient Deleted", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // clear fields after delete
                        txtboxID.Text = "";
                        txtName.Text = "";
                        txtAddress.Text = "";
                        txtPhone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBoxPatient.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFind.Text);
            SqlCommand command = new SqlCommand("SELECT ID, name, birthdate, gender, phone, address, picture FROM PATIENT WHERE ID=" + id);
            DataTable table = patient.getPatient(command);
            if (table.Rows.Count > 0)
            {
               txtboxID.Text= table.Rows[0]["ID"].ToString();
                txtName.Text = table.Rows[0]["name"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["birthdate"];
                comboBox1.Text = table.Rows[0]["gender"].ToString();
                //comboBox1 = table.Rows[0][comboBox1.Text].ToString();
                txtPhone.Text = table.Rows[0]["phone"].ToString();
                txtAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxPatient.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if (
                            (txtName.Text.Trim() == "")
                        || (txtAddress.Text.Trim() == "")
                        || (txtPhone.Text.Trim() == "")
                        /*|| (pictureBoxPatient.Image == null)*/)
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
