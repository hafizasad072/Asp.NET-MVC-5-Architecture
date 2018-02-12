using ServiceLayer.StudentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LogicLayer.Controllers
{
    public class HomeController : BaseController
    {
        #region Fields

        private IStudentService _StudentService;

        #endregion

        #region Constructor

        public HomeController(IStudentService StudentService)
        {
            _StudentService = StudentService;
        }

        #endregion

        #region Actions
        public ActionResult Index()
        {
            _StudentService.AddStudent();
            return View();
        }
        #endregion
    }
}
