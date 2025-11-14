using MyProject.BLL;
using MyProject.BLL.Auth;
using MyProject.DAL.Models;
using MyProject.GUI;
using MyProject.GUI.ViewModels;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class formMainStudent : UIForm
    {
        private readonly NotifyBLL _notifySvc = new NotifyBLL();
        private readonly CalendarBLL _calBll = new CalendarBLL();
        private readonly ScoreBLL _scoreBll = new ScoreBLL();
        private readonly SubjectsBLL _subjectBll = new SubjectsBLL();    
        private readonly LecturersBLL _lecturerBll = new LecturersBLL();

        private FlowLayoutPanel _flp;
        private ucCalendar ucCalendar1;               

        private DateOnly _monday = DateOnly.FromDateTime(DateTime.Today);
        private string _maSV = "";
        private const int CardTarget = 1000;   // bề rộng mong muốn của mỗi card
        private const int CardMin = 500;
        public formMainStudent()
        {
            InitializeComponent();
            uiNavMenu.MenuItemClick -= uiNavMenu_MenuItemClick;
            uiNavMenu.MenuItemClick += uiNavMenu_MenuItemClick;
            this.Load += formMainStudent_Load;
            pnlPost.Resize += (s, e) => ResizeCardsToPanelWidth();
        }

        private void formMainStudent_Load(object sender, EventArgs e)
        {
            EnsurePostsHost();
            RefreshUserBox();
            ucCalendar1 = new ucCalendar { Name = "ucCalendar1", Dock = DockStyle.Fill };

            _maSV = AuthContextService.CurrentUser?.students?.MaSV ?? "";
            _monday = ToMonday(DateOnly.FromDateTime(DateTime.Today));
            ShowHomePane();

            LoadHomePosts();
        }

        private void RefreshUserBox()
        {
            if (AuthContextService.IsLoggedIn)
            {
                var gv = AuthContextService.CurrentUser?.students;

                if (gv != null)
                {
                    lblUser.Text = $"User: {gv.MaSV}";
                    lblName.Text = gv.HoTen;


                    lblUser.Font = new Font("Segoe UI", 11, FontStyle.Bold);
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
            var txt = node.Text?.Trim();
            if (string.Equals(txt, "Trang chủ", StringComparison.OrdinalIgnoreCase))
            {
                ShowHomePane();
                return;
            }
            if (string.Equals(txt, "Thời khóa biểu", StringComparison.OrdinalIgnoreCase))
            {
                ShowCalendarPane();
                ReloadStudentCalendar();
                return;
            }
            if (string.Equals(txt, "Điểm", StringComparison.OrdinalIgnoreCase))
            {
                LoadMyScores();
                return;
            }
            if (string.Equals(txt, "Thông tin phần mềm", StringComparison.OrdinalIgnoreCase))
            {
                var f = new formSoftWareInfo();
                f.ShowDialog();
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
        private void LoadMyScores()
        {
            pnlPost.Controls.Clear();
            var uc = new ucStudentScore { Dock = DockStyle.Fill };
            pnlPost.Controls.Add(uc);
            uc.RefreshFor(_maSV); 
        }
        private void ShowHomePane()
        {
            EnsurePostsHost();
            pnlPost.Controls.Clear();
            pnlPost.Controls.Add(_flp);
            LoadHomePosts();
        }

        private void ShowCalendarPane()
        {
            pnlPost.Controls.Clear();
            pnlPost.Controls.Add(ucCalendar1);
        }

        private void ReloadStudentCalendar()
        {
            if (string.IsNullOrWhiteSpace(_maSV))
            {
                UIMessageBox.ShowError("Không xác định được mã sinh viên đang đăng nhập.");
                return;
            }

            var scores = _scoreBll.GetAllScore()
                                  ?.Where(x => string.Equals(x.MaSV, _maSV, StringComparison.OrdinalIgnoreCase))
                                  .ToList() ?? new List<Score>();

            var subjectOnly = scores
                .Select(s => s.MaMH)
                .Where(m => !string.IsNullOrWhiteSpace(m))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            var all = _calBll.GetAllCalendar() ?? new List<Calendars>();
            var studentAll = all.Where(c => subjectOnly.Contains(c.MaMH ?? ""))
                                .OrderBy(c => c.Ngay)
                                .ThenBy(c => PeriodStart(c.TietHoc))
                                .ToList();

            if (studentAll.Count == 0)
            {
                ucCalendar1.SetStudentData(new List<CalendarStudentVM>());
                return;
            }

            var sunday = _monday.AddDays(6);
            var filtered = studentAll.Where(c => c.Ngay >= _monday && c.Ngay <= sunday).ToList();
            if (filtered.Count == 0)
            {
                var firstDate = studentAll.Min(x => x.Ngay);
                _monday = ToMonday(firstDate);
                sunday = _monday.AddDays(6);
                filtered = studentAll.Where(c => c.Ngay >= _monday && c.Ngay <= sunday).ToList();
            }

            var subjects = _subjectBll.GetAllSubject();      
            var lecturers = _lecturerBll.GetAllLecturers();  

            string TenMHOf(string maMH) =>
                subjects.FirstOrDefault(x => string.Equals(x.MaMH, maMH, StringComparison.OrdinalIgnoreCase))?.TenMH ?? maMH;

            string TenGVOf(string maGV) =>
                lecturers.FirstOrDefault(x => string.Equals(x.MaGV, maGV, StringComparison.OrdinalIgnoreCase))?.HoTen ?? maGV;

            var vms = filtered.Select(c => new CalendarStudentVM
            {
                Ngay = c.Ngay,
                Thu = ThuVN(c.Ngay),
                TietHoc = c.TietHoc,
                MaMH = c.MaMH,
                TenMH = TenMHOf(c.MaMH),
                MaGV = c.MaGV,
                TenGV = TenGVOf(c.MaGV),
                PhongHoc = c.PhongHoc
            })
             .OrderBy(x => x.Ngay)
             .ThenBy(x => x.TietHoc)
             .ToList();

            ucCalendar1.SetStudentData(vms);
        }


        private static DateOnly ToMonday(DateOnly d)
        {
            int dow = (int)d.DayOfWeek;
            int delta = (dow == 0) ? -6 : (1 - dow);
            return d.AddDays(delta);
        }

        private static int PeriodStart(string tiet)
        {
            if (string.IsNullOrWhiteSpace(tiet)) return 99;
            var s = tiet.ToLower().Replace("tiết", "").Trim(); 
            var seg = s.Split('-', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (seg.Length > 0 && int.TryParse(seg[0], out var p1)) return p1;
            if (int.TryParse(s, out var p)) return p;
            return 99;
        }

        private void EnsurePostsHost()
        {
            if (_flp != null && !_flp.IsDisposed) return;

            pnlPost.SuspendLayout();
            pnlPost.Controls.Clear();

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

            pnlPost.Controls.Add(_flp);
            pnlPost.ResumeLayout();
        }

        private void LoadHomePosts()
        {
            EnsurePostsHost();

            _flp.SuspendLayout();
            _flp.Controls.Clear();

            try
            {
                var posts = _notifySvc.GetAllNotify()
                                      .OrderByDescending(n => n.CreatedAt)
                                      .ToList();

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

                            var roProp = card.GetType().GetProperty("ReadOnlyMode");
                            if (roProp != null) roProp.SetValue(card, true, null);
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

            // bề rộng hữu ích (trừ thanh cuộn dọc nếu có)
            int w = _flp.ClientSize.Width;
            if (_flp.VerticalScroll.Visible)
                w -= SystemInformation.VerticalScrollBarWidth;

            // tính bề rộng card & padding trái/phải để căn giữa
            int cardW = Math.Max(CardMin, Math.Min(CardTarget, w - 24)); // 24 = đệm tối thiểu hai bên
            int pad = Math.Max(0, (w - cardW) / 2);

            // căn giữa nguyên cột bằng Padding
            _flp.Padding = new Padding(pad, 12, pad, 12);

            // áp cho từng card
            foreach (Control c in _flp.Controls)
            {
                if (c is ucItemPost)
                {
                    c.Width = cardW;
                    c.Margin = new Padding(0, 12, 0, 12);
                    c.Anchor = AnchorStyles.Top;                 // chỉ Top, tránh trái/phải
                    c.MinimumSize = new Size(0, c.MinimumSize.Height); // KHÔNG khóa bề rộng tối thiểu
                }
            }
        }
        private static string ThuVN(DateOnly d) => d.DayOfWeek switch
        {
            DayOfWeek.Monday => "Thứ 2",
            DayOfWeek.Tuesday => "Thứ 3",
            DayOfWeek.Wednesday => "Thứ 4",
            DayOfWeek.Thursday => "Thứ 5",
            DayOfWeek.Friday => "Thứ 6",
            DayOfWeek.Saturday => "Thứ 7",
            DayOfWeek.Sunday => "CN",
            _ => ""
        };
    }
}
