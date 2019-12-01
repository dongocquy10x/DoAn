using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.Cache;

namespace Presentation
{
    public partial class frmGiaoDien : Form
    {
        public frmGiaoDien()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 300)
                MenuVertical.Width = 70;
            else
                MenuVertical.Width = 300;
        }

        private void IconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconMaximize.Visible = false;
            IconRestore.Visible = true;
        }

        private void IconRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestore.Visible = false;
            IconMaximize.Visible = true;
        }

        private void IconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            //Di chuyen giao dien
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGiaoDien_Load(object sender, EventArgs e)
        {
            lblHoTen.Text += UserLoginCache.HoTen;
            lblChucVu.Text += UserLoginCache.ChucVu;
            lblEmail.Text += UserLoginCache.SDT;

            if (UserLoginCache.ChucVu == "Nhân Viên Bán Hàng")
            {
                button1.Enabled = true;
            }
            else if (UserLoginCache.ChucVu == "Thủ Kho")
            {
                btnNhaKho.Enabled = true;
            }
            else if (UserLoginCache.ChucVu == "Giám Đốc" || UserLoginCache.ChucVu== "Quản Lý")
            {
                btnTongQuan.Enabled = true;
                btnSanPham.Enabled = true;
                btnNhanVien.Enabled = true;
                btnKhachHang.Enabled = true;
                btnNhaKho.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
        private void ADDfrompanel(object frompanel)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            Form th;
            th = frompanel as Form;
            th.TopLevel = false;
            th.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(th);
            this.panelContainer.Tag = th;
            th.Show();
        }
        

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ADDfrompanel(new frmHangHoa());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ADDfrompanel(new frmNhanVien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ADDfrompanel(new frmkhachHang());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADDfrompanel(new frmDonHang());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADDfrompanel(new frmThuChi());
        }

        private void btnNhaKho_Click(object sender, EventArgs e)
        {
            ADDfrompanel(new frmNhaKho());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADDfrompanel(new frmNhapHang());
        }
    }
}
