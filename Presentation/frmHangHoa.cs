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
        SqlConnection sql = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DOAN;Integrated Security=True");
        SqlCommand com;
        string comma = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=DOAN;Integrated Security=True";
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
    }
}
