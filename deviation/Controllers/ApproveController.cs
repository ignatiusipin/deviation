using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using deviation.Models;
using System.Data.Entity;
using System.Linq.Dynamic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace deviation.Controllers
{
    public class ApproveController : Controller
    {
        // GET: Approve
        private readonly string constr = ConfigurationManager.ConnectionStrings["DB_DO"].ConnectionString;
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
                        deviationData = deviationData.Where(m => m.Location.Contains(searchValue) || m.Location_site.Contains(searchValue) || m.Problem.Contains(searchValue) || m.REQ_ID.Contains(searchValue));
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

        public ActionResult LoadDetailForm(string REQID)
        {
            try
            {
                List<string> ModelData = new List<string>();

                DataTable dt = new DataTable();
                string query = "EXEC INSERT_FORM_DEVIATION @PILIH = 6, @REQID='" + REQID + "'";

                SqlConnection conn = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(dt);
                conn.Close();
                da.Dispose();

                List<DataRow> DataRow = new List<DataRow>();
                int n = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    //string Date = dr[0].ToString().Substring(0, 10);
                    //string Date = dr[0].ToString();
                    //string DateInput = Date.Replace("/", "-");
                    ModelData.Add(dr[0].ToString());
                    ModelData.Add(dr[1].ToString());
                    ModelData.Add(dr[2].ToString());
                    ModelData.Add(dr[3].ToString());
                    ModelData.Add(dr[4].ToString());
                    ModelData.Add(dr[5].ToString());
                    ModelData.Add(dr[6].ToString());
                    ModelData.Add(dr[7].ToString());
                    ModelData.Add(dr[8].ToString());
                    ModelData.Add(dr[9].ToString());
                    ModelData.Add(dr[10].ToString());
                    ModelData.Add(dr[11].ToString());
                    ModelData.Add(dr[12].ToString());
                    ModelData.Add(dr[13].ToString());
                    ModelData.Add(dr[14].ToString());
                    ModelData.Add(dr[15].ToString());
                    ModelData.Add(dr[16].ToString());
                    ModelData.Add(dr[17].ToString());
                    ModelData.Add(dr[18].ToString());
                    ModelData.Add(dr[19].ToString());
                    ModelData.Add(dr[20].ToString());
                    ModelData.Add(dr[21].ToString());
                    ModelData.Add(dr[22].ToString());
                    ModelData.Add(dr[23].ToString());
                    ModelData.Add(dr[24].ToString());
                    ModelData.Add(dr[25].ToString());
                    ModelData.Add(dr[26].ToString());
                    ModelData.Add(dr[27].ToString());
                    ModelData.Add(dr[28].ToString());
                    ModelData.Add(dr[29].ToString());
                    ModelData.Add(dr[30].ToString());
                }
                return Json(ModelData);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult DetailForm(string REQID)
        {
            ViewBag.REQID = REQID;
            return View();
        }

        
    }
}