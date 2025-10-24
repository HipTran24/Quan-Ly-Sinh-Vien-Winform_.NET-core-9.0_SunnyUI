using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class ucScore
    {
        private System.ComponentModel.IContainer components = null;
        private UIDataGridView ScoreDisplay;
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
            ScoreDisplay = new UIDataGridView();
            ColMaSV = new DataGridViewTextBoxColumn();
            ColMaMH = new DataGridViewTextBoxColumn();
            ColDiemGK = new DataGridViewTextBoxColumn();
            ColDiemCK = new DataGridViewTextBoxColumn();
            ColDiemTrungBinh = new DataGridViewTextBoxColumn();
            ColHocKy = new DataGridViewTextBoxColumn();
            panelBottom = new UIPanel();
            btnUpdate = new UISymbolButton();
            btnDelete = new UISymbolButton();
            btnChange = new UISymbolButton();
            btnAdd = new UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)ScoreDisplay).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // ScoreDisplay
            // 
            ScoreDisplay.AllowUserToAddRows = false;
            ScoreDisplay.AllowUserToDeleteRows = false;
            ScoreDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            ScoreDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ScoreDisplay.BackgroundColor = Color.White;
            ScoreDisplay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ScoreDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ScoreDisplay.ColumnHeadersHeight = 34;
            ScoreDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaSV, ColMaMH, ColDiemGK, ColDiemCK, ColDiemTrungBinh, ColHocKy });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ScoreDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            ScoreDisplay.Dock = DockStyle.Fill;
            ScoreDisplay.EnableHeadersVisualStyles = false;
            ScoreDisplay.Font = new Font("Microsoft Sans Serif", 12F);
            ScoreDisplay.GridColor = Color.FromArgb(204, 204, 204);
            ScoreDisplay.Location = new Point(0, 0);
            ScoreDisplay.Name = "ScoreDisplay";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ScoreDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ScoreDisplay.RowHeadersVisible = false;
            ScoreDisplay.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            ScoreDisplay.RowsDefaultCellStyle = dataGridViewCellStyle5;
            ScoreDisplay.ScrollBarColor = Color.Silver;
            ScoreDisplay.ScrollBarStyleInherited = false;
            ScoreDisplay.SelectedIndex = -1;
            ScoreDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ScoreDisplay.Size = new Size(1099, 565);
            ScoreDisplay.StripeOddColor = Color.White;
            ScoreDisplay.TabIndex = 1;
            // 
            // ColMaSV
            // 
            ColMaSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMaSV.DataPropertyName = "MaSV";
            ColMaSV.HeaderText = "Mã số sinh viên";
            ColMaSV.MinimumWidth = 150;
            ColMaSV.Name = "ColMaSV";
            // 
            // ColMaMH
            // 
            ColMaMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColMaMH.DataPropertyName = "MaMH";
            ColMaMH.HeaderText = "Mã môn học";
            ColMaMH.MinimumWidth = 130;
            ColMaMH.Name = "ColMaMH";
            ColMaMH.Width = 150;
            // 
            // ColDiemGK
            // 
            ColDiemGK.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColDiemGK.DataPropertyName = "DiemGK";
            ColDiemGK.HeaderText = "Điểm giữa kỳ";
            ColDiemGK.MinimumWidth = 120;
            ColDiemGK.Name = "ColDiemGK";
            ColDiemGK.Width = 140;
            // 
            // ColDiemCK
            // 
            ColDiemCK.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColDiemCK.DataPropertyName = "DiemCK";
            ColDiemCK.HeaderText = "Điểm cuối kỳ";
            ColDiemCK.MinimumWidth = 120;
            ColDiemCK.Name = "ColDiemCK";
            ColDiemCK.Width = 140;
            // 
            // ColDiemTrungBinh
            // 
            ColDiemTrungBinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColDiemTrungBinh.DataPropertyName = "DiemTrungBinh";
            ColDiemTrungBinh.HeaderText = "Điểm trung bình";
            ColDiemTrungBinh.MinimumWidth = 140;
            ColDiemTrungBinh.Name = "ColDiemTrungBinh";
            ColDiemTrungBinh.Width = 160;
            // 
            // ColHocKy
            // 
            ColHocKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColHocKy.DataPropertyName = "HocKy";
            ColHocKy.HeaderText = "Học kỳ";
            ColHocKy.MinimumWidth = 100;
            ColHocKy.Name = "ColHocKy";
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
            // ucScore
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(ScoreDisplay);
            Controls.Add(panelBottom);
            Name = "ucScore";
            Size = new Size(1099, 613);
            Load += ucScore_Load;
            ((System.ComponentModel.ISupportInitialize)ScoreDisplay).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn ColMaSV;
        private DataGridViewTextBoxColumn ColMaMH;
        private DataGridViewTextBoxColumn ColDiemGK;
        private DataGridViewTextBoxColumn ColDiemCK;
        private DataGridViewTextBoxColumn ColDiemTrungBinh;
        private DataGridViewTextBoxColumn ColHocKy;
    }
}
