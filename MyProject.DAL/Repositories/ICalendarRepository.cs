using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public interface ICalendarRepository
    {
        public List<Calendars> GetAll();
        public Calendars GetById(int id);

        public void Add(Calendars calendar);
        public void Update(Calendars calendar);
        public void Delete(string maMH, string maGV, DateOnly ngay, string tietHoc);

    }
}
