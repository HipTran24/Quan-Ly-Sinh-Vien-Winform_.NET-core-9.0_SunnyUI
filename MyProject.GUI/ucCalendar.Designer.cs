using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class ucCalendar
    {
        private System.ComponentModel.IContainer components = null;
        private UIDataGridView CalendarDisplay;
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
            CalendarDisplay = new UIDataGridView();
            panelBottom = new UIPanel();
            btnUpdate = new UISymbolButton();
            btnDelete = new UISymbolButton();
            btnChange = new UISymbolButton();
            btnAdd = new UISymbolButton();
            ColMaMH = new DataGridViewTextBoxColumn();
            ColMaGV = new DataGridViewTextBoxColumn();
            ColNgay = new DataGridViewTextBoxColumn();
            ColTietHoc = new DataGridViewTextBoxColumn();
            ColPhongHoc = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)CalendarDisplay).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // CalendarDisplay
            // 
            CalendarDisplay.AllowUserToAddRows = false;
            CalendarDisplay.AllowUserToDeleteRows = false;
            CalendarDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            CalendarDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CalendarDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CalendarDisplay.BackgroundColor = Color.White;
            CalendarDisplay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CalendarDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CalendarDisplay.ColumnHeadersHeight = 34;
            CalendarDisplay.Columns.AddRange(new DataGridViewColumn[] { ColMaMH, ColMaGV, ColNgay, ColTietHoc, ColPhongHoc });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CalendarDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            CalendarDisplay.Dock = DockStyle.Fill;
            CalendarDisplay.EnableHeadersVisualStyles = false;
            CalendarDisplay.Font = new Font("Microsoft Sans Serif", 12F);
            CalendarDisplay.GridColor = Color.FromArgb(204, 204, 204);
            CalendarDisplay.Location = new Point(0, 0);
            CalendarDisplay.Name = "CalendarDisplay";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CalendarDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CalendarDisplay.RowHeadersVisible = false;
            CalendarDisplay.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            CalendarDisplay.RowsDefaultCellStyle = dataGridViewCellStyle5;
            CalendarDisplay.SelectedIndex = -1;
            CalendarDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CalendarDisplay.Size = new Size(1099, 565);
            CalendarDisplay.StripeOddColor = Color.White;
            CalendarDisplay.TabIndex = 1;
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
            // ColMaMH
            // 
            ColMaMH.DataPropertyName = "MaMH";
            ColMaMH.FillWeight = 99.88584F;
            ColMaMH.HeaderText = "Mã môn";
            ColMaMH.MinimumWidth = 140;
            ColMaMH.Name = "ColMaMH";
            // 
            // ColMaGV
            // 
            ColMaGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMaGV.DataPropertyName = "MaGV";
            ColMaGV.FillWeight = 99.88368F;
            ColMaGV.HeaderText = "Mã giảng viên";
            ColMaGV.MinimumWidth = 180;
            ColMaGV.Name = "ColMaGV";
            // 
            // ColNgay
            // 
            ColNgay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNgay.DataPropertyName = "Ngay";
            ColNgay.FillWeight = 100.45771F;
            ColNgay.HeaderText = "Ngày học";
            ColNgay.MinimumWidth = 140;
            ColNgay.Name = "ColNgay";
            // 
            // ColTietHoc
            // 
            ColTietHoc.DataPropertyName = "TietHoc";
            ColTietHoc.FillWeight = 99.8935547F;
            ColTietHoc.HeaderText = "Tiết học";
            ColTietHoc.MinimumWidth = 100;
            ColTietHoc.Name = "ColTietHoc";
            // 
            // ColPhongHoc
            // 
            ColPhongHoc.DataPropertyName = "PhongHoc";
            ColPhongHoc.FillWeight = 99.87924F;
            ColPhongHoc.HeaderText = "Phòng học";
            ColPhongHoc.MinimumWidth = 120;
            ColPhongHoc.Name = "ColPhongHoc";
            // 
            // ucCalendar
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(CalendarDisplay);
            Controls.Add(panelBottom);
            Margin = new Padding(2);
            Name = "ucCalendar";
            Size = new Size(1099, 613);
            Load += ucCalendar_Load;
            ((System.ComponentModel.ISupportInitialize)CalendarDisplay).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn ColMaMH;
        private DataGridViewTextBoxColumn ColMaGV;
        private DataGridViewTextBoxColumn ColNgay;
        private DataGridViewTextBoxColumn ColTietHoc;
        private DataGridViewTextBoxColumn ColPhongHoc;
    }
}
