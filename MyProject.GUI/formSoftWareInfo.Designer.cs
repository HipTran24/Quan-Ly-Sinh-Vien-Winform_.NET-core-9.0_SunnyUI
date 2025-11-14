using LiveChartsCore.Measure;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyProject.GUI
{
    partial class formSoftWareInfo
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(formSoftWareInfo));
            label1 = new Label();
            InfoDisplay = new RichTextBox();
            label2 = new Label();
            lbNameSoftware = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin phần mềm";
            // 
            // InfoDisplay
            // 
            InfoDisplay.Location = new Point(10, 74);
            InfoDisplay.Margin = new Padding(2);
            InfoDisplay.Name = "InfoDisplay";
            InfoDisplay.ReadOnly = true;
            InfoDisplay.Size = new Size(440, 268);
            InfoDisplay.TabIndex = 2;
            InfoDisplay.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên phần mềm: ";
            // 
            // lbNameSoftware
            // 
            lbNameSoftware.AutoSize = true;
            lbNameSoftware.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameSoftware.Location = new Point(125, 52);
            lbNameSoftware.Margin = new Padding(2, 0, 2, 0);
            lbNameSoftware.Name = "lbNameSoftware";
            lbNameSoftware.Size = new Size(51, 20);
            lbNameSoftware.TabIndex = 4;
            lbNameSoftware.Text = "label3";
            // 
            // formSoftWareInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(458, 349);
            Controls.Add(lbNameSoftware);
            Controls.Add(label2);
            Controls.Add(InfoDisplay);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "formSoftWareInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin phần mềm";
            Load += formSoftWareInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox InfoDisplay;
        private Label label2;
        private Label lbNameSoftware;
    }
}