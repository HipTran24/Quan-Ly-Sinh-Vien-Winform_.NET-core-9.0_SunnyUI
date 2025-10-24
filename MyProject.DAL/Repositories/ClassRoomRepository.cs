using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public class ClassRoomRepository : IClassRoomRepository
    {
        private readonly AppDbContext _context;
        public ClassRoomRepository()
        { 
            _context = new AppDbContext();
        }

        public List<ClassRoom> GetAll()
        {
            return _context.LopHoc.ToList();
        }
        public ClassRoom GetById(int id) 
        {
            return _context.LopHoc.Find(id);
        }
        public void Add(ClassRoom room)
        {
         _context.LopHoc.Add(room);
         _context.SaveChanges();
        }
        public void Update(ClassRoom room) 
        { 
          _context.LopHoc.Update(room);
           _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var room = _context.LopHoc.Find(id);
            if (room != null)
            {
                _context.LopHoc.Remove(room);
                _context.SaveChanges();
            }
        }


    }
}
