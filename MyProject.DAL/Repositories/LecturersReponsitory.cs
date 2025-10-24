using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public class LecturersReponsitory : ILecturersRepository
    {
        private readonly AppDbContext _context;

        public LecturersReponsitory()
        {
            _context = new AppDbContext();
        }
        public List<Lecturers> GetAll()
        {
            return _context.GiangVien.ToList();
        }
        public Lecturers GetById(string id)
        {
            return _context.GiangVien.Find(id);
        }
        public void Add(Lecturers gv)
        {
            _context.GiangVien.Add(gv);
            _context.SaveChanges();
        }   
        public void Update(Lecturers gv)
        {
            _context.GiangVien.Update(gv);
            _context.SaveChanges();
        }
        public void Delete(string id)
        {
            var gv = _context.GiangVien.Find(id);
            if (gv != null)
            {
                _context.GiangVien.Remove(gv);
                _context.SaveChanges();
            }
        }

    }
}
