using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;

namespace MyProject.GUI
{
    partial class ucUpdateAccount
    {
        private System.ComponentModel.IContainer components = null;
        private UIDataGridView UserAccountDisplay;
        private UIPanel panelBottom;
        private UISymbolButton btnUpdate;
        private UISymbolButton btnDelete;
        private UISymbolButton btnChange;
        private UISymbolButton btnAdd;

        // Top search
        private UIPanel panelSearch;
        private UITextBox tbSearch;          // giữ nguyên tên để code-behind dùng như cũ
        private UISymbolButton btnSearch;    // giữ nguyên tên

        // Columns
        private DataGridViewTextBoxColumn ColUsername;
        private DataGridViewTextBoxColumn ColPassword;
        private DataGridViewTextBoxColumn ColRole;
        private DataGridViewTextBoxColumn ColMaSV;
        private DataGridViewTextBoxColumn ColMaGV;
        private DataGridViewTextBoxColumn ColIDAdmin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panelSearch = new UIPanel();
            tbSearch = new UITextBox();
            btnSearch = new UISymbolButton();
            UserAccountDisplay = new UIDataGridView();
            ColUsername = new DataGridViewTextBoxColumn();
            ColPassword = new DataGridViewTextBoxColumn();
            ColRole = new DataGridViewTextBoxColumn();
            ColMaSV = new DataGridViewTextBoxColumn();
            ColMaGV = new DataGridViewTextBoxColumn();
            ColIDAdmin = new DataGridViewTextBoxColumn();
            panelBottom = new UIPanel();
            btnUpdate = new UISymbolButton();
            btnDelete = new UISymbolButton();
            btnChange = new UISymbolButton();
            btnAdd = new UISymbolButton();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserAccountDisplay).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(tbSearch);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.FillColor = Color.White;
            panelSearch.Font = new Font("Microsoft Sans Serif", 12F);
            panelSearch.Location = new Point(0, 0);
            panelSearch.Margin = new Padding(4, 5, 4, 5);
            panelSearch.MinimumSize = new Size(1, 1);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(12, 8, 12, 8);
            panelSearch.Size = new Size(1099, 52);
            panelSearch.Style = UIStyle.Custom;
            panelSearch.TabIndex = 1;
            panelSearch.Text = null;
            panelSearch.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tbSearch
            // 
            tbSearch.FillColor = Color.FromArgb(248, 248, 248);
            tbSearch.Font = new Font("Segoe UI", 10F);
            tbSearch.Location = new Point(12, 8);
            tbSearch.Margin = new Padding(4, 5, 4, 5);
            tbSearch.MinimumSize = new Size(1, 1);
            tbSearch.Name = "tbSearch";
            tbSearch.Padding = new Padding(5);
            tbSearch.RectColor = Color.Silver;
            tbSearch.ShowText = false;
            tbSearch.Size = new Size(320, 36);
            tbSearch.TabIndex = 0;
            tbSearch.TextAlignment = ContentAlignment.MiddleLeft;
            tbSearch.Watermark = "Nhập ID User";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F);
            btnSearch.Location = new Point(344, 8);
            btnSearch.MinimumSize = new Size(1, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 36);
            btnSearch.Symbol = 61442;
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSearch.Click += btnSearch_Click;
            // 
            // UserAccountDisplay
            // 
            UserAccountDisplay.AllowUserToAddRows = false;
            UserAccountDisplay.AllowUserToDeleteRows = false;
            UserAccountDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            UserAccountDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            UserAccountDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserAccountDisplay.BackgroundColor = Color.White;
            UserAccountDisplay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UserAccountDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UserAccountDisplay.ColumnHeadersHeight = 34;
            UserAccountDisplay.Columns.AddRange(new DataGridViewColumn[] { ColUsername, ColPassword, ColRole, ColMaSV, ColMaGV, ColIDAdmin });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(225, 235, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UserAccountDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            UserAccountDisplay.Dock = DockStyle.Fill;
            UserAccountDisplay.EnableHeadersVisualStyles = false;
            UserAccountDisplay.Font = new Font("Microsoft Sans Serif", 12F);
            UserAccountDisplay.GridColor = Color.FromArgb(204, 204, 204);
            UserAccountDisplay.Location = new Point(0, 52);
            UserAccountDisplay.MultiSelect = false;
            UserAccountDisplay.Name = "UserAccountDisplay";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            UserAccountDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            UserAccountDisplay.RowHeadersVisible = false;
            UserAccountDisplay.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            UserAccountDisplay.RowsDefaultCellStyle = dataGridViewCellStyle5;
            UserAccountDisplay.SelectedIndex = -1;
            UserAccountDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserAccountDisplay.Size = new Size(1099, 513);
            UserAccountDisplay.StripeOddColor = Color.White;
            UserAccountDisplay.Style = UIStyle.Custom;
            UserAccountDisplay.TabIndex = 2;
            // 
            // ColUsername
            // 
            ColUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColUsername.DataPropertyName = "Username";
            ColUsername.HeaderText = "Tài khoản";
            ColUsername.MinimumWidth = 140;
            ColUsername.Name = "ColUsername";
            // 
            // ColPassword
            // 
            ColPassword.DataPropertyName = "Password";
            ColPassword.HeaderText = "Mật khẩu";
            ColPassword.MinimumWidth = 120;
            ColPassword.Name = "ColPassword";
            // 
            // ColRole
            // 
            ColRole.DataPropertyName = "Role";
            ColRole.HeaderText = "Vai trò";
            ColRole.MinimumWidth = 120;
            ColRole.Name = "ColRole";
            // 
            // ColMaSV
            // 
            ColMaSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMaSV.DataPropertyName = "MaSV";
            ColMaSV.HeaderText = "Mã sinh viên";
            ColMaSV.MinimumWidth = 160;
            ColMaSV.Name = "ColMaSV";
            // 
            // ColMaGV
            // 
            ColMaGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColMaGV.DataPropertyName = "MaGV";
            ColMaGV.HeaderText = "Mã giảng viên";
            ColMaGV.MinimumWidth = 160;
            ColMaGV.Name = "ColMaGV";
            // 
            // ColIDAdmin
            // 
            ColIDAdmin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColIDAdmin.DataPropertyName = "AdminID";
            ColIDAdmin.HeaderText = "ID Admin";
            ColIDAdmin.MinimumWidth = 140;
            ColIDAdmin.Name = "ColIDAdmin";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnUpdate);
            panelBottom.Controls.Add(btnDelete);
            panelBottom.Controls.Add(btnChange);
            panelBottom.Controls.Add(btnAdd);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.FillColor = Color.White;
            panelBottom.Font = new Font("Microsoft Sans Serif", 12F);
            panelBottom.Location = new Point(0, 565);
            panelBottom.Margin = new Padding(4, 5, 4, 5);
            panelBottom.MinimumSize = new Size(1, 1);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8, 6, 8, 6);
            panelBottom.Size = new Size(1099, 48);
            panelBottom.Style = UIStyle.Custom;
            panelBottom.TabIndex = 3;
            panelBottom.Text = null;
            panelBottom.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F);
            btnUpdate.Location = new Point(630, 6);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 32);
            btnUpdate.Symbol = 61473;
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Location = new Point(746, 6);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 32);
            btnDelete.Symbol = 61944;
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChange.Font = new Font("Microsoft Sans Serif", 12F);
            btnChange.Location = new Point(862, 6);
            btnChange.MinimumSize = new Size(1, 1);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(110, 32);
            btnChange.Symbol = 61459;
            btnChange.TabIndex = 1;
            btnChange.Text = "Thay đổi";
            btnChange.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnChange.Click += btnChange_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdd.Location = new Point(978, 6);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 32);
            btnAdd.Symbol = 61543;
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdd.Click += btnAdd_Click;
            // 
            // ucUpdateAccount
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(UserAccountDisplay);
            Controls.Add(panelBottom);
            Controls.Add(panelSearch);
            Name = "ucUpdateAccount";
            Size = new Size(1099, 613);
            Load += ucUpdateAccount_Load;
            panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserAccountDisplay).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
