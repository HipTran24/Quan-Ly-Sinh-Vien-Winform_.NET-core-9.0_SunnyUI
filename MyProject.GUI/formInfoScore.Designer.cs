namespace MyProject.GUI
{
    partial class formInfoScore
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInfoScore));
            label9 = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            label8 = new Label();
            tbMidterm = new TextBox();
            label7 = new Label();
            tbIdSubject = new TextBox();
            label3 = new Label();
            lbformName = new Label();
            tbIdStudent = new TextBox();
            label1 = new Label();
            tbFinalScore = new TextBox();
            tbEndOTerm = new TextBox();
            label2 = new Label();
            cbSemester = new ComboBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(494, 162);
            label9.Name = "label9";
            label9.Size = new Size(156, 25);
            label9.TabIndex = 54;
            label9.Text = "Điểm trung bình:";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(491, 293);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(617, 293);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 34);
            btnConfirm.TabIndex = 52;
            btnConfirm.Text = "Thêm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(251, 162);
            label8.Name = "label8";
            label8.Size = new Size(127, 25);
            label8.TabIndex = 50;
            label8.Text = "Điểm cuối kỳ:";
            // 
            // tbMidterm
            // 
            tbMidterm.Location = new Point(147, 156);
            tbMidterm.Name = "tbMidterm";
            tbMidterm.Size = new Size(77, 31);
            tbMidterm.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 159);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 48;
            label7.Text = "Điểm giữa kỳ:";
            // 
            // tbIdSubject
            // 
            tbIdSubject.Location = new Point(507, 85);
            tbIdSubject.Name = "tbIdSubject";
            tbIdSubject.Size = new Size(222, 31);
            tbIdSubject.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(384, 91);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 44;
            label3.Text = "Mã môn học:";
            // 
            // lbformName
            // 
            lbformName.AutoSize = true;
            lbformName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbformName.Location = new Point(294, 9);
            lbformName.Name = "lbformName";
            lbformName.Size = new Size(174, 38);
            lbformName.TabIndex = 43;
            lbformName.Text = "Thêm điểm ";
            // 
            // tbIdStudent
            // 
            tbIdStudent.Location = new Point(147, 85);
            tbIdStudent.Name = "tbIdStudent";
            tbIdStudent.Size = new Size(231, 31);
            tbIdStudent.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 91);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 41;
            label1.Text = "Mã sinh viên:";
            // 
            // tbFinalScore
            // 
            tbFinalScore.Location = new Point(652, 156);
            tbFinalScore.Name = "tbFinalScore";
            tbFinalScore.ReadOnly = true;
            tbFinalScore.Size = new Size(77, 31);
            tbFinalScore.TabIndex = 55;
            // 
            // tbEndOTerm
            // 
            tbEndOTerm.Location = new Point(384, 156);
            tbEndOTerm.Name = "tbEndOTerm";
            tbEndOTerm.Size = new Size(77, 31);
            tbEndOTerm.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 231);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 57;
            label2.Text = "Học kỳ:";
            // 
            // cbSemester
            // 
            cbSemester.FormattingEnabled = true;
            cbSemester.Items.AddRange(new object[] { "HK1A-2025-2026", "HK1B-2025-2026", "HK2A-2025-2026", "HK2B-2025-2026", "HK3-2025-2026" });
            cbSemester.Location = new Point(94, 223);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(182, 33);
            cbSemester.TabIndex = 58;
            // 
            // formInfoScore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 378);
            Controls.Add(cbSemester);
            Controls.Add(label2);
            Controls.Add(tbEndOTerm);
            Controls.Add(tbFinalScore);
            Controls.Add(label9);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label8);
            Controls.Add(tbMidterm);
            Controls.Add(label7);
            Controls.Add(tbIdSubject);
            Controls.Add(label3);
            Controls.Add(lbformName);
            Controls.Add(tbIdStudent);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formInfoScore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin điểm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numQuantityCl;
        private Label label9;
        private Button btnCancel;
        private Button btnConfirm;
        private TextBox tbDean;
        private Label label8;
        private TextBox tbMidterm;
        private Label label7;
        private TextBox tbIdSubject;
        private Label label3;
        private Label lbformName;
        private TextBox tbIdStudent;
        private Label label1;
        private TextBox tbFinalScore;
        private TextBox tbEndOTerm;
        private Label label2;
        private ComboBox cbSemester;
    }
}