using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Models
{
    public class Faculty
    {
        [Key]
        [MaxLength(20)]
        public string MaKhoa { get; set; } 
        public string TenKhoa { get; set; } 
        public string TruongKhoa { get; set; } 
        public string PhongCongTac  { get; set; } 
        public long SoLuongLop { get; set; }
        public string EmailKhoa { get; set; }

        public ICollection<Lecturers> lecturers { get; set; }
        public ICollection<ClassRoom> classrooms { get; set; }
        public ICollection<Subjects> subjects { get; set; }

    }
}
