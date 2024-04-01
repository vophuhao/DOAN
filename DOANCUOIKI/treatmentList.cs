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
    public partial class treatmentList : Form
    {
        public treatmentList()
        {
            InitializeComponent();
        }

        private void treatmentList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nHAKHOADataSet1.Treatment' table. You can move, or remove it, as needed.
            this.treatmentTableAdapter.Fill(this.nHAKHOADataSet1.Treatment);
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Detail";
            btn.Text = "Xem";
            btn.Name = "btnDetail";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DetailTreatment detailTreatment = new DetailTreatment();
           
            My_DB db = new My_DB();
            DetailTreatment treament = new DetailTreatment();
            string stt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells[4].Value.ToString();
          

            SqlCommand command = new SqlCommand("SELECT * FROM Treatment where namePatient=@name AND STT=@stt", db.getConnection);
            command.Parameters.Add("@name ", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@stt ", SqlDbType.VarChar).Value = stt;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            treament.labelAdvice.Text += table.Rows[0]["Advice"].ToString();
            treament.labelDate.Text += table.Rows[0]["Date"].ToString();
            treament.labelDoctor.Text += table.Rows[0]["nameDoctor"].ToString();
            treament.labelMedicine.Text += table.Rows[0]["Medicine"].ToString();
            treament.labelSTT.Text += table.Rows[0]["STT"].ToString();
            treament.labelDieutri.Text += table.Rows[0]["Dichvu"].ToString();
            treament.labelPatient.Text += table.Rows[0]["namePatient"].ToString();
            treament.labelCost.Text += table.Rows[0]["Cost"].ToString();

            treament.ShowDialog();
        }
    }
}
