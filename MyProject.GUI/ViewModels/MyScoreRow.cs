using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.GUI.ViewModels
{
    public class MyScoreRow
    {
        public string MaMH { get; set; } = "";
        public string TenMH { get; set; } = "";
        public double DiemGiuaKy { get; set; }
        public double DiemCuoiKy { get; set; }
        public double DiemTrungBinh { get; set; }
        public int SoTinChi { get; set; }
        public string HocKy { get; set; } = "";
    }
}
