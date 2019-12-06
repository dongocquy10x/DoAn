using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace Presentation
{
    public partial class frmHangHoa : Form
    {
        TextBox text = new TextBox();
        TextBox tb2 = new TextBox();
        TextBox tb3 = new TextBox();
        TextBox tb4 = new TextBox();
        TextBox tb5 = new TextBox();
        ComboBox cb1= new ComboBox();
        ComboBox cb2 = new ComboBox();
        ComboBox cb3 = new ComboBox();
        frmAddHangHoa frm;
        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-RRIQLD7\\SQLEXPRESS;Initial Catalog=QLST;Integrated Security=True");
        SqlCommand com;
        string comma = "Data Source=DESKTOP-RRIQLD7\\SQLEXPRESS;Initial Catalog=QLST;Integrated Security=True";
        SqlConnection cnn;
        public frmHangHoa()
        {
            InitializeComponent();
            cnn = new SqlConnection(comma);
            cnn.Open();
            dataload();
        }
        public void dataload()
        {
            sql.Open();
            string query = "SELECT * FROM HANGHOA";
            SqlCommand cmd = new SqlCommand(query, sql);
            DataTable data = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(data);
            sql.Close();
            dataGridView1.DataSource = data;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Add("ABC");
            this.Controls.Add(comboBox4);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frm = new frmAddHangHoa();
            frm.Show();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            com = cnn.CreateCommand();

            com.CommandText = "DELETE FROM HANGHOA WHERE MAHH = '" + textBox1.Text + "'";
            com.ExecuteNonQuery();
            dataload();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            copyAllToClipboard();
            Excel.Application xlexcel;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    
        private void copyAllToClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if(dataObj!=null)
            {
                Clipboard.SetDataObject(dataObj);
            }
        }

        
    }
}
