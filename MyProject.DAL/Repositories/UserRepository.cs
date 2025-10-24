using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context = new AppDbContext();

        public List<AppUsers> GetAll() => _context.Users.ToList();

        public AppUsers? GetById(string username) => _context.Users.Find(username);
        
        public void Add(AppUsers user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(AppUsers user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Delete(string username)
        {
            var user = _context.Users.Find(username);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    } 
}
