using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit; // <--- BẮT BUỘC PHẢI CÓ DÒNG NÀYusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggy_Admin
{
        public static class Dinhdangluoi
        {
        public static void DinhDangLuoiAdmin(KryptonDataGridView grid)
        {
            // 1. BẢNG MÀU ADMIN (Dựa trên RGB bạn gửi)
            Color colorHeaderAdmin = Color.FromArgb(124, 144, 160);     // Xanh Dương Đậm (Header)
            Color colorTextAdmin = Color.FromArgb(11, 60, 93);       // Chữ nội dung (Xanh Đậm)

            // Nền chính: Màu Trắng Kem (Sáng sủa)
            Color colorBackgroundGrid = Color.FromArgb(247, 245, 242);

            // Nền dòng chẵn: Màu Kem Xám nhẹ (Zebra)
            Color colorAltRow = Color.FromArgb(206, 219, 221);

            // Màu chọn dòng: Xanh Dương Nhạt (Tạo điểm nhấn)
            Color colorSelection = Color.FromArgb(163, 199, 227);

            // Đường kẻ: Xanh xám nhạt
            Color colorGridLine = Color.FromArgb(124, 144, 160);

            // --- 2. CẤU HÌNH KHUNG VIỀN ---
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.HideOuterBorders = false;

            // --- 3. MÀU NỀN TỔNG THỂ ---
            grid.StateCommon.Background.Color1 = colorBackgroundGrid;
            grid.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundSheet;

            // Thiết lập Zebra (Dòng lẻ/chẵn)
            grid.RowsDefaultCellStyle.BackColor = colorBackgroundGrid;
            grid.AlternatingRowsDefaultCellStyle.BackColor = colorAltRow;

            // --- 4. HEADER (TIÊU ĐỀ CỘT) ---
            grid.PaletteMode = PaletteMode.ProfessionalSystem;
            grid.StateCommon.HeaderColumn.Back.Color1 = colorHeaderAdmin;
            grid.StateCommon.HeaderColumn.Back.Color2 = colorHeaderAdmin;
            grid.StateCommon.HeaderColumn.Content.Color1 = Color.White; // Chữ trắng nổi bật trên nền xanh đậm
            grid.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grid.StateCommon.HeaderColumn.Content.TextH = PaletteRelativeAlign.Center;
            grid.ColumnHeadersHeight = 45;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // --- 5. DÒNG DỮ LIỆU ---
            grid.RowTemplate.Height = 40; // Cao thoáng giống bên User
            grid.StateCommon.DataCell.Content.Font = new Font("Segoe UI", 10F);
            grid.StateCommon.DataCell.Content.Color1 = colorTextAdmin; // Chữ xanh đậm sang trọng

            // --- KẺ LƯỚI DỌC VÀ NGANG ---
            grid.GridStyles.StyleColumn = (GridStyle)DataGridViewStyle.Sheet;
            grid.GridStyles.StyleRow = (GridStyle)DataGridViewStyle.List;

            // Màu đường kẻ
            grid.StateCommon.DataCell.Border.Color1 = colorGridLine;
            grid.StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.All; // Kẻ đủ 4 cạnh (có kẻ dọc)

            // --- 6. HIỆU ỨNG CHỌN DÒNG ---
            grid.StateSelected.DataCell.Back.Color1 = colorSelection;
            grid.StateSelected.DataCell.Back.Color2 = colorSelection;
            // Khi chọn, chữ vẫn giữ màu xanh đậm (dễ đọc) hoặc đổi sang trắng nếu thích tương phản mạnh
            grid.StateSelected.DataCell.Content.Color1 = colorTextAdmin;

            // --- 7. TINH CHỈNH KHÁC ---
            grid.RowHeadersVisible = false;
            grid.AllowUserToResizeRows = false;
            grid.ShowCellToolTips = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static void DinhDangLuoiNguoiDung(KryptonDataGridView grid)
        {
            // --- 1. BẢNG MÀU DỊU MẮT (WARM TONE) ---
            Color colorPrimaryDark = ColorTranslator.FromHtml("#244c3c"); // Header: Xanh rêu đậm
            Color colorTextDark = ColorTranslator.FromHtml("#425e6a");    // Chữ: Xám xanh

            // Nền: Màu Kem Sữa (Thay vì trắng toát lạnh lẽo)
            Color colorBackgroundGrid = Color.FromArgb(244, 244, 238);

            // Nền dòng chẵn: Màu Kem trầm hơn chút (Zebra)
            Color colorAltRow = Color.FromArgb(235, 236, 228);

            // Chọn dòng: Xanh rêu pha Be rất nhạt (Tông xuyệt tông)
            Color colorSelection = Color.FromArgb(215, 220, 210);

            // Đường kẻ bảng: Màu be đậm (để kẻ khung)
            Color colorGridLine = Color.FromArgb(200, 200, 190);

            // --- 2. CẤU HÌNH KHUNG VIỀN (ĐỂ BẬT KHUNG) ---
            grid.BorderStyle = BorderStyle.FixedSingle; // Viền đơn nét mảnh
            grid.HideOuterBorders = false;              // Bắt buộc FALSE để thấy viền ngoài

            // --- 3. MÀU NỀN TỔNG THỂ ---
            grid.StateCommon.Background.Color1 = colorBackgroundGrid;
            grid.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundSheet;

            // Thiết lập màu nền cho dòng lẻ và chẵn
            grid.RowsDefaultCellStyle.BackColor = colorBackgroundGrid;
            grid.AlternatingRowsDefaultCellStyle.BackColor = colorAltRow;

            // --- 4. HEADER (TIÊU ĐỀ CỘT) ---
            grid.PaletteMode = PaletteMode.ProfessionalSystem;
            grid.StateCommon.HeaderColumn.Back.Color1 = colorPrimaryDark;
            grid.StateCommon.HeaderColumn.Back.Color2 = colorPrimaryDark;
            grid.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            grid.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grid.StateCommon.HeaderColumn.Content.TextH = PaletteRelativeAlign.Center;
            grid.ColumnHeadersHeight = 45;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // --- 5. DÒNG DỮ LIỆU ---
            grid.RowTemplate.Height = 40;
            grid.StateCommon.DataCell.Content.Font = new Font("Segoe UI", 10F);
            grid.StateCommon.DataCell.Content.Color1 = colorTextDark;

            // --- QUAN TRỌNG: KẺ LƯỚI DỌC VÀ NGANG ---
            // Dùng Sheet để có kẻ dọc (List chỉ có kẻ ngang)
            // Ép kiểu (DataGridViewStyle) để tránh lỗi CS0266
            //grid.GridStyles.Style = GridStyle.Sheet;
            grid.GridStyles.StyleColumn = GridStyle.Sheet;
            grid.GridStyles.StyleRow = GridStyle.Sheet;

            // Chỉnh màu đường kẻ
            grid.StateCommon.DataCell.Border.Color1 = colorGridLine;
            // Vẽ viền tất cả các cạnh (All) để hiện đường kẻ dọc ngăn cách cột
            grid.StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.All;

            // --- 6. HIỆU ỨNG CHỌN DÒNG ---
            grid.StateSelected.DataCell.Back.Color1 = colorSelection;
            grid.StateSelected.DataCell.Back.Color2 = colorSelection;
            grid.StateSelected.DataCell.Content.Color1 = colorTextDark; // Giữ nguyên màu chữ

            // --- 7. TINH CHỈNH KHÁC ---
            grid.RowHeadersVisible = false;
            grid.AllowUserToResizeRows = false;
            grid.ShowCellToolTips = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
 

