namespace MyProject.GUI
{
    partial class formInfoUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInfoUser));
            tbIDUser = new TextBox();
            label9 = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            label8 = new Label();
            tbPWord = new TextBox();
            label3 = new Label();
            lbformName = new Label();
            tbUserName = new TextBox();
            label1 = new Label();
            cbRole = new ComboBox();
            SuspendLayout();
            // 
            // tbIDUser
            // 
            tbIDUser.Location = new Point(98, 75);
            tbIDUser.Margin = new Padding(2, 2, 2, 2);
            tbIDUser.Name = "tbIDUser";
            tbIDUser.Size = new Size(162, 27);
            tbIDUser.TabIndex = 70;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 82);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 68;
            label9.Text = "Mã user:";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(361, 199);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 67;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(462, 199);
            btnConfirm.Margin = new Padding(2, 2, 2, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(90, 27);
            btnConfirm.TabIndex = 66;
            btnConfirm.Text = "Thêm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 136);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 64;
            label8.Text = "Vai trò:";
            // 
            // tbPWord
            // 
            tbPWord.Location = new Point(382, 130);
            tbPWord.Margin = new Padding(2, 2, 2, 2);
            tbPWord.Name = "tbPWord";
            tbPWord.PasswordChar = '*';
            tbPWord.Size = new Size(162, 27);
            tbPWord.TabIndex = 62;
            tbPWord.TextChanged += tbPWord_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(299, 134);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 61;
            label3.Text = "Mật khẩu:";
            // 
            // lbformName
            // 
            lbformName.AutoSize = true;
            lbformName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbformName.Location = new Point(189, 15);
            lbformName.Margin = new Padding(2, 0, 2, 0);
            lbformName.Name = "lbformName";
            lbformName.Size = new Size(234, 32);
            lbformName.TabIndex = 60;
            lbformName.Text = "Cập nhập tài khoản";
            lbformName.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(382, 75);
            tbUserName.Margin = new Padding(2, 2, 2, 2);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(162, 27);
            tbUserName.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 80);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 58;
            label1.Text = "Tài khoản:";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(98, 130);
            cbRole.Margin = new Padding(2, 2, 2, 2);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(162, 28);
            cbRole.TabIndex = 71;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // formInfoUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 262);
            Controls.Add(cbRole);
            Controls.Add(tbIDUser);
            Controls.Add(label9);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label8);
            Controls.Add(tbPWord);
            Controls.Add(label3);
            Controls.Add(lbformName);
            Controls.Add(tbUserName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "formInfoUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật tài khoản";
            Load += formInfoUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbIDUser;
        private Label label9;
        private Button btnCancel;
        private Button btnConfirm;
        private Label label8;
        private TextBox tbPWord;
        private Label label3;
        private Label lbformName;
        private TextBox tbUserName;
        private Label label1;
        private ComboBox cbRole;
    }
}