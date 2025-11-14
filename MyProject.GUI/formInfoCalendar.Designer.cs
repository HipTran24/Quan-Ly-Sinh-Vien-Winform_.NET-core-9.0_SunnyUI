namespace MyProject.GUI
{
    partial class formInfoCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInfoCalendar));
            label9 = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            tbPeriods = new TextBox();
            label8 = new Label();
            label7 = new Label();
            tbIDLec = new TextBox();
            label3 = new Label();
            lbformName = new Label();
            tbIDSub = new TextBox();
            label1 = new Label();
            dtpCalen = new DateTimePicker();
            tbNumR = new TextBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(453, 135);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 54;
            label9.Text = "Phòng:";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(387, 202);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(488, 202);
            btnConfirm.Margin = new Padding(2, 2, 2, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(90, 27);
            btnConfirm.TabIndex = 52;
            btnConfirm.Text = "Thêm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tbPeriods
            // 
            tbPeriods.Location = new Point(356, 130);
            tbPeriods.Margin = new Padding(2, 2, 2, 2);
            tbPeriods.Name = "tbPeriods";
            tbPeriods.Size = new Size(93, 27);
            tbPeriods.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(282, 135);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 50;
            label8.Text = "Tiết dạy:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 134);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 48;
            label7.Text = "Lịch dạy:";
            // 
            // tbIDLec
            // 
            tbIDLec.Location = new Point(394, 74);
            tbIDLec.Margin = new Padding(2, 2, 2, 2);
            tbIDLec.Name = "tbIDLec";
            tbIDLec.Size = new Size(184, 27);
            tbIDLec.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 79);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 44;
            label3.Text = "Mã giảng viên:";
            // 
            // lbformName
            // 
            lbformName.AutoSize = true;
            lbformName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbformName.Location = new Point(214, 16);
            lbformName.Margin = new Padding(2, 0, 2, 0);
            lbformName.Name = "lbformName";
            lbformName.Size = new Size(179, 32);
            lbformName.TabIndex = 43;
            lbformName.Text = "Lịch giảng dạy";
            lbformName.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbIDSub
            // 
            tbIDSub.Location = new Point(83, 74);
            tbIDSub.Margin = new Padding(2, 2, 2, 2);
            tbIDSub.Name = "tbIDSub";
            tbIDSub.Size = new Size(179, 27);
            tbIDSub.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 79);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 41;
            label1.Text = "Mã môn:";
            // 
            // dtpCalen
            // 
            dtpCalen.Location = new Point(83, 129);
            dtpCalen.Margin = new Padding(2, 2, 2, 2);
            dtpCalen.Name = "dtpCalen";
            dtpCalen.Size = new Size(179, 27);
            dtpCalen.TabIndex = 56;
            // 
            // tbNumR
            // 
            tbNumR.Location = new Point(510, 129);
            tbNumR.Margin = new Padding(2, 2, 2, 2);
            tbNumR.Name = "tbNumR";
            tbNumR.Size = new Size(68, 27);
            tbNumR.TabIndex = 57;
            // 
            // formInfoCalendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 271);
            Controls.Add(tbNumR);
            Controls.Add(dtpCalen);
            Controls.Add(label9);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(tbPeriods);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tbIDLec);
            Controls.Add(label3);
            Controls.Add(lbformName);
            Controls.Add(tbIDSub);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "formInfoCalendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch giảng dạy";
            Load += formInfoCalendar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Button btnCancel;
        private Button btnConfirm;
        private TextBox tbPeriods;
        private Label label8;
        private Label label7;
        private TextBox tbIDLec;
        private Label label3;
        private Label lbformName;
        private TextBox tbIDSub;
        private Label label1;
        private DateTimePicker dtpCalen;
        private TextBox tbNumR;
    }
}