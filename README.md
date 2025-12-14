# 🐷 Piggy Bank - Ứng dụng Quản lý Tài chính Cá nhân


**Piggy Bank** là đồ án kết thúc học phần **Phát triển Ứng dụng Desktop** tại trường Đại học Kinh tế TP. Hồ Chí Minh (UEH). Ứng dụng được xây dựng trên nền tảng Windows Forms (WinForms) giúp người dùng cá nhân quản lý thu chi, lập ngân sách và theo dõi dòng tiền một cách trực quan, khoa học.

---

## 👥 Thành viên thực hiện (Nhóm 8)

| STT | Họ và tên | MSSV | Vai trò |
|:---:|:--- |:--- |:--- |
| 1 | **Huỳnh Nguyễn Nhật Nam** | 31231020931 | Nhóm trưởng |
| 2 | **Nguyễn Khánh Hoàng** | 31231025616 | Thành viên |
| 3 | **Trần Bích Trâm** | 31231024970 | Thành viên |
| 4 | **Lê Thanh Vy** | 31231022150 | Thành viên |

**Giảng viên hướng dẫn:** TS. Nguyễn Mạnh Tuấn

---

## 🚀 Công nghệ sử dụng

* **Ngôn ngữ:** C# (.NET Framework / .NET Core)
* **Nền tảng:** Windows Forms (WinForms)
* **Cơ sở dữ liệu:** Microsoft SQL Server
* **ORM:** Entity Framework Core
* **Thư viện hỗ trợ:**
    * `LiveCharts`: Vẽ biểu đồ thống kê trực quan.
    * `MiniExcel`: Xuất báo cáo ra file Excel nhanh chóng.
    * `System.Media.SoundPlayer`: Hiệu ứng âm thanh tương tác.
    * `Dependency Injection (DI)`: Quản lý các service và DbContext.
* **Công cụ thiết kế:** Figma (Prototype), Visual Studio (IDE).

---

## ✨ Tính năng nổi bật

Hệ thống được chia làm 2 phân hệ chính: **Người dùng (User)** và **Quản trị viên (Admin)**.

### 👤 Dành cho Người dùng (User)
1.  **Quản lý Tài khoản & Bảo mật:**
    * Đăng ký/Đăng nhập (Có xác thực qua Email).
    * Đổi mật khẩu, Xóa tài khoản.
    * Quản lý hồ sơ cá nhân.
2.  **Quản lý Tài khoản Thanh toán:**
    * Thêm mới ví tiền (Tiền mặt, Ngân hàng, Ví điện tử...).
    * Theo dõi số dư khả dụng.
    * Chuyển số dư khi đóng tài khoản.
3.  **Quản lý Giao dịch (Thu/Chi):**
    * Ghi chép thu chi hàng ngày.
    * Phân loại theo danh mục và đối tượng.
    * Tìm kiếm và lọc giao dịch thông minh.
4.  **Lập Ngân sách (Budgeting):**
    * Thiết lập hạn mức chi tiêu theo tháng/năm.
    * Cảnh báo khi chi tiêu vượt ngân sách.
    * Biểu đồ so sánh thực chi và kế hoạch.
5.  **Báo cáo & Thống kê:**
    * Dashboard tổng quan tình hình tài chính.
    * Biểu đồ tròn (Cơ cấu chi tiêu), Biểu đồ đường (Xu hướng), Biểu đồ cột (Thu/Chi).
    * Xuất báo cáo chi tiết ra file Excel.
6.  **UX/UI:**
    * Hiệu ứng chuyển cảnh (Fade In/Out).
    * Hiệu ứng rung lắc vui nhộn (Shake effect) trên Icon.
    * Thông báo thời gian thực (Real-time notifications).

### 🛡️ Dành cho Quản trị viên (Admin)
1.  **Dashboard hệ thống:**
    * Thống kê lượng người dùng truy cập.
    * Phân tích tần suất đăng nhập và thời gian sử dụng trung bình.
    * Biểu đồ mức độ quan tâm các chức năng.
2.  **Quản lý Người dùng:**
    * Xem danh sách người dùng.
    * Khóa/Kích hoạt hoặc Xóa tài khoản vi phạm.
3.  **Quản lý Thông báo:**
    * Soạn thảo và gửi thông báo hệ thống đến toàn bộ người dùng.
    * Quản lý lịch sử thông báo.

---

## 📸 Hình ảnh giao diện (Screenshots)

### 1. Dashboard & Báo cáo
<img width="1226" height="733" alt="{C80321FF-5397-4F0E-91EE-3F4E307737A3}" src="https://github.com/user-attachments/assets/a92c1713-f0da-42d9-80e7-1ae7a266d87b" />

*Giao diện tổng quan với biểu đồ trực quan*


### 2. Quản lý Giao dịch
<img width="1229" height="732" alt="{921C5D9C-6701-42DD-8A93-E44FBDDAA3A8}" src="https://github.com/user-attachments/assets/a8b5c99f-e122-4337-8ef3-3a9976891eac" />

*Danh sách giao dịch với bộ lọc tìm kiếm*


### 3. Lập Ngân sách
<img width="1226" height="730" alt="{4AA4A9A3-4796-4098-BA12-AF753354E0A7}" src="https://github.com/user-attachments/assets/91cefad2-2e81-4acc-8705-324bd2536fd5" />

*Theo dõi tiến độ chi tiêu so với hạn mức*


### 4. Giao diện Admin
<img width="1535" height="815" alt="{50CB9F72-10FE-43D1-8D17-EC2787C2CF31}" src="https://github.com/user-attachments/assets/af4cf00f-adea-4487-a56d-60ce73607b0d" />

*Thống kê hệ thống và quản lý người dùng*


---

## ⚙️ Cài đặt và Hướng dẫn sử dụng

### Yêu cầu hệ thống
* Windows 10/11
* .NET Framework / .NET Core Runtime
* SQL Server (LocalDB hoặc Server chính)

### Các bước cài đặt
1.  **Clone repository:**
    ```bash
    git clone [https://github.com/username/PiggyBank-Desktop-App.git](https://github.com/username/PiggyBank-Desktop-App.git)
    ```
2.  **Cấu hình Cơ sở dữ liệu:**
    * Mở SQL Server Management Studio (SSMS).
    * Chạy script `Database/PiggyBankDB.sql` để tạo CSDL và dữ liệu mẫu.
    * Cập nhật `ConnectionString` trong file `appsettings.json` hoặc `App.config` để trỏ đúng về SQL Server của bạn.
3.  **Chạy ứng dụng:**
    * Mở solution bằng Visual Studio.
    * Build và Run (F5).

---

## 📘 Tài liệu Hướng dẫn Sử dụng (User Guide)

Nhằm hỗ trợ người dùng và giảng viên dễ dàng tiếp cận và sử dụng ứng dụng **Piggy Bank**, nhóm đã xây dựng tài liệu **Hướng dẫn Sử dụng dành cho người dùng cuối**.

Tài liệu này tập trung mô tả:
- Ứng dụng **Piggy Bank** gồm những chức năng chính nào
- Mỗi màn hình/chức năng trong ứng dụng dùng để làm gì
- Các thao tác cơ bản khi sử dụng: nhấn nút nào, nhập thông tin ở đâu
- Hình ảnh minh họa trực quan cho từng chức năng chính

👉 **Xem tài liệu chi tiết tại:**  
[`HDSD.md`](HDSD.md)

---

## 📂 Cấu trúc dự án (Sơ lược)

```text
PiggyBank/
├── Data/                   # Lớp xử lý dữ liệu, DbContext, Entity Framework
├── Demo Layout/            # Prototype giao diện, demo bố cục màn hình
├── PhanQuyen/              # Xử lý phân quyền (User / Admin)
├── Piggy Admin/            # Phân hệ dành cho Quản trị viên
│
├── Demo Layout.sln         # File solution của Visual Studio
├── HDSD.md                 # Tài liệu Hướng dẫn Sử dụng cho người dùng cuối
├── QLTCCN.sql              # Script tạo Cơ sở dữ liệu và dữ liệu mẫu
├── README.md               # Tài liệu giới thiệu dự án
└── blank-default-pfp-*.png # Ảnh đại diện mặc định

---



