using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace deviation.Controllers
{
    public class ApprovalController : Controller
    {
        // GET: Approval
        private readonly string constr = ConfigurationManager.ConnectionStrings["DB_DO"].ConnectionString;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List_Pending()
        {
            return View();
        }


        public ActionResult LoadListPending()
        {
            try { }
            catch { }
        }

        public ActionResult LoadPendingApprove()
        {
            DataTable dt = new DataTable();

            List<string> ModelData = new List<string>();
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("Insert_form_deviation", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PILIH", System.Data.SqlDbType.Int);
                    command.Parameters["@PILIH"].Value = 5;

                    SqlDataAdapter dataAdapt = new SqlDataAdapter();
                    dataAdapt.SelectCommand = command;

                    dataAdapt.Fill(dt);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                ModelData.Add(ex.ToString());
                return Json(ModelData);
            }

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            if (dt.Rows.Count > 0)
            {

                Dictionary<string, object> row;
                foreach (DataRow dr in dt.Rows)
                {
                    row = new Dictionary<string, object>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        row.Add(col.ColumnName, dr[col]);
                    }
                    rows.Add(row);
                }
                return Json(rows);
            }
            else
            {
                ModelData.Add("Data Kosong !!");
                return Json(rows);
            }
        }
    }
}