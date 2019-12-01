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
    public partial class frmAdd : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DOAN;Integrated Security=True");
        SqlCommand com;
        string commal = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=DOAN;Integrated Security=True";
        SqlConnection cnn;


        public frmAdd()
        {
            InitializeComponent();
            cnn = new SqlConnection(commal);
            cnn.Open();

        }
        private void frmAdd_Load(object sender, EventArgs e)
        {
           
            dataload();
        }

        public void dataload()
        {
            sql.Open();
            string query = "SELECT * FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(query, sql);
            DataTable data = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(data);
            sql.Close();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)// button  để t copy
        {
            DialogResult dialog= MessageBox.Show("Thao tác thành công ", "THÔNG BÁO ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           
                com = cnn.CreateCommand();
                com.CommandText = "INSERT INTO NHANVIEN VALUES ('" + txtMaNV.Text + "',N'" + txtHOTEN.Text + "',N'" + txtChucVu.Text + "','" + txtSDT.Text + "',N'"+ txtGT.Text+"','"+txtNgsinh.Text+ "',N'"+txtDiachi+"'," + txtLuong.Text + ",'" + txtNgVL.Text + "')";
                com.ExecuteNonQuery();
                this.Close(); // 

           
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
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


    }
}
