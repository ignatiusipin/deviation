using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Template_.Controllers
{
    public class InputController : Controller
    {
        // GET: Input
        
        public ActionResult Index()
        {
            return View();
        }
    }
}