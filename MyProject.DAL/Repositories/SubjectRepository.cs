using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly AppDbContext _context;
        public SubjectRepository() 
        {
            _context = new AppDbContext();
        }
        public List<Subjects> GetAll() 
        { 
            return _context.MonHoc.ToList();
        }
        public Subjects GetById(int id) 
        {
            return _context.MonHoc.Find(id);
        }

        public void Add(Subjects subject)
        {
             _context.MonHoc.Add(subject);
            _context.SaveChanges();
        }
        public void Update(Subjects subjects) 
        {
            _context.MonHoc.Update(subjects);
            _context.SaveChanges();
        }
        public void Delete(string id)
        {
            var subject = _context.MonHoc.Find(id);
            if(subject != null)
            {
                _context.MonHoc.Remove(subject);
                _context.SaveChanges();
            }
        }

    }
}
