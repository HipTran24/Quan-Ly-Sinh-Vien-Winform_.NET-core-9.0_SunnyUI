using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public interface IStudentsRepository
    {
        List<Students> GetAll();
        Students GetById(string id);
        void Add(Students sv);
        void Update(Students sv);
        void Delete(string maSV);
    }
}
