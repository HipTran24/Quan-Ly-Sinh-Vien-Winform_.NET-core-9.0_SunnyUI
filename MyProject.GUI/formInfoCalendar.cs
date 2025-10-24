using Microsoft.VisualBasic;
using MyProject.BLL;
using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class formInfoCalendar : Form
    {
        private readonly CalendarBLL _calendarBLL = new CalendarBLL();
        private readonly string mode;
        public formInfoCalendar(string mode, string maMH = "", string maGV = "",
                                DateOnly? ngay = null, string tietHoc = "", string phongHoc = "")
        {
            InitializeComponent();
            this.mode = mode;
            btnConfirm.Text = mode == "add" ? "Thêm" : "Cập nhật";

            if (mode == "edit")
            {
                tbIDSub.Text = maMH;
                tbIDLec.Text = maGV;
                dtpCalen.Value = ngay.HasValue
                    ? ngay.Value.ToDateTime(TimeOnly.MinValue)
                    : DateTime.Now;
                tbPeriods.Text = tietHoc;
                tbNumR.Text = phongHoc;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrWhiteSpace(tbIDSub.Text) ||
                    string.IsNullOrWhiteSpace(tbIDLec.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ mã môn học và mã giảng viên!",
                        "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng Calendar
                var calendar = new Calendars
                {
                    MaMH = tbIDSub.Text.Trim(),
                    MaGV = tbIDLec.Text.Trim(),
                    Ngay = DateOnly.FromDateTime(dtpCalen.Value),
                    TietHoc = tbPeriods.Text.Trim(),
                    PhongHoc = tbNumR.Text.Trim()
                };

                // Thực hiện thêm hoặc cập nhật
                if (mode == "add")
                    _calendarBLL.Add(calendar);
                else
                    _calendarBLL.Update(calendar);

                MessageBox.Show("Lưu lịch giảng dạy thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu lịch giảng dạy: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formInfoCalendar_Load(object sender, EventArgs e)
        {
            // Đặt ngôn ngữ hiển thị cho DateTimePicker
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("vi-VN");
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("vi-VN");

            // Định dạng ngày tháng
            dtpCalen.Format = DateTimePickerFormat.Custom;
            dtpCalen.CustomFormat = "dd/MM/yyyy"; // hoặc "dddd, dd MMMM yyyy" để hiện thứ + tháng
        }
    }
}
