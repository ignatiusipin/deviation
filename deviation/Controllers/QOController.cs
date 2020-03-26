using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace deviation.Controllers
{
    public class QOController : Controller
    {
        // GET: QO
        private readonly string constr = ConfigurationManager.ConnectionStrings["DB_DO"].ConnectionString;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Koordinator()
        {
            return View();
        }
    }
}