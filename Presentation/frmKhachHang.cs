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
    public partial class frmkhachHang : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DOAN;Integrated Security=True");
            public frmkhachHang()
        {
            InitializeComponent();
            dataload();
        }
        void dataload()
        {
            sql.Open();
            string query = "SELECT * FROM KHACHHANG";
            SqlCommand cmd = new SqlCommand(query, sql);
            DataTable data = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(data);
            sql.Close();
            dataGridView1.DataSource = data;
        }
    }
}
