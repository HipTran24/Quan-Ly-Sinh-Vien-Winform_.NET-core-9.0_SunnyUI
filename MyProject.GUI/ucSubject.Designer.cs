using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class ucSubject
    {
        private System.ComponentModel.IContainer components = null;
        private UIDataGridView SubjectDisplay;
        private UIPanel panelBottom;
        private UISymbolButton btnUpdate;
        private UISymbolButton btnDelete;
        private UISymbolButton btnChange;
        private UISymbolButton btnAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            SubjectDisplay = new UIDataGridView();
            ColMaMH = new DataGridViewTextBoxColumn();
            ColTenMH = new DataGridViewTextBoxColumn();
            ColSoTinChi = new DataGridViewTextBoxColumn();
            ColSoTiet = new DataGridViewTextBoxColumn();
            ColNgayBatDau = new DataGridViewTextBoxColumn();
            ColNgayKetThuc = new DataGridViewTextBoxColumn();
            ColMaKhoa = new DataGridViewTextBoxColumn();
            panelBottom = new UIPanel();
            btnUpdate = new UISymbolButton();
            btnDelete = new UISymbolButton();
            btnChange = new UISymbolButton();
            btnAdd = new UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)SubjectDisplay).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // SubjectDisplay
            // 
            SubjectDisplay.AllowUserToAddRows = false;
            SubjectDisplay.AllowUserToDeleteRows = false;
            SubjectDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            SubjectDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            SubjectDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubjectDisplay.BackgroundColor = Color.White;
            SubjectDisplay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SubjectDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SubjectDisplay.ColumnHeadersHeight = 34;
            SubjectDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaMH, ColTenMH, ColSoTinChi, ColSoTiet, ColNgayBatDau, ColNgayKetThuc, ColMaKhoa });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SubjectDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            SubjectDisplay.Dock = DockStyle.Fill;
            SubjectDisplay.EnableHeadersVisualStyles = false;
            SubjectDisplay.Font = new Font("Microsoft Sans Serif", 12F);
            SubjectDisplay.GridColor = Color.FromArgb(204, 204, 204);
            SubjectDisplay.Location = new Point(0, 0);
            SubjectDisplay.Name = "SubjectDisplay";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            SubjectDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            SubjectDisplay.RowHeadersVisible = false;
            SubjectDisplay.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            SubjectDisplay.RowsDefaultCellStyle = dataGridViewCellStyle5;
            SubjectDisplay.SelectedIndex = -1;
            SubjectDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubjectDisplay.Size = new Size(1099, 565);
            SubjectDisplay.StripeOddColor = Color.White;
            SubjectDisplay.TabIndex = 1;
            // 
            // ColMaMH
            // 
            ColMaMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColMaMH.DataPropertyName = "MaMH";
            ColMaMH.HeaderText = "Mã môn học";
            ColMaMH.MinimumWidth = 140;
            ColMaMH.Name = "ColMaMH";
            ColMaMH.Width = 160;
            // 
            // ColTenMH
            // 
            ColTenMH.DataPropertyName = "TenMH";
            ColTenMH.HeaderText = "Tên môn học";
            ColTenMH.MinimumWidth = 160;
            ColTenMH.Name = "ColTenMH";
            // 
            // ColSoTinChi
            // 
            ColSoTinChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColSoTinChi.DataPropertyName = "SoTinChi";
            ColSoTinChi.HeaderText = "Số tín chỉ";
            ColSoTinChi.MinimumWidth = 100;
            ColSoTinChi.Name = "ColSoTinChi";
            ColSoTinChi.Width = 120;
            // 
            // ColSoTiet
            // 
            ColSoTiet.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColSoTiet.DataPropertyName = "SoTiet";
            ColSoTiet.HeaderText = "Số tiết";
            ColSoTiet.MinimumWidth = 100;
            ColSoTiet.Name = "ColSoTiet";
            ColSoTiet.Width = 120;
            // 
            // ColNgayBatDau
            // 
            ColNgayBatDau.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColNgayBatDau.DataPropertyName = "NgayBatDau";
            ColNgayBatDau.HeaderText = "Ngày bắt đầu";
            ColNgayBatDau.MinimumWidth = 140;
            ColNgayBatDau.Name = "ColNgayBatDau";
            ColNgayBatDau.Width = 160;
            // 
            // ColNgayKetThuc
            // 
            ColNgayKetThuc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColNgayKetThuc.DataPropertyName = "NgayKetThuc";
            ColNgayKetThuc.HeaderText = "Ngày kết thúc";
            ColNgayKetThuc.MinimumWidth = 140;
            ColNgayKetThuc.Name = "ColNgayKetThuc";
            ColNgayKetThuc.Width = 160;
            // 
            // ColMaKhoa
            // 
            ColMaKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColMaKhoa.DataPropertyName = "MaKhoa";
            ColMaKhoa.HeaderText = "Mã khoa";
            ColMaKhoa.MinimumWidth = 120;
            ColMaKhoa.Name = "ColMaKhoa";
            ColMaKhoa.Width = 140;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnUpdate);
            panelBottom.Controls.Add(btnDelete);
            panelBottom.Controls.Add(btnChange);
            panelBottom.Controls.Add(btnAdd);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.FillColor = Color.White;
            panelBottom.Font = new Font("Microsoft Sans Serif", 12F);
            panelBottom.Location = new Point(0, 565);
            panelBottom.Margin = new Padding(4, 5, 4, 5);
            panelBottom.MinimumSize = new Size(1, 1);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8, 6, 8, 6);
            panelBottom.Size = new Size(1099, 48);
            panelBottom.Style = UIStyle.Custom;
            panelBottom.TabIndex = 2;
            panelBottom.Text = null;
            panelBottom.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F);
            btnUpdate.Location = new Point(630, 6);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 32);
            btnUpdate.Symbol = 61473;
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Location = new Point(746, 6);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 32);
            btnDelete.Symbol = 61944;
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChange.Font = new Font("Microsoft Sans Serif", 12F);
            btnChange.Location = new Point(862, 6);
            btnChange.MinimumSize = new Size(1, 1);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(110, 32);
            btnChange.Symbol = 61459;
            btnChange.TabIndex = 2;
            btnChange.Text = "Thay đổi";
            btnChange.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnChange.Click += btnChange_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdd.Location = new Point(978, 6);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 32);
            btnAdd.Symbol = 61543;
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdd.Click += btnAdd_Click;
            // 
            // ucSubject
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(SubjectDisplay);
            Controls.Add(panelBottom);
            Name = "ucSubject";
            Size = new Size(1099, 613);
            Load += ucSubject_Load;
            ((System.ComponentModel.ISupportInitialize)SubjectDisplay).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn ColMaMH;
        private DataGridViewTextBoxColumn ColTenMH;
        private DataGridViewTextBoxColumn ColSoTinChi;
        private DataGridViewTextBoxColumn ColSoTiet;
        private DataGridViewTextBoxColumn ColNgayBatDau;
        private DataGridViewTextBoxColumn ColNgayKetThuc;
        private DataGridViewTextBoxColumn ColMaKhoa;
    }
}
