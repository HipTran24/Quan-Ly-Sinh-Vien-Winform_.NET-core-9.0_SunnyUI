// formMainStudent.Designer.cs
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class formMainStudent
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private UIPanel pnlHeader;
        private PictureBox picBanner;
        private UIPanel pnlHeaderLeft;
        private UILabel lblUser;
        private UILabel lblName;

        // Left menu
        private UIPanel pnlLeft;
        private UINavMenu uiNavMenu;

        // Content
        private UIPanel pnlPost;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainStudent));
            TreeNode treeNode15 = new TreeNode("Trang chủ");
            TreeNode treeNode16 = new TreeNode("Thời khóa biểu");
            TreeNode treeNode17 = new TreeNode("Điểm");
            TreeNode treeNode18 = new TreeNode("Thông tin phần mềm");
            TreeNode treeNode19 = new TreeNode("Thay đổi thông tin");
            TreeNode treeNode20 = new TreeNode("Đăng xuất");
            TreeNode treeNode21 = new TreeNode("Tài khoản", new TreeNode[] { treeNode19, treeNode20 });
            pnlHeader = new UIPanel();
            picBanner = new PictureBox();
            pnlHeaderLeft = new UIPanel();
            lblName = new UILabel();
            lblUser = new UILabel();
            pnlLeft = new UIPanel();
            uiNavMenu = new UINavMenu();
            pnlPost = new UIPanel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBanner).BeginInit();
            pnlHeaderLeft.SuspendLayout();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(picBanner);
            pnlHeader.Controls.Add(pnlHeaderLeft);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.FillColor = Color.White;
            pnlHeader.Font = new Font("Microsoft Sans Serif", 12F);
            pnlHeader.Location = new Point(2, 36);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.MinimumSize = new Size(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(8);
            pnlHeader.Size = new Size(1371, 110);
            pnlHeader.Style = UIStyle.Custom;
            pnlHeader.TabIndex = 2;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // picBanner
            // 
            picBanner.BackColor = Color.White;
            picBanner.Image = (Image)resources.GetObject("picBanner.Image");
            picBanner.Location = new Point(252, 8);
            picBanner.Name = "picBanner";
            picBanner.Size = new Size(1116, 94);
            picBanner.SizeMode = PictureBoxSizeMode.Zoom;
            picBanner.TabIndex = 0;
            picBanner.TabStop = false;
            // 
            // pnlHeaderLeft
            // 
            pnlHeaderLeft.Controls.Add(lblName);
            pnlHeaderLeft.Controls.Add(lblUser);
            pnlHeaderLeft.FillColor = Color.Transparent;
            pnlHeaderLeft.Font = new Font("Microsoft Sans Serif", 12F);
            pnlHeaderLeft.Location = new Point(4, 8);
            pnlHeaderLeft.Margin = new Padding(4, 5, 4, 5);
            pnlHeaderLeft.MinimumSize = new Size(1, 1);
            pnlHeaderLeft.Name = "pnlHeaderLeft";
            pnlHeaderLeft.RectColor = Color.Silver;
            pnlHeaderLeft.Size = new Size(240, 94);
            pnlHeaderLeft.Style = UIStyle.Custom;
            pnlHeaderLeft.TabIndex = 1;
            pnlHeaderLeft.Text = null;
            pnlHeaderLeft.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(48, 48, 48);
            lblName.Location = new Point(17, 50);
            lblName.Name = "lblName";
            lblName.Padding = new Padding(0, 2, 0, 0);
            lblName.Size = new Size(142, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Trần Thanh Hiệp";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(48, 48, 48);
            lblUser.Location = new Point(17, 17);
            lblUser.Name = "lblUser";
            lblUser.Padding = new Padding(0, 2, 0, 0);
            lblUser.Size = new Size(129, 25);
            lblUser.TabIndex = 1;
            lblUser.Text = "User: Sinh viên";
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(uiNavMenu);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.FillColor = Color.FromArgb(45, 45, 45);
            pnlLeft.Font = new Font("Microsoft Sans Serif", 12F);
            pnlLeft.Location = new Point(2, 146);
            pnlLeft.Margin = new Padding(4, 5, 4, 5);
            pnlLeft.MinimumSize = new Size(1, 1);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(8);
            pnlLeft.Size = new Size(244, 727);
            pnlLeft.Style = UIStyle.Custom;
            pnlLeft.TabIndex = 1;
            pnlLeft.Text = null;
            pnlLeft.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiNavMenu
            // 
            uiNavMenu.BorderStyle = BorderStyle.None;
            uiNavMenu.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            uiNavMenu.Font = new Font("Segoe UI", 10F);
            uiNavMenu.FullRowSelect = true;
            uiNavMenu.HotTracking = true;
            uiNavMenu.ItemHeight = 42;
            uiNavMenu.Location = new Point(8, 8);
            uiNavMenu.Name = "uiNavMenu";
            treeNode15.Name = "";
            treeNode15.Text = "Trang chủ";
            treeNode16.Name = "";
            treeNode16.Text = "Thời khóa biểu";
            treeNode17.Name = "";
            treeNode17.Text = "Điểm";
            treeNode18.Name = "";
            treeNode18.Text = "Thông tin phần mềm";
            treeNode19.Name = "";
            treeNode19.Text = "Thay đổi thông tin";
            treeNode20.Name = "";
            treeNode20.Text = "Đăng xuất";
            treeNode21.Name = "";
            treeNode21.Text = "Tài khoản";
            uiNavMenu.Nodes.AddRange(new TreeNode[] { treeNode15, treeNode16, treeNode17, treeNode18, treeNode21 });
            uiNavMenu.ShowLines = false;
            uiNavMenu.ShowPlusMinus = false;
            uiNavMenu.ShowRootLines = false;
            uiNavMenu.Size = new Size(236, 538);
            uiNavMenu.Style = UIStyle.Custom;
            uiNavMenu.TabIndex = 0;
            uiNavMenu.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // pnlPost
            // 
            pnlPost.BackColor = Color.White;
            pnlPost.Font = new Font("Microsoft Sans Serif", 12F);
            pnlPost.Location = new Point(246, 146);
            pnlPost.Margin = new Padding(4, 5, 4, 5);
            pnlPost.MinimumSize = new Size(1, 1);
            pnlPost.Name = "pnlPost";
            pnlPost.Padding = new Padding(12);
            pnlPost.Size = new Size(1127, 727);
            pnlPost.Style = UIStyle.Custom;
            pnlPost.TabIndex = 0;
            pnlPost.Text = null;
            pnlPost.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // formMainStudent
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1375, 875);
            Controls.Add(pnlPost);
            Controls.Add(pnlLeft);
            Controls.Add(pnlHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1100, 650);
            Name = "formMainStudent";
            Padding = new Padding(2, 36, 2, 2);
            Resizable = true;
            ShowDragStretch = true;
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Sinh viên";
            TitleFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            ZoomScaleRect = new Rectangle(19, 19, 1202, 702);
            Load += formMainStudent_Load;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBanner).EndInit();
            pnlHeaderLeft.ResumeLayout(false);
            pnlHeaderLeft.PerformLayout();
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
