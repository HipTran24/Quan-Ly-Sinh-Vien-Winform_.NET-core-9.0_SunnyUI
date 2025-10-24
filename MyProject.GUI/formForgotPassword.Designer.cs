namespace MyProject.GUI
{
    partial class formForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formForgotPassword));
            panel1 = new Panel();
            label1 = new Label();
            btnConfirm = new Button();
            tbEmail = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(tbEmail);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 258);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 81);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 5;
            label1.Text = "Nhập email:";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(239, 146);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(125, 34);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(161, 75);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(278, 31);
            tbEmail.TabIndex = 3;
            // 
            // formForgotPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 261);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lấy lại mật khẩu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnConfirm;
        private TextBox tbEmail;
    }
}