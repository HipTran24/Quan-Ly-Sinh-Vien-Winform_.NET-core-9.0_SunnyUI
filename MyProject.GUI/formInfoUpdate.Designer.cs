namespace MyProject.GUI
{
    partial class formInfoUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInfoUpdate));
            btnChooseImg = new Button();
            label3 = new Label();
            label2 = new Label();
            picImage = new PictureBox();
            rtbContent = new RichTextBox();
            tbTitle = new TextBox();
            label1 = new Label();
            btnUp = new Button();
            button1 = new Button();
            lblAdmin = new Label();
            lblDateUp = new Label();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // btnChooseImg
            // 
            btnChooseImg.Anchor = AnchorStyles.Top;
            btnChooseImg.BackColor = Color.Transparent;
            btnChooseImg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChooseImg.Location = new Point(588, 51);
            btnChooseImg.Margin = new Padding(2);
            btnChooseImg.Name = "btnChooseImg";
            btnChooseImg.Size = new Size(122, 27);
            btnChooseImg.TabIndex = 38;
            btnChooseImg.Text = "Chọn ảnh";
            btnChooseImg.UseVisualStyleBackColor = false;
            btnChooseImg.Click += btnChooseImg_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 265);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 44;
            label3.Text = "Nội dung bài viết";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 81);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 43;
            label2.Text = "Ảnh bài viết";
            // 
            // picImage
            // 
            picImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(82, 97);
            picImage.Margin = new Padding(2);
            picImage.Name = "picImage";
            picImage.Size = new Size(628, 143);
            picImage.TabIndex = 42;
            picImage.TabStop = false;
            // 
            // rtbContent
            // 
            rtbContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbContent.Location = new Point(82, 287);
            rtbContent.Margin = new Padding(2);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(629, 208);
            rtbContent.TabIndex = 41;
            rtbContent.Text = "";
            // 
            // tbTitle
            // 
            tbTitle.Anchor = AnchorStyles.Top;
            tbTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(202, 47);
            tbTitle.Margin = new Padding(2);
            tbTitle.Name = "tbTitle";
            tbTitle.PlaceholderText = "Nhập tiêu đề";
            tbTitle.Size = new Size(374, 34);
            tbTitle.TabIndex = 40;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 39;
            label1.Text = "Thông Tin Bài Viết";
            // 
            // btnUp
            // 
            btnUp.BackColor = Color.Transparent;
            btnUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUp.Location = new Point(588, 526);
            btnUp.Margin = new Padding(2);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(122, 27);
            btnUp.TabIndex = 45;
            btnUp.Text = "Đăng bài";
            btnUp.UseVisualStyleBackColor = false;
            btnUp.Click += btnUp_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(446, 526);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(122, 27);
            button1.TabIndex = 46;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Location = new Point(10, 518);
            lblAdmin.Margin = new Padding(2, 0, 2, 0);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(0, 20);
            lblAdmin.TabIndex = 48;
            // 
            // lblDateUp
            // 
            lblDateUp.AutoSize = true;
            lblDateUp.Location = new Point(10, 550);
            lblDateUp.Margin = new Padding(2, 0, 2, 0);
            lblDateUp.Name = "lblDateUp";
            lblDateUp.Size = new Size(0, 20);
            lblDateUp.TabIndex = 49;
            // 
            // formInfoUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 603);
            Controls.Add(lblDateUp);
            Controls.Add(lblAdmin);
            Controls.Add(button1);
            Controls.Add(btnUp);
            Controls.Add(btnChooseImg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(picImage);
            Controls.Add(rtbContent);
            Controls.Add(tbTitle);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "formInfoUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin bài viết";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChooseImg;
        private Label label3;
        private Label label2;
        public PictureBox picImage;
        public RichTextBox rtbContent;
        public TextBox tbTitle;
        private Label label1;
        private Button btnUp;
        private Button button1;
        private Label lblAdmin;
        private Label lblDateUp;
    }
}