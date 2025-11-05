namespace Demo_Layout
{
    partial class QuanLyTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlTieuDe = new Panel();
            lblTieuDe = new Label();
            pnlNoiDung = new Panel();
            lblThongTinTaiKhoan = new Label();
            lblTenNguoiDung = new Label();
            lblTenDangNhap = new Label();
            lblEmail = new Label();
            picAnhDaiDien = new PictureBox();
            btnCapNhatMatKhau = new Button();
            btnXoaTaiKhoan = new Button();
            btnDangXuat = new Button();

            pnlTieuDe.SuspendLayout();
            pnlNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhDaiDien).BeginInit();
            SuspendLayout();

            // === PANEL TIÊU ĐỀ ===
            pnlTieuDe.BackColor = Color.FromArgb(255, 255, 192);
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Padding = new Padding(20);
            pnlTieuDe.Size = new Size(944, 140);
            pnlTieuDe.TabIndex = 1;

            // === LABEL TIÊU ĐỀ ===
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.Black;
            lblTieuDe.Location = new Point(16, 36);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(471, 57);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ TÀI KHOẢN";

            // === PANEL NỘI DUNG ===
            pnlNoiDung.BackColor = Color.WhiteSmoke;
            pnlNoiDung.Controls.Add(lblThongTinTaiKhoan);
            pnlNoiDung.Controls.Add(lblTenNguoiDung);
            pnlNoiDung.Controls.Add(lblTenDangNhap);
            pnlNoiDung.Controls.Add(lblEmail);
            pnlNoiDung.Controls.Add(picAnhDaiDien);
            pnlNoiDung.Controls.Add(btnCapNhatMatKhau);
            pnlNoiDung.Controls.Add(btnXoaTaiKhoan);
            pnlNoiDung.Controls.Add(btnDangXuat);
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.Location = new Point(0, 140);
            pnlNoiDung.Name = "pnlNoiDung";
            pnlNoiDung.Padding = new Padding(24);
            pnlNoiDung.Size = new Size(944, 298);
            pnlNoiDung.TabIndex = 0;

            // === LABEL "THÔNG TIN TÀI KHOẢN" ===
            lblThongTinTaiKhoan.AutoSize = true;
            lblThongTinTaiKhoan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblThongTinTaiKhoan.ForeColor = Color.DimGray;
            lblThongTinTaiKhoan.Location = new Point(27, 11);
            lblThongTinTaiKhoan.Name = "lblThongTinTaiKhoan";
            lblThongTinTaiKhoan.Size = new Size(204, 28);
            lblThongTinTaiKhoan.Text = "Thông tin tài khoản:";

            // === TÊN NGƯỜI DÙNG ===
            lblTenNguoiDung.AutoSize = true;
            lblTenNguoiDung.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTenNguoiDung.ForeColor = Color.Black;
            lblTenNguoiDung.Location = new Point(400, 53);
            lblTenNguoiDung.Name = "lblTenNguoiDung";
            lblTenNguoiDung.Size = new Size(205, 38);
            lblTenNguoiDung.Text = "Nguyễn Văn A";

            // === TÊN ĐĂNG NHẬP ===
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10F);
            lblTenDangNhap.ForeColor = Color.Gray;
            lblTenDangNhap.Location = new Point(400, 83);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(255, 28);
            lblTenDangNhap.Text = "Tên đăng nhập: nguyenvana";

            // === EMAIL ===
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(400, 107);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(308, 28);
            lblEmail.Text = "Email: nguyenvana@example.com";

            // === ẢNH ĐẠI DIỆN ===
            picAnhDaiDien.BorderStyle = BorderStyle.FixedSingle;
            picAnhDaiDien.Location = new Point(290, 53);
            picAnhDaiDien.Name = "picAnhDaiDien";
            picAnhDaiDien.Size = new Size(82, 83);
            picAnhDaiDien.SizeMode = PictureBoxSizeMode.Zoom;

            // === NÚT CẬP NHẬT MẬT KHẨU ===
            btnCapNhatMatKhau.Font = new Font("Segoe UI", 10F);
            btnCapNhatMatKhau.BackColor = Color.Goldenrod;
            btnCapNhatMatKhau.ForeColor = Color.White;
            btnCapNhatMatKhau.Location = new Point(524, 163);
            btnCapNhatMatKhau.Name = "btnCapNhatMatKhau";
            btnCapNhatMatKhau.Size = new Size(180, 36);
            btnCapNhatMatKhau.Text = "Cập nhật mật khẩu";
            btnCapNhatMatKhau.Click += new EventHandler(this.btnCapNhatMatKhau_Click);

            // === NÚT XÓA TÀI KHOẢN ===
            btnXoaTaiKhoan.Font = new Font("Segoe UI", 10F);
            btnXoaTaiKhoan.BackColor = Color.IndianRed;
            btnXoaTaiKhoan.ForeColor = Color.White;
            btnXoaTaiKhoan.Location = new Point(378, 163);
            btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            btnXoaTaiKhoan.Size = new Size(140, 36);
            btnXoaTaiKhoan.Text = "Xóa tài khoản";
            btnXoaTaiKhoan.Click += new EventHandler(this.btnXoaTaiKhoan_Click);

            // === NÚT ĐĂNG XUẤT ===
            btnDangXuat.Font = new Font("Segoe UI", 10F);
            btnDangXuat.BackColor = Color.SteelBlue;
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(262, 163);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(110, 36);
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.Click += new EventHandler(this.btnDangXuat_Click);

            // === FORM CHÍNH ===
            ClientSize = new Size(944, 438);
            Controls.Add(pnlNoiDung);
            Controls.Add(pnlTieuDe);
            Name = "QuanLyTaiKhoan";
            Text = "Quản lý tài khoản cá nhân";

            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            pnlNoiDung.ResumeLayout(false);
            pnlNoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhDaiDien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Panel pnlNoiDung;
        private Label lblThongTinTaiKhoan;
        private Label lblTenNguoiDung;
        private Label lblTenDangNhap;
        private Label lblEmail;
        private PictureBox picAnhDaiDien;
        private Button btnCapNhatMatKhau;
        private Button btnXoaTaiKhoan;
        private Button btnDangXuat;
    }
}
