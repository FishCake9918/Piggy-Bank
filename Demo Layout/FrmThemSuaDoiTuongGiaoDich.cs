using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Data;

namespace Demo_Layout
{
    public partial class FrmThemSuaDoiTuongGiaoDich : Form
    {
        public Action OnDataSaved; // Callback để refresh dữ liệu ở form cha
        private readonly IDbContextFactory<QLTCCNContext> _dbFactory;
        private readonly CurrentUserContext _userContext;
        private int _idDoiTuong = 0;
        public FrmThemSuaDoiTuongGiaoDich(
            IDbContextFactory<QLTCCNContext> dbFactory,
            CurrentUserContext userContext)
        {
            InitializeComponent();
            _dbFactory = dbFactory;
            _userContext = userContext;
            // Gắn sự kiện bấm nút Lưu và Hủy
            this.btnLuu.Click += btnLuu_Click;
            this.btnHuy.Click += btnHuy_Click;
        }

        public void SetId(int id)
        {
            _idDoiTuong = id;
            this.Text = (id == 0) ? "Thêm Đối Tượng" : "Sửa Đối Tượng"; // Tự động đổi form thành Thêm hoặc Sửa

            // CẬP NHẬT: Đặt tiêu đề cho lblForm
            if (lblForm != null)
            {
                lblForm.Text = (id == 0) ? "THÊM ĐỐI TƯỢNG GIAO DỊCH" : "SỬA ĐỐI TƯỢNG GIAO DỊCH";
            }

            if (_idDoiTuong > 0) LoadDataForEdit(_idDoiTuong);
            else { txtTen.Text = ""; txtGhiChu.Text = ""; }
        }

        private void LoadDataForEdit(int id)
        {
            try
            {
                using (var db = _dbFactory.CreateDbContext())
                {
                    // Đảm bảo đối tượng thuộc về người dùng hiện tại (bảo mật)
                    var obj = db.DoiTuongGiaoDichs
                                .AsNoTracking()
                                .FirstOrDefault(d => d.MaDoiTuongGiaoDich == id && d.MaNguoiDung == _userContext.MaNguoiDung);

                    if (obj != null)
                    {
                        txtTen.Text = obj.TenDoiTuong;
                        txtGhiChu.Text = obj.GhiChu;
                    }
                    else
                    {
                        MessageBox.Show("Đối tượng không tồn tại hoặc bạn không có quyền truy cập.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        private void btnHuy_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; this.Close(); }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_userContext.MaNguoiDung == null) return;
            string tenDoiTuong = txtTen.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();

            if (string.IsNullOrEmpty(tenDoiTuong)) { MessageBox.Show("Tên đối tượng không được để trống."); return; }
            // KIỂM TRA TRÙNG TÊN — chỉ trong phạm vi người dùng hiện tại
            using (var db = _dbFactory.CreateDbContext())
            {       
                bool isDuplicate = db.DoiTuongGiaoDichs
                    .Any(p => p.TenDoiTuong.Equals(tenDoiTuong) &&
                              p.MaNguoiDung == _userContext.MaNguoiDung &&
                              p.MaDoiTuongGiaoDich != _idDoiTuong);

                if (isDuplicate) { MessageBox.Show("Tên đối tượng đã tồn tại. Vui lòng chọn tên khác."); return; }

                try
                {
                    if (_idDoiTuong == 0) //THÊM MỚI — tự động gán MaNguoiDung
                    {
                        var newObj = new DoiTuongGiaoDich
                        {
                            TenDoiTuong = tenDoiTuong,
                            GhiChu = ghiChu,
                            MaNguoiDung = _userContext.MaNguoiDung.Value // <-- ID thật
                        };
                        db.DoiTuongGiaoDichs.Add(newObj);
                    }
                    else // LOGIC CHỈNH SỬA
                    {
                        var objToUpdate = db.DoiTuongGiaoDichs.FirstOrDefault(d => d.MaDoiTuongGiaoDich == _idDoiTuong);
                        if (objToUpdate != null && objToUpdate.MaNguoiDung == _userContext.MaNguoiDung)
                        {
                            objToUpdate.TenDoiTuong = tenDoiTuong;
                            objToUpdate.GhiChu = ghiChu;
                        }
                        else if (objToUpdate != null)
                        {
                            MessageBox.Show("Bạn không có quyền sửa đối tượng này.");
                            return;
                        }
                    }
                    db.SaveChanges();

                    OnDataSaved?.Invoke();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}