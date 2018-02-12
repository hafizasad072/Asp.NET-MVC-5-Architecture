using DataLayer.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.UnitOfWorkService
{
    public interface IUnitOfWork: IDisposable
    {
        void Commit();
    }
}
