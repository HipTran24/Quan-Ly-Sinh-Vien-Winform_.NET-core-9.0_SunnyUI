using MyProject.BLL;
using MyProject.BLL.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyProject.GUI
{
    public partial class formLogin : Form
    {
        private readonly UserBLL _userBll = new UserBLL();

        public formLogin()
        {
            InitializeComponent();
            txbPass.UseSystemPasswordChar = true;
            this.AcceptButton = button1;
            button1.Click += button1_Click;
            panelMain.Layout += (_, __) =>
            {
                linkLabel1.Left = (panelMain.ClientSize.Width - linkLabel1.Width) / 2;
            };
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            string username = txbUser.Text.Trim();
            string password = txbPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _userBll.Login(username, password);
            if (user != null)
            {
                AuthContextService.SignIn(user);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!",
                    "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.logo_removebg_preview;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Parent = this;


            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BringToFront();
            this.BackgroundImage = Properties.Resources.BackgroundLogin;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            var screenPos = linkLabel1.PointToScreen(Point.Empty);
            linkLabel1.Parent = this;
            linkLabel1.Location = this.PointToClient(screenPos);

            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.ActiveLinkColor = Color.LightCyan;
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.Font = new Font("Segoe UI", 10, FontStyle.Italic | FontStyle.Bold);
            linkLabel1.AutoSize = true;
            linkLabel1.BringToFront();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkClicked += (s, ev) =>
                {
                    using var f = new formForgotPassword();
                    f.ShowDialog(this);
                };
            }
            catch { /* ignore if control not present */ }
        }
    }
}
