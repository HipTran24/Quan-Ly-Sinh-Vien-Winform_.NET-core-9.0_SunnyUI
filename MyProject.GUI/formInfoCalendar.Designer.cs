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
            label9.Location = new Point(566, 169);
            label9.Name = "label9";
            label9.Size = new Size(72, 25);
            label9.TabIndex = 54;
            label9.Text = "Phòng:";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(484, 253);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(610, 253);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 34);
            btnConfirm.TabIndex = 52;
            btnConfirm.Text = "Thêm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tbPeriods
            // 
            tbPeriods.Location = new Point(445, 163);
            tbPeriods.Name = "tbPeriods";
            tbPeriods.Size = new Size(115, 31);
            tbPeriods.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(353, 169);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 50;
            label8.Text = "Tiết dạy:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 167);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 48;
            label7.Text = "Lịch dạy:";
            // 
            // tbIDLec
            // 
            tbIDLec.Location = new Point(493, 93);
            tbIDLec.Name = "tbIDLec";
            tbIDLec.Size = new Size(229, 31);
            tbIDLec.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(353, 99);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 44;
            label3.Text = "Mã giảng viên:";
            // 
            // lbformName
            // 
            lbformName.AutoSize = true;
            lbformName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbformName.Location = new Point(267, 20);
            lbformName.Name = "lbformName";
            lbformName.Size = new Size(206, 38);
            lbformName.TabIndex = 43;
            lbformName.Text = "Lịch giảng dạy";
            lbformName.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbIDSub
            // 
            tbIDSub.Location = new Point(104, 93);
            tbIDSub.Name = "tbIDSub";
            tbIDSub.Size = new Size(223, 31);
            tbIDSub.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 99);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 41;
            label1.Text = "Mã môn:";
            // 
            // dtpCalen
            // 
            dtpCalen.Location = new Point(104, 161);
            dtpCalen.Name = "dtpCalen";
            dtpCalen.Size = new Size(223, 31);
            dtpCalen.TabIndex = 56;
            // 
            // tbNumR
            // 
            tbNumR.Location = new Point(638, 161);
            tbNumR.Name = "tbNumR";
            tbNumR.Size = new Size(84, 31);
            tbNumR.TabIndex = 57;
            // 
            // formInfoCalendar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 339);
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