using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DOANCUOIKI
{
    public partial class ListPatient : Form
    {
        Patient patient=new Patient();
       
        public ListPatient()
        {
            InitializeComponent();
          
            
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

        private void ListPatient_Load(object sender, EventArgs e)
        {
            listPatientLoad();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditAndRemove edit = new EditAndRemove();   
            edit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditAndRemove edit = new EditAndRemove();
            edit.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PATIENT WHERE CONCAT(name,' ', address, ID) LIKE '%" + txtFind.Text + "%'");
            DataGridViewImageColumn picCo1 = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            DataGridView1.RowTemplate.Height = 80; // dong nay tham khao tren HSDH ngay 19/03/2019,co gian de pic dep, dang tìm auto-size
            DataGridView1.DataSource = patient.getPatient(command);
            picCo1 = (DataGridViewImageColumn)DataGridView1.Columns[6];
            picCo1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }
    }
}
