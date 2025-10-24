using MyProject.DAL.Models;
using MyProject.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class ScoreBLL
    {
        private readonly IScoreRepository _repo;

        public ScoreBLL()
        {
            _repo = new ScoreRepository();
        }

        public List<Score> GetAllScore()
        {
            return _repo.GetAll();
        }

        public void Add(Score score)
        {
            _repo.Add(score);
        }
        public void Update(Score score)
        {
            _repo.Update(score);
        }
        public void Delete(string idSt, string idSj) 
        {
            _repo.Delete(idSt, idSj);
        }
    }
}
