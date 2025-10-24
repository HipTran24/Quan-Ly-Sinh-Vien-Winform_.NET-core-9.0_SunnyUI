using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Models
{
    public class AppUsers
    {
        [Key]
        [MaxLength(20)]
        public string Username { get; set; }

        [MaxLength(100)]
        public string Password { get; set; }
        public string Role { get; set; }
        public string? MaSV { get; set; }
        public string? MaGV { get; set; }
        [Column("AdminID")]
        public string ? AdminID { get; set; }

        [ForeignKey("MaSV")]
        public Students students { get; set; }

        [ForeignKey("MaGV")]
        public Lecturers lecturers { get; set; }

        public ICollection<Notify> Notifies { get; set; }
    }
}
