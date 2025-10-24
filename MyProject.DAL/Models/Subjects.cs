using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Models

{
    public class Subjects
    {
        [Key]
        [MaxLength(20)]
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public int SoTinChi { get; set; }

        public int SoTiet { get; set; }

        [Required]
        public DateOnly NgayBatDau { get; set; }

        [Required]
        public DateOnly NgayKetThuc { get; set; }

        public string MaKhoa { get; set; }

        [ForeignKey("MaKhoa")]
        public Faculty faculty { get; set; }

        public ICollection<Score> Scores { get; set; }
        public ICollection<Calendars> LichGiangDay { get; set; }
    }
}
