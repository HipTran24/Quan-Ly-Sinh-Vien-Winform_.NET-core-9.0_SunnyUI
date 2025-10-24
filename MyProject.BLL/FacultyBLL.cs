using MyProject.DAL.Models;
using MyProject.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class FacultyBLL
    {
        private readonly IFacultyRepository _repo;
        public FacultyBLL()
        {
            _repo = new FacultyRepository();
        }
        public List<Faculty> GetAllFaculty()
        {
            return _repo.GetAll();
        }
        public void Add(Faculty f)
        {
            _repo.Add(f);
        }
        public void Update(Faculty f)
        {
            if (string.IsNullOrWhiteSpace(f.MaKhoa))
                throw new Exception("Mã khoa không hợp lệ!");
            _repo.Update(f);
        }
        public void Delete(string maKhoa)
        {
            _repo.Delete(maKhoa);
        }
    }
}
