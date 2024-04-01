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

namespace DOANCUOIKI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            My_DB db = new My_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE User = @Username AND Password = @Pass", db.getConnection);

            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = textBoxUser.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if ( table.Rows.Count > 0)
            {
                MessageBox.Show("Ok, next time will be go to Main Menu of App");
                MainForm form = new MainForm();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
