using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DAL.Repositories
{
    public interface INotifyRepository
    {
        List<Notify> GetAll();
        Notify GetById(string id);
        void Add(Notify notify);
        void Update(Notify notify);
        void Delete(string id);
    }
}
