using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using deviation.Models;
using System.Data.Entity;
using System.Linq.Dynamic;



namespace deviation.Controllers
{
    public class ApproveController : Controller
    {
        // GET: Approve
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PendingList()
        {
            return View();
        }

        public ActionResult LoadPendingApprove()
        {
            try
            {
                using (DatabaseContext _context = new DatabaseContext())
                {
                    var draw = Request.Form.GetValues("draw").FirstOrDefault();
                    var start = Request.Form.GetValues("start").FirstOrDefault();
                    var length = Request.Form.GetValues("length").FirstOrDefault();
                    var sortColumn = Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
                    var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();
                    var searchValue = Request.Form.GetValues("search[value]").FirstOrDefault();

                    //Paging Size (10,20,50,100)  
                    int pageSize = length != null ? Convert.ToInt32(length) : 0;
                    int skip = start != null ? Convert.ToInt32(start) : 0;
                    int recordsTotal = 0;

                    // Getting all Customer data  
                    var deviationData = (from tempdeviationHeader in _context.Deviations
                                        select tempdeviationHeader);

                    //Sorting  
                    if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
                    {
                        deviationData = deviationData.OrderBy(sortColumn + " " + sortColumnDir);
                    }

                    //Search  
                    if (!string.IsNullOrEmpty(searchValue))
                    {
                        deviationData = deviationData.Where(m => m.Location == searchValue || m.Location_site == searchValue || m.Problem == searchValue || m.REQ_ID == searchValue);
                    }

                    //total number of rows count   
                    recordsTotal = deviationData.Count();
                    
                    //Paging   
                    var data = deviationData.Skip(skip).Take(pageSize).ToList();
                    
                    //Returning Json Data  
                    return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}