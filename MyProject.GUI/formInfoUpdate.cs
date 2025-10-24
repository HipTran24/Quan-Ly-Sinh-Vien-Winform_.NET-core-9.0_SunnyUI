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
    public partial class formInfoUpdate : Form
    {
        private readonly NotifyBLL notifyBLL = new NotifyBLL();
        private Notify existingPost;  // nếu khác null thì là đang sửa
        private string selectedImagePath = null;
        private bool isEditMode = false;

        public Notify BaiVietMoi { get; private set; }

        public formInfoUpdate()
        {
            InitializeComponent();
            lblAdmin.Text = "Người đăng: admin01";
            lblDateUp.Text = $"Ngày đăng: {DateTime.Now:dd/MM/yyyy HH:mm}";
        }

        public formInfoUpdate(Notify post) : this()
        {
            isEditMode = true;
            existingPost = post;

            // Đổ dữ liệu sẵn lên form
            tbTitle.Text = post.TieuDe;
            rtbContent.Text = post.NoiDung;
            lblAdmin.Text = $"Người đăng: {post.Username}";
            lblDateUp.Text = $"Ngày đăng: {post.CreatedAt:dd/MM/yyyy HH:mm}";

            if (!string.IsNullOrEmpty(post.AnhURL))
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, post.AnhURL);
                if (File.Exists(path))
                {
                    picImage.Image = Image.FromFile(path);
                    picImage.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            btnUp.Text = "Lưu chỉnh sửa";
        }

        private void btnDang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                MessageBox.Show("Vui lòng nhập tiêu đề.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Copy ảnh nếu có chọn mới
            string relativeImage = existingPost?.AnhURL;
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                Directory.CreateDirectory(imageFolder);
                string fileName = $"post_{Guid.NewGuid()}{Path.GetExtension(selectedImagePath)}";
                string destPath = Path.Combine(imageFolder, fileName);
                File.Copy(selectedImagePath, destPath, true);
                relativeImage = $"Images/{fileName}";
            }

            if (isEditMode)
            {
                // Cập nhật dữ liệu
                existingPost.TieuDe = tbTitle.Text.Trim();
                existingPost.NoiDung = rtbContent.Text.Trim();
                existingPost.AnhURL = relativeImage;

                notifyBLL.Update(existingPost);
                MessageBox.Show("Đã lưu chỉnh sửa bài viết!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thêm mới
                BaiVietMoi = new Notify
                {
                    MaTB = Guid.NewGuid().ToString("N").Substring(0, 10),
                    TieuDe = tbTitle.Text.Trim(),
                    NoiDung = rtbContent.Text.Trim(),
                    AnhURL = relativeImage,
                    Username = "admin01",
                    CreatedAt = DateTime.Now
                };

                notifyBLL.Add(BaiVietMoi);
                MessageBox.Show("Đăng bài viết thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Ảnh (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    picImage.Image = Image.FromFile(ofd.FileName);
                    picImage.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                MessageBox.Show("Vui lòng nhập tiêu đề.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string relativeImage = existingPost?.AnhURL;
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                Directory.CreateDirectory(imageFolder);
                string fileName = $"post_{Guid.NewGuid()}{Path.GetExtension(selectedImagePath)}";
                string destPath = Path.Combine(imageFolder, fileName);
                File.Copy(selectedImagePath, destPath, true);
                relativeImage = $"Images/{fileName}";
            }

            if (isEditMode && existingPost != null)
            {
                // 📝 ĐANG SỬA — cập nhật thay vì thêm mới
                existingPost.TieuDe = tbTitle.Text.Trim();
                existingPost.NoiDung = rtbContent.Text.Trim();
                existingPost.AnhURL = relativeImage;

                notifyBLL.Update(existingPost);
                MessageBox.Show("Đã lưu chỉnh sửa bài viết!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK; // chỉ đóng form, không thêm bài mới
                Close();
            }
            else
            {
                // 🆕 THÊM MỚI
                BaiVietMoi = new Notify
                {
                    MaTB = Guid.NewGuid().ToString("N").Substring(0, 10),
                    TieuDe = tbTitle.Text.Trim(),
                    NoiDung = rtbContent.Text.Trim(),
                    AnhURL = relativeImage,
                    Username = "admin01",
                    CreatedAt = DateTime.Now
                };

                notifyBLL.Add(BaiVietMoi);
                MessageBox.Show("Đăng bài viết thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
    }

