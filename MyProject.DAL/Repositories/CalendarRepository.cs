using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public class CalendarRepository : ICalendarRepository
    {
        private readonly AppDbContext _context;
        public CalendarRepository()
        {
            _context = new AppDbContext();
        }
        public List<Calendars> GetAll()
        {
            return _context.LichGiangDay.ToList();
        }
        public Calendars GetById(int id)
        {
            return _context.LichGiangDay.Find(id);
        }
        public void Add(Calendars calendar)
        {
            var exists = _context.LichGiangDay.Any(l =>
                    l.MaMH == calendar.MaMH &&
                    l.MaGV == calendar.MaGV &&
                    l.Ngay == calendar.Ngay &&
                    l.TietHoc == calendar.TietHoc);

            if (exists)
                throw new Exception("Lịch giảng dạy này đã tồn tại!");
            _context.LichGiangDay.Add(calendar);
            _context.SaveChanges();
        }
        public void Update(Calendars calendar)
        {
            _context.LichGiangDay.Update(calendar);
            _context.SaveChanges();
        }
        public void Delete(string maMH, string maGV, DateOnly ngay, string tietHoc) 
        {
            var calendar = GetByKey(maMH, maGV, ngay, tietHoc);
            if (calendar == null)
                throw new Exception("Không tìm thấy lịch để xóa!");

            _context.LichGiangDay.Remove(calendar);
            _context.SaveChanges();
        }
        public Calendars GetByKey(string maMH, string maGV, DateOnly ngay, string tietHoc)
        {
            return _context.LichGiangDay
                .FirstOrDefault(c => c.MaMH == maMH && c.MaGV == maGV && c.Ngay == ngay && c.TietHoc == tietHoc);
        }
    }
}
