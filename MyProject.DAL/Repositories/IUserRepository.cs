using MyProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyProject.DAL.Repositories
{
    public interface IUserRepository
    {
        List<AppUsers> GetAll();
        AppUsers? GetById(string username);
        void Add(AppUsers user);
        void Update(AppUsers user);
        void Delete(string username);


    }
}
