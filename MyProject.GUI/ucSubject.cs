using MyProject.BLL;
using MyProject.DAL;
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
    public partial class ucSubject : UserControl
    {
        private readonly SubjectsBLL _subjectBLL;
        public ucSubject()
        {
            InitializeComponent();
            _subjectBLL = new SubjectsBLL();
        }


        private void ucSubject_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var list = db.MonHoc.ToList();
                SubjectDisplay.DataSource = null;
                SubjectDisplay.AutoGenerateColumns = false;
                SubjectDisplay.DataSource = list;
                LoadData();
            }
        }
        private void LoadData()
        {
            var list = _subjectBLL.GetAllSubject();

            SubjectDisplay.DataSource = null;
            SubjectDisplay.DataSource = list;

            SubjectDisplay.Columns["ColNgayBatDau"].DefaultCellStyle.Format = "dd/MM/yyyy";
            SubjectDisplay.Columns["ColNgayKetThuc"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            formInfoSubject f = new formInfoSubject("add");
            f.ShowDialog();
            LoadData();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (SubjectDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa!", "Thông báo");
                return;
            }
            DataGridViewRow row = SubjectDisplay.CurrentRow;
            string maMH = row.Cells["ColMaMH"].Value.ToString();
            string tenMH = row.Cells["ColTenMH"].Value.ToString();
            int soTinChi = Convert.ToInt32(row.Cells["ColSoTinChi"].Value);
            int soTiet = Convert.ToInt32(row.Cells["ColSoTiet"].Value);
            DateOnly ngayBD = DateOnly.Parse(row.Cells["ColNgayBatDau"].Value.ToString());
            DateOnly ngayKT = DateOnly.Parse(row.Cells["ColNgayKetThuc"].Value.ToString());
            string maKhoa = row.Cells["ColMaKhoa"].Value.ToString();

            formInfoSubject f = new formInfoSubject("edit", maMH, tenMH, soTinChi, soTiet, ngayBD, ngayKT, maKhoa);
            f.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SubjectDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!", "Thông báo");
                return;
            }

            string maMH = SubjectDisplay.CurrentRow.Cells["ColMaMH"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa môn học {maMH} và toàn bộ dữ liệu liên quan?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _subjectBLL.Delete(maMH);
                    MessageBox.Show("Đã xóa môn học thành công!", "Thông báo");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
