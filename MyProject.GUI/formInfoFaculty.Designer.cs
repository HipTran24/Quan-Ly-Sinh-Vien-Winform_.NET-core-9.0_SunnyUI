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
            label9.Location = new Point(316, 186);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 39;
            label9.Text = "Số lượng lớp:";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(386, 262);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(487, 262);
            btnConfirm.Margin = new Padding(2, 2, 2, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(90, 27);
            btnConfirm.TabIndex = 36;
            btnConfirm.Text = "Thêm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tbDean
            // 
            tbDean.Location = new Point(414, 122);
            tbDean.Margin = new Padding(2, 2, 2, 2);
            tbDean.Name = "tbDean";
            tbDean.Size = new Size(171, 27);
            tbDean.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(315, 125);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 34;
            label8.Text = "Trưởng khoa:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(101, 125);
            tbEmail.Margin = new Padding(2, 2, 2, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(206, 27);
            tbEmail.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 127);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 32;
            label7.Text = "Email:";
            // 
            // tbWRoom
            // 
            tbWRoom.Location = new Point(117, 184);
            tbWRoom.Margin = new Padding(2, 2, 2, 2);
            tbWRoom.Name = "tbWRoom";
            tbWRoom.Size = new Size(190, 27);
            tbWRoom.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 189);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 30;
            label6.Text = "Phòng công tác:";
            // 
            // tbID
            // 
            tbID.Location = new Point(406, 70);
            tbID.Margin = new Padding(2, 2, 2, 2);
            tbID.Name = "tbID";
            tbID.Size = new Size(178, 27);
            tbID.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(329, 75);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 24;
            label3.Text = "Mã khoa:";
            // 
            // lbformName
            // 
            lbformName.AutoSize = true;
            lbformName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbformName.Location = new Point(202, 14);
            lbformName.Margin = new Padding(2, 0, 2, 0);
            lbformName.Name = "lbformName";
            lbformName.Size = new Size(194, 32);
            lbformName.TabIndex = 23;
            lbformName.Text = "Thêm khoa viện";
            // 
            // tbName
            // 
            tbName.Location = new Point(102, 70);
            tbName.Margin = new Padding(2, 2, 2, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(205, 27);
            tbName.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 75);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 21;
            label1.Text = "Tên khoa:";
            // 
            // numQuantityCl
            // 
            numQuantityCl.Location = new Point(421, 185);
            numQuantityCl.Margin = new Padding(2, 2, 2, 2);
            numQuantityCl.Name = "numQuantityCl";
            numQuantityCl.Size = new Size(65, 27);
            numQuantityCl.TabIndex = 40;
            // 
            // formInfoFaculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 330);
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
            Margin = new Padding(2, 2, 2, 2);
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