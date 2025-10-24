using MyProject.DAL.Models;
using MyProject.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class CalendarBLL
    {
        private readonly ICalendarRepository _repo;

        public CalendarBLL()
        {
            _repo = new CalendarRepository();
        }
        public List<Calendars> GetAllCalendar()
        {
            return _repo.GetAll();
        }
        public void Add(Calendars c)
        {
            if (string.IsNullOrWhiteSpace(c.MaMH) ||
                string.IsNullOrWhiteSpace(c.MaGV) ||
                string.IsNullOrWhiteSpace(c.TietHoc))
                throw new Exception("Vui lòng nhập đầy đủ thông tin môn học, giảng viên và tiết học!");

            if (c.Ngay == default)
                throw new Exception("Ngày giảng dạy không hợp lệ!");

            _repo.Add(c);
        }
        public void Update(Calendars c)
        {
            if (string.IsNullOrWhiteSpace(c.MaMH) ||
                string.IsNullOrWhiteSpace(c.MaGV))
                throw new Exception("Thiếu mã môn học hoặc mã giảng viên để cập nhật!");

            _repo.Update(c);
        }
        public void Delete(string maMH, string maGV, DateOnly ngay, string tietHoc)
        {
            if (string.IsNullOrWhiteSpace(maMH) ||
                string.IsNullOrWhiteSpace(maGV) ||
                string.IsNullOrWhiteSpace(tietHoc))
                throw new Exception("Thiếu thông tin để xóa lịch!");

            _repo.Delete(maMH, maGV, ngay, tietHoc);
        }

    }
}
