using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public interface IFacultyRepository
    {
        List<Faculty> GetAll();
        Faculty GetById(int id);
        void Add(Faculty faculty);
        void Update(Faculty faculty);
        void Delete(string id);

    }
}
