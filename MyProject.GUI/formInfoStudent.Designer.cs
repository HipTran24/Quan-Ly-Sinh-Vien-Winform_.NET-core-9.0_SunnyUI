namespace MyProject.GUI
{
    partial class formInfoStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInfoStudent));
            tbName = new TextBox();
            label2 = new Label();
            tbID = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            rbtMen = new RadioButton();
            rbtWomen = new RadioButton();
            tbAddress = new TextBox();
            label6 = new Label();
            tbEmail = new TextBox();
            label7 = new Label();
            tbNumPhone = new TextBox();
            label8 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            dtpBDay = new DateTimePicker();
            tbIdClass = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(93, 67);
            tbName.Margin = new Padding(2, 2, 2, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(174, 27);
            tbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(187, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(244, 32);
            label2.TabIndex = 2;
            label2.Text = "Thông Tin Sinh Viên";
            // 
            // tbID
            // 
            tbID.Location = new Point(406, 67);
            tbID.Margin = new Padding(2, 2, 2, 2);
            tbID.Name = "tbID";
            tbID.Size = new Size(160, 27);
            tbID.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 72);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã số sinh viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 72);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 237);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 5;
            label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(323, 122);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 7;
            label5.Text = "Giới tính:";
            // 
            // rbtMen
            // 
            rbtMen.AutoSize = true;
            rbtMen.Location = new Point(400, 120);
            rbtMen.Margin = new Padding(2, 2, 2, 2);
            rbtMen.Name = "rbtMen";
            rbtMen.Size = new Size(62, 24);
            rbtMen.TabIndex = 8;
            rbtMen.TabStop = true;
            rbtMen.Text = "Nam";
            rbtMen.UseVisualStyleBackColor = true;
            // 
            // rbtWomen
            // 
            rbtWomen.AutoSize = true;
            rbtWomen.Location = new Point(466, 120);
            rbtWomen.Margin = new Padding(2, 2, 2, 2);
            rbtWomen.Name = "rbtWomen";
            rbtWomen.Size = new Size(50, 24);
            rbtWomen.TabIndex = 9;
            rbtWomen.TabStop = true;
            rbtWomen.Text = "Nữ";
            rbtWomen.UseVisualStyleBackColor = true;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(92, 174);
            tbAddress.Margin = new Padding(2, 2, 2, 2);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(210, 27);
            tbAddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 177);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 10;
            label6.Text = "Địa chỉ:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(89, 122);
            tbEmail.Margin = new Padding(2, 2, 2, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(216, 27);
            tbEmail.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 124);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 12;
            label7.Text = "Email:";
            // 
            // tbNumPhone
            // 
            tbNumPhone.Location = new Point(405, 177);
            tbNumPhone.Margin = new Padding(2, 2, 2, 2);
            tbNumPhone.Name = "tbNumPhone";
            tbNumPhone.Size = new Size(161, 27);
            tbNumPhone.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(306, 179);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 14;
            label8.Text = "Số điện thoại:";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(475, 323);
            btnConfirm.Margin = new Padding(2, 2, 2, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(90, 27);
            btnConfirm.TabIndex = 16;
            btnConfirm.Text = "Thêm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(374, 323);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpBDay
            // 
            dtpBDay.Location = new Point(93, 232);
            dtpBDay.Margin = new Padding(2, 2, 2, 2);
            dtpBDay.Name = "dtpBDay";
            dtpBDay.Size = new Size(241, 27);
            dtpBDay.TabIndex = 18;
            // 
            // tbIdClass
            // 
            tbIdClass.Location = new Point(419, 232);
            tbIdClass.Margin = new Padding(2, 2, 2, 2);
            tbIdClass.Name = "tbIdClass";
            tbIdClass.Size = new Size(146, 27);
            tbIdClass.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(354, 237);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 19;
            label9.Text = "Mã lớp:";
            // 
            // formInfoStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 378);
            Controls.Add(tbIdClass);
            Controls.Add(label9);
            Controls.Add(dtpBDay);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(tbNumPhone);
            Controls.Add(label8);
            Controls.Add(tbEmail);
            Controls.Add(label7);
            Controls.Add(tbAddress);
            Controls.Add(label6);
            Controls.Add(rbtWomen);
            Controls.Add(rbtMen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "formInfoStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin sinh viên";
            Load += formInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbIdClass;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private Button button1;
        private Button button2;
        private TextBox tbName;
        private TextBox tbID;
        private RadioButton rbtMen;
        private RadioButton rbtWomen;
        private TextBox tbAddress;
        private TextBox tbEmail;
        private TextBox tbNumPhone;
        private Button btnConfirm;
        private Button btnCancel;
        private DateTimePicker dtpBDay;
        private Label label9;
    }
}