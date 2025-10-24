namespace MyProject.GUI
{
    partial class ucConfirmOTP
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
            label1 = new Label();
            tbOPT = new TextBox();
            btnConfirmOTP = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 94);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập OTP:";
            // 
            // tbOPT
            // 
            tbOPT.Location = new Point(224, 91);
            tbOPT.Name = "tbOPT";
            tbOPT.Size = new Size(150, 31);
            tbOPT.TabIndex = 1;
            // 
            // btnConfirmOTP
            // 
            btnConfirmOTP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmOTP.Location = new Point(236, 165);
            btnConfirmOTP.Name = "btnConfirmOTP";
            btnConfirmOTP.Size = new Size(112, 34);
            btnConfirmOTP.TabIndex = 2;
            btnConfirmOTP.Text = "Xác nhận";
            btnConfirmOTP.UseVisualStyleBackColor = true;
            btnConfirmOTP.Click += btnConfirmOTP_Click;
            // 
            // ucConfirmOTP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnConfirmOTP);
            Controls.Add(tbOPT);
            Controls.Add(label1);
            Name = "ucConfirmOTP";
            Size = new Size(589, 258);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbOPT;
        private Button btnConfirmOTP;
    }
}
