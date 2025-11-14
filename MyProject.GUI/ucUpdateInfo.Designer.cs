using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class ucUpdateInfo
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel flowPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            flowPanel = new FlowLayoutPanel();
            btnUp = new UISymbolButton();
            pnlHeader = new Panel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.White;
            flowPanel.Location = new Point(0, 48);
            flowPanel.Name = "flowPanel";
            flowPanel.Padding = new Padding(12);
            flowPanel.Size = new Size(1098, 565);
            flowPanel.TabIndex = 0;
            // 
            // btnUp
            // 
            btnUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUp.Location = new Point(3, 6);
            btnUp.MinimumSize = new Size(1, 1);
            btnUp.Name = "btnUp";
            btnUp.Radius = 20;
            btnUp.Size = new Size(206, 36);
            btnUp.Symbol = 61543;
            btnUp.TabIndex = 1;
            btnUp.Text = "Đăng bài";
            btnUp.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnUp.Click += btnUp_Click_1;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnUp);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1098, 49);
            pnlHeader.TabIndex = 2;
            // 
            // ucUpdateInfo
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(pnlHeader);
            Controls.Add(flowPanel);
            Name = "ucUpdateInfo";
            Size = new Size(1098, 613);
            Load += ucUpdateInfo_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }
        private UISymbolButton btnUp;
        private Panel pnlHeader;
    }
}
