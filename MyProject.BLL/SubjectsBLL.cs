using MyProject.DAL.Models;
using MyProject.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BLL
{
    public class SubjectsBLL
    {
        private readonly ISubjectRepository _repo;
        public SubjectsBLL()
        {
            _repo = new SubjectRepository();
        }
        public List<Subjects> GetAllSubject()
        {
            return _repo.GetAll();
        }
        public void Add(Subjects s)
        {
            _repo.Add(s);
        }

        public void Update(Subjects s)
        {
            if (string.IsNullOrWhiteSpace(s.MaMH))
                throw new Exception("Không tìm thấy mã môn học để cập nhật!");

            _repo.Update(s);
        }

        public void Delete(string maMH)
        {
            _repo.Delete(maMH);
        }
    }
}
