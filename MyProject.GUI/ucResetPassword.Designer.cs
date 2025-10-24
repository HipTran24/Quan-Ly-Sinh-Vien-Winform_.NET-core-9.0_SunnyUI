namespace MyProject.GUI
{
    partial class ucResetPassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNewPass = new TextBox();
            label1 = new Label();
            btnConfirm = new Button();
            label2 = new Label();
            tbNewPassAg = new TextBox();
            SuspendLayout();
            // 
            // tbNewPass
            // 
            tbNewPass.Location = new Point(193, 66);
            tbNewPass.Name = "tbNewPass";
            tbNewPass.Size = new Size(263, 31);
            tbNewPass.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 74);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 1;
            label1.Text = "Mật khẩu mới:";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(247, 180);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 34);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Thay đổi";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 123);
            label2.Name = "label2";
            label2.Size = new Size(173, 25);
            label2.TabIndex = 4;
            label2.Text = "Nhập lại mật khẩu:";
            // 
            // tbNewPassAg
            // 
            tbNewPassAg.Location = new Point(193, 117);
            tbNewPassAg.Name = "tbNewPassAg";
            tbNewPassAg.Size = new Size(263, 31);
            tbNewPassAg.TabIndex = 3;
            // 
            // ucResetPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(tbNewPassAg);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(tbNewPass);
            Name = "ucResetPassword";
            Size = new Size(589, 258);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNewPass;
        private Label label1;
        private Button btnConfirm;
        private Label label2;
        private TextBox tbNewPassAg;
    }
}
