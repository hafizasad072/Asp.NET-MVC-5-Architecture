using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.GenericRepository;
using DB.Core;

namespace DataLayer.Student.Data
{
    public class StudentRepo : Repository<DB.Core.Student>, IStudentRepo
    {
        public StudentRepo(ArchitectureEntities context) : base(context)
        {
        }
    }
}
