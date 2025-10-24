using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public class SinhVienRepository : IStudentsRepository
    {
        private readonly AppDbContext _context;

        public SinhVienRepository()
        {
            _context = new AppDbContext();
        }

        public List<Students> GetAll()
        {
            return _context.SinhVien.ToList();
        }

        public Students GetById(string id)
        {
            return _context.SinhVien.Find(id);
        }

        public void Add(Students sv)
        {
            _context.SinhVien.Add(sv);
            _context.SaveChanges();
        }

        public void Update(Students sv)
        {
            _context.SinhVien.Update(sv);
            _context.SaveChanges();
        }

        public void Delete(string maSV)
        {
            var sv = _context.SinhVien.FirstOrDefault(s => s.MaSV == maSV);
            if (sv != null)
            {
                _context.SinhVien.Remove(sv);
                _context.SaveChanges();
            }
        }
    }
}
