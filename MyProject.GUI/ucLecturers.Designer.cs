using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class ucLecturers
    {
        private System.ComponentModel.IContainer components = null;
        private UIDataGridView LecturerDisplay;
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
            LecturerDisplay = new UIDataGridView();
            ColMaGV = new DataGridViewTextBoxColumn();
            ColHoTen = new DataGridViewTextBoxColumn();
            ColSDT = new DataGridViewTextBoxColumn();
            ColEmail = new DataGridViewTextBoxColumn();
            ColMaKhoa = new DataGridViewTextBoxColumn();
            panelBottom = new UIPanel();
            btnUpdate = new UISymbolButton();
            btnDelete = new UISymbolButton();
            btnChange = new UISymbolButton();
            btnAdd = new UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)LecturerDisplay).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // LecturerDisplay
            // 
            LecturerDisplay.AllowUserToAddRows = false;
            LecturerDisplay.AllowUserToDeleteRows = false;
            LecturerDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            LecturerDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            LecturerDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LecturerDisplay.BackgroundColor = Color.White;
            LecturerDisplay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            LecturerDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            LecturerDisplay.ColumnHeadersHeight = 34;
            LecturerDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaGV, ColHoTen, ColSDT, ColEmail, ColMaKhoa });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            LecturerDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            LecturerDisplay.Dock = DockStyle.Fill;
            LecturerDisplay.EnableHeadersVisualStyles = false;
            LecturerDisplay.Font = new Font("Microsoft Sans Serif", 12F);
            LecturerDisplay.GridColor = Color.FromArgb(204, 204, 204);
            LecturerDisplay.Location = new Point(0, 0);
            LecturerDisplay.Name = "LecturerDisplay";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            LecturerDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            LecturerDisplay.RowHeadersVisible = false;
            LecturerDisplay.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            LecturerDisplay.RowsDefaultCellStyle = dataGridViewCellStyle5;
            LecturerDisplay.SelectedIndex = -1;
            LecturerDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LecturerDisplay.Size = new Size(1099, 565);
            LecturerDisplay.StripeOddColor = Color.White;
            LecturerDisplay.TabIndex = 1;
            // 
            // ColMaGV
            // 
            ColMaGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColMaGV.DataPropertyName = "MaGV";
            ColMaGV.HeaderText = "Mã giảng viên";
            ColMaGV.MinimumWidth = 140;
            ColMaGV.Name = "ColMaGV";
            ColMaGV.Width = 160;
            // 
            // ColHoTen
            // 
            ColHoTen.DataPropertyName = "HoTen";
            ColHoTen.HeaderText = "Họ tên";
            ColHoTen.MinimumWidth = 160;
            ColHoTen.Name = "ColHoTen";
            // 
            // ColSDT
            // 
            ColSDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColSDT.DataPropertyName = "SDT";
            ColSDT.HeaderText = "Số điện thoại";
            ColSDT.MinimumWidth = 140;
            ColSDT.Name = "ColSDT";
            ColSDT.Width = 160;
            // 
            // ColEmail
            // 
            ColEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColEmail.DataPropertyName = "Email";
            ColEmail.HeaderText = "Email";
            ColEmail.MinimumWidth = 160;
            ColEmail.Name = "ColEmail";
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
            // ucLecturers
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(LecturerDisplay);
            Controls.Add(panelBottom);
            Name = "ucLecturers";
            Size = new Size(1099, 613);
            Load += ucLecturers_Load;
            ((System.ComponentModel.ISupportInitialize)LecturerDisplay).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn ColMaGV;
        private DataGridViewTextBoxColumn ColHoTen;
        private DataGridViewTextBoxColumn ColSDT;
        private DataGridViewTextBoxColumn ColEmail;
        private DataGridViewTextBoxColumn ColMaKhoa;
    }
}
