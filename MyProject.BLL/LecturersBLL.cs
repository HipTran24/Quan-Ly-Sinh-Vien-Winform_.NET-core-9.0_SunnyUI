using MyProject.DAL;
using MyProject.DAL.Models;
using MyProject.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class LecturersBLL
    {
        private readonly ILecturersRepository _repo;
        public LecturersBLL()
        {
            _repo = new LecturersReponsitory();
        }
        public List<Lecturers> GetAllLecturers()
        {
            return _repo.GetAll();
        }
        public void Add(Lecturers lecturers) 
        {
            if (string.IsNullOrWhiteSpace(lecturers.MaGV) || string.IsNullOrWhiteSpace(lecturers.HoTen))
                throw new Exception("Vui lòng nhập đầy đủ thông tin mã và họ tên giảng viên!");

            // ✅ Kiểm tra mã khoa có tồn tại không
            using (var db = new AppDbContext())
            {
                bool exists = db.Khoa.Any(k => k.MaKhoa == lecturers.MaKhoa);
                if (!exists)
                    throw new Exception($"Mã khoa '{lecturers.MaKhoa}' không tồn tại trong hệ thống!");
            }
            _repo.Add(lecturers);

        }
        public void Update(Lecturers lecturers)
        {
            _repo.Update(lecturers);
        }
        public void Delete(string id)
        {
            _repo.Delete(id);
        }
        public Lecturers GetById(string id) => _repo.GetById(id);

    }
}
