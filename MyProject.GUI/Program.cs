using MyProject.BLL.Auth;
using MyProject.DAL;
using MyProject.GUI;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myproject.GUI
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var uiStyleManager = new UIStyleManager(); 
            uiStyleManager.Style = UIStyle.Blue;       
            uiStyleManager.DPIScale = true;           
           // Application.Run(new formMain());


           while (true)
            {
                using (var login = new formLogin())
                {
                    var result = login.ShowDialog();
                    if (result != DialogResult.OK || !AuthContextService.IsLoggedIn) break;

                    Form? mainForm = AuthContextService.Role switch
                    {
                        "Admin" or "Quản trị" => new formMain(),
                        "Lecturer" or "Giảng viên" => new formMainLecturer(),
                        "Student" or "Sinh viên" => new formMainStudent(),
                        _ => null
                    };

                    if (mainForm == null)
                    {
                        MessageBox.Show("Vai trò người dùng không hợp  lệ", "Lại",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AuthContextService.SignOut();
                        continue;
                    }

                    var mainResult = mainForm.ShowDialog();
                    if (mainResult == DialogResult.Retry) continue;
                    break;
                }
            }
        }
    }
}
