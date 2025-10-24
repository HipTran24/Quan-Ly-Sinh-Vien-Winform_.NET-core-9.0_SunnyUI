using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class ucUpdateInfo
    {
        private System.ComponentModel.IContainer components = null;
        private UISymbolButton btnUp;
        private UIPanel pnlControl;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnUp = new UISymbolButton();
            pnlControl = new UIPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowPanel = new FlowLayoutPanel();
            pnlControl.SuspendLayout();
            SuspendLayout();
            // 
            // btnUp
            // 
            btnUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUp.Location = new Point(3, 3);
            btnUp.MinimumSize = new Size(1, 1);
            btnUp.Name = "btnUp";
            btnUp.Radius = 20;
            btnUp.Size = new Size(200, 38);
            btnUp.Symbol = 61543;
            btnUp.TabIndex = 0;
            btnUp.Text = "Đăng bài";
            btnUp.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnUp.Click += btnUp_Click;
            // 
            // pnlControl
            // 
            pnlControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlControl.Controls.Add(btnUp);
            pnlControl.Controls.Add(flowLayoutPanel1);
            pnlControl.FillColor = Color.White;
            pnlControl.Font = new Font("Microsoft Sans Serif", 12F);
            pnlControl.Location = new Point(0, 0);
            pnlControl.Margin = new Padding(4, 5, 4, 5);
            pnlControl.MinimumSize = new Size(1, 1);
            pnlControl.Name = "pnlControl";
            pnlControl.Padding = new Padding(12);
            pnlControl.Radius = 10;
            pnlControl.RectColor = Color.Gainsboro;
            pnlControl.Size = new Size(1098, 48);
            pnlControl.Style = UIStyle.Custom;
            pnlControl.TabIndex = 1;
            pnlControl.Text = null;
            pnlControl.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Visible = false;
            // 
            // flowPanel
            // 
            flowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.White;
            flowPanel.Location = new Point(0, 48);
            flowPanel.Name = "flowPanel";
            flowPanel.Padding = new Padding(12);
            flowPanel.Size = new Size(1098, 565);
            flowPanel.TabIndex = 0;
            // 
            // ucUpdateInfo
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(flowPanel);
            Controls.Add(pnlControl);
            Name = "ucUpdateInfo";
            Size = new Size(1098, 613);
            Load += ucUpdateInfo_Load;
            pnlControl.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
