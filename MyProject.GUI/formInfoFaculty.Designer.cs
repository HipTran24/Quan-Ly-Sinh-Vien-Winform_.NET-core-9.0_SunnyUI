namespace MyProject.GUI
{
    partial class formInfoFaculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInfoFaculty));
            label9 = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            tbDean = new TextBox();
            label8 = new Label();
            tbEmail = new TextBox();
            label7 = new Label();
            tbWRoom = new TextBox();
            label6 = new Label();
            tbID = new TextBox();
            label3 = new Label();
            lbformName = new Label();
            tbName = new TextBox();
            label1 = new Label();
            numQuantityCl = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numQuantityCl).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(395, 233);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 39;
            label9.Text = "Số lượng lớp:";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(483, 327);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(609, 327);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 34);
            btnConfirm.TabIndex = 36;
            btnConfirm.Text = "Thêm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tbDean
            // 
            tbDean.Location = new Point(517, 153);
            tbDean.Name = "tbDean";
            tbDean.Size = new Size(213, 31);
            tbDean.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(394, 156);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 34;
            label8.Text = "Trưởng khoa:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(126, 156);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(257, 31);
            tbEmail.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(47, 159);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 32;
            label7.Text = "Email:";
            // 
            // tbWRoom
            // 
            tbWRoom.Location = new Point(146, 230);
            tbWRoom.Name = "tbWRoom";
            tbWRoom.Size = new Size(237, 31);
            tbWRoom.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 236);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 30;
            label6.Text = "Phòng công tác:";
            // 
            // tbID
            // 
            tbID.Location = new Point(508, 88);
            tbID.Name = "tbID";
            tbID.Size = new Size(222, 31);
            tbID.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(411, 94);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 24;
            label3.Text = "Mã khoa:";
            // 
            // lbformName
            // 
            lbformName.AutoSize = true;
            lbformName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbformName.Location = new Point(252, 18);
            lbformName.Name = "lbformName";
            lbformName.Size = new Size(227, 38);
            lbformName.TabIndex = 23;
            lbformName.Text = "Thêm khoa viện";
            // 
            // tbName
            // 
            tbName.Location = new Point(128, 88);
            tbName.Name = "tbName";
            tbName.Size = new Size(255, 31);
            tbName.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 94);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 21;
            label1.Text = "Tên khoa:";
            // 
            // numQuantityCl
            // 
            numQuantityCl.Location = new Point(526, 231);
            numQuantityCl.Name = "numQuantityCl";
            numQuantityCl.Size = new Size(81, 31);
            numQuantityCl.TabIndex = 40;
            // 
            // formInfoFaculty
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 412);
            Controls.Add(numQuantityCl);
            Controls.Add(label9);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(tbDean);
            Controls.Add(label8);
            Controls.Add(tbEmail);
            Controls.Add(label7);
            Controls.Add(tbWRoom);
            Controls.Add(label6);
            Controls.Add(tbID);
            Controls.Add(label3);
            Controls.Add(lbformName);
            Controls.Add(tbName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formInfoFaculty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin khoa viện";
            ((System.ComponentModel.ISupportInitialize)numQuantityCl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Button btnCancel;
        private Button btnConfirm;
        private TextBox tbDean;
        private Label label8;
        private TextBox tbEmail;
        private Label label7;
        private TextBox tbWRoom;
        private Label label6;
        private TextBox tbID;
        private Label label3;
        private Label lbformName;
        private TextBox tbName;
        private Label label1;
        private NumericUpDown numQuantityCl;
    }
}