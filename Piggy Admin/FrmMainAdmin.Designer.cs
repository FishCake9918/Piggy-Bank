namespace Piggy_Admin
{
    partial class FrmMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainAdmin));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button9 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel3 = new Panel();
            scTaoThongBao = new Button();
            scThemTaiKhoan = new Button();
            pictureBox2 = new PictureBox();
            pnlMenu = new Panel();
            panel1 = new Panel();
            lblVaiTro = new Label();
            lblTenHienThi = new Label();
            picUserProfile = new PictureBox();
            button5 = new Button();
            button2 = new Button();
            button1 = new Button();
            pnlHienThi = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserProfile).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(19, 75, 131);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1488, 44);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 12);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 3;
            label1.Text = "PIGGY ADMIN";
            // 
            // button9
            // 
            button9.Dock = DockStyle.Right;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(1386, 0);
            button9.Name = "button9";
            button9.Size = new Size(34, 44);
            button9.TabIndex = 2;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Right;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(1420, 0);
            button7.Name = "button7";
            button7.Size = new Size(34, 44);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Right;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(1454, 0);
            button8.Name = "button8";
            button8.Size = new Size(34, 44);
            button8.TabIndex = 1;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(70, 125, 167);
            panel3.Controls.Add(scTaoThongBao);
            panel3.Controls.Add(scThemTaiKhoan);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(1488, 53);
            panel3.TabIndex = 2;
            // 
            // scTaoThongBao
            // 
            scTaoThongBao.FlatAppearance.BorderSize = 0;
            scTaoThongBao.FlatStyle = FlatStyle.Flat;
            scTaoThongBao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            scTaoThongBao.ForeColor = Color.White;
            scTaoThongBao.Image = (Image)resources.GetObject("scTaoThongBao.Image");
            scTaoThongBao.ImageAlign = ContentAlignment.MiddleLeft;
            scTaoThongBao.Location = new Point(190, 9);
            scTaoThongBao.Margin = new Padding(2);
            scTaoThongBao.Name = "scTaoThongBao";
            scTaoThongBao.Size = new Size(151, 39);
            scTaoThongBao.TabIndex = 9;
            scTaoThongBao.Text = "Tạo thông báo";
            scTaoThongBao.TextAlign = ContentAlignment.MiddleRight;
            scTaoThongBao.UseVisualStyleBackColor = true;
            scTaoThongBao.Click += scTaoThongBao_Click;
            // 
            // scThemTaiKhoan
            // 
            scThemTaiKhoan.FlatAppearance.BorderSize = 0;
            scThemTaiKhoan.FlatStyle = FlatStyle.Flat;
            scThemTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            scThemTaiKhoan.ForeColor = Color.White;
            scThemTaiKhoan.Image = (Image)resources.GetObject("scThemTaiKhoan.Image");
            scThemTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            scThemTaiKhoan.Location = new Point(14, 9);
            scThemTaiKhoan.Margin = new Padding(2);
            scThemTaiKhoan.Name = "scThemTaiKhoan";
            scThemTaiKhoan.Size = new Size(158, 39);
            scThemTaiKhoan.TabIndex = 8;
            scThemTaiKhoan.Text = "Thêm tài khoản";
            scThemTaiKhoan.TextAlign = ContentAlignment.MiddleRight;
            scThemTaiKhoan.UseVisualStyleBackColor = true;
            scThemTaiKhoan.Click += scThemTaiKhoan_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1436, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(11, 60, 93);
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Controls.Add(button5);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Controls.Add(button1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 97);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(310, 703);
            pnlMenu.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(lblVaiTro);
            panel1.Controls.Add(lblTenHienThi);
            panel1.Controls.Add(picUserProfile);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 623);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 80);
            panel1.TabIndex = 6;
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblVaiTro.ForeColor = Color.FromArgb(124, 144, 160);
            lblVaiTro.Location = new Point(80, 40);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(65, 25);
            lblVaiTro.TabIndex = 4;
            lblVaiTro.Text = "Vai trò";
            // 
            // lblTenHienThi
            // 
            lblTenHienThi.AutoSize = true;
            lblTenHienThi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTenHienThi.ForeColor = Color.FromArgb(11, 60, 93);
            lblTenHienThi.Location = new Point(80, 15);
            lblTenHienThi.Name = "lblTenHienThi";
            lblTenHienThi.Size = new Size(168, 28);
            lblTenHienThi.TabIndex = 3;
            lblTenHienThi.Text = "Tên Người Dùng";
            // 
            // picUserProfile
            // 
            picUserProfile.BackColor = Color.FromArgb(247, 245, 242);
            picUserProfile.Cursor = Cursors.Hand;
            picUserProfile.Image = (Image)resources.GetObject("picUserProfile.Image");
            picUserProfile.Location = new Point(12, 12);
            picUserProfile.Name = "picUserProfile";
            picUserProfile.Size = new Size(56, 56);
            picUserProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picUserProfile.TabIndex = 2;
            picUserProfile.TabStop = false;
            picUserProfile.Click += pictureBox1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(11, 60, 93);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(6, 158);
            button5.Name = "button5";
            button5.Size = new Size(301, 70);
            button5.TabIndex = 4;
            button5.Text = "Quản lý thông báo";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(11, 60, 93);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(9, 82);
            button2.Name = "button2";
            button2.Size = new Size(301, 70);
            button2.TabIndex = 1;
            button2.Text = "  Quản lý tài khoản";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(11, 60, 93);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(9, 6);
            button1.Name = "button1";
            button1.Size = new Size(301, 70);
            button1.TabIndex = 0;
            button1.Text = "  Báo cáo thống kê";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlHienThi
            // 
            pnlHienThi.BackColor = Color.FromArgb(247, 245, 242);
            pnlHienThi.Dock = DockStyle.Fill;
            pnlHienThi.Location = new Point(310, 97);
            pnlHienThi.Name = "pnlHienThi";
            pnlHienThi.Size = new Size(1178, 703);
            pnlHienThi.TabIndex = 4;
            // 
            // FrmMainAdmin
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1488, 800);
            Controls.Add(pnlHienThi);
            Controls.Add(pnlMenu);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMainAdmin";
            Text = "FrmMainAdmin";
            Load += FrmMain_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserProfile).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button button9;
        private Button button7;
        private Button button8;
        private Panel panel3;
        private Panel pnlMenu;
        private Panel panel1;
        private PictureBox picUserProfile;
        private Button button5;
        private Button button2;
        private Button button1;
        private Panel pnlHienThi;
        private PictureBox pictureBox2;

        // Labels mới
        private System.Windows.Forms.Label lblTenHienThi;
        private System.Windows.Forms.Label lblVaiTro;
        private Button scThemTaiKhoan;
        private Button scTaoThongBao;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
