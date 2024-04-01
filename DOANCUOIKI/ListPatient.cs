using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.IO;
namespace DOANCUOIKI
{
    public partial class ListPatient : Form
    {
        Patient patient = new Patient();

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

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataColumn col1 = new DataColumn("ID");
            DataColumn col2 = new DataColumn("name");
            DataColumn col3 = new DataColumn("address");
            DataColumn col5 = new DataColumn("gender");
            DataColumn col4 = new DataColumn("birthdate");
            DataColumn col6 = new DataColumn("phone");
            DataColumn col7 = new DataColumn("image");


            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);


            foreach (DataGridViewRow dtgvRow in DataGridView1.Rows)
            {
                DataRow dtrow = dataTable.NewRow();
                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;
                dtrow[6] = dtgvRow.Cells[6].Value;
            
                dataTable.Rows.Add(dtrow);
            }
            ExportFile(dataTable, "Danh sach", "Danh sách patient");
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "M1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "ID";

            cl1.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "name";

            cl2.ColumnWidth = 30.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "address";
            cl3.ColumnWidth = 15.5;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "birthdate";

            cl4.ColumnWidth = 15.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "gender";

            cl5.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "phone";

            cl6.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "image";

            cl7.ColumnWidth = 20.5;
      
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        }

       

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                My_DB db = new My_DB();
                DetailTreatment treament = new DetailTreatment();
                string id = DataGridView1.CurrentRow.Cells[0].Value.ToString();
                treament.labelSTT.Text += id;

                SqlCommand command = new SqlCommand("SELECT * FROM Treatment where idPatient=@id", db.getConnection);
                command.Parameters.Add("@id ", SqlDbType.VarChar).Value = id;
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
            catch { 
            
               MessageBox.Show("Benh nhan chua co lich dieu tri", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}