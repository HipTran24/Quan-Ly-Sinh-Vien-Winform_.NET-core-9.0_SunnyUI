namespace MyProject.GUI
{
    partial class ucStudentScore
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
            dgvScores = new Sunny.UI.UIDataGridView();
            ColMaMH = new DataGridViewTextBoxColumn();
            ColTenMH = new DataGridViewTextBoxColumn();
            ColGiuaKy = new DataGridViewTextBoxColumn();
            ColDiemCuoiKy = new DataGridViewTextBoxColumn();
            ColDTB = new DataGridViewTextBoxColumn();
            ColSCT = new DataGridViewTextBoxColumn();
            ColHocKy = new DataGridViewTextBoxColumn();
            panelBottom = new Sunny.UI.UIPanel();
            lblGPA = new Sunny.UI.UILabel();
            lblTotalCredits = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)dgvScores).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // dgvScores
            // 
            dgvScores.AllowUserToAddRows = false;
            dgvScores.AllowUserToDeleteRows = false;
            dgvScores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvScores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvScores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvScores.BackgroundColor = Color.White;
            dgvScores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvScores.ColumnHeadersHeight = 34;
            dgvScores.Columns.AddRange(new DataGridViewColumn[] { ColMaMH, ColTenMH, ColGiuaKy, ColDiemCuoiKy, ColDTB, ColSCT, ColHocKy });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvScores.DefaultCellStyle = dataGridViewCellStyle3;
            dgvScores.EnableHeadersVisualStyles = false;
            dgvScores.Font = new Font("Microsoft Sans Serif", 12F);
            dgvScores.GridColor = Color.FromArgb(204, 204, 204);
            dgvScores.Location = new Point(0, 0);
            dgvScores.Name = "dgvScores";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvScores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvScores.RowHeadersVisible = false;
            dgvScores.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvScores.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvScores.ScrollBarColor = Color.Silver;
            dgvScores.ScrollBarStyleInherited = false;
            dgvScores.SelectedIndex = -1;
            dgvScores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvScores.Size = new Size(1099, 565);
            dgvScores.StripeOddColor = Color.White;
            dgvScores.TabIndex = 3;
            // 
            // ColMaMH
            // 
            ColMaMH.DataPropertyName = "MaMH";
            ColMaMH.HeaderText = "Mã Môn";
            ColMaMH.MinimumWidth = 6;
            ColMaMH.Name = "ColMaMH";
            // 
            // ColTenMH
            // 
            ColTenMH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTenMH.DataPropertyName = "TenMH";
            ColTenMH.HeaderText = "Tên môn";
            ColTenMH.MinimumWidth = 6;
            ColTenMH.Name = "ColTenMH";
            // 
            // ColGiuaKy
            // 
            ColGiuaKy.DataPropertyName = "DiemGiuaKy";
            ColGiuaKy.HeaderText = "Điểm GK";
            ColGiuaKy.MinimumWidth = 6;
            ColGiuaKy.Name = "ColGiuaKy";
            // 
            // ColDiemCuoiKy
            // 
            ColDiemCuoiKy.DataPropertyName = "DiemCuoiKy";
            ColDiemCuoiKy.HeaderText = "Điểm CK";
            ColDiemCuoiKy.MinimumWidth = 6;
            ColDiemCuoiKy.Name = "ColDiemCuoiKy";
            // 
            // ColDTB
            // 
            ColDTB.DataPropertyName = "DiemTrungBinh";
            ColDTB.HeaderText = "Điểm Trung Bình";
            ColDTB.MinimumWidth = 6;
            ColDTB.Name = "ColDTB";
            // 
            // ColSCT
            // 
            ColSCT.DataPropertyName = "SoTinChi";
            ColSCT.HeaderText = "Số tín chỉ";
            ColSCT.MinimumWidth = 6;
            ColSCT.Name = "ColSCT";
            // 
            // ColHocKy
            // 
            ColHocKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColHocKy.DataPropertyName = "HocKy";
            ColHocKy.HeaderText = "Học kỳ";
            ColHocKy.MinimumWidth = 6;
            ColHocKy.Name = "ColHocKy";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(lblGPA);
            panelBottom.Controls.Add(lblTotalCredits);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.FillColor = Color.White;
            panelBottom.Font = new Font("Microsoft Sans Serif", 12F);
            panelBottom.Location = new Point(0, 565);
            panelBottom.Margin = new Padding(4, 5, 4, 5);
            panelBottom.MinimumSize = new Size(1, 1);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8, 6, 8, 6);
            panelBottom.Size = new Size(1099, 48);
            panelBottom.Style = Sunny.UI.UIStyle.Custom;
            panelBottom.TabIndex = 4;
            panelBottom.Text = null;
            panelBottom.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblGPA
            // 
            lblGPA.Font = new Font("Microsoft Sans Serif", 12F);
            lblGPA.ForeColor = Color.FromArgb(48, 48, 48);
            lblGPA.Location = new Point(849, 6);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(107, 29);
            lblGPA.TabIndex = 6;
            // 
            // lblTotalCredits
            // 
            lblTotalCredits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalCredits.Font = new Font("Microsoft Sans Serif", 12F);
            lblTotalCredits.ForeColor = Color.FromArgb(48, 48, 48);
            lblTotalCredits.Location = new Point(962, 6);
            lblTotalCredits.Name = "lblTotalCredits";
            lblTotalCredits.Size = new Size(126, 29);
            lblTotalCredits.TabIndex = 5;
            // 
            // ucStudentScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvScores);
            Controls.Add(panelBottom);
            Name = "ucStudentScore";
            Size = new Size(1099, 613);
            ((System.ComponentModel.ISupportInitialize)dgvScores).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvScores;
        private Sunny.UI.UIPanel panelBottom;
        private Sunny.UI.UILabel lblTotalCredits;
        private Sunny.UI.UILabel lblGPA;
        private DataGridViewTextBoxColumn ColMaMH;
        private DataGridViewTextBoxColumn ColTenMH;
        private DataGridViewTextBoxColumn ColGiuaKy;
        private DataGridViewTextBoxColumn ColDiemCuoiKy;
        private DataGridViewTextBoxColumn ColDTB;
        private DataGridViewTextBoxColumn ColSCT;
        private DataGridViewTextBoxColumn ColHocKy;
    }
}
