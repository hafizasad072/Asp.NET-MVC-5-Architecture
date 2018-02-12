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
            throw new NotImplementedException();
        }
    }
}
