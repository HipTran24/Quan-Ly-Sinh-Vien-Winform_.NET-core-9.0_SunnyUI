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
        private Label? _lblStatus; // label “ghi trạng thái” đặt dưới ảnh

        // Sửa nullable + xoá trùng khai báo
        public event EventHandler? DaSuaThanhCong;          // để báo ucUpdateInfo reload
        public event EventHandler<Notify>? XoaClicked;
        private bool _isReflowing = false;

        public ucItemPost()
        {
            InitializeComponent();
            // Khi control đã tạo handle, áp lại các state để không vỡ Designer
            this.HandleCreated += (s, e) =>
            {
                ApplyReadOnlyMode();
                RenderStatusBelowImage();
            };
            this.Resize += (s, e) =>
            {
                if (_isReflowing) return;   // tránh gọi lại khi chính Reflow đang chạy
                Reflow();
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

        private void ApplyReadOnlyMode()
        {
            // Phòng null khi Designer gọi sớm
            if (btnSua == null || btnXoa == null) return;

            btnSua.Visible = !_readOnlyMode;
            btnXoa.Visible = !_readOnlyMode;
            AdjustLayoutForReadOnly();
        }

        private void LoadData()
        {
            if (_baiViet == null) return;

            // Người đăng & tiêu đề
            lblNguoiDang.Text = $"Đăng bởi {_baiViet.Username} • {_baiViet.CreatedAt:dd/MM/yyyy HH:mm}";
            lblTieuDe.Text = _baiViet.TieuDe ?? "";
            SetupTitleStyle();

            // Ảnh (cố định chiều cao để layout không nhảy)
            picAnh.Image = null;
            if (!string.IsNullOrEmpty(_baiViet.AnhURL))
            {
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _baiViet.AnhURL);
                if (System.IO.File.Exists(path))
                {
                    picAnh.Image = Image.FromFile(path);
                }
            }
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.Height = 180;              

            // Status + Nội dung
            RenderStatusBelowImage();           // KHÔNG Dock
            lbNoiDung.Text = _baiViet.NoiDung ?? "";
            lbNoiDung.ForeColor = Color.Black;
            lbNoiDung.Font = new Font(lbNoiDung.Font, FontStyle.Regular);
            lbNoiDung.AutoSize = false;
            lbNoiDung.TextAlign = ContentAlignment.TopLeft;

            // Sắp xếp tất cả
            Reflow();
        }


        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (_baiViet == null) return;
            using var form = new formInfoUpdate(_baiViet); // truyền bài viết cũ vào
            if (form.ShowDialog() == DialogResult.OK)
            {
                DaSuaThanhCong?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (_baiViet == null) return;
            XoaClicked?.Invoke(this, _baiViet);
        }

        private void RenderStatusBelowImage()
        {
            EnsureStatusLabelCreated();

            // Lấy status từ model
            string statusText = GetStatusTextFromModel(_baiViet);

            _lblStatus!.Text = statusText?.Trim();
            _lblStatus.Visible = !string.IsNullOrWhiteSpace(_lblStatus.Text);

            if (_lblStatus.Parent != this) this.Controls.Add(_lblStatus);

            // Style (không Dock)
            _lblStatus.AutoSize = false;
            _lblStatus.Dock = DockStyle.None;
            _lblStatus.Font = new Font(Font, FontStyle.Regular);
            _lblStatus.ForeColor = Color.Black;
            _lblStatus.BackColor = Color.Transparent;
            _lblStatus.TextAlign = ContentAlignment.TopLeft;
            _lblStatus.Padding = new Padding(0);

            // Vị trí/size tạm – Reflow sẽ sắp xếp lại cuối cùng
            int pad = 24;
            int contentW = this.ClientSize.Width - pad * 2;
            _lblStatus.Left = pad + 4;
            _lblStatus.Width = contentW - 8;
            _lblStatus.Top = (picAnh?.Bottom ?? 0) + 8;
            _lblStatus.Height = _lblStatus.Visible
                ? MeasureTextHeight(_lblStatus.Text, _lblStatus.Font, _lblStatus.Width)
                : 0;

            Reflow();  // cập nhật layout sau khi đổi Visible/Height
        }

        private static int MeasureTextHeight(string text, Font font, int width)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            var sz = TextRenderer.MeasureText(text, font,
                new Size(width, int.MaxValue),
                TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl | TextFormatFlags.NoPadding);
            return sz.Height;
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
                int padX = 24;
                int y = lblNguoiDang.Bottom + 6;
                int contentW = this.ClientSize.Width - padX * 2;


                int bottom;
                if (_readOnlyMode)
                {
                    if (btnSua != null) btnSua.Visible = false;
                    if (btnXoa != null) btnXoa.Visible = false;
                    bottom = Math.Max(lbNoiDung.Bottom, (_lblStatus?.Bottom ?? 0));
                }
                else
                {
                    bottom = Math.Max(btnSua?.Bottom ?? y, btnXoa?.Bottom ?? y);
                }

                int newHeight = bottom + 16;
                int target = Math.Max(newHeight, this.MinimumSize.Height);
                if (this.Height != target) this.Height = target;
            }
            finally
            {
                _isReflowing = false;
            }
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
                Font = new Font(Font, FontStyle.Regular), // ✅ chữ bình thường
                ForeColor = Color.Black,                  // chữ màu đen
                BackColor = Color.FromArgb(245, 245, 245),
                TextAlign = ContentAlignment.MiddleLeft,
                Visible = false
            };

            this.Controls.Add(_lblStatus);
            // đảm bảo nó nằm ngay dưới ảnh khi Dock.Top
            this.Controls.SetChildIndex(_lblStatus, 0);
        }

        private static string GetStatusTextFromModel(Notify? n)
        {
            if (n == null) return "";

            string[] candidates =
            {
             "NoiDung"
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

        // =================== LAYOUT ===================

        private void AdjustLayoutForReadOnly()
        {
            int bottomPadding = 16;
            int bottom = 0;

            foreach (Control c in this.Controls)
                bottom = Math.Max(bottom, c.Bottom);

            this.Height = bottom + bottomPadding;
        }
    }
}
