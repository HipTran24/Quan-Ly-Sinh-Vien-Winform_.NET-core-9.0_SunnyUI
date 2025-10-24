using MyProject.DAL.Models;
using MyProject.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class StudentsBLL
    {
        private readonly IStudentsRepository _repo;

        public StudentsBLL()
        {
            _repo = new SinhVienRepository();
        }

        public List<Students> GetAllStudents()
        {
            return _repo.GetAll();
        }
        public void Add(Students student) 
        {
            var lop = _repo.GetAll().FirstOrDefault(x => x.MaLop == student.MaLop);
            if (lop == null)
            {
                throw new Exception("Mã lớp không tồn tại trong hệ thống!");
            }
            _repo.Add(student);
        }
        public void Update(Students student) 
        { 
            _repo.Update(student);
        }
        public void Delete(string MaSV) 
        {  
            _repo.Delete(MaSV);
        }
        public Students GetById(string id) => _repo.GetById(id);
    }
}
