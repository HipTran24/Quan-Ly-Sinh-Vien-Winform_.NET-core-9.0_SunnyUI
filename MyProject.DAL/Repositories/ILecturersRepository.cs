using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public interface ILecturersRepository
    {
        List<Lecturers> GetAll();
        Lecturers GetById(string id);
        void Add(Lecturers gv);
        void Update(Lecturers gv);
        void Delete(string id);
    }
}
