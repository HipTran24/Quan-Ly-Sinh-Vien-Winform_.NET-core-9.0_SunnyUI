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
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 32);
            label1.TabIndex = 0;
            label1.Text = "Thông tin phần mềm";
            // 
            // InfoDisplay
            // 
            InfoDisplay.Location = new Point(12, 93);
            InfoDisplay.Name = "InfoDisplay";
            InfoDisplay.ReadOnly = true;
            InfoDisplay.Size = new Size(549, 334);
            InfoDisplay.TabIndex = 2;
            InfoDisplay.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 3;
            label2.Text = "Tên phần mềm: ";
            // 
            // lbNameSoftware
            // 
            lbNameSoftware.AutoSize = true;
            lbNameSoftware.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNameSoftware.Location = new Point(148, 65);
            lbNameSoftware.Name = "lbNameSoftware";
            lbNameSoftware.Size = new Size(63, 25);
            lbNameSoftware.TabIndex = 4;
            lbNameSoftware.Text = "label3";
            // 
            // formSoftWareInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(573, 436);
            Controls.Add(lbNameSoftware);
            Controls.Add(label2);
            Controls.Add(InfoDisplay);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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