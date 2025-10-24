using Microsoft.EntityFrameworkCore;
using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public class ScoreRepository : IScoreRepository
    { 
        private readonly AppDbContext _context;

        public ScoreRepository()
        {
            _context = new AppDbContext();
        }
        public List<Score> GetAll()
        {
            return _context.Diem.ToList();
        }
        public Score GetById(int id) 
        {
            return _context.Diem.Find(id);
        }
        public void Add(Score score)
        {
            var exist = _context.Diem
           .AsNoTracking()
           .FirstOrDefault(s => s.MaSV == score.MaSV && s.MaMH == score.MaMH);

            if (exist != null)
                throw new Exception("Điểm của sinh viên này cho môn học này đã tồn tại!");

            _context.Diem.Add(score);
            _context.SaveChanges();
        }
        public void Update(Score score) 
        { 
           _context.Diem.Update(score);
           _context.SaveChanges();     
        }
        public void Delete(string idSt, string idSj)
        {
            var score = _context.Diem.Find(idSt, idSj);
            if (score != null)
            {
                _context.Diem.Remove(score);
                _context.SaveChanges();
            }
        }

    }
}
