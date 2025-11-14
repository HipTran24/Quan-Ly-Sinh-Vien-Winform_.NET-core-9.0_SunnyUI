using MyProject.BLL;
using MyProject.DAL.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class ucItemPost : UserControl
    {
        private Notify _baiViet;
        private bool _readOnlyMode;
        private Label? _lblStatus;
        private bool _isReflowing = false;

        public event EventHandler? DaSuaThanhCong;
        public event EventHandler<Notify>? XoaClicked;

        private const int PadX = 28;            
        private const int GapY = 10;          
        private const int CardMaxWidth = 960;
        private const int CardMinWidth = 420;

        public ucItemPost()
        {
            InitializeComponent();

            this.HandleCreated += (s, e) =>
            {
                EnsureButtonPanel();            // đảm bảo có panel nút
                ApplyReadOnlyMode();
                RenderStatusBelowImage();
                Reflow();
                CenterSelfInParent();
            };

            this.Resize += (s, e) =>
            {
                if (_isReflowing) return;
                Reflow();
                CenterSelfInParent();
            };

            this.ParentChanged += (s, e) =>
            {
                HookParentResize(false);
                HookParentResize(true);
                CenterSelfInParent();
            };
        }

        public ucItemPost(Notify bv, bool readOnly = false) : this()
        {
            _baiViet = bv;
            LoadData();
            ReadOnlyMode = readOnly;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ReadOnlyMode
        {
            get => _readOnlyMode;
            set { _readOnlyMode = value; ApplyReadOnlyMode(); }
        }

        private void HookParentResize(bool attach)
        {
            if (Parent == null) return;
            if (attach) Parent.Resize += Parent_Resize;
            else Parent.Resize -= Parent_Resize;
        }

        private void Parent_Resize(object? sender, EventArgs e) => CenterSelfInParent();

        private void ApplyReadOnlyMode()
        {
            if (btnSua == null || btnXoa == null) return;
            btnSua.Visible = !_readOnlyMode;
            btnXoa.Visible = !_readOnlyMode;
            AdjustLayoutForReadOnly();
        }

        private void LoadData()
        {
            if (_baiViet == null) return;

            lblNguoiDang.Text = $"Đăng bởi {_baiViet.Username} • {_baiViet.CreatedAt:dd/MM/yyyy HH:mm}";
            lblTieuDe.Text = _baiViet.TieuDe ?? "";
            SetupTitleStyle();

            // Ảnh
            picAnh.Image = null;
            if (!string.IsNullOrEmpty(_baiViet.AnhURL))
            {
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _baiViet.AnhURL);
                if (System.IO.File.Exists(path))
                    picAnh.Image = Image.FromFile(path);
            }
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.Height = 320;

            // Status + Nội dung
            RenderStatusBelowImage();

            lbNoiDung.Text = _baiViet.NoiDung ?? "";
            lbNoiDung.ForeColor = Color.Black;
            lbNoiDung.Font = new Font(lbNoiDung.Font, FontStyle.Regular);
            lbNoiDung.AutoSize = false;
            lbNoiDung.TextAlign = ContentAlignment.TopLeft;

            EnsureButtonPanel(); // chắc chắn 2 nút nằm trong _btnBar

            Reflow();
            CenterSelfInParent();
        }


        private void EnsureButtonPanel()
        {
            if (_btnBar == null)
            {
                _btnBar = new Panel
                {
                    AutoSize = false,
                    BackColor = Color.Transparent
                };
                this.Controls.Add(_btnBar);
                _btnBar.BringToFront();
            }

            // chuyển 2 nút vào _btnBar (nếu Designer chưa đặt)
            if (btnSua != null && btnSua.Parent != _btnBar)
            {
                btnSua.Parent = _btnBar;
                btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            }
            if (btnXoa != null && btnXoa.Parent != _btnBar)
            {
                btnXoa.Parent = _btnBar;
                btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            }
        }

        private void RenderStatusBelowImage()
        {
            EnsureStatusLabelCreated();

            string statusText = GetStatusTextFromModel(_baiViet);

            var noiDungText = _baiViet?.NoiDung?.Trim() ?? "";
            if (!string.IsNullOrWhiteSpace(statusText) &&
                string.Equals(statusText.Trim(), noiDungText, StringComparison.Ordinal))
            {
                statusText = "";
            }

            _lblStatus!.Text = statusText;
            _lblStatus.Visible = !string.IsNullOrWhiteSpace(statusText);

            if (_lblStatus.Parent != this) this.Controls.Add(_lblStatus);

            _lblStatus.AutoSize = false;
            _lblStatus.Dock = DockStyle.None;
            _lblStatus.Font = new Font(Font, FontStyle.Regular);
            _lblStatus.ForeColor = Color.Black;
            _lblStatus.BackColor = Color.FromArgb(245, 245, 245);
            _lblStatus.TextAlign = ContentAlignment.TopLeft;
            _lblStatus.Padding = new Padding(6, 4, 6, 4);

            Reflow();
        }

        private void SetupTitleStyle()
        {
            lblTieuDe.AutoSize = false;
            lblTieuDe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Font = new Font(lblTieuDe.Font, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Black;
        }

        private void Reflow()
        {
            if (_isReflowing) return;
            _isReflowing = true;
            try
            {
                // ---- Tính cột nội dung ---
                int contentW = Math.Max(this.ClientSize.Width - 2 * PadX, 240);
                int x = (this.ClientSize.Width - contentW) / 2;
                int y = PadX;

                // Người đăng
                lblNguoiDang.Left = x;
                lblNguoiDang.Top = y;
                lblNguoiDang.Width = contentW;
                y = lblNguoiDang.Bottom + GapY;

                // Tiêu đề
                lblTieuDe.Left = x;
                lblTieuDe.Top = y;
                lblTieuDe.Width = contentW;
                y = lblTieuDe.Bottom + GapY;

                // Ảnh
                picAnh.Left = x;
                picAnh.Top = y;
                picAnh.Width = contentW;
                y = picAnh.Bottom + GapY;

                // Status (nếu có)
                if (_lblStatus != null)
                {
                    _lblStatus.Left = x + 4;
                    _lblStatus.Width = contentW - 8;
                    _lblStatus.Top = y;
                    _lblStatus.Height = _lblStatus.Visible
                        ? MeasureTextHeight(_lblStatus.Text, _lblStatus.Font, _lblStatus.Width)
                        : 0;

                    y = _lblStatus.Bottom + (_lblStatus.Visible ? GapY : 0);
                }

                lbNoiDung.Left = x;
                lbNoiDung.Top = y;

                lbNoiDung.AutoSize = false;
                lbNoiDung.MaximumSize = Size.Empty;               // bỏ giới hạn cũ (0,0 = không giới hạn)
                lbNoiDung.MinimumSize = new Size(contentW, 0);    // đảm bảo tối thiểu = full ngang
                lbNoiDung.Width = contentW;
                lbNoiDung.Padding = new Padding(0);               // (tuỳ) xoá padding nội bộ nếu có

                lbNoiDung.Height = MeasureTextHeight(lbNoiDung.Text ?? "", lbNoiDung.Font, lbNoiDung.Width);
                y = lbNoiDung.Bottom + GapY;

                // ===== Nút thao tác (Panel _btnBar là 1 dòng riêng) =====
                if (!_readOnlyMode && (btnSua != null || btnXoa != null) && _btnBar != null)
                {
                    _btnBar.Left = x;
                    _btnBar.Top = y;
                    _btnBar.Width = contentW;

                    int btnGap = 8;
                    int right = _btnBar.Width;

                    if (btnXoa != null)
                    {
                        btnXoa.Top = 0;
                        btnXoa.Left = right - btnXoa.Width;
                        right -= btnXoa.Width + btnGap;
                    }

                    if (btnSua != null)
                    {
                        btnSua.Top = 0;
                        btnSua.Left = right - btnSua.Width;
                    }

                    _btnBar.Height = Math.Max(btnSua?.Height ?? 0, btnXoa?.Height ?? 0);
                    y = _btnBar.Bottom + PadX;
                }
                else
                {
                    y += PadX;
                }

                // Chiều cao card
                int target = Math.Max(y, this.MinimumSize.Height);
                if (this.Height != target) this.Height = target;
            }
            finally
            {
                _isReflowing = false;
            }
        }

        private void CenterSelfInParent()
        {
            if (Parent == null) return;

            // Nếu nằm trong FlowLayoutPanel: KHÔNG căn giữa lần nữa.
            // Để ucUpdateInfo.UpdateCenter() xử lý bằng Padding của flowPanel.
            if (Parent is FlowLayoutPanel)
            {
                // Giữ khoảng cách dọc, bỏ căn lề ngang
                this.Margin = new Padding(0, this.Margin.Top, 0, this.Margin.Bottom);
                return;
            }

            // Ngoài ra (không phải FlowLayoutPanel), giữ logic cũ để tự căn giữa
            int maxAvail = Math.Max(Parent.ClientSize.Width - 2 * PadX, CardMinWidth);
            int w = Math.Clamp(maxAvail, CardMinWidth, CardMaxWidth);
            this.Width = w;
            this.Left = Math.Max((Parent.ClientSize.Width - this.Width) / 2, PadX);
        }

        private void EnsureStatusLabelCreated()
        {
            if (_lblStatus != null) return;

            _lblStatus = new Label
            {
                AutoSize = false,
                Height = 24,
                Margin = new Padding(8, 6, 8, 6),
                Padding = new Padding(6, 4, 6, 4),
                Font = new Font(Font, FontStyle.Regular),
                ForeColor = Color.Black,
                BackColor = Color.FromArgb(245, 245, 245),
                TextAlign = ContentAlignment.MiddleLeft,
                Visible = false
            };

            this.Controls.Add(_lblStatus);
            this.Controls.SetChildIndex(_lblStatus, 0);
        }

        // ===== Lấy text trạng thái từ model (KHÔNG dùng NoiDung) =====
        private static string GetStatusTextFromModel(Notify? n)
        {
            if (n == null) return "";

            string[] candidates =
            {
                "TrangThai", "Status", "TinhTrang", "TrangThaiDuyet", "ApproveStatus", "State"
            };

            foreach (var name in candidates)
            {
                var prop = n.GetType().GetProperty(name,
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (prop == null) continue;

                var val = prop.GetValue(n);
                if (val == null) continue;

                if (val is int i) return MapStatusCode(i);
                if (val is Enum) return val.ToString() ?? "";

                var s = val.ToString() ?? "";
                if (!string.IsNullOrWhiteSpace(s)) return s;
            }

            return "";
        }

        private static string MapStatusCode(int code) => code switch
        {
            0 => "Nháp",
            1 => "Chờ duyệt",
            2 => "Đã duyệt",
            3 => "Đã ẩn",
            _ => $"Mã {code}"
        };

        private static int MeasureTextHeight(string text, Font font, int width)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            var sz = TextRenderer.MeasureText(text, font,
                new Size(width, int.MaxValue),
                TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl | TextFormatFlags.NoPadding);
            return sz.Height;
        }

        private void AdjustLayoutForReadOnly()
        {
            int bottomPadding = 16;
            int bottom = 0;
            foreach (Control c in this.Controls)
                bottom = Math.Max(bottom, c.Bottom);
            this.Height = bottom + bottomPadding;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_baiViet == null) return;
            using var form = new formInfoUpdate(_baiViet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DaSuaThanhCong?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_baiViet == null) return;
            XoaClicked?.Invoke(this, _baiViet);
        }
    }
}
