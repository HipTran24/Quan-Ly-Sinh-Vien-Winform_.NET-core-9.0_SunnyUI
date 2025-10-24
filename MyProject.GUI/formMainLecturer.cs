using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MyProject.BLL;
using MyProject.BLL.Auth;
using MyProject.DAL.Models;
using Sunny.UI;

namespace MyProject.GUI
{
    public partial class formMainLecturer : UIForm
    {
        private readonly NotifyBLL _notifySvc = new NotifyBLL();
        private FlowLayoutPanel _flp; 

        public formMainLecturer()
        {
            InitializeComponent();
            this.Load += formMainLecturer_Load;
            uiNavMenu.MenuItemClick -= uiNavMenu_MenuItemClick;
            uiNavMenu.MenuItemClick += uiNavMenu_MenuItemClick;

            pnlPost.Resize += (s, e) => ResizeCardsToPanelWidth();
        }

        private void formMainLecturer_Load(object? sender, EventArgs e)
        {
            EnsurePostsHost();      
            LoadHomePosts();
            RefreshUserBox();
        }
        
        private void RefreshUserBox()
        {
            if (AuthContextService.IsLoggedIn)
            {
                var gv = AuthContextService.CurrentUser?.lecturers;

                if (gv != null)
                {
                    lblUser.Text = $"User: {gv.MaGV}";
                    lblName.Text = gv.HoTen;

                    lblUser.Font = new Font("Segoe UI", 11, FontStyle.Bold );
                    lblName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                }
                else
                {

                    lblUser.Text = $"User: {AuthContextService.CurrentUser?.Username ?? "N/A"}";
                    lblName.Text = AuthContextService.CurrentUser?.Username ?? lblName.Text;
                }
            }
        }
        private void uiNavMenu_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {
            if (string.Equals(node.Text?.Trim(), "Trang chủ", StringComparison.OrdinalIgnoreCase))
            {

                SwitchToHome();
                return;
            }

            if (string.Equals(node.Text?.Trim(), "Lịch giảng dạy", StringComparison.OrdinalIgnoreCase))
            {
                ShowLecturerCalendar();
                return;
            }
            if (string.Equals(node.Text?.Trim(),"Cập nhật điểm", StringComparison.OrdinalIgnoreCase))
            {
                ShowScoreLecturer();
                return;
            }
            if (string.Equals(node.Text?.Trim(), "Thông tin phần mềm", StringComparison.OrdinalIgnoreCase))
            {
                ShowSoftwareInfo();     
                return;
            }
            if (string.Equals(node.Text?.Trim(), "Thay đổi thông tin", StringComparison.OrdinalIgnoreCase))
            {
                LoadMyProfile();  
                return;
            }
            if (string.Equals(node.Text?.Trim(), "Đăng xuất", StringComparison.OrdinalIgnoreCase))
            {
                LoadLogOut();
                return;
            }

        }
       
        private void LoadLogOut()
        {
            AuthContextService.SignOut();
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
        private void LoadMyProfile()
        {
            pnlPost.SuspendLayout();
            pnlPost.Controls.Clear();

            var uc = new ucChangeInfo();
            uc.Dock = DockStyle.Fill;
            pnlPost.Controls.Add(uc);

            pnlPost.ResumeLayout();
        }
        private void ShowSoftwareInfo()
        {
            using var fInfo = new formSoftWareInfo
            {
                StartPosition = FormStartPosition.CenterParent,
                ShowInTaskbar = false
            };
            fInfo.ShowDialog(this);
        }

        private void SwitchToHome()
        {
            EnsurePostsHost();      
            _flp.SuspendLayout();
            _flp.Controls.Clear();
            LoadHomePosts();
            _flp.ResumeLayout();
        }

        private void ShowLecturerCalendar()
        {
            pnlPost.SuspendLayout();
            pnlPost.Controls.Clear();

            var uc = new ucCalendar
            {
                Dock = DockStyle.Fill
            };
            uc.ReadOnlyMode = true;


            pnlPost.Controls.Add(uc);
            pnlPost.ResumeLayout();
        }

        private void EnsurePostsHost()
        {

            if (_flp == null || _flp.IsDisposed)
            {
                _flp = new FlowLayoutPanel
                {
                    Name = "flpPosts",
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false,
                    AutoScroll = true,
                    Padding = new Padding(12),
                    BackColor = Color.White
                };

                _flp.SizeChanged += (s, e) => ResizeCardsToPanelWidth();
                _flp.ControlAdded += (s, e) => BeginInvoke((Action)ResizeCardsToPanelWidth);
                _flp.ControlRemoved += (s, e) => BeginInvoke((Action)ResizeCardsToPanelWidth);
                pnlPost.SizeChanged += (s, e) => ResizeCardsToPanelWidth();
            }

            if (!pnlPost.Controls.Contains(_flp))
            {
                pnlPost.SuspendLayout();
                pnlPost.Controls.Clear();  
                pnlPost.Controls.Add(_flp);
                pnlPost.ResumeLayout();
            }
        }
        private void ShowScoreLecturer()
        {
            pnlPost.SuspendLayout();
            pnlPost.Controls.Clear();

            var uc = new ucScoreLecturer
            {
                Dock = DockStyle.Fill
            };

            pnlPost.Controls.Add(uc);
            pnlPost.ResumeLayout();
        }

        private void LoadHomePosts()
        {
            EnsurePostsHost();

            _flp.SuspendLayout();
            _flp.Controls.Clear();
            _flp.Controls.Add(new Label { Text = "Đang tải...", AutoSize = true, ForeColor = Color.Gray });
            try
            {
                var posts = _notifySvc.GetAllNotify()
                                      .OrderByDescending(n => n.CreatedAt)
                                      .ToList();
             _flp.Controls.Clear(); 


                if (posts.Count == 0)
                {
                    _flp.Controls.Add(new Label
                    {
                        AutoSize = false,
                        Dock = DockStyle.Top,
                        Height = 48,
                        Text = "Chưa có bài đăng nào.",
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.DimGray
                    });
                }
                else
                {
                    foreach (var p in posts)
                    {
                        try
                        {
                            var card = new ucItemPost(p, readOnly: true)
                            {
                                Margin = new Padding(20, 10, 12, 20),  
                                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                                MinimumSize = new Size(1000, 600)       
                            };
                            _flp.Controls.Add(card);

                            var roProp = card.GetType().GetProperty("ReadOnlyMode");
                            if (roProp != null)
                            {
                                roProp.SetValue(card, true, null);
                            }
                            else
                            {
                                foreach (Control ctl in card.Controls)
                                {
                                    if (ctl is UISymbolButton btn &&
                                        (string.Equals(btn.Text?.Trim(), "Xóa", StringComparison.OrdinalIgnoreCase) ||
                                         string.Equals(btn.Text?.Trim(), "Thay đổi", StringComparison.OrdinalIgnoreCase)))
                                    {
                                        btn.Visible = false;
                                    }
                                }
                            }

                            _flp.Controls.Add(card);
                        }
                        catch (Exception exCard)
                        {
                            _flp.Controls.Add(new Label
                            {
                                AutoSize = false,
                                Dock = DockStyle.Top,
                                Height = 38,
                                ForeColor = Color.Firebrick,
                                Text = $"Không thể hiển thị 1 bài đăng: {exCard.Message}"
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _flp.Controls.Add(new Label
                {
                    AutoSize = false,
                    Dock = DockStyle.Top,
                    Height = 60,
                    ForeColor = Color.Firebrick,
                    Text = $"Lỗi khi lấy dữ liệu bài đăng: {ex.Message}",
                    TextAlign = ContentAlignment.MiddleCenter
                });
            }

            ResizeCardsToPanelWidth();
            _flp.ResumeLayout(true);
            _flp.BringToFront();
        }

        private void ResizeCardsToPanelWidth()
        {
            if (_flp == null || _flp.IsDisposed) return;

            void ResizeOnce()
            {
                int padding = _flp.Padding.Horizontal;
                int scrollW = _flp.VerticalScroll.Visible ? SystemInformation.VerticalScrollBarWidth : 0;
                int usable = Math.Max(120, _flp.ClientSize.Width - padding - scrollW);

                foreach (Control c in _flp.Controls)
                {
                    int w = Math.Max(c.MinimumSize.Width, usable - c.Margin.Horizontal);
                    if (c.Width != w) c.Width = w;
                }
            }

            ResizeOnce();

            BeginInvoke((Action)ResizeOnce);
        }
    }
}
