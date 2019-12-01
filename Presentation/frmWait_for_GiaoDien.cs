using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
namespace Presentation
{
    public partial class frmWait_for_GiaoDien : Form
    {
        public frmWait_for_GiaoDien()
        {
            InitializeComponent();
        }

        int time;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity == 0.0)
            {
                timer2.Stop();
                this.Close();
            }

        }

        private void FrmWait_for_GiaoDien_Load(object sender, EventArgs e)
        {
            lblTenNguoiDung.Text = UserLoginCache.HoTen;
            this.Opacity = 0.0;
            timer1.Start();
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }

        private void CircularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}