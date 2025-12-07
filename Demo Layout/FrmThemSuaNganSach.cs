using Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace Demo_Layout
{
    public partial class FrmThemSuaNganSach : Form
    {
        private readonly IDbContextFactory<QLTCCNContext> _dbFactory;
        private readonly NguoiDungHienTai _userContext;
        private int _maNganSach = 0;
        public FrmThemSuaNganSach(
            IDbContextFactory<QLTCCNContext> dbFactory,
            NguoiDungHienTai userContext)
        {
            InitializeComponent();
            _dbFactory = dbFactory;
            _userContext = userContext;

            this.Load += FrmThemSuaNganSach_Load;
            this.btnLuu.Click += BtnLuu_Click;
            this.btnHuy.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            // Xử lý sự kiện KeyPress để chỉ cho phép nhập số/dấu phẩy/dấu chấm vào ô tiền và năm.
            this.txtSoTien.KeyPress += TxtSoTien_KeyPress;
            this.txtNam.KeyPress += TxtNam_KeyPress;
        }
        // Chức năng thiết lập chế độ Thêm/Sửa
        public void SetId(int id)
        {
            _maNganSach = id;
            this.Text = (id == 0) ? "Thêm Ngân sách mới" : "Sửa Ngân sách";

            // CẬP NHẬT: Đặt tiêu đề cho lblForm
            if (lblForm != null)
            {
                lblForm.Text = (id == 0) ? "THÊM NGÂN SÁCH" : "SỬA NGÂN SÁCH";
            }

            if (_maNganSach == 0)
            {
                txtSoTien.Text = string.Empty;
                // cmbThang là ComboBox WinForms, thuộc tính SelectedValue vẫn hoạt động
                if (cmbThang.DataSource != null) cmbThang.SelectedValue = DateTime.Today.Month;
                txtNam.Text = DateTime.Today.Year.ToString();
            }
        }

        private void TxtNam_KeyPress(object sender, KeyPressEventArgs e) { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }
        private void FrmThemSuaNganSach_Load(object sender, EventArgs e) { LoadThangComboBox(); LoadDanhMuc(); if (_maNganSach > 0) LoadDataForEdit(_maNganSach); }

        
        // Tải danh sách Danh mục chi tiêu (chỉ các danh mục cấp cha)
        private void LoadDanhMuc()
        {
            if (_userContext.MaNguoiDung == null) return;
            try
            {
                using (var db = _dbFactory.CreateDbContext())
                {
                    var danhMucList = db.DanhMucChiTieus
                       .Where(d => d.MaNguoiDung == _userContext.MaNguoiDung && d.DanhMucCha == null)
                       .AsNoTracking().ToList();

                    cmbDanhMuc.DataSource = danhMucList;
                    cmbDanhMuc.DisplayMember = "TenDanhMuc";
                    cmbDanhMuc.ValueMember = "MaDanhMuc";
                    cmbDanhMuc.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void LoadThangComboBox()
        {
            var months = Enumerable.Range(1, 12).Select(m => new { MonthValue = m, MonthName = $"Tháng {m}" }).ToList();
            cmbThang.DataSource = months;
            cmbThang.DisplayMember = "MonthName";
            cmbThang.ValueMember = "MonthValue";
            cmbThang.SelectedValue = DateTime.Today.Month;
        }
        // Hàm tải dữ liệu cho chế độ Sửa
        private void LoadDataForEdit(int id)
        {
            try
            {
                using (var db = _dbFactory.CreateDbContext())
                {
                    var ns = db.BangNganSachs
                               .AsNoTracking()
                               .FirstOrDefault(n => n.MaNganSach == id && n.MaNguoiDung == _userContext.MaNguoiDung);

                    if (ns != null)
                    {
                        // Định dạng số tiền có dấu phẩy/chấm theo CultureInfo hiện tại (ví dụ: 100,000)
                        txtSoTien.Text = ns.SoTien.ToString("N0", CultureInfo.CurrentCulture);
                        // Ràng buộc: Không cho phép sửa Danh mục, Tháng, Năm khi ở chế độ Sửa
                        cmbDanhMuc.SelectedValue = ns.MaDanhMuc;
                        cmbDanhMuc.Enabled = false;
                        cmbThang.SelectedValue = ns.NgayBatDau?.Month ?? DateTime.Today.Month;
                        txtNam.Text = (ns.NgayBatDau?.Year ?? DateTime.Today.Year).ToString();
                        cmbThang.Enabled = false; txtNam.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Ngân sách không tồn tại hoặc bạn không có quyền truy cập.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (_userContext.MaNguoiDung == null) return;
            int? maDanhMuc = cmbDanhMuc.SelectedValue as int?;
            int? thang = cmbThang.SelectedValue as int?;
            int? nam = int.TryParse(txtNam.Text.Trim(), out int n) ? (int?)n : null;
            decimal soTien;

            if (maDanhMuc == null || maDanhMuc.Value <= 0) { MessageBox.Show("Vui lòng chọn Danh mục."); return; }
            if (!thang.HasValue || !nam.HasValue) { MessageBox.Show("Vui lòng chọn Tháng/Năm."); return; }
            // Xử lý và kiểm tra Số tiền
            // Thay thế dấu phẩy/chấm để cố gắng Parse, đảm bảo số tiền > 0.
            if (!decimal.TryParse(txtSoTien.Text.Replace(",", "").Replace(".", ""), NumberStyles.Any, CultureInfo.CurrentCulture, out soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền phải lớn hơn 0 và đúng định dạng.");
                return;
            }

            DateTime ngayBatDau;
            try { ngayBatDau = new DateTime(nam.Value, thang.Value, 1); } catch { MessageBox.Show("Ngày tháng năm không hợp lệ."); return; }

            if (_maNganSach == 0)
            {
                if (ngayBatDau.Date < new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)) { MessageBox.Show("Không thể lập ngân sách cho tháng/năm đã qua."); return; }
            }

            using (var db = _dbFactory.CreateDbContext())
            {
                try
                {
                    if (_maNganSach == 0)
                    {
                        // Ràng buộc: Kiểm tra trùng lặp (Ngân sách cho Danh mục/Tháng/Năm đã tồn tại?)
                        bool isOverlap = db.BangNganSachs.Any(n => n.MaNguoiDung == _userContext.MaNguoiDung && n.MaDanhMuc == maDanhMuc.Value && n.NgayBatDau == ngayBatDau);
                        if (isOverlap) { MessageBox.Show("Đã có ngân sách cho danh mục này trong tháng/năm này."); return; }

                        var newNs = new BangNganSach // Tạo đối tượng BangNganSach mới
                        {
                            SoTien = soTien,
                            NgayBatDau = ngayBatDau,
                            NgayKetThuc = ngayBatDau.AddMonths(1).AddDays(-1), // Logic tính toán: Ngày kết thúc là ngày cuối cùng của tháng (NgayBatDau + 1 tháng - 1 ngày)
                            MaNguoiDung = _userContext.MaNguoiDung.Value,
                            MaDanhMuc = maDanhMuc.Value
                        };
                        db.BangNganSachs.Add(newNs);
                    }
                    else // LOGIC CHỈNH SỬA (chỉ cho phép sửa SoTien)
                    {
                        var nsToUpdate = db.BangNganSachs.FirstOrDefault(n => n.MaNganSach == _maNganSach);

                        if (nsToUpdate != null && nsToUpdate.MaNguoiDung == _userContext.MaNguoiDung)
                        {
                            nsToUpdate.SoTien = soTien;
                        }
                        else if (nsToUpdate != null)
                        {
                            MessageBox.Show("Bạn không có quyền sửa ngân sách này.");
                            return;
                        }
                    }
                    db.SaveChanges();
                    MessageBox.Show("Lưu Ngân sách thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi khi lưu Ngân sách: " + ex.Message); }
            }
        }

        private void TxtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',') e.Handled = true;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && ((TextBox)sender).Text.Contains(e.KeyChar)) e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}