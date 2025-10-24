using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.GUI.ViewModels
{
    public class CalendarStudentVM
    {
        public DateOnly Ngay { get; set; }
        public string NgayStr => $"{Ngay:dd/MM/yyyy}";  // dùng cho DataGridView
        public string Thu { get; set; } = "";           // “Thứ 2” … “CN”
        public string TietHoc { get; set; } = "";
        public string MaMH { get; set; } = "";
        public string TenMH { get; set; } = "";
        public string MaGV { get; set; } = "";
        public string TenGV { get; set; } = "";
        public string PhongHoc { get; set; } = "";
    }
}
