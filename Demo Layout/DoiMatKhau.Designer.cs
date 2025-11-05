using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Demo_Layout
{
    partial class DoiMatKhau
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Mã thiết kế giao diện

        private void InitializeComponent()
        {
            lblMatKhauCu = new Label();
            lblMatKhauMoi = new Label();
            lblXacNhan = new Label();
            txtMatKhauCu = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            btnDongY = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblMatKhauCu
            // 
            lblMatKhauCu.AutoSize = true;
            lblMatKhauCu.Location = new Point(16, 20);
            lblMatKhauCu.Name = "lblMatKhauCu";
            lblMatKhauCu.Size = new Size(147, 25);
            lblMatKhauCu.TabIndex = 0;
            lblMatKhauCu.Text = "Mật khẩu hiện tại:";
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Location = new Point(16, 60);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(121, 25);
            lblMatKhauMoi.TabIndex = 2;
            lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // lblXacNhan
            // 
            lblXacNhan.AutoSize = true;
            lblXacNhan.Location = new Point(16, 100);
            lblXacNhan.Name = "lblXacNhan";
            lblXacNhan.Size = new Size(162, 25);
            lblXacNhan.TabIndex = 4;
            lblXacNhan.Text = "Xác nhận mật khẩu:";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(200, 14);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(240, 31);
            txtMatKhauCu.TabIndex = 1;
            txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(200, 54);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(240, 31);
            txtMatKhauMoi.TabIndex = 3;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(200, 94);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(240, 31);
            txtXacNhanMatKhau.TabIndex = 5;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(200, 150);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(90, 32);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(360, 150);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 32);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // DoiMatKhauForm
            // 
            AcceptButton = btnDongY;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 200);
            Controls.Add(btnHuy);
            Controls.Add(btnDongY);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(lblXacNhan);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Controls.Add(lblMatKhauCu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DoiMatKhauForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMatKhauCu;
        private Label lblMatKhauMoi;
        private Label lblXacNhan;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhanMatKhau;
        private Button btnDongY;
        private Button btnHuy;
    }
}
