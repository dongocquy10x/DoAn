using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
//using Common.Cache;

namespace Presentation
{
    public class UserModel
    {
        UserData userData = new UserData();
        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user, pass);
        }

    }

}
namespace Presentation
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picError = new System.Windows.Forms.PictureBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.chkLuuMatKhau = new System.Windows.Forms.CheckBox();
            this.IconMinimize = new System.Windows.Forms.PictureBox();
            this.IconClose = new System.Windows.Forms.PictureBox();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.lnkQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 462);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.picError);
            this.panel2.Controls.Add(this.lblErrorMessage);
            this.panel2.Controls.Add(this.chkLuuMatKhau);
            this.panel2.Controls.Add(this.IconMinimize);
            this.panel2.Controls.Add(this.IconClose);
            this.panel2.Controls.Add(this.lblDangNhap);
            this.panel2.Controls.Add(this.lnkQuenMatKhau);
            this.panel2.Controls.Add(this.btnDangNhap);
            this.panel2.Controls.Add(this.txtTaiKhoan);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTaiKhoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 462);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            // 
            // picError
            // 
            this.picError.Image = ((System.Drawing.Image)(resources.GetObject("picError.Image")));
            this.picError.Location = new System.Drawing.Point(280, 312);
            this.picError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(27, 28);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError.TabIndex = 17;
            this.picError.TabStop = false;
            this.picError.Visible = false;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMessage.Location = new System.Drawing.Point(309, 317);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(129, 24);
            this.lblErrorMessage.TabIndex = 16;
            this.lblErrorMessage.Text = "ErrorMessage";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMessage.Visible = false;
            // 
            // chkLuuMatKhau
            // 
            this.chkLuuMatKhau.AutoSize = true;
            this.chkLuuMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkLuuMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLuuMatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkLuuMatKhau.Location = new System.Drawing.Point(201, 277);
            this.chkLuuMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLuuMatKhau.Name = "chkLuuMatKhau";
            this.chkLuuMatKhau.Size = new System.Drawing.Size(147, 26);
            this.chkLuuMatKhau.TabIndex = 2;
            this.chkLuuMatKhau.Text = "Lưu Mật Khẩu";
            this.chkLuuMatKhau.UseVisualStyleBackColor = true;
            // 
            // IconMinimize
            // 
            this.IconMinimize.AccessibleDescription = "";
            this.IconMinimize.AccessibleName = "";
            this.IconMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimize.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimize.Image")));
            this.IconMinimize.Location = new System.Drawing.Point(664, 5);
            this.IconMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IconMinimize.Name = "IconMinimize";
            this.IconMinimize.Size = new System.Drawing.Size(30, 31);
            this.IconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMinimize.TabIndex = 14;
            this.IconMinimize.TabStop = false;
            this.IconMinimize.Click += new System.EventHandler(this.IconMinimize_Click);
            // 
            // IconClose
            // 
            this.IconClose.AccessibleDescription = "";
            this.IconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconClose.Image = ((System.Drawing.Image)(resources.GetObject("IconClose.Image")));
            this.IconClose.Location = new System.Drawing.Point(707, 5);
            this.IconClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(30, 31);
            this.IconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconClose.TabIndex = 14;
            this.IconClose.TabStop = false;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.BackColor = System.Drawing.Color.SteelBlue;
            this.lblDangNhap.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDangNhap.Location = new System.Drawing.Point(248, 29);
            this.lblDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(259, 45);
            this.lblDangNhap.TabIndex = 13;
            this.lblDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lnkQuenMatKhau
            // 
            this.lnkQuenMatKhau.AutoSize = true;
            this.lnkQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkQuenMatKhau.Location = new System.Drawing.Point(300, 411);
            this.lnkQuenMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkQuenMatKhau.Name = "lnkQuenMatKhau";
            this.lnkQuenMatKhau.Size = new System.Drawing.Size(150, 22);
            this.lnkQuenMatKhau.TabIndex = 4;
            this.lnkQuenMatKhau.TabStop = true;
            this.lnkQuenMatKhau.Text = "Quên Mật Khẩu ?";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Azure;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDangNhap.Location = new System.Drawing.Point(304, 358);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(147, 40);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(201, 143);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(481, 26);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(201, 222);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(481, 26);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(66, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật Khẩu:";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTaiKhoan.Location = new System.Drawing.Point(66, 140);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(129, 29);
            this.lblTaiKhoan.TabIndex = 7;
            this.lblTaiKhoan.Text = "Tài Khoản:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 462);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkLuuMatKhau;
        private System.Windows.Forms.PictureBox IconMinimize;
        private System.Windows.Forms.PictureBox IconClose;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.LinkLabel lnkQuenMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.PictureBox picError;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        // private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}