using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class ucItemPost
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTieuDe;
        private Label lblNguoiDang;
        private PictureBox picAnh;
        private Label lbNoiDung;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblNguoiDang = new Label();
            picAnh = new PictureBox();
            lbNoiDung = new Label();
            _btnBar = new Panel();
            btnXoa = new UISymbolButton();
            btnSua = new UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            _btnBar.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(40, 40, 40);
            lblTieuDe.Location = new Point(16, 34);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(488, 32);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "Tiêu đề bài đăng";
            lblTieuDe.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNguoiDang
            // 
            lblNguoiDang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNguoiDang.ForeColor = Color.FromArgb(90, 90, 90);
            lblNguoiDang.Location = new Point(16, 10);
            lblNguoiDang.Name = "lblNguoiDang";
            lblNguoiDang.Size = new Size(380, 22);
            lblNguoiDang.TabIndex = 0;
            lblNguoiDang.Text = "Người đăng";
            // 
            // picAnh
            // 
            picAnh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picAnh.BackColor = Color.FromArgb(248, 248, 248);
            picAnh.Location = new Point(16, 70);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(906, 241);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 2;
            picAnh.TabStop = false;
            // 
            // lbNoiDung
            // 
            lbNoiDung.Font = new Font("Segoe UI", 10F);
            lbNoiDung.ForeColor = Color.FromArgb(55, 55, 55);
            lbNoiDung.Location = new Point(16, 260);
            lbNoiDung.MaximumSize = new Size(488, 0);
            lbNoiDung.Name = "lbNoiDung";
            lbNoiDung.Size = new Size(488, 0);
            lbNoiDung.TabIndex = 3;
            lbNoiDung.Text = "Nội dung bài đăng...";
            // 
            // _btnBar
            // 
            _btnBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            _btnBar.Controls.Add(btnXoa);
            _btnBar.Controls.Add(btnSua);
            _btnBar.Location = new Point(16, 479);
            _btnBar.Name = "_btnBar";
            _btnBar.Size = new Size(906, 41);
            _btnBar.TabIndex = 6;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.FillColor = Color.FromArgb(255, 87, 87);
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(677, 4);
            btnXoa.MinimumSize = new Size(1, 1);
            btnXoa.Name = "btnXoa";
            btnXoa.Radius = 20;
            btnXoa.RectColor = Color.FromArgb(255, 87, 87);
            btnXoa.Size = new Size(110, 34);
            btnXoa.Symbol = 62164;
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Location = new Point(793, 4);
            btnSua.MinimumSize = new Size(1, 1);
            btnSua.Name = "btnSua";
            btnSua.Radius = 20;
            btnSua.Size = new Size(110, 34);
            btnSua.Symbol = 61459;
            btnSua.TabIndex = 7;
            btnSua.Text = "Thay đổi";
            btnSua.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSua.Click += btnSua_Click;
            // 
            // ucItemPost
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(_btnBar);
            Controls.Add(lblNguoiDang);
            Controls.Add(lblTieuDe);
            Controls.Add(picAnh);
            Controls.Add(lbNoiDung);
            Margin = new Padding(12);
            Name = "ucItemPost";
            Padding = new Padding(16);
            Size = new Size(938, 536);
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            _btnBar.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Panel _btnBar;
        private UISymbolButton btnXoa;
        private UISymbolButton btnSua;
    }
}
