namespace MyProject.GUI
{
    partial class ucScoreLecturer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            UpdateScoreDisplay = new Sunny.UI.UIDataGridView();
            MaSV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            MaMH = new DataGridViewTextBoxColumn();
            HocKy = new DataGridViewTextBoxColumn();
            DiemGK = new DataGridViewTextBoxColumn();
            DiemCK = new DataGridViewTextBoxColumn();
            DiemTrungBinh = new DataGridViewTextBoxColumn();
            btnUpdate = new Sunny.UI.UISymbolButton();
            panelBottom = new Sunny.UI.UIPanel();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            uiSymbolButton4 = new Sunny.UI.UISymbolButton();
            uiComboBox2 = new Sunny.UI.UIComboBox();
            uiLabel1 = new Sunny.UI.UILabel();
            pnlFilter = new Sunny.UI.UIPanel();
            cbHocKy = new Sunny.UI.UIComboBox();
            uiLabel3 = new Sunny.UI.UILabel();
            cbMon = new Sunny.UI.UIComboBox();
            uiLabel2 = new Sunny.UI.UILabel();
            cbLop = new Sunny.UI.UIComboBox();
            ((System.ComponentModel.ISupportInitialize)UpdateScoreDisplay).BeginInit();
            panelBottom.SuspendLayout();
            pnlFilter.SuspendLayout();
            SuspendLayout();
            // 
            // UpdateScoreDisplay
            // 
            UpdateScoreDisplay.AllowUserToAddRows = false;
            UpdateScoreDisplay.AllowUserToDeleteRows = false;
            UpdateScoreDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            UpdateScoreDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            UpdateScoreDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UpdateScoreDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UpdateScoreDisplay.BackgroundColor = Color.White;
            UpdateScoreDisplay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UpdateScoreDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UpdateScoreDisplay.ColumnHeadersHeight = 34;
            UpdateScoreDisplay.Columns.AddRange(new DataGridViewColumn[] { MaSV, HoTen, MaMH, HocKy, DiemGK, DiemCK, DiemTrungBinh });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UpdateScoreDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            UpdateScoreDisplay.EnableHeadersVisualStyles = false;
            UpdateScoreDisplay.Font = new Font("Microsoft Sans Serif", 12F);
            UpdateScoreDisplay.GridColor = Color.FromArgb(204, 204, 204);
            UpdateScoreDisplay.Location = new Point(0, 46);
            UpdateScoreDisplay.Name = "UpdateScoreDisplay";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            UpdateScoreDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            UpdateScoreDisplay.RowHeadersVisible = false;
            UpdateScoreDisplay.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            UpdateScoreDisplay.RowsDefaultCellStyle = dataGridViewCellStyle5;
            UpdateScoreDisplay.SelectedIndex = -1;
            UpdateScoreDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpdateScoreDisplay.Size = new Size(879, 396);
            UpdateScoreDisplay.StripeOddColor = Color.White;
            UpdateScoreDisplay.TabIndex = 3;
            UpdateScoreDisplay.CellEndEdit += UpdateScoreDisplay_CellEndEdit;
            UpdateScoreDisplay.CellValidating += UpdateScoreDisplay_CellValidating;
            // 
            // MaSV
            // 
            MaSV.DataPropertyName = "MaSV";
            MaSV.HeaderText = "Mã SV";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // MaMH
            // 
            MaMH.DataPropertyName = "MaMH";
            MaMH.HeaderText = "Mã môn";
            MaMH.MinimumWidth = 6;
            MaMH.Name = "MaMH";
            // 
            // HocKy
            // 
            HocKy.DataPropertyName = "HocKy";
            HocKy.HeaderText = "Học kỳ";
            HocKy.MinimumWidth = 6;
            HocKy.Name = "HocKy";
            // 
            // DiemGK
            // 
            DiemGK.DataPropertyName = "DiemGK";
            DiemGK.HeaderText = "Điểm GK";
            DiemGK.MinimumWidth = 6;
            DiemGK.Name = "DiemGK";
            // 
            // DiemCK
            // 
            DiemCK.DataPropertyName = "DiemCK";
            DiemCK.HeaderText = "Điểm CK";
            DiemCK.MinimumWidth = 6;
            DiemCK.Name = "DiemCK";
            // 
            // DiemTrungBinh
            // 
            DiemTrungBinh.DataPropertyName = "DiemTrungBinh";
            DiemTrungBinh.HeaderText = "DTB";
            DiemTrungBinh.MinimumWidth = 6;
            DiemTrungBinh.Name = "DiemTrungBinh";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F);
            btnUpdate.Location = new Point(758, 9);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 32);
            btnUpdate.Symbol = 61473;
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnUpdate);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.FillColor = Color.White;
            panelBottom.Font = new Font("Microsoft Sans Serif", 12F);
            panelBottom.Location = new Point(0, 443);
            panelBottom.Margin = new Padding(4, 5, 4, 5);
            panelBottom.MinimumSize = new Size(1, 1);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8, 6, 8, 6);
            panelBottom.Size = new Size(879, 47);
            panelBottom.Style = Sunny.UI.UIStyle.Custom;
            panelBottom.TabIndex = 10;
            panelBottom.Text = null;
            panelBottom.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uiSymbolButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton1.Location = new Point(1011, 12);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Size = new Size(110, 32);
            uiSymbolButton1.Symbol = 61473;
            uiSymbolButton1.TabIndex = 0;
            uiSymbolButton1.Text = "Cập nhật";
            uiSymbolButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiSymbolButton2
            // 
            uiSymbolButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uiSymbolButton2.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton2.Location = new Point(1127, 12);
            uiSymbolButton2.MinimumSize = new Size(1, 1);
            uiSymbolButton2.Name = "uiSymbolButton2";
            uiSymbolButton2.Size = new Size(110, 32);
            uiSymbolButton2.Symbol = 61944;
            uiSymbolButton2.TabIndex = 1;
            uiSymbolButton2.Text = "Xóa";
            uiSymbolButton2.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiSymbolButton3
            // 
            uiSymbolButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uiSymbolButton3.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton3.Location = new Point(1243, 12);
            uiSymbolButton3.MinimumSize = new Size(1, 1);
            uiSymbolButton3.Name = "uiSymbolButton3";
            uiSymbolButton3.Size = new Size(110, 32);
            uiSymbolButton3.Symbol = 61459;
            uiSymbolButton3.TabIndex = 2;
            uiSymbolButton3.Text = "Thay đổi";
            uiSymbolButton3.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiSymbolButton4
            // 
            uiSymbolButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uiSymbolButton4.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton4.Location = new Point(1359, 12);
            uiSymbolButton4.MinimumSize = new Size(1, 1);
            uiSymbolButton4.Name = "uiSymbolButton4";
            uiSymbolButton4.Size = new Size(110, 32);
            uiSymbolButton4.Symbol = 61543;
            uiSymbolButton4.TabIndex = 3;
            uiSymbolButton4.Text = "Thêm";
            uiSymbolButton4.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiComboBox2
            // 
            uiComboBox2.DataSource = null;
            uiComboBox2.FillColor = Color.White;
            uiComboBox2.Font = new Font("Microsoft Sans Serif", 12F);
            uiComboBox2.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox2.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox2.Location = new Point(58, 5);
            uiComboBox2.Margin = new Padding(4, 5, 4, 5);
            uiComboBox2.MinimumSize = new Size(63, 0);
            uiComboBox2.Name = "uiComboBox2";
            uiComboBox2.Padding = new Padding(0, 0, 30, 2);
            uiComboBox2.Size = new Size(188, 36);
            uiComboBox2.SymbolSize = 24;
            uiComboBox2.TabIndex = 2;
            uiComboBox2.Text = "uiComboBox2";
            uiComboBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox2.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(3, 9);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(48, 29);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "Lớp";
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(cbHocKy);
            pnlFilter.Controls.Add(uiLabel3);
            pnlFilter.Controls.Add(cbMon);
            pnlFilter.Controls.Add(uiLabel2);
            pnlFilter.Controls.Add(cbLop);
            pnlFilter.Controls.Add(uiLabel1);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Font = new Font("Microsoft Sans Serif", 12F);
            pnlFilter.Location = new Point(0, 0);
            pnlFilter.Margin = new Padding(4, 5, 4, 5);
            pnlFilter.MinimumSize = new Size(1, 1);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(879, 42);
            pnlFilter.TabIndex = 11;
            pnlFilter.Text = null;
            pnlFilter.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // cbHocKy
            // 
            cbHocKy.DataSource = null;
            cbHocKy.FillColor = Color.White;
            cbHocKy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cbHocKy.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbHocKy.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbHocKy.Location = new Point(565, 4);
            cbHocKy.Margin = new Padding(4, 5, 4, 5);
            cbHocKy.MinimumSize = new Size(63, 0);
            cbHocKy.Name = "cbHocKy";
            cbHocKy.Padding = new Padding(0, 0, 30, 2);
            cbHocKy.Size = new Size(188, 33);
            cbHocKy.SymbolSize = 24;
            cbHocKy.TabIndex = 13;
            cbHocKy.TextAlignment = ContentAlignment.MiddleLeft;
            cbHocKy.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(501, 9);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(66, 29);
            uiLabel3.TabIndex = 12;
            uiLabel3.Text = "Học kỳ";
            // 
            // cbMon
            // 
            cbMon.DataSource = null;
            cbMon.FillColor = Color.White;
            cbMon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cbMon.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbMon.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbMon.Location = new Point(303, 5);
            cbMon.Margin = new Padding(4, 5, 4, 5);
            cbMon.MinimumSize = new Size(63, 0);
            cbMon.Name = "cbMon";
            cbMon.Padding = new Padding(0, 0, 30, 2);
            cbMon.Size = new Size(188, 33);
            cbMon.SymbolSize = 24;
            cbMon.TabIndex = 4;
            cbMon.TextAlignment = ContentAlignment.MiddleLeft;
            cbMon.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(248, 9);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(48, 29);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "Môn";
            // 
            // cbLop
            // 
            cbLop.DataSource = null;
            cbLop.FillColor = Color.White;
            cbLop.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cbLop.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbLop.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbLop.Location = new Point(45, 4);
            cbLop.Margin = new Padding(4, 5, 4, 5);
            cbLop.MinimumSize = new Size(63, 0);
            cbLop.Name = "cbLop";
            cbLop.Padding = new Padding(0, 0, 30, 2);
            cbLop.Size = new Size(188, 33);
            cbLop.SymbolSize = 24;
            cbLop.TabIndex = 2;
            cbLop.TextAlignment = ContentAlignment.MiddleLeft;
            cbLop.Watermark = "";
            // 
            // ucScoreLecturer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlFilter);
            Controls.Add(panelBottom);
            Controls.Add(UpdateScoreDisplay);
            Name = "ucScoreLecturer";
            Size = new Size(879, 490);
            Load += ucScoreLecturer_Load;
            ((System.ComponentModel.ISupportInitialize)UpdateScoreDisplay).EndInit();
            panelBottom.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView UpdateScoreDisplay;
        private Sunny.UI.UISymbolButton btnUpdate;
        private Sunny.UI.UIPanel panelBottom;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UISymbolButton uiSymbolButton4;
        private Sunny.UI.UIComboBox uiComboBox2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel pnlFilter;
        private Sunny.UI.UIComboBox cbLop;
        private Sunny.UI.UIComboBox cbHocKy;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboBox cbMon;
        private Sunny.UI.UILabel uiLabel2;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn HocKy;
        private DataGridViewTextBoxColumn DiemGK;
        private DataGridViewTextBoxColumn DiemCK;
        private DataGridViewTextBoxColumn DiemTrungBinh;
    }
}
