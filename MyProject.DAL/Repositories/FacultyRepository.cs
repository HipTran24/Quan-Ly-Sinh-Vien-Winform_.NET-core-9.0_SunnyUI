using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public class FacultyRepository : IFacultyRepository
    {
        private readonly AppDbContext _context;

        public FacultyRepository()
        {
            _context = new AppDbContext();
        }

        public List<Faculty> GetAll()
        {
            return _context.Khoa.ToList();
        }
        public Faculty GetById(int id)
        {
            return _context.Khoa.Find(id);
        }
        public void Add(Faculty faculty)
        {
            _context.Khoa.Add(faculty);
            _context.SaveChanges();
        }
        public void Update(Faculty faculty)
        {
            _context.Khoa.Update(faculty);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var faculty = _context.Khoa.Find(id);
            if (faculty != null) 
            { 
                _context.Khoa.Remove(faculty);
                _context.SaveChanges();
            }
        }

    }
}
