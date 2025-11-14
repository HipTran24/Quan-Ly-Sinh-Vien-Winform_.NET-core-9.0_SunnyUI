using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using MyProject.BLL;
using MyProject.BLL.Auth;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyProject.GUI
{
    public partial class ucChangeInfo : UserControl
    {
        private bool _editMode = false;

        private readonly StudentsBLL _studentSvc = new StudentsBLL();
        private readonly LecturersBLL _lecturerSvc = new LecturersBLL();
        public ucChangeInfo()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.Load += ucChangeInfo_Load;
            btnEdit.Click += btnEdit_Click;
            btnUpdate.Click += btnUpdate_Click;
        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var u = AuthContextService.CurrentUser;
            if (u == null)
            {
                MessageBox.Show("Không xác định được người dùng hiện tại.");
                return;
            }

            string name = (tbName.Text ?? "").Trim();
            string email = (tbEmail.Text ?? "").Trim();
            string phone = (tbNumP.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Họ tên không được để trống.");
                tbName.Focus(); return;
            }
            if (!string.IsNullOrWhiteSpace(email) && !email.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ.");
                tbEmail.Focus(); return;
            }

            try
            {
                if (u.lecturers != null && AuthContextService.IsLecturer)
                {
                    var gvId = u.lecturers.MaGV;
                    var dbLecturer = _lecturerSvc.GetById(gvId);
                    if (dbLecturer == null)
                    {
                        MessageBox.Show("Không tìm thấy giảng viên trong CSDL.");
                        return;
                    }

                    dbLecturer.HoTen = name;
                    dbLecturer.Email = email;
                    dbLecturer.SDT = phone;

                    _lecturerSvc.Update(dbLecturer);

                    u.lecturers.HoTen = dbLecturer.HoTen;
                    u.lecturers.Email = dbLecturer.Email;
                    u.lecturers.SDT = dbLecturer.SDT;

                    MessageBox.Show("Đã cập nhật thông tin giảng viên.");
                }
                else if (u.students != null && AuthContextService.IsStudent)
                {
                    DateTime? dob = null;
                    if (!string.IsNullOrWhiteSpace(tbDateB.Text))
                    {
                        if (DateTime.TryParseExact(tbDateB.Text.Trim(), "dd/MM/yyyy",
                            CultureInfo.GetCultureInfo("vi-VN"),
                            DateTimeStyles.None, out var d))
                        {
                            dob = d;
                        }
                        else
                        {
                            MessageBox.Show("Ngày sinh không đúng định dạng dd/MM/yyyy.");
                            tbDateB.Focus(); return;
                        }
                    }

                    string gioiTinh = "";
                    if (cmbSex.SelectedIndex == 0) gioiTinh = "Nam";
                    else if (cmbSex.SelectedIndex == 1) gioiTinh = "Nữ";

                    string diaChi = (tbAddress.Text ?? "").Trim();

                    var svId = u.students.MaSV;
                    var dbStudent = _studentSvc.GetById(svId);
                    if (dbStudent == null)
                    {
                        MessageBox.Show("Không tìm thấy sinh viên trong CSDL.");
                        return;
                    }

                    dbStudent.HoTen = name;
                    dbStudent.Email = email;
                    dbStudent.SDT = phone;
                    if (dob.HasValue)
                        dbStudent.NgaySinh = DateOnly.FromDateTime(dob.Value);

                    dbStudent.GioiTinh = gioiTinh;
                    dbStudent.DiaChi = diaChi;

                    _studentSvc.Update(dbStudent);

                    u.students.HoTen = dbStudent.HoTen;
                    u.students.Email = dbStudent.Email;
                    u.students.SDT = dbStudent.SDT;
                    u.students.NgaySinh = dbStudent.NgaySinh;
                    u.students.GioiTinh = dbStudent.GioiTinh;
                    u.students.DiaChi = dbStudent.DiaChi;

                    MessageBox.Show("Đã cập nhật thông tin sinh viên.");
                }
                else
                {
                    MessageBox.Show("Tài khoản chưa liên kết giảng viên/sinh viên.");
                    return;
                }

                _editMode = false;
                SetEditMode(false);
                SetEditButtonsText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void SetEditButtonsText()
        {
            btnEdit.Text = _editMode ? "Hủy" : "Sửa";
            btnUpdate.Enabled = _editMode;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            _editMode = !_editMode;
            SetEditMode(_editMode);
            SetEditButtonsText();
        }

        private void ucChangeInfo_Load(object sender, EventArgs e)
        {
            BindFromCurrentUser();
            SetEditMode(false);
            _editMode = false;
            SetEditButtonsText();

            if (AuthContextService.IsLecturer)
            {
                HideRowSmart(label4); HideRowSmart(tbDateB);
                HideRowSmart(label5); HideRowSmart(cmbSex);
                HideRowSmart(label6); HideRowSmart(tbAddress);
            }
        }
        public void BindFromCurrentUser()
        {
            var u = AuthContextService.CurrentUser;
            if (u == null) return;

            if (AuthContextService.IsLecturer)
            {
                HideRowSmart(label4);
                HideRowSmart(tbDateB);

                HideRowSmart(label5);
                HideRowSmart(cmbSex);

                HideRowSmart(label6);
                HideRowSmart(tbAddress);
            }

            // ID & Vai trò
            tbID.Text = u.Username ?? "";
            tbRole.Text = AuthContextService.IsLecturer ? "Giảng Viên"
           : AuthContextService.IsStudent ? "Sinh Viên"
           : (AuthContextService.IsAdmin ? "Admin" : "Khác");

            tbName.Text =
                u.lecturers?.HoTen
                ?? u.students?.HoTen
                ?? u.Username
                ?? "";

            tbEmail.Text =
                u.lecturers?.Email
                ?? u.students?.Email
                ?? "";

            tbNumP.Text =
                u.lecturers?.SDT
                ?? u.students?.SDT
                ?? "";

            if (AuthContextService.IsStudent && u.students != null)
            {
                tbDateB.Text = u.students.NgaySinh.ToString("dd/MM/yyyy") ?? "";

                var gt = (u.students.GioiTinh ?? "").Trim();
                if (gt.Equals("Nam", StringComparison.OrdinalIgnoreCase)) cmbSex.SelectedIndex = 0;
                else if (gt.Equals("Nữ", StringComparison.OrdinalIgnoreCase)) cmbSex.SelectedIndex = 1;
                else cmbSex.SelectedIndex = -1;

                tbAddress.Text = u.students.DiaChi ?? "";
            }
            else
            {
                tbDateB.Text = "";
                cmbSex.SelectedIndex = -1;
                tbAddress.Text = "";
            }
        }

        private void SetEditMode(bool enable)
        {
            // luôn chỉ đọc ID/Role
            SetEditable(tbID, false);
            SetEditable(tbRole, false);

            // 3 ô chung
            SetEditable(tbName, enable);
            SetEditable(tbEmail, enable);
            SetEditable(tbNumP, enable);

            // chỉ SV mới được sửa 3 ô này
            bool isStudent = AuthContextService.IsStudent && (AuthContextService.CurrentUser?.students != null);
            SetEditable(tbDateB, enable && isStudent);
            cmbSex.Enabled = enable && isStudent;
            SetEditable(tbAddress, enable && isStudent);

            // Giảng viên: chắc chắn tắt 3 ô này
            if (AuthContextService.IsLecturer)
            {
                SetEditable(tbDateB, false);
                cmbSex.Enabled = false;
                SetEditable(tbAddress, false);
            }

            btnUpdate.Enabled = enable;
        }
        private void HideRowSmart(Control anyCellControl)
        {
            if (anyCellControl == null) return;

            TableLayoutPanel? tlp = null;
            Control anchor = anyCellControl;
            for (Control c = anyCellControl; c != null; c = c.Parent)
            {
                if (c.Parent is TableLayoutPanel t)
                {
                    tlp = t;
                    anchor = c;
                    break;
                }
            }
            if (tlp == null) return;

            int rowIndex = tlp.GetRow(anchor);

            foreach (Control ctrl in tlp.Controls)
            {
                if (tlp.GetRow(ctrl) == rowIndex)
                    ctrl.Visible = false;
            }

            if (rowIndex >= 0 && rowIndex < tlp.RowStyles.Count)
            {
                tlp.RowStyles[rowIndex].Height = 0;
                tlp.RowStyles[rowIndex].SizeType = SizeType.Absolute;
            }
        }
        private static void SetEditable(Control ctrl, bool canEdit)
        {
            if (ctrl == null) return;

            // TextBox chuẩn (TextBox, RichTextBox kế thừa TextBoxBase)
            if (ctrl is TextBoxBase tb)
            {
                tb.ReadOnly = !canEdit;
                tb.Enabled = true;      // luôn bật control
                tb.TabStop = canEdit;
                try { tb.BackColor = canEdit ? Color.White : SystemColors.Control; } catch { }
                return;
            }

            // Sunny.UI UITextBox (nếu bạn dùng Sunny.UI)
            var uiTextBoxType = Type.GetType("Sunny.UI.UITextBox, Sunny.UI");
            if (uiTextBoxType != null && uiTextBoxType.IsInstanceOfType(ctrl))
            {
                var propReadOnly = uiTextBoxType.GetProperty("ReadOnly");
                var propFillColor = uiTextBoxType.GetProperty("FillColor");

                propReadOnly?.SetValue(ctrl, !canEdit);
                ctrl.Enabled = true;
                ctrl.TabStop = canEdit;

                try { propFillColor?.SetValue(ctrl, canEdit ? Color.White : SystemColors.Control); } catch { }
                return;
            }

            // Mặc định cho control khác
            ctrl.Enabled = canEdit;
            ctrl.TabStop = canEdit;
        }


    }
}
