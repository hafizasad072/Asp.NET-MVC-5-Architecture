using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LogicLayer.Controllers
{
   public class HomeController:BaseController
    {
        #region Fields



        #endregion

        #region Constructor

        public HomeController()
        {

        }

        #endregion

        #region Actions
        public ActionResult Index()
        {
            return View();
        }
        #endregion
    }
}
