using MyProject.BLL;
using MyProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class ucFaculty : UserControl
    {
        private readonly FacultyBLL _facultyBLL;
        public ucFaculty()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _facultyBLL = new FacultyBLL();
            panelBottom.Resize += PanelBottom_Resize;
            PanelBottom_Resize(panelBottom, EventArgs.Empty);
        }

        private void ucFaculty_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var list = db.Khoa.ToList();
                FacultyDisplay.DataSource = null;
                FacultyDisplay.AutoGenerateColumns = true;
                FacultyDisplay.DataSource = list;
            }
            FacultyDisplay.Columns["lecturers"].Visible = false;
            FacultyDisplay.Columns["classrooms"].Visible = false;
            FacultyDisplay.Columns["subjects"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formInfoFaculty f = new formInfoFaculty("add");
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            var list = _facultyBLL.GetAllFaculty()
                .Select(f => new
                {
                    MaKhoa = f.MaKhoa,
                    TenKhoa = f.TenKhoa,
                    TruongKhoa = f.TruongKhoa,
                    PhongCongTac = f.PhongCongTac,
                    SoLuongLop = f.SoLuongLop,
                    EmailKhoa = f.EmailKhoa
                })
                .ToList();

            FacultyDisplay.DataSource = null;
            FacultyDisplay.DataSource = list;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (FacultyDisplay.CurrentRow != null)
            {
                var row = FacultyDisplay.CurrentRow;

                string maKhoa = row.Cells[0].Value.ToString();
                string tenKhoa = row.Cells[1].Value.ToString();
                string truongKhoa = row.Cells[2].Value.ToString();
                string phong = row.Cells[3].Value.ToString();
                long soLop = Convert.ToInt64(row.Cells[4].Value);
                string email = row.Cells[5].Value.ToString();

                formInfoFaculty f = new formInfoFaculty("edit", maKhoa, tenKhoa, truongKhoa, phong, soLop, email);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khoa để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (FacultyDisplay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một khoa để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKhoa = FacultyDisplay.CurrentRow.Cells[0].Value.ToString();
            string tenKhoa = FacultyDisplay.CurrentRow.Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa khoa '{tenKhoa}' (Mã: {maKhoa}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _facultyBLL.Delete(maKhoa);
                    MessageBox.Show("Đã xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void PanelBottom_Resize(object? sender, EventArgs e)
        {
            int btnW = btnAdd.Width;      // hoặc 110
            int gap = 8;
            int y = (panelBottom.Height - btnAdd.Height) / 2;

            btnAdd.Location = new Point(panelBottom.Width - (btnW + gap * 2), y);
            btnChange.Location = new Point(panelBottom.Width - (btnW * 2 + gap * 3), y);
            btnDelete.Location = new Point(panelBottom.Width - (btnW * 3 + gap * 4), y);
            btnUpdate.Location = new Point(panelBottom.Width - (btnW * 4 + gap * 5), y);

            // đảm bảo bám về bên phải khi form giãn
            btnAdd.Anchor = btnChange.Anchor = btnDelete.Anchor = btnUpdate.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;
        }
    }
}
