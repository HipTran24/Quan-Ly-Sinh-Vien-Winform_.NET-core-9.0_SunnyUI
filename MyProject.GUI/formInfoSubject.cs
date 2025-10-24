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
    public partial class formInfoSubject : Form
    {
        private string mode;
        private readonly SubjectsBLL _subjectBLL;
        public formInfoSubject(string mode,
                                string maMH = "",
                                string tenMH = "",
                                int soTinChi = 0,
                                int soTiet = 0,
                                DateOnly? ngayBatDau = null,
                                DateOnly? ngayKetThuc = null,
                                string maKhoa = "")
        {
            InitializeComponent();
            this.mode = mode;
            _subjectBLL = new SubjectsBLL();
            if (mode == "add")
            {
                btnConfirm.Text = "Thêm";
            }
            else if (mode == "edit")
            {
                tbIdSubject.Text = maMH;
                tbName.Text = tenMH;
                numQuantity.Value = soTinChi;
                numLessons.Value = soTiet;
                dtpStart.Value = ngayBatDau.HasValue
                    ? ngayBatDau.Value.ToDateTime(TimeOnly.MinValue)
                    : DateTime.Now;

                dtpEnd.Value = ngayKetThuc.HasValue
                    ? ngayKetThuc.Value.ToDateTime(TimeOnly.MinValue)
                    : DateTime.Now;
                tbIdFaculty.Text = maKhoa;
                lbformName.Text = "Cập nhập môn học";
                btnConfirm.Text = "Cập nhật";
            }
        }

        private void formInfoSubject_Load(object sender, EventArgs e)
        {
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "dd/MM/yyyy";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "dd/MM/yyyy";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var s = new Subjects
                {
                    MaMH = tbIdSubject.Text,
                    TenMH = tbName.Text,
                    SoTinChi = (int)numQuantity.Value,
                    SoTiet = (int)numLessons.Value,
                    NgayBatDau = DateOnly.FromDateTime(dtpStart.Value),
                    NgayKetThuc = DateOnly.FromDateTime(dtpEnd.Value),
                    MaKhoa = tbIdFaculty.Text.ToString()
                };

                if (mode == "add")
                    _subjectBLL.Add(s);
                else
                    _subjectBLL.Update(s);

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }
    }
}
