using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class formMain
    {
        private System.ComponentModel.IContainer components = null;

        private UIPanel pnlHeader;
        private PictureBox picBanner;
        private UIPanel pnlHeaderLeft;    
        private UILabel lblAccount;
        private UILabel lblID;

        private UIPanel pnlLeft;
        private UINavMenu uiNavMenu;

        private UIPanel pnlEvaluate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            TreeNode treeNode1 = new TreeNode("Trang chủ");
            TreeNode treeNode2 = new TreeNode("Khoa");
            TreeNode treeNode3 = new TreeNode("Sinh viên");
            TreeNode treeNode4 = new TreeNode("Môn học");
            TreeNode treeNode5 = new TreeNode("Cập nhật điểm");
            TreeNode treeNode6 = new TreeNode("Giảng viên");
            TreeNode treeNode7 = new TreeNode("Lịch giảng dạy");
            TreeNode treeNode8 = new TreeNode("Quản lý", new TreeNode[] { treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Cập nhật tài khoản");
            TreeNode treeNode10 = new TreeNode("Cập nhật thông tin");
            TreeNode treeNode11 = new TreeNode("Danh sách giảng viên");
            TreeNode treeNode12 = new TreeNode("Danh sách sinh viên");
            TreeNode treeNode13 = new TreeNode("Danh sách điểm");
            TreeNode treeNode14 = new TreeNode("Xuất báo cáo", new TreeNode[] { treeNode11, treeNode12, treeNode13 });
            TreeNode treeNode15 = new TreeNode("Chức năng", new TreeNode[] { treeNode9, treeNode10, treeNode14 });
            TreeNode treeNode16 = new TreeNode("Thông tin phần mềm");
            TreeNode treeNode18 = new TreeNode("Đăng xuất");
            pnlHeader = new UIPanel();
            picBanner = new PictureBox();
            pnlHeaderLeft = new UIPanel();
            lblID = new UILabel();
            lblAccount = new UILabel();
            pnlLeft = new UIPanel();
            uiNavMenu = new UINavMenu();
            pnlEvaluate = new UIPanel();
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
            pnlHeaderLeft.Controls.Add(lblID);
            pnlHeaderLeft.Controls.Add(lblAccount);
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
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.FromArgb(48, 48, 48);
            lblID.Location = new Point(36, 51);
            lblID.Name = "lblID";
            lblID.Padding = new Padding(0, 2, 0, 0);
            lblID.Size = new Size(82, 25);
            lblID.TabIndex = 0;
            lblID.Text = "IDAdmin";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccount.ForeColor = Color.FromArgb(48, 48, 48);
            lblAccount.Location = new Point(36, 16);
            lblAccount.Name = "lblAccount";
            lblAccount.Padding = new Padding(0, 2, 0, 0);
            lblAccount.Size = new Size(110, 25);
            lblAccount.TabIndex = 1;
            lblAccount.Text = "User: Admin";
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
            treeNode1.Name = "";
            treeNode1.Text = "Trang chủ";
            treeNode2.Name = "";
            treeNode2.Text = "Khoa";
            treeNode3.Name = "";
            treeNode3.Text = "Sinh viên";
            treeNode4.Name = "";
            treeNode4.Text = "Môn học";
            treeNode5.Name = "";
            treeNode5.Text = "Cập nhật điểm";
            treeNode6.Name = "";
            treeNode6.Text = "Giảng viên";
            treeNode7.Name = "";
            treeNode7.Text = "Lịch giảng dạy";
            treeNode8.Name = "";
            treeNode8.Text = "Quản lý";
            treeNode9.Name = "";
            treeNode9.Text = "Cập nhật tài khoản";
            treeNode10.Name = "";
            treeNode10.Text = "Cập nhật thông tin";
            treeNode11.Name = "";
            treeNode11.Text = "Danh sách giảng viên";
            treeNode12.Name = "";
            treeNode12.Text = "Danh sách sinh viên";
            treeNode13.Name = "";
            treeNode13.Text = "Danh sách điểm";
            treeNode14.Name = "";
            treeNode14.Text = "Xuất báo cáo";
            treeNode15.Name = "";
            treeNode15.Text = "Chức năng";
            treeNode16.Name = "";
            treeNode16.Text = "Thông tin phần mềm";
            treeNode18.Name = "";
            treeNode18.Text = "Đăng xuất";
            uiNavMenu.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode8, treeNode15, treeNode16, treeNode18
            });
            uiNavMenu.ShowLines = false;
            uiNavMenu.ShowPlusMinus = false;
            uiNavMenu.ShowRootLines = false;
            uiNavMenu.Size = new Size(236, 711);
            uiNavMenu.Style = UIStyle.Custom;
            uiNavMenu.TabIndex = 0;
            uiNavMenu.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiNavMenu.MenuItemClick += uiNavMenu_MenuItemClick;
            // 
            // pnlEvaluate
            // 
            pnlEvaluate.BackColor = Color.White;
            pnlEvaluate.Dock = DockStyle.Fill;
            pnlEvaluate.Font = new Font("Microsoft Sans Serif", 12F);
            pnlEvaluate.Location = new Point(246, 146);
            pnlEvaluate.Margin = new Padding(4, 5, 4, 5);
            pnlEvaluate.MinimumSize = new Size(1, 1);
            pnlEvaluate.Name = "pnlEvaluate";
            pnlEvaluate.Padding = new Padding(12);
            pnlEvaluate.Size = new Size(1127, 727);
            pnlEvaluate.Style = UIStyle.Custom;
            pnlEvaluate.TabIndex = 0;
            pnlEvaluate.Text = null;
            pnlEvaluate.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1375, 875);
            Controls.Add(pnlEvaluate);
            Controls.Add(pnlLeft);
            Controls.Add(pnlHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(2400, 1275);
            MinimumSize = new Size(1375, 875);
            Name = "formMain";
            Padding = new Padding(2, 36, 2, 2);
            Resizable = true;
            ShowDragStretch = true;
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Quản lý sinh viên";
            TitleFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            ZoomScaleRect = new Rectangle(19, 19, 1525, 925);
            Load += formMain_Load;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBanner).EndInit();
            pnlHeaderLeft.ResumeLayout(false);
            pnlHeaderLeft.PerformLayout();
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
