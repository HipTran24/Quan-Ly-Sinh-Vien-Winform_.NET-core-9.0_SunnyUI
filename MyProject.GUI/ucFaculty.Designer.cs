using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class ucFaculty
    {
        private System.ComponentModel.IContainer components = null;
        private UIDataGridView FacultyDisplay;
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            FacultyDisplay = new UIDataGridView();
            ColMaKhoa = new DataGridViewTextBoxColumn();
            ColTenKhoa = new DataGridViewTextBoxColumn();
            ColTruongKhoa = new DataGridViewTextBoxColumn();
            ColPhongCongTac = new DataGridViewTextBoxColumn();
            ColSoLuongLop = new DataGridViewTextBoxColumn();
            ColEmailKhoa = new DataGridViewTextBoxColumn();
            panelBottom = new UIPanel();
            btnUpdate = new UISymbolButton();
            btnDelete = new UISymbolButton();
            btnChange = new UISymbolButton();
            btnAdd = new UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)FacultyDisplay).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // FacultyDisplay
            // 
            FacultyDisplay.AllowUserToAddRows = false;
            FacultyDisplay.AllowUserToDeleteRows = false;
            FacultyDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            FacultyDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            FacultyDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FacultyDisplay.BackgroundColor = Color.White;
            FacultyDisplay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            FacultyDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            FacultyDisplay.ColumnHeadersHeight = 34;
            FacultyDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaKhoa, ColTenKhoa, ColTruongKhoa, ColPhongCongTac, ColSoLuongLop, ColEmailKhoa });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            FacultyDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            FacultyDisplay.Dock = DockStyle.Fill;
            FacultyDisplay.EnableHeadersVisualStyles = false;
            FacultyDisplay.Font = new Font("Microsoft Sans Serif", 12F);
            FacultyDisplay.GridColor = Color.FromArgb(204, 204, 204);
            FacultyDisplay.Location = new Point(0, 0);
            FacultyDisplay.Name = "FacultyDisplay";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            FacultyDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            FacultyDisplay.RowHeadersVisible = false;
            FacultyDisplay.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            FacultyDisplay.RowsDefaultCellStyle = dataGridViewCellStyle5;
            FacultyDisplay.SelectedIndex = -1;
            FacultyDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FacultyDisplay.Size = new Size(1127, 679);
            FacultyDisplay.StripeOddColor = Color.White;
            FacultyDisplay.TabIndex = 0;
            // 
            // ColMaKhoa
            // 
            ColMaKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColMaKhoa.DataPropertyName = "MaKhoa";
            ColMaKhoa.HeaderText = "Mã khoa";
            ColMaKhoa.MinimumWidth = 100;
            ColMaKhoa.Name = "ColMaKhoa";
            ColMaKhoa.Width = 120;
            // 
            // ColTenKhoa
            // 
            ColTenKhoa.DataPropertyName = "TenKhoa";
            ColTenKhoa.HeaderText = "Tên khoa";
            ColTenKhoa.MinimumWidth = 140;
            ColTenKhoa.Name = "ColTenKhoa";
            // 
            // ColTruongKhoa
            // 
            ColTruongKhoa.DataPropertyName = "TruongKhoa";
            ColTruongKhoa.HeaderText = "Trưởng Khoa";
            ColTruongKhoa.MinimumWidth = 160;
            ColTruongKhoa.Name = "ColTruongKhoa";
            // 
            // ColPhongCongTac
            // 
            ColPhongCongTac.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColPhongCongTac.DataPropertyName = "PhongCongTac";
            ColPhongCongTac.HeaderText = "Phòng công tác";
            ColPhongCongTac.MinimumWidth = 160;
            ColPhongCongTac.Name = "ColPhongCongTac";
            ColPhongCongTac.Width = 180;
            // 
            // ColSoLuongLop
            // 
            ColSoLuongLop.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColSoLuongLop.DataPropertyName = "SoLuongLop";
            ColSoLuongLop.HeaderText = "Số lượng lớp";
            ColSoLuongLop.MinimumWidth = 100;
            ColSoLuongLop.Name = "ColSoLuongLop";
            ColSoLuongLop.Width = 125;
            // 
            // ColEmailKhoa
            // 
            ColEmailKhoa.DataPropertyName = "EmailKhoa";
            ColEmailKhoa.HeaderText = "Email";
            ColEmailKhoa.MinimumWidth = 180;
            ColEmailKhoa.Name = "ColEmailKhoa";
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
            panelBottom.Location = new Point(0, 679);
            panelBottom.Margin = new Padding(4, 5, 4, 5);
            panelBottom.MinimumSize = new Size(1, 1);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8, 6, 8, 6);
            panelBottom.Size = new Size(1127, 48);
            panelBottom.Style = UIStyle.Custom;
            panelBottom.TabIndex = 1;
            panelBottom.Text = null;
            panelBottom.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F);
            btnUpdate.Location = new Point(658, 0);
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
            btnDelete.Location = new Point(774, 0);
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
            btnChange.Location = new Point(890, 0);
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
            btnAdd.Location = new Point(1006, 0);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 32);
            btnAdd.Symbol = 61543;
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdd.Click += btnAdd_Click;
            // 
            // ucFaculty
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(FacultyDisplay);
            Controls.Add(panelBottom);
            Name = "ucFaculty";
            Size = new Size(1127, 727);
            Load += ucFaculty_Load;
            ((System.ComponentModel.ISupportInitialize)FacultyDisplay).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn ColMaKhoa;
        private DataGridViewTextBoxColumn ColTenKhoa;
        private DataGridViewTextBoxColumn ColTruongKhoa;
        private DataGridViewTextBoxColumn ColPhongCongTac;
        private DataGridViewTextBoxColumn ColSoLuongLop;
        private DataGridViewTextBoxColumn ColEmailKhoa;
    }
}
