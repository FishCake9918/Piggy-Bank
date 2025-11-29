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
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            signInToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem1 = new ToolStripMenuItem();
            redoToolStripMenuItem1 = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            findSchedulesToolStripMenuItem1 = new ToolStripMenuItem();
            minimizeToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            documentationToolStripMenuItem1 = new ToolStripMenuItem();
            keyboardShortcutsToolStripMenuItem1 = new ToolStripMenuItem();
            button9 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel3 = new Panel();
            scTaoThongBao = new Button();
            scThemTaiKhoan = new Button();
            scThemBaoCao = new Button();
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
            menuStrip1.SuspendLayout();
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
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1860, 42);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(19, 75, 131);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(11, 6);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 1, 0, 1);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(301, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.BackColor = Color.FromArgb(19, 75, 131);
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { signInToolStripMenuItem, signOutToolStripMenuItem, exitToolStripMenuItem });
            accountToolStripMenuItem.ForeColor = Color.White;
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(98, 29);
            accountToolStripMenuItem.Text = "Account ";
            // 
            // signInToolStripMenuItem
            // 
            signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            signInToolStripMenuItem.Size = new Size(270, 34);
            signInToolStripMenuItem.Text = "Sign in ";
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(270, 34);
            signOutToolStripMenuItem.Text = "Sign out";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem1, redoToolStripMenuItem1 });
            editToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem1
            // 
            undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            undoToolStripMenuItem1.Size = new Size(158, 34);
            undoToolStripMenuItem1.Text = "Undo";
            // 
            // redoToolStripMenuItem1
            // 
            redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            redoToolStripMenuItem1.Size = new Size(158, 34);
            redoToolStripMenuItem1.Text = "Redo";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findSchedulesToolStripMenuItem1, minimizeToolStripMenuItem1 });
            toolsToolStripMenuItem.ForeColor = Color.White;
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(69, 29);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // findSchedulesToolStripMenuItem1
            // 
            findSchedulesToolStripMenuItem1.Name = "findSchedulesToolStripMenuItem1";
            findSchedulesToolStripMenuItem1.Size = new Size(270, 34);
            findSchedulesToolStripMenuItem1.Text = "Find schedules";
            // 
            // minimizeToolStripMenuItem1
            // 
            minimizeToolStripMenuItem1.Name = "minimizeToolStripMenuItem1";
            minimizeToolStripMenuItem1.Size = new Size(270, 34);
            minimizeToolStripMenuItem1.Text = "Minimize";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.BackColor = Color.FromArgb(19, 75, 131);
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentationToolStripMenuItem1, keyboardShortcutsToolStripMenuItem1 });
            helpToolStripMenuItem.ForeColor = Color.White;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem1
            // 
            documentationToolStripMenuItem1.Name = "documentationToolStripMenuItem1";
            documentationToolStripMenuItem1.Size = new Size(270, 34);
            documentationToolStripMenuItem1.Text = "Documentation";
            // 
            // keyboardShortcutsToolStripMenuItem1
            // 
            keyboardShortcutsToolStripMenuItem1.Name = "keyboardShortcutsToolStripMenuItem1";
            keyboardShortcutsToolStripMenuItem1.Size = new Size(270, 34);
            keyboardShortcutsToolStripMenuItem1.Text = "Keyboard Shortcuts";
            // 
            // button9
            // 
            button9.Dock = DockStyle.Right;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(1734, 0);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(42, 42);
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
            button7.Location = new Point(1776, 0);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(42, 42);
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
            button8.Location = new Point(1818, 0);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(42, 42);
            button8.TabIndex = 1;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(70, 125, 167);
            panel3.Controls.Add(scTaoThongBao);
            panel3.Controls.Add(scThemTaiKhoan);
            panel3.Controls.Add(scThemBaoCao);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 42);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1860, 51);
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
            scTaoThongBao.Location = new Point(388, 2);
            scTaoThongBao.Name = "scTaoThongBao";
            scTaoThongBao.Size = new Size(175, 49);
            scTaoThongBao.TabIndex = 9;
            scTaoThongBao.Text = "Tạo thông báo";
            scTaoThongBao.TextAlign = ContentAlignment.MiddleRight;
            scTaoThongBao.UseVisualStyleBackColor = true;
            // 
            // scThemTaiKhoan
            // 
            scThemTaiKhoan.FlatAppearance.BorderSize = 0;
            scThemTaiKhoan.FlatStyle = FlatStyle.Flat;
            scThemTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            scThemTaiKhoan.ForeColor = Color.White;
            scThemTaiKhoan.Image = (Image)resources.GetObject("scThemTaiKhoan.Image");
            scThemTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            scThemTaiKhoan.Location = new Point(184, 2);
            scThemTaiKhoan.Name = "scThemTaiKhoan";
            scThemTaiKhoan.Size = new Size(183, 49);
            scThemTaiKhoan.TabIndex = 8;
            scThemTaiKhoan.Text = "Thêm tài khoản";
            scThemTaiKhoan.TextAlign = ContentAlignment.MiddleRight;
            scThemTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // scThemBaoCao
            // 
            scThemBaoCao.FlatAppearance.BorderSize = 0;
            scThemBaoCao.FlatStyle = FlatStyle.Flat;
            scThemBaoCao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            scThemBaoCao.ForeColor = Color.White;
            scThemBaoCao.Image = (Image)resources.GetObject("scThemBaoCao.Image");
            scThemBaoCao.ImageAlign = ContentAlignment.MiddleLeft;
            scThemBaoCao.Location = new Point(17, 2);
            scThemBaoCao.Name = "scThemBaoCao";
            scThemBaoCao.Size = new Size(161, 49);
            scThemBaoCao.TabIndex = 7;
            scThemBaoCao.Text = "Tạo báo cáo ";
            scThemBaoCao.TextAlign = ContentAlignment.MiddleRight;
            scThemBaoCao.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1795, 8);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
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
            pnlMenu.Location = new Point(0, 93);
            pnlMenu.Margin = new Padding(4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(388, 907);
            pnlMenu.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(lblVaiTro);
            panel1.Controls.Add(lblTenHienThi);
            panel1.Controls.Add(picUserProfile);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 807);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 100);
            panel1.TabIndex = 6;
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblVaiTro.ForeColor = Color.FromArgb(124, 144, 160);
            lblVaiTro.Location = new Point(100, 50);
            lblVaiTro.Margin = new Padding(4, 0, 4, 0);
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
            lblTenHienThi.Location = new Point(100, 19);
            lblTenHienThi.Margin = new Padding(4, 0, 4, 0);
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
            picUserProfile.Location = new Point(15, 15);
            picUserProfile.Margin = new Padding(4);
            picUserProfile.Name = "picUserProfile";
            picUserProfile.Size = new Size(70, 70);
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
            button5.Location = new Point(8, 198);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(376, 88);
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
            button2.Location = new Point(11, 102);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(376, 88);
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
            button1.Location = new Point(11, 8);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(376, 88);
            button1.TabIndex = 0;
            button1.Text = "  Báo cáo thống kê";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlHienThi
            // 
            pnlHienThi.BackColor = Color.FromArgb(247, 245, 242);
            pnlHienThi.Dock = DockStyle.Fill;
            pnlHienThi.Location = new Point(388, 93);
            pnlHienThi.Margin = new Padding(4);
            pnlHienThi.Name = "pnlHienThi";
            pnlHienThi.Size = new Size(1472, 907);
            pnlHienThi.TabIndex = 4;
            // 
            // FrmMainAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1860, 1000);
            Controls.Add(pnlHienThi);
            Controls.Add(pnlMenu);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmMainAdmin";
            Text = "FrmMainAdmin";
            Load += FrmMain_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem signInToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem1;
        private ToolStripMenuItem redoToolStripMenuItem1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem findSchedulesToolStripMenuItem1;
        private ToolStripMenuItem minimizeToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem1;
        private ToolStripMenuItem keyboardShortcutsToolStripMenuItem1;
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
        private Button scThemBaoCao;
        private Button scThemTaiKhoan;
        private Button scTaoThongBao;
    }
}
