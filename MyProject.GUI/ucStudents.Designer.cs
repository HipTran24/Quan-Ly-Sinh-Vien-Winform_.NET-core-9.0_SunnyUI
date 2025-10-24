using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class ucStudents
    {
        private System.ComponentModel.IContainer components = null;
        private UIDataGridView StudentDisplay;
        private UIPanel panelBottom;
        private UISymbolButton btnUpdate;
        private UISymbolButton btnDelete;
        private UISymbolButton btnChange;
        private UISymbolButton btnAdd;

        private DataGridViewTextBoxColumn ColMaSV;
        private DataGridViewTextBoxColumn ColHoTen;
        private DataGridViewTextBoxColumn ColMaLop;
        private DataGridViewTextBoxColumn ColNgaySinh;
        private DataGridViewTextBoxColumn ColGioiTinh;
        private DataGridViewTextBoxColumn ColDiaChi;
        private DataGridViewTextBoxColumn ColEmail;
        private DataGridViewTextBoxColumn ColSDT;

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
            StudentDisplay = new UIDataGridView();
            ColMaSV = new DataGridViewTextBoxColumn();
            ColHoTen = new DataGridViewTextBoxColumn();
            ColMaLop = new DataGridViewTextBoxColumn();
            ColNgaySinh = new DataGridViewTextBoxColumn();
            ColGioiTinh = new DataGridViewTextBoxColumn();
            ColDiaChi = new DataGridViewTextBoxColumn();
            ColEmail = new DataGridViewTextBoxColumn();
            ColSDT = new DataGridViewTextBoxColumn();
            panelBottom = new UIPanel();
            btnUpdate = new UISymbolButton();
            btnDelete = new UISymbolButton();
            btnChange = new UISymbolButton();
            btnAdd = new UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)StudentDisplay).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // StudentDisplay
            // 
            StudentDisplay.AllowUserToAddRows = false;
            StudentDisplay.AllowUserToDeleteRows = false;
            StudentDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            StudentDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            StudentDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentDisplay.BackgroundColor = Color.White;
            StudentDisplay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            StudentDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            StudentDisplay.ColumnHeadersHeight = 34;
            StudentDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaSV, ColHoTen, ColMaLop, ColNgaySinh, ColGioiTinh, ColDiaChi, ColEmail, ColSDT });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 235, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            StudentDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            StudentDisplay.Dock = DockStyle.Fill;
            StudentDisplay.EnableHeadersVisualStyles = false;
            StudentDisplay.Font = new Font("Microsoft Sans Serif", 12F);
            StudentDisplay.GridColor = Color.FromArgb(204, 204, 204);
            StudentDisplay.Location = new Point(0, 0);
            StudentDisplay.MultiSelect = false;
            StudentDisplay.Name = "StudentDisplay";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            StudentDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            StudentDisplay.RowHeadersVisible = false;
            StudentDisplay.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            StudentDisplay.RowsDefaultCellStyle = dataGridViewCellStyle5;
            StudentDisplay.ScrollBarColor = Color.Silver;
            StudentDisplay.ScrollBarStyleInherited = false;
            StudentDisplay.SelectedIndex = -1;
            StudentDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentDisplay.Size = new Size(1127, 675);
            StudentDisplay.StripeOddColor = Color.White;
            StudentDisplay.Style = UIStyle.Custom;
            StudentDisplay.TabIndex = 0;
            // 
            // ColMaSV
            // 
            ColMaSV.DataPropertyName = "MaSV";
            ColMaSV.HeaderText = "Mã số sinh viên";
            ColMaSV.MinimumWidth = 120;
            ColMaSV.Name = "ColMaSV";
            // 
            // ColHoTen
            // 
            ColHoTen.DataPropertyName = "HoTen";
            ColHoTen.HeaderText = "Họ tên";
            ColHoTen.MinimumWidth = 150;
            ColHoTen.Name = "ColHoTen";
            // 
            // ColMaLop
            // 
            ColMaLop.DataPropertyName = "MaLop";
            ColMaLop.HeaderText = "Mã lớp";
            ColMaLop.MinimumWidth = 100;
            ColMaLop.Name = "ColMaLop";
            // 
            // ColNgaySinh
            // 
            ColNgaySinh.DataPropertyName = "NgaySinh";
            ColNgaySinh.HeaderText = "Ngày sinh";
            ColNgaySinh.MinimumWidth = 130;
            ColNgaySinh.Name = "ColNgaySinh";
            // 
            // ColGioiTinh
            // 
            ColGioiTinh.DataPropertyName = "GioiTinh";
            ColGioiTinh.HeaderText = "Giới tính";
            ColGioiTinh.MinimumWidth = 6;
            ColGioiTinh.Name = "ColGioiTinh";
            // 
            // ColDiaChi
            // 
            ColDiaChi.DataPropertyName = "DiaChi";
            ColDiaChi.HeaderText = "Địa chỉ";
            ColDiaChi.MinimumWidth = 6;
            ColDiaChi.Name = "ColDiaChi";
            // 
            // ColEmail
            // 
            ColEmail.DataPropertyName = "Email";
            ColEmail.HeaderText = "Email";
            ColEmail.MinimumWidth = 6;
            ColEmail.Name = "ColEmail";
            // 
            // ColSDT
            // 
            ColSDT.DataPropertyName = "SDT";
            ColSDT.HeaderText = "Số điện thoại";
            ColSDT.MinimumWidth = 6;
            ColSDT.Name = "ColSDT";
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
            panelBottom.Location = new Point(0, 675);
            panelBottom.Margin = new Padding(4, 5, 4, 5);
            panelBottom.MinimumSize = new Size(1, 1);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8);
            panelBottom.Size = new Size(1127, 52);
            panelBottom.Style = UIStyle.Custom;
            panelBottom.TabIndex = 1;
            panelBottom.Text = null;
            panelBottom.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F);
            btnUpdate.Location = new Point(632, 8);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 36);
            btnUpdate.Symbol = 61473;
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Location = new Point(748, 8);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 36);
            btnDelete.Symbol = 61944;
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Microsoft Sans Serif", 12F);
            btnChange.Location = new Point(864, 8);
            btnChange.MinimumSize = new Size(1, 1);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(110, 36);
            btnChange.Symbol = 61459;
            btnChange.TabIndex = 2;
            btnChange.Text = "Thay đổi";
            btnChange.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnChange.Click += button2_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdd.Location = new Point(980, 8);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 36);
            btnAdd.Symbol = 61543;
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdd.Click += button1_Click;
            // 
            // ucStudents
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(StudentDisplay);
            Controls.Add(panelBottom);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "ucStudents";
            Size = new Size(1127, 727);
            Load += ucStudents_Load;
            ((System.ComponentModel.ISupportInitialize)StudentDisplay).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
    }
}
