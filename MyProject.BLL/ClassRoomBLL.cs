using MyProject.DAL.Models;
using MyProject.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class ClassRoomBLL
    {
        private readonly IClassRoomRepository _repo;
        public ClassRoomBLL()
        {
            _repo = new ClassRoomRepository();
        }
        public List<ClassRoom> GetAllClassRoom()
        {
            return _repo.GetAll();
        }
    }
}
