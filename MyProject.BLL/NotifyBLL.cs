using MyProject.DAL.Models;
using MyProject.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class NotifyBLL
    {
        private readonly NotifyRepository _repo;

        public NotifyBLL()
        {
            _repo = new NotifyRepository();
        }

        public List<Notify> GetAllNotify() => _repo.GetAll();

        public void Add(Notify notify) => _repo.Add(notify);

        public void Update(Notify notify) => _repo.Update(notify);

        public void Delete(string id) => _repo.Delete(id);
    }
}
