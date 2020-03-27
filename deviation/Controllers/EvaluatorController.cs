using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace deviation.Controllers
{
    public class EvaluatorController : Controller
    {
        // GET: Evaluator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }
    }
}