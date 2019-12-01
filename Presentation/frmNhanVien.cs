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
    public partial class frmNhanVien : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DOAN;Integrated Security=True");
        SqlCommand com;
        string comma = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=DOAN;Integrated Security=True";
        SqlConnection cnn;


        public frmNhanVien()
        {
            InitializeComponent();
            cnn = new SqlConnection(comma);
            cnn.Open();
            dataload();
        }
     
   
        void dataload()
        {
            sql.Open();// mở SQL
            string query = "SELECT MANV AS 'Mã Nhân Viên',HOTEN AS 'Họ Tên',CHUCVU AS 'Chức Vụ',SDT AS 'Số điện thoại',GIOITINH AS 'Giới Tính',NGAYSINH AS 'Ngày Sinh',DIACHI AS'Địa Chỉ',LUONG AS 'Lương',NGVL AS 'Ngày vào làm'" + 
                " FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(query, sql);
            DataTable data = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(data);
            sql.Close();
            dataGridView1.DataSource = data; // 
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.Show();
            
            dataGridView1.Invalidate();
            dataload(); 
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
         
            com = cnn.CreateCommand();

            com.CommandText = "DELETE FROM NHAPKHO WHERE MANV ='"+textBox1.Text+"'" +
                "DELETE FROM NHANVIEN1 WHERE MANV = '" + textBox1.Text + "'";
            com.ExecuteNonQuery();
            dataload();
       

        }
        String s;

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.Text== "Tìm kiếm thông tin nhân viên")
            {
                bunifuMaterialTextbox1.Text = "";
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.Text=="")
            {
                bunifuMaterialTextbox1.Text = "Tìm kiếm thông tin nhân viên";
            }
        }


        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int i;
        //    i = dataGridView1.CurrentRow.Index;
        //    textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        //    textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        //    textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        //    textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

        //}
        //private void bunifuThinButton22_Click(object sender, EventArgs e)
        //{
        //    com = cnn.CreateCommand();
        //    com.CommandText = "DELETE FROM NHANVIEN WHERE MaNV = '" + textBox1.Text + "'";
        //    com.ExecuteNonQuery();
        //    dataload();
        //}

    }
}
