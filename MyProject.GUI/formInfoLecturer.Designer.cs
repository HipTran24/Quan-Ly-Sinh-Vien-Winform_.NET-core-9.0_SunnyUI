namespace MyProject.GUI
{
    partial class formInfoLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInfoLecturer));
            btnCancel = new Button();
            btnConfirm = new Button();
            tbNumP = new TextBox();
            label8 = new Label();
            tbEmail = new TextBox();
            label7 = new Label();
            tbIdFa = new TextBox();
            label6 = new Label();
            tbID = new TextBox();
            label3 = new Label();
            lbformName = new Label();
            tbName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(500, 293);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(626, 293);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 34);
            btnConfirm.TabIndex = 52;
            btnConfirm.Text = "Thêm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tbNumP
            // 
            tbNumP.Location = new Point(525, 155);
            tbNumP.Name = "tbNumP";
            tbNumP.Size = new Size(213, 31);
            tbNumP.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(400, 161);
            label8.Name = "label8";
            label8.Size = new Size(129, 25);
            label8.TabIndex = 50;
            label8.Text = "Số điện thoại:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(113, 158);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(257, 31);
            tbEmail.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(55, 164);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 48;
            label7.Text = "Email:";
            // 
            // tbIdFa
            // 
            tbIdFa.Location = new Point(113, 224);
            tbIdFa.Name = "tbIdFa";
            tbIdFa.Size = new Size(257, 31);
            tbIdFa.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 230);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 46;
            label6.Text = "Mã khoa: ";
            // 
            // tbID
            // 
            tbID.Location = new Point(525, 90);
            tbID.Name = "tbID";
            tbID.Size = new Size(213, 31);
            tbID.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(391, 96);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 44;
            label3.Text = "Mã giảng viên:";
            // 
            // lbformName
            // 
            lbformName.AutoSize = true;
            lbformName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbformName.Location = new Point(239, 9);
            lbformName.Name = "lbformName";
            lbformName.Size = new Size(290, 38);
            lbformName.TabIndex = 43;
            lbformName.Text = "Thông tin giảng viên";
            // 
            // tbName
            // 
            tbName.Location = new Point(148, 90);
            tbName.Name = "tbName";
            tbName.Size = new Size(222, 31);
            tbName.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 41;
            label1.Text = "Tên giảng viên:";
            // 
            // formInfoLecturer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 367);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(tbNumP);
            Controls.Add(label8);
            Controls.Add(tbEmail);
            Controls.Add(label7);
            Controls.Add(tbIdFa);
            Controls.Add(label6);
            Controls.Add(tbID);
            Controls.Add(label3);
            Controls.Add(lbformName);
            Controls.Add(tbName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formInfoLecturer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin giảng viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private Button btnConfirm;
        private TextBox tbNumP;
        private Label label8;
        private TextBox tbEmail;
        private Label label7;
        private TextBox tbIdFa;
        private Label label6;
        private TextBox tbID;
        private Label label3;
        private Label lbformName;
        private TextBox tbName;
        private Label label1;
    }
}