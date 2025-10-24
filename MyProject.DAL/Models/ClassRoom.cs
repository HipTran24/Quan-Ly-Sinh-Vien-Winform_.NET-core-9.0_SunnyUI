using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Models
{
    public class ClassRoom
    {
        [Key]
        [MaxLength(20)]
        public string MaLop { get; set; }   
        public string TenLop { get; set; } 
        public string KhoaHoc { get; set; } 
        public string MaGV { get; set; } 
        public string MaKhoa { get; set; }
        public int SoLuongSV { get; set; }

        public ICollection<Students> Students { get; set; }

        [ForeignKey("MaKhoa")]
        public Faculty faculty { get; set; }
    }
}
