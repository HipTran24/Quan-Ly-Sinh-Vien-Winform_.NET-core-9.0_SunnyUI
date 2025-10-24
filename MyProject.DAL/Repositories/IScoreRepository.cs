using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public interface IScoreRepository
    {
        public List<Score> GetAll();

        public Score GetById(int id);
        public void Add(Score score);
        public void Update(Score score);
        public void Delete(string idSt, string idSj);
    }
}
