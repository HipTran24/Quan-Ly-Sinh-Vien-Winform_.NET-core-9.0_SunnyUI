namespace MyProject.GUI
{
    partial class formInfoSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInfoSubject));
            numQuantity = new NumericUpDown();
            label9 = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            tbIdFaculty = new TextBox();
            label8 = new Label();
            tbIdSubject = new TextBox();
            label3 = new Label();
            lbformName = new Label();
            tbName = new TextBox();
            label1 = new Label();
            numLessons = new NumericUpDown();
            label2 = new Label();
            dtpStart = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dtpEnd = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLessons).BeginInit();
            SuspendLayout();
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(91, 118);
            numQuantity.Margin = new Padding(2, 2, 2, 2);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(65, 27);
            numQuantity.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 124);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 54;
            label9.Text = "Số tín chỉ:";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(375, 254);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(476, 254);
            btnConfirm.Margin = new Padding(2, 2, 2, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(90, 27);
            btnConfirm.TabIndex = 52;
            btnConfirm.Text = "Thêm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tbIdFaculty
            // 
            tbIdFaculty.Location = new Point(91, 177);
            tbIdFaculty.Margin = new Padding(2, 2, 2, 2);
            tbIdFaculty.Name = "tbIdFaculty";
            tbIdFaculty.Size = new Size(144, 27);
            tbIdFaculty.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 182);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 50;
            label8.Text = "Mã khoa:";
            // 
            // tbIdSubject
            // 
            tbIdSubject.Location = new Point(401, 68);
            tbIdSubject.Margin = new Padding(2, 2, 2, 2);
            tbIdSubject.Name = "tbIdSubject";
            tbIdSubject.Size = new Size(189, 27);
            tbIdSubject.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(326, 73);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 44;
            label3.Text = "Mã môn:";
            // 
            // lbformName
            // 
            lbformName.AutoSize = true;
            lbformName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbformName.Location = new Point(212, 7);
            lbformName.Margin = new Padding(2, 0, 2, 0);
            lbformName.Name = "lbformName";
            lbformName.Size = new Size(184, 32);
            lbformName.TabIndex = 43;
            lbformName.Text = "Thêm môn học";
            // 
            // tbName
            // 
            tbName.Location = new Point(100, 68);
            tbName.Margin = new Padding(2, 2, 2, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(205, 27);
            tbName.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 73);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 41;
            label1.Text = "Tên môn:";
            // 
            // numLessons
            // 
            numLessons.Location = new Point(239, 118);
            numLessons.Margin = new Padding(2, 2, 2, 2);
            numLessons.Name = "numLessons";
            numLessons.Size = new Size(65, 27);
            numLessons.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 56;
            label2.Text = "Số tiết:";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(418, 124);
            dtpStart.Margin = new Padding(2, 2, 2, 2);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(175, 27);
            dtpStart.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(309, 129);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 59;
            label4.Text = "Ngày bắt đầu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(280, 182);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 61;
            label5.Text = "Ngày bắt kết thúc:";
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(418, 178);
            dtpEnd.Margin = new Padding(2, 2, 2, 2);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(175, 27);
            dtpEnd.TabIndex = 60;
            // 
            // formInfoSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 325);
            Controls.Add(label5);
            Controls.Add(dtpEnd);
            Controls.Add(label4);
            Controls.Add(dtpStart);
            Controls.Add(numLessons);
            Controls.Add(label2);
            Controls.Add(numQuantity);
            Controls.Add(label9);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(tbIdFaculty);
            Controls.Add(label8);
            Controls.Add(tbIdSubject);
            Controls.Add(label3);
            Controls.Add(lbformName);
            Controls.Add(tbName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "formInfoSubject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin môn học";
            Load += formInfoSubject_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLessons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numQuantity;
        private Label label9;
        private Button btnCancel;
        private Button btnConfirm;
        private TextBox tbIdFaculty;
        private Label label8;
        private TextBox tbIdSubject;
        private Label label3;
        private Label lbformName;
        private TextBox tbName;
        private Label label1;
        private NumericUpDown numLessons;
        private Label label2;
        private DateTimePicker dtpStart;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpEnd;
    }
}