using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Models
{
    public class SoftwareInfo
    {
        [Key]
        public int MaPM { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenPM { get; set; }

        public string MoTa { get; set; }
    }
}
