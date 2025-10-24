using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class ucChangeInfo
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panel1;
        private Panel buttonsPanel;                 // giữ panel nút thành field để Resize ngoài init
        private TableLayoutPanel formTable;

        private Label label1;
        private Label label2, label3, label4, label5, label6, label7, label8, label9;

        private TextBox tbID, tbName, tbDateB, tbAddress, tbEmail, tbNumP, tbRole;
        private ComboBox cmbSex;

        private UISymbolButton btnEdit;
        private UISymbolButton btnUpdate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            formTable = new TableLayoutPanel();
            label2 = new Label();
            tbID = new TextBox();
            label3 = new Label();
            tbName = new TextBox();
            tbDateB = new TextBox();
            tbEmail = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            tbNumP = new TextBox();
            cmbSex = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            tbAddress = new TextBox();
            tbRole = new TextBox();
            label1 = new Label();
            buttonsPanel = new Panel();
            btnEdit = new UISymbolButton();
            btnUpdate = new UISymbolButton();
            panel1.SuspendLayout();
            formTable.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(formTable);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonsPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(24);
            panel1.Size = new Size(1099, 613);
            panel1.TabIndex = 0;
            // 
            // formTable
            // 
            formTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            formTable.ColumnCount = 2;
            formTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            formTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formTable.Controls.Add(label2, 0, 0);
            formTable.Controls.Add(tbID, 1, 0);
            formTable.Controls.Add(label3, 0, 1);
            formTable.Controls.Add(tbName, 1, 1);
            formTable.Controls.Add(tbDateB, 1, 5);
            formTable.Controls.Add(tbEmail, 1, 2);
            formTable.Controls.Add(label7, 0, 2);
            formTable.Controls.Add(label4, 0, 5);
            formTable.Controls.Add(label5, 0, 6);
            formTable.Controls.Add(label8, 0, 3);
            formTable.Controls.Add(tbNumP, 1, 3);
            formTable.Controls.Add(cmbSex, 1, 6);
            formTable.Controls.Add(label6, 0, 7);
            formTable.Controls.Add(label9, 0, 4);
            formTable.Controls.Add(tbAddress, 1, 7);
            formTable.Controls.Add(tbRole, 1, 4);
            formTable.Location = new Point(24, 64);
            formTable.Name = "formTable";
            formTable.RowCount = 8;
            formTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            formTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            formTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            formTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            formTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            formTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            formTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            formTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            formTable.Size = new Size(1051, 420);
            formTable.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbID.Location = new Point(223, 10);
            tbID.Name = "tbID";
            tbID.Size = new Size(825, 27);
            tbID.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 62);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ và Tên:";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(223, 58);
            tbName.Name = "tbName";
            tbName.Size = new Size(825, 27);
            tbName.TabIndex = 3;
            // 
            // tbDateB
            // 
            tbDateB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbDateB.Location = new Point(223, 250);
            tbDateB.Name = "tbDateB";
            tbDateB.Size = new Size(825, 27);
            tbDateB.TabIndex = 5;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.Location = new Point(223, 106);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(825, 27);
            tbEmail.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 110);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 10;
            label7.Text = "Email:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 254);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 4;
            label4.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 302);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 6;
            label5.Text = "Giới Tính:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 158);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 12;
            label8.Text = "Số Điện Thoại:";
            // 
            // tbNumP
            // 
            tbNumP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbNumP.Location = new Point(223, 154);
            tbNumP.Name = "tbNumP";
            tbNumP.Size = new Size(825, 27);
            tbNumP.TabIndex = 13;
            // 
            // cmbSex
            // 
            cmbSex.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSex.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cmbSex.Location = new Point(223, 298);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(825, 28);
            cmbSex.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 368);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 8;
            label6.Text = "Địa chỉ:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 206);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 14;
            label9.Text = "Vai Trò:";
            // 
            // tbAddress
            // 
            tbAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbAddress.Location = new Point(223, 364);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(825, 27);
            tbAddress.TabIndex = 9;
            // 
            // tbRole
            // 
            tbRole.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbRole.Location = new Point(223, 202);
            tbRole.Name = "tbRole";
            tbRole.Size = new Size(825, 27);
            tbRole.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 1;
            label1.Text = "Thông Tin Của Bạn";
            // 
            // buttonsPanel
            // 
            buttonsPanel.BackColor = Color.White;
            buttonsPanel.Controls.Add(btnEdit);
            buttonsPanel.Controls.Add(btnUpdate);
            buttonsPanel.Dock = DockStyle.Bottom;
            buttonsPanel.Location = new Point(24, 525);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Padding = new Padding(0, 12, 24, 12);
            buttonsPanel.Size = new Size(1051, 64);
            buttonsPanel.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Microsoft Sans Serif", 12F);
            btnEdit.Location = new Point(789, 12);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 36);
            btnEdit.Symbol = 61459;
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Sửa";
            btnEdit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F);
            btnUpdate.Location = new Point(928, 12);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 36);
            btnUpdate.Symbol = 61473;
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // ucChangeInfo
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "ucChangeInfo";
            Size = new Size(1099, 613);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            formTable.ResumeLayout(false);
            formTable.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        /// <summary>
        /// Mọi style/logic (font, màu, radius, event, resize…) đặt ở đây để Designer không báo lỗi.
        /// Gọi hàm này từ constructor sau InitializeComponent().
        /// </summary>
        private void ApplyStyles()
        {
            // Header
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(40, 40, 40);

            // Labels
            var lbls = new[] { label2, label3, label4, label5, label6, label7, label8, label9 };
            foreach (var lbl in lbls)
            {
                lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                lbl.ForeColor = Color.FromArgb(70, 70, 70);
                lbl.Margin = new Padding(0, 12, 8, 0);
            }

            // TextBoxes
            var tbs = new[] { tbID, tbName, tbDateB, tbAddress, tbEmail, tbNumP, tbRole };
            foreach (var tb in tbs)
            {
                tb.Font = new Font("Segoe UI", 10F);
                tb.Margin = new Padding(0, 8, 0, 0);
            }

            // Combo
            cmbSex.Font = new Font("Segoe UI", 10F);
            cmbSex.Margin = new Padding(0, 8, 0, 0);

            // Buttons (SunnyUI radius & màu)
            btnEdit.Radius = 18;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.FillColor = Color.FromArgb(80, 160, 255);
            btnEdit.RectColor = btnEdit.FillColor;
            btnEdit.ForeColor = Color.White;
            btnEdit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnEdit.Click += btnEdit_Click;

            btnUpdate.Radius = 18;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.FillColor = Color.FromArgb(100, 181, 246);
            btnUpdate.RectColor = btnUpdate.FillColor;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnUpdate.Click += btnUpdate_Click;

            // Căn nút về góc phải dưới (đặt ngoài InitializeComponent để tránh Designer lỗi)
            buttonsPanel.Resize += (s, e) =>
            {
                btnUpdate.Left = buttonsPanel.Width - btnUpdate.Width - 24;
                btnEdit.Left = btnUpdate.Left - btnEdit.Width - 12;
                // giữ cùng cao
                btnEdit.Top = btnUpdate.Top = 12;
            };
            // gọi 1 lần để căn ngay
            buttonsPanel.PerformLayout();
            buttonsPanel.Width = buttonsPanel.Width; // trigger Resize
        }

        // GỌI ApplyStyles trong ctor của partial .cs kia:
        // public ucChangeInfo()
        // {
        //     InitializeComponent();
        //     ApplyStyles();
        // }
    }
}
