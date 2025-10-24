using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Models
{
    public class Score
    {
        public string MaSV { get; set; }   
        public string MaMH { get; set; }
        private float _diemGK;
        public float DiemGK
        {
            get => _diemGK;
            set
            {
                _diemGK = value;
                UpdateDiemTrungBinh();
            }
        }
        private float _diemCK;
        public float DiemCK
        {
            get => _diemCK;
            set
            {
                _diemCK = value;
                UpdateDiemTrungBinh();
            }
        }

        private void UpdateDiemTrungBinh()
        {
            DiemTrungBinh = (DiemGK * 0.5f) + (DiemCK * 0.5f);
        }
        public float DiemTrungBinh { get; set; }
        public string HocKy { get; set; }

        [ForeignKey("MaSV")]
        public Students students { get; set; }

        [ForeignKey("MaMH")]
        public Subjects subjects { get; set; }

    }
}
