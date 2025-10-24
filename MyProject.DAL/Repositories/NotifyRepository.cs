using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public class NotifyRepository : INotifyRepository
    {
        private readonly AppDbContext _context;

        public NotifyRepository()
        {
            _context = new AppDbContext();
        }

        public List<Notify> GetAll()
        {
            return _context.ThongBao
                .OrderByDescending(n => n.CreatedAt)
                .ToList();
        }

        public Notify GetById(string id)
        {
            return _context.ThongBao.FirstOrDefault(n => n.MaTB == id);
        }

        public void Add(Notify notify)
        {
            try
            {
                _context.ThongBao.Add(notify);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // 🔥 Hiển thị lỗi chi tiết bên trong (inner exception)
                throw new Exception($"Lỗi khi thêm thông báo: {ex.InnerException?.Message ?? ex.Message}");
            }
        }

        public void Update(Notify notify)
        {
            _context.ThongBao.Update(notify);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var notify = _context.ThongBao.Find(id);
            if (notify != null)
            {
                _context.ThongBao.Remove(notify);
                _context.SaveChanges();
            }
        }
    } 
}
