using Krypton.Toolkit;

namespace Demo_Layout
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Lấy kích thước của màn hình làm việc (Working Area) hiện tại.
            // Working Area là kích thước màn hình trừ đi Taskbar và các dock bar khác.
            System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Đặt thuộc tính MaximumSize của Form bằng với kích thước màn hình làm việc.
            this.MaximumSize = workingArea.Size;

            // Nếu bạn muốn bao gồm cả Taskbar (kích thước đầy đủ của màn hình),
            // bạn có thể dùng thuộc tính Bounds thay thế:
            // this.MaximumSize = Screen.PrimaryScreen.Bounds.Size;
        }
    }
}
