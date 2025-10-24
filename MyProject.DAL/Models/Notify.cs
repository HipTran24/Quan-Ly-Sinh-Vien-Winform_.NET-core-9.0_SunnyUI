using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Models
{
    public class Notify
    {
        [Key]
        [MaxLength(20)]
        public string MaTB { get; set; } = Guid.NewGuid().ToString("N").Substring(0, 10);
        [Required]
        [MaxLength(200)]
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string ? AnhURL { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now; // ✅ Thêm dòng này
        [Required]
        public string Username { get; set; }

        [ForeignKey("Username")]
        public AppUsers Admin { get; set; }
    }
}
