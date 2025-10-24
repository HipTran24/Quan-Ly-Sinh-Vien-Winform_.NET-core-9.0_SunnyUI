using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public interface IClassRoomRepository
    {
        public List<ClassRoom> GetAll();
        public ClassRoom GetById(int id);
        public void Add(ClassRoom room);
        public void Update(ClassRoom room);
        public void Delete(int id);

    }
}
