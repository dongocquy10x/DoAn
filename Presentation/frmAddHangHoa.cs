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
    public partial class frmAddHangHoa : Form
    {
        public string s1,s2,s3,s4,s5,s6,s7,s8;
    
        SqlConnection sql = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DOAN;Integrated Security=True");

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
         



        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thoát", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        SqlCommand com;



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn tiếp tục ", "THÔNG BÁO ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(dialog ==  DialogResult.OK)
            {
                com = cnn.CreateCommand();
            com.CommandText = "INSERT INTO HANGHOA VALUES ('" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + comboBox1.Text + "'," + textBox4.Text + "," + textBox5.Text + ",N'" + textBox6.Text + "',N'" + comboBox2.Text + "',N'" + comboBox3.Text + "')";
            com.ExecuteNonQuery();
            dataload();
            }
             // 

        }

        string commal = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=DOAN;Integrated Security=True";
        SqlConnection cnn;


        public frmAddHangHoa()
        {
            InitializeComponent();
            cnn = new SqlConnection(commal);
            cnn.Open();

        }
        private void frmAdd_Load(object sender, EventArgs e)
        {

            dataload();
        }

        void dataload()
        {
            sql.Open();
            string query = "SELECT * FROM HANGHOA";
            SqlCommand cmd = new SqlCommand(query, sql);
            DataTable data = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(data);
            sql.Close();
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
