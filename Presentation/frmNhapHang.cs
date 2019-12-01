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
using System.Data;
namespace Presentation
{
    public partial class frmNhapHang : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DOAN;Integrated Security=True");
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            groupBox1.Text = "Thông tin nhập kho";
            textBox1.Text = "Mã nhập kho";
            textBox3.Text = "Mã hàng hóa";
            textBox2.Text = "Mã NCC";
            textBox4.Text = "Số lượng";
            textBox5.Visible = true;
            
            sql.Open();
            string query = "SELECT * FROM CTNHAPKHO";
            SqlCommand cmd = new SqlCommand(query, sql);
            DataTable data = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(data);
            sql.Close();
            bunifuCustomDataGrid1.DataSource = data;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Thông tin xuất kho";
            textBox1.Text = "Mã xuất kho";
            textBox3.Text = "Số lượng";
            textBox4.Text = "Mã quầy";
            textBox5.Visible = false;
            sql.Open();
            string query = "SELECT * FROM CTXUATKHO";
            SqlCommand cmd = new SqlCommand(query, sql);
            DataTable data = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(data);
            sql.Close();
            bunifuCustomDataGrid1.DataSource = data;
        }

     
    }
}
