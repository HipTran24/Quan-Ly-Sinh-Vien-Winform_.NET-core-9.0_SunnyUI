using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Models
{
    public class Calendars
    {
        [Required]
        public string MaMH { get; set; }
        public Subjects MonHoc { get; set; }

        [Required]
        public string MaGV { get; set; }
        public Lecturers GiangVien { get; set; }

        [Required]
        public DateOnly Ngay { get; set; }

        [Required]
        [MaxLength(50)]
        public string TietHoc { get; set; } // VD: "Tiết 1-3", "Tiết 4-6"

        [MaxLength(50)]
        public string PhongHoc { get; set; }
    }
}
