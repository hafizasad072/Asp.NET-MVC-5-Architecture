using DataLayer.GenericRepository;
using DB.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Student.Data
{
    public interface IStudentRepo : IRepository<DB.Core.Student>
    {
    }
}
