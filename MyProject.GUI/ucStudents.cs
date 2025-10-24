using MyProject.BLL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class ucStudents : UserControl
    {
        private readonly StudentsBLL _studentBLL;

        public ucStudents()
        {
            InitializeComponent();
            _studentBLL = new StudentsBLL();

        }

        private void ucStudents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Lấy dữ liệu và bind đúng cột
            var list = _studentBLL.GetAllStudents()
                .Select(s => new
                {
                    s.MaSV,
                    s.HoTen,
                    s.MaLop,
                    s.NgaySinh,     // nếu muốn định dạng ngày, làm ở CellFormatting
                    s.GioiTinh,
                    s.DiaChi,
                    s.Email,
                    s.SDT
                })
                .ToList();

            StudentDisplay.AutoGenerateColumns = false;
            StudentDisplay.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e) // Thêm
        {
            var f = new formInfoStudent("add");
            if (f.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void button2_Click(object sender, EventArgs e) // Thay đổi
        {
            if (StudentDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để thay đổi thông tin!");
                return;
            }

            var row = StudentDisplay.CurrentRow;

            string maSV = row.Cells["ColMaSV"].Value?.ToString();
            string hoTen = row.Cells["ColHoTen"].Value?.ToString();
            string maLop = row.Cells["ColMaLop"].Value?.ToString();

            // DateOnly hoặc DateTime đều xử lý được
            var cell = row.Cells["ColNgaySinh"].Value;
            DateOnly ngaySinh = cell is DateOnly d ? d : DateOnly.FromDateTime(Convert.ToDateTime(cell));

            string gioiTinh = row.Cells["ColGioiTinh"].Value?.ToString();
            string diaChi = row.Cells["ColDiaChi"].Value?.ToString();
            string email = row.Cells["ColEmail"].Value?.ToString();
            string sdt = row.Cells["ColSDT"].Value?.ToString();

            var f = new formInfoStudent("edit", maSV, hoTen, maLop, ngaySinh, gioiTinh, diaChi, email, sdt);
            if (f.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (StudentDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = StudentDisplay.CurrentRow.Cells["ColMaSV"].Value?.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {maSV} không?",
                                "Xác nhận xóa",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _studentBLL.Delete(maSV);
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
