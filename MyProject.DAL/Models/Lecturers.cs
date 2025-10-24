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
    public class Lecturers
    {
        [Key]
        [MaxLength(20)]
        public string MaGV { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string MaKhoa { get; set; }

        [ForeignKey("MaKhoa")]
        public Faculty faculty { get; set; }
        public ICollection<AppUsers> users { get; set; }
        public ICollection<Calendars> LichGiangDay { get; set; }


    }
}
