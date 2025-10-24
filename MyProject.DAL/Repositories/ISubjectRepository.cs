using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public interface ISubjectRepository
    {
        public List<Subjects> GetAll();
        public Subjects GetById(int id);
        public void Add(Subjects subject);
        public void Update(Subjects subject);
        public void Delete(string id);

    }
}
