using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Student.Data;
using DB.Core;

namespace ServiceLayer.UnitOfWorkService
{
    public class UnitOfWork : IUnitOfWork
    {
        private IStudentRepo _StudentRepo;
        private ArchitectureEntities _db;
        #region Constructor 
        public UnitOfWork(IStudentRepo StudentRepo ,ArchitectureEntities db)
        {
            _StudentRepo = StudentRepo;
            _db = db;
        }
        #endregion
        public IStudentRepo StudentRepo
        {
            get
            {
               // if(_StudentRepo == null)
               //return _StudentRepo = new StudentRepo();
                return _StudentRepo;
            }
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            
        }
    }
}
