using System.Drawing;
using System.Windows.Forms;

namespace MyProject.GUI
{
    partial class formLogin
    {
        private System.ComponentModel.IContainer components = null;

        // GIỮ NGUYÊN TÊN NHƯ CODE-BEHIND
        private Panel panelMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            panelMain = new Panel();
            pictureBox1 = new PictureBox();
            txbUser = new TextBox();
            txbPass = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(txbUser);
            panelMain.Controls.Add(txbPass);
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(linkLabel1);
            panelMain.Controls.Add(pictureBox2);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(24);
            panelMain.Size = new Size(533, 444);
            panelMain.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(212, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txbUser
            // 
            txbUser.Anchor = AnchorStyles.Top;
            txbUser.Font = new Font("Segoe UI", 10F);
            txbUser.Location = new Point(147, 223);
            txbUser.Name = "txbUser";
            txbUser.PlaceholderText = "Tên đăng nhập";
            txbUser.Size = new Size(233, 30);
            txbUser.TabIndex = 11;
            // 
            // txbPass
            // 
            txbPass.Anchor = AnchorStyles.Top;
            txbPass.Font = new Font("Segoe UI", 10F);
            txbPass.Location = new Point(147, 279);
            txbPass.Name = "txbPass";
            txbPass.PlaceholderText = "Mật khẩu";
            txbPass.Size = new Size(233, 30);
            txbPass.TabIndex = 12;
            txbPass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(80, 160, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(200, 324);
            button1.Name = "button1";
            button1.Size = new Size(120, 42);
            button1.TabIndex = 13;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(100, 150, 255);
            linkLabel1.Anchor = AnchorStyles.Top;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.InactiveBorder;
            linkLabel1.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(80, 120, 200);
            linkLabel1.Location = new Point(197, 384);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(126, 21);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(533, 444);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(532, 442);
            Controls.Add(panelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += formLogin_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txbUser;
        private TextBox txbPass;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}
