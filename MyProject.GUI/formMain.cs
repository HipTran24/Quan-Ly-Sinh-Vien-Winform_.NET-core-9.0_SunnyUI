using MyProject.BLL;
using MyProject.BLL.Auth;
using MyProject.BLL.Service;
using Sunny.UI;
using System;
using System.IO;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class formMain : UIForm
    {
        private readonly UserBLL _userBLL = new UserBLL();

        public formMain()
        {
            InitializeComponent();
            this.Load += formMain_Load;
        }

        private void formMain_Load(object? sender, EventArgs e)
        {
            LoadControl(new ucEvaluate());
            RefreshUserBox();
        }
        private void RefreshUserBox()
        {
            var u = AuthContextService.CurrentUser;
            if (u == null)
            {
                lblAccount.Text = "User: N/A";
                lblID.Text = "ID: N/A";
                return;
            }
            lblAccount.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblID.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            lblAccount.Text = $"User: {u.Username}";

            var fresh = _userBLL.GetAllUser()
                                .FirstOrDefault(x => x.Username != null &&
                                                     x.Username.Equals(u.Username, StringComparison.OrdinalIgnoreCase));

            string? adminId =
                  fresh?.AdminID
               ?? (fresh?.GetType().GetProperty("IDAdmin")?.GetValue(fresh)?.ToString())
               ?? (fresh?.GetType().GetProperty("AdminID")?.GetValue(fresh)?.ToString());

            if (string.IsNullOrWhiteSpace(adminId))
                adminId = u.AdminID 
                       ?? u.Username; 

            string role = (fresh?.Role ?? u.Role ?? "").Trim().ToLowerInvariant();

            if (role == "admin")
                lblID.Text = $"IDAdmin: {adminId}";
            else if (role is "lecturer" or "gv" or "giangvien")
                lblID.Text = $"IDGiangVien: {fresh?.MaGV ?? u.MaGV ?? "N/A"}";
            else if (role is "student" or "sv" or "sinhvien")
                lblID.Text = $"IDSinhVien: {fresh?.MaSV ?? u.MaSV ?? "N/A"}";
            else
                lblID.Text = $"ID: {adminId}";
        }
        

        private void LoadControl(UserControl uc)
        {
            pnlEvaluate.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlEvaluate.Controls.Add(uc);
        }

        private void uiNavMenu_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {
            var text = item?.Text?.Trim() ?? node?.Text?.Trim() ?? string.Empty;

            switch (text)
            {
                case "Trang chủ": MenuItemMain_Click(this, EventArgs.Empty); break;

                case "Khoa": MenuItemFaculty_Click(this, EventArgs.Empty); break;
                case "Sinh viên": MenuItemStudents_Click(this, EventArgs.Empty); break;
                case "Môn học": MenuItemSubject_Click(this, EventArgs.Empty); break;
                case "Cập nhật điểm": MenuItemScore_Click(this, EventArgs.Empty); break;
                case "Giảng viên": MenuItemLecturers_Click(this, EventArgs.Empty); break;
                case "Lịch giảng dạy": MenuItemCalendar_Click(this, EventArgs.Empty); break;

                case "Cập nhật tài khoản": MenuItemUpdateAccount_Click(this, EventArgs.Empty); break;
                case "Cập nhật thông tin": MenuItemUpdateInfo_Click(this, EventArgs.Empty); break;

                case "Danh sách giảng viên": MenuItemExportLecturers_Click(this, EventArgs.Empty); break;
                case "Danh sách sinh viên": MenuItemExportStudents_Click(this, EventArgs.Empty); break;
                case "Danh sách điểm": MenuItemExportScores_Click(this, EventArgs.Empty); break;

                case "Thông tin phần mềm": MenuItemSwInfo_Click(this, EventArgs.Empty); break;
                case "Đăng xuất": MenuItemLogout_Click(this, EventArgs.Empty); break;
            }
        }

        private void MenuItemMain_Click(object? sender, EventArgs e) => LoadControl(new ucEvaluate());
        private void MenuItemFaculty_Click(object? sender, EventArgs e) => LoadControl(new ucFaculty());
        private void MenuItemStudents_Click(object? sender, EventArgs e) => LoadControl(new ucStudents());
        private void MenuItemSubject_Click(object? sender, EventArgs e) => LoadControl(new ucSubject());
        private void MenuItemScore_Click(object? sender, EventArgs e) => LoadControl(new ucScore());
        private void MenuItemLecturers_Click(object? sender, EventArgs e) => LoadControl(new ucLecturers());
        private void MenuItemCalendar_Click(object? sender, EventArgs e) => LoadControl(new ucCalendar());
        private void MenuItemUpdateAccount_Click(object? sender, EventArgs e) => LoadControl(new ucUpdateAccount());
        private void MenuItemUpdateInfo_Click(object? sender, EventArgs e) => LoadControl(new ucUpdateInfo());
        private void MenuItemSwInfo_Click(object? sender, EventArgs e)
        {
            using var fInfo = new formSoftWareInfo();
            fInfo.ShowDialog(this);
        }

        private void MenuItemExportLecturers_Click(object? sender, EventArgs e) => ExportWithDialog("GiangVien");
        private void MenuItemExportStudents_Click(object? sender, EventArgs e) => ExportWithDialog("SinhVien");
        private void MenuItemExportScores_Click(object? sender, EventArgs e) => ExportWithDialog("BangDiem");

        private void ExportWithDialog(string type)
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = $"Chọn thư mục để lưu file danh sách {type}"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            string fileName = $"DanhSach_{type}_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";
            string path = Path.Combine(dialog.SelectedPath, fileName);

            var exporter = new ExcelExportService();

            try
            {
                switch (type)
                {
                    case "GiangVien": exporter.ExportLecturersOnly(path); break;
                    case "SinhVien": exporter.ExportStudentsOnly(path); break;
                    case "BangDiem": exporter.ExportScoresOnly(path); break;
                }

                MessageBox.Show(this, $"✅ Xuất thành công!\nĐường dẫn: {path}",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path)
                    {
                        UseShellExecute = true
                    });
                }
                catch { /* ignore open error */ }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "❌ Lỗi khi xuất Excel: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemLogout_Click(object? sender, EventArgs e)
        {
            AuthContextService.SignOut();
            this.DialogResult = DialogResult.Retry; 
            this.Close();
        }

    }
}
