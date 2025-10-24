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
    public class Students
    {
        [Key]                      
        [MaxLength(20)]
        public string MaSV { get; set; }  
        public string HoTen { get; set; }  
        public DateOnly NgaySinh { get; set; }  
        public string GioiTinh  { get; set; } 
        public string DiaChi { get; set; } 
        public string Email { get; set; } 
        public string SDT { get; set; }

        public string MaLop { get; set; }

        [ForeignKey("MaLop")]
        public ClassRoom classrooms { get; set; }

        public ICollection<Score> Scores { get; set; }
        public AppUsers users { get; set; }

    }
}
