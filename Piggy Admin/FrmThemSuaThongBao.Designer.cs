using System.Drawing;
using System.Windows.Forms;

namespace Piggy_Admin
{
    partial class FrmThemSuaThongBao
    {
        private System.ComponentModel.IContainer components = null;

        // --- CONTROL GIỮ NGUYÊN TÊN ---
        private System.Windows.Forms.Label lblTieuDe; // Label Title trên Header
        private System.Windows.Forms.Label lblTieuDeTB;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label lblNoiDungTB;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblMaTB;
        private System.Windows.Forms.Label lblMaThongBaoValue;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button button1; // Nút đóng (Close)

        // Control trang trí mới
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLine;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            button1 = new Button();
            lblTieuDe = new Label();
            lblMaTB = new Label();
            lblMaThongBaoValue = new Label();
            lblTieuDeTB = new Label();
            txtTieuDe = new TextBox();
            lblNoiDungTB = new Label();
            txtNoiDung = new TextBox();
            lblRole = new Label();
            txtRole = new TextBox();
            pnlLine = new Panel();
            btnLuu = new Button();
            btnHuy = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(11, 60, 93);
            pnlHeader.Controls.Add(button1);
            pnlHeader.Controls.Add(lblTieuDe);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(2, 2);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(623, 80);
            pnlHeader.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(548, 0);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(75, 80);
            button1.TabIndex = 1;
            button1.Text = "✕";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(30, 22);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(347, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "THÔNG TIN THÔNG BÁO";
            // 
            // lblMaTB
            // 
            lblMaTB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaTB.ForeColor = Color.FromArgb(11, 60, 93);
            lblMaTB.Location = new Point(45, 89);
            lblMaTB.Margin = new Padding(4, 0, 4, 0);
            lblMaTB.Name = "lblMaTB";
            lblMaTB.Size = new Size(150, 34);
            lblMaTB.TabIndex = 11;
            lblMaTB.Text = "Mã TB:";
            // 
            // lblMaThongBaoValue
            // 
            lblMaThongBaoValue.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaThongBaoValue.ForeColor = Color.Gray;
            lblMaThongBaoValue.Location = new Point(152, 83);
            lblMaThongBaoValue.Margin = new Padding(4, 0, 4, 0);
            lblMaThongBaoValue.Name = "lblMaThongBaoValue";
            lblMaThongBaoValue.Size = new Size(150, 34);
            lblMaThongBaoValue.TabIndex = 10;
            lblMaThongBaoValue.Text = "(Tạo mới)";
            // 
            // lblTieuDeTB
            // 
            lblTieuDeTB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTieuDeTB.ForeColor = Color.FromArgb(11, 60, 93);
            lblTieuDeTB.Location = new Point(45, 140);
            lblTieuDeTB.Margin = new Padding(4, 0, 4, 0);
            lblTieuDeTB.Name = "lblTieuDeTB";
            lblTieuDeTB.Size = new Size(150, 34);
            lblTieuDeTB.TabIndex = 9;
            lblTieuDeTB.Text = "Tiêu đề:";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Font = new Font("Segoe UI", 11F);
            txtTieuDe.Location = new Point(45, 178);
            txtTieuDe.Margin = new Padding(4);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(540, 37);
            txtTieuDe.TabIndex = 2;
            // 
            // lblNoiDungTB
            // 
            lblNoiDungTB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNoiDungTB.ForeColor = Color.FromArgb(11, 60, 93);
            lblNoiDungTB.Location = new Point(45, 232);
            lblNoiDungTB.Margin = new Padding(4, 0, 4, 0);
            lblNoiDungTB.Name = "lblNoiDungTB";
            lblNoiDungTB.Size = new Size(150, 34);
            lblNoiDungTB.TabIndex = 8;
            lblNoiDungTB.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Font = new Font("Segoe UI", 11F);
            txtNoiDung.Location = new Point(45, 270);
            txtNoiDung.Margin = new Padding(4);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            txtNoiDung.Size = new Size(540, 161);
            txtNoiDung.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(11, 60, 93);
            lblRole.Location = new Point(35, 460);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(150, 34);
            lblRole.TabIndex = 7;
            lblRole.Text = "Người tạo:";
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.WhiteSmoke;
            txtRole.Font = new Font("Segoe UI", 11F);
            txtRole.Location = new Point(193, 460);
            txtRole.Margin = new Padding(4);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(392, 37);
            txtRole.TabIndex = 4;
            // 
            // pnlLine
            // 
            pnlLine.BackColor = Color.LightGray;
            pnlLine.Location = new Point(45, 519);
            pnlLine.Margin = new Padding(4);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(540, 2);
            pnlLine.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(70, 125, 167);
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(381, 541);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(204, 68);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "LƯU THÔNG BÁO";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(240, 240, 240);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHuy.ForeColor = Color.FromArgb(64, 64, 64);
            btnHuy.Location = new Point(41, 541);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(114, 68);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FrmThemSuaThongBao
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(627, 650);
            Controls.Add(pnlLine);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtRole);
            Controls.Add(lblRole);
            Controls.Add(txtNoiDung);
            Controls.Add(lblNoiDungTB);
            Controls.Add(txtTieuDe);
            Controls.Add(lblTieuDeTB);
            Controls.Add(lblMaThongBaoValue);
            Controls.Add(lblMaTB);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmThemSuaThongBao";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý thông báo";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}