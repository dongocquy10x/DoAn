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
using System.Data.SqlClient;
using Domain;


namespace Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void IconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //Di chuyen giao dien
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            if (tk == "")
            {
                lblErrorMessage.Text = "Vui lòng nhập Tài khoản";
                lblErrorMessage.Visible = true;
                picError.Visible = true;
            }
            else
            {
                if (mk == "")
                {
                    lblErrorMessage.Text = "Vui lòng nhập Mật khẩu";
                    lblErrorMessage.Visible = true;
                    picError.Visible = true;
                }
                else
                {
                    try
                    {
                        UserModel user = new UserModel();
                        var validLogin = user.LoginUser(tk, mk);
                        if (validLogin == true)
                        {
                            this.Hide();
                            frmWait_for_GiaoDien welcome = new frmWait_for_GiaoDien();
                            welcome.ShowDialog();
                            frmGiaoDien frmGiaoDien = new frmGiaoDien();
                            frmGiaoDien.Show();
                            // thêm sự kiện logout khi bấm nút logout bên frmGiaoDien,
                            // nếu không có thì khi bấm nút LogOut , frmLogin sẽ k xuất hiện
                            frmGiaoDien.FormClosed += LogOut;
                            // Ẩn frmLogin khi đăng nhập thành công
                            // hàm Close sẽ đóng luôn frm -> đóng luôn chương trình

                        }
                        else
                        {
                            MessageBox.Show("Tài khoản/Mật khẩu bạn đã nhập không chính xác! Vui lòng kiểm tra lại.",
                                "Lỗi đăng nhập",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            txtTaiKhoan.Focus();
                            txtMatKhau.Text = "";
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi kết nối");
                    }
                }
            }
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {

            // show frmLogin sau khi log out
            this.Show();

            // xóa hết những gì đã nhập
            this.txtTaiKhoan.Clear();
            this.txtMatKhau.Clear();

            lblErrorMessage.Visible = false;
            txtTaiKhoan.Focus();
        }


    }


}
