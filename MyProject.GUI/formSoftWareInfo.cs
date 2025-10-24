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
    public partial class formSoftWareInfo : Form
    {
        public formSoftWareInfo()
        {
            InitializeComponent();
        }

        private void formSoftWareInfo_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var info = context.ThongtinPM.FirstOrDefault();
                if (info != null)
                {
                    lbNameSoftware.Text = info.TenPM;
                    InfoDisplay.Text = info.MoTa;
                }
                else
                {
                    lbNameSoftware.Text = "Chưa có thông tin phần mềm";
                    InfoDisplay.Text = string.Empty;
                }
            }

        }
    }
}
