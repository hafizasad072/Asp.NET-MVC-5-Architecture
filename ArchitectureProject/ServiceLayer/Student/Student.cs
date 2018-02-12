using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.UnitOfWorkService;

namespace ServiceLayer.StudentService
{
    public class StudentService : IStudentService
    {
        private IUnitOfWork _uow;
        public StudentService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public int AddStudent()
        {
            var s = new DB.Core.Student();
            s.Name = "Asad";
            s.Batch = "BS101";
            _uow.StudentRepo.Insert(s);
           var data = _uow.StudentRepo.GetById(1);
            data.Name = "Omar";
            _uow.StudentRepo.Edit(data);
            _uow.Commit();
            return 0;
        }
    }
}
