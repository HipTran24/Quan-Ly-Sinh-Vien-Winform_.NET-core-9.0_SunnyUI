using MyProject.BLL;
using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class ucUpdateInfo : UserControl
    {
        private readonly NotifyBLL notifyBLL = new NotifyBLL();
        private List<Notify> danhSachBaiViet = new List<Notify>();
        private const int CardWidth = 760;

        public ucUpdateInfo()
        {
            InitializeComponent();
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.WrapContents = false;
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.AutoSize = false;
            flowPanel.Padding = new Padding(12);

            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, flowPanel, new object[] { true });

            flowPanel.SizeChanged += (s, e) => UpdateCenter();
        }
        private void UpdateCenter()
        {

            int w = flowPanel.ClientSize.Width;
            if (flowPanel.VerticalScroll.Visible)
                w -= SystemInformation.VerticalScrollBarWidth;

            int itemW = Math.Min(CardWidth, Math.Max(380, w - 24));
            int pad = Math.Max(0, (w - itemW) / 2);


            flowPanel.Padding = new Padding(pad, 12, pad, 12);


            foreach (Control c in flowPanel.Controls)
            {
                if (c is ucItemPost)
                {
                    c.Width = itemW;
                    c.Margin = new Padding(0, 12, 0, 12);
                    c.Anchor = AnchorStyles.Top;
                }
            }
        }


        private void LoadDanhSach()
        {
            flowPanel.Controls.Clear();
            danhSachBaiViet = notifyBLL.GetAllNotify();


            foreach (var bv in danhSachBaiViet)
            {
                var item = new ucItemPost(bv);
                item.XoaClicked += Item_XoaClicked;
                item.DaSuaThanhCong += (s, e) => LoadDanhSach();

                item.Anchor = AnchorStyles.Top;          // chỉ Top
                item.Margin = new Padding(0, 12, 0, 12); // khoảng cách dọc
                item.Width = Math.Min(CardWidth, flowPanel.ClientSize.Width - 24);

                flowPanel.Controls.Add(item);
            }
            UpdateCenter();

            flowPanel.Resize -= FlowPanel_Resize; // tránh đăng ký trùng
            flowPanel.Resize += FlowPanel_Resize;
        }


        private void FlowPanel_Resize(object sender, EventArgs e)
        {
            UpdateCenter();
        }

        private void Item_XoaClicked(object sender, Notify bv)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa bài viết này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                notifyBLL.Delete(bv.MaTB);
                LoadDanhSach();
                MessageBox.Show("Đã xóa bài viết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ucUpdateInfo_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }


        private void btnUp_Click_1(object sender, EventArgs e)
        {
            formInfoUpdate form = new formInfoUpdate();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSach();
                MessageBox.Show("Đăng bài viết thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
