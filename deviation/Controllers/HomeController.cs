using deviation.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Web.Mvc;


namespace deviation.Controllers
{
    public class HomeController : Controller
    {
        //ConnectionStringSettings mySetting = ConfigurationManager.ConnectionStrings["DB_DO"];
        private readonly string constr = ConfigurationManager.ConnectionStrings["DB_DO"].ConnectionString;

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Input()
        {
            return View();
        }

        #region DROPDOWN
        public ActionResult GetSite()
        {
            string query = "select ddl_code, ddl_description from DEVIATION_DDL where ddl_type = 'SITE' and is_active = 1 ";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {                
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }

        public ActionResult GetKategori()
        {
            string query = "select ddl_code, ddl_description from [DEVIATION_DDL] where ddl_type = 'KATEGORI' and is_active = 1";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }

        public ActionResult GetJenisPenyimpangan()
        {
            string query = "select ddl_code, ddl_description from [DEVIATION_DDL] where ddl_type = 'JENIS' and is_active = 1";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }

        public ActionResult GetKualitasProduk()
        {
            string query = "select ddl_code, ddl_description from [DEVIATION_DDL] where ddl_type = 'I_QUAL' and is_active = 1";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }

        public ActionResult GetCompliance()
        {
            string query = "select ddl_code, ddl_description from [DEVIATION_DDL] where ddl_type = 'I_COMP' and is_active = 1";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }

        public ActionResult GetResikoOper()
        {
            string query = "select ddl_code, ddl_description from [DEVIATION_DDL] where ddl_type = 'I_RESOPR' and is_active = 1";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }

        public ActionResult GetResikoFinan()
        {
            string query = "select ddl_code, ddl_description from [DEVIATION_DDL] where ddl_type = 'I_RESFIN' and is_active = 1";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }

        public ActionResult GetResikoOrg()
        {
            string query = "select ddl_code, ddl_description from [DEVIATION_DDL] where ddl_type = 'I_RESORG' and is_active = 1";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }

        public ActionResult GetResikoKeamPer()
        {
            string query = "select ddl_code, ddl_description from  [DEVIATION_DDL] where ddl_type = 'I_RESKPE' and is_active = 1";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }

        public ActionResult GetResikoKesPer()
        {
            string query = "select ddl_code, ddl_description from  [DEVIATION_DDL] where ddl_type = 'I_RESHTP' and is_active = 1";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }

        public ActionResult GetRskLgkgan()
        {
            string query = "select ddl_code, ddl_description from  [DEVIATION_DDL] where ddl_type = 'I_RESLKG' and is_active = 1";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }        

        public ActionResult GetResikoIntelektual()
        {
            string query = "select ddl_code, ddl_description from [DEVIATION_DDL] where ddl_type = 'I_RESINTEL' and is_active = 1";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["ddl_description"].ToString(),
                                Value = sdr["ddl_code"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return Json(items);
        }
        #endregion

        // Generate No ReqID
        public ActionResult GenerateNoReqID()
        {
            string result; ;
            List<string> ModelData = new List<string>();
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            using (SqlCommand command = new SqlCommand("GENERATE_REQ_NO", conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                result = (string)command.ExecuteScalar();
            }
            conn.Close();
            ModelData.Add(result);
            return Json(ModelData);
        }

        public ActionResult InsertFormDeviation(Form_deviation FD)
        {
            string result;
            List<string> ModelData = new List<string>();            

            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            using (SqlCommand command = new SqlCommand("Insert_form_deviation", conn))
            {          
                /* Header*/
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@pilih", System.Data.SqlDbType.Int);
                command.Parameters["@pilih"].Value = 1;

                command.Parameters.Add("@ID_PROPOSER", System.Data.SqlDbType.VarChar);
                command.Parameters["@ID_PROPOSER"].Value = FD.Id_proposer;

                command.Parameters.Add("@CR_Date_User", System.Data.SqlDbType.VarChar);
                command.Parameters["@CR_Date_User"].Value = FD.CR_Date_User; 

                command.Parameters.Add("@DEPARTEMENT", System.Data.SqlDbType.VarChar);
                command.Parameters["@DEPARTEMENT"].Value = FD.Departement;

                command.Parameters.Add("@PROBLEM", System.Data.SqlDbType.VarChar);
                command.Parameters["@PROBLEM"].Value = FD.Problem;

                command.Parameters.Add("@DATE_OF_INCIDENT", System.Data.SqlDbType.VarChar);
                command.Parameters["@DATE_OF_INCIDENT"].Value = FD.Date_of_incident;

                command.Parameters.Add("@LOCATION_SITE", System.Data.SqlDbType.VarChar);
                command.Parameters["@LOCATION_SITE"].Value = FD.Location_site;

                command.Parameters.Add("@DEVIATION_CATEGORY", System.Data.SqlDbType.VarChar);
                command.Parameters["@DEVIATION_CATEGORY"].Value = FD.Deviation_category;

                command.Parameters.Add("@DEVIATION_TYPE", System.Data.SqlDbType.VarChar);
                command.Parameters["@DEVIATION_TYPE"].Value = FD.Deviation_type;

                command.Parameters.Add("@KET_CATEGORY", System.Data.SqlDbType.VarChar);
                command.Parameters["@KET_CATEGORY"].Value = FD.Ket_category;

                command.Parameters.Add("@LOCATION", System.Data.SqlDbType.VarChar);
                command.Parameters["@LOCATION"].Value = FD.Location;
                /* END Header */

                /* Strat Details */
                command.Parameters.Add("@USER_INVOLVED", System.Data.SqlDbType.VarChar);
                command.Parameters["@USER_INVOLVED"].Value = FD.User_involved;

                command.Parameters.Add("@ORDER_OF_EVENTS", System.Data.SqlDbType.VarChar);
                command.Parameters["@ORDER_OF_EVENTS"].Value = FD.Order_of_events;
                /* ****** 1 */
                command.Parameters.Add("@SAME_POTEN_DEV_FLAG", System.Data.SqlDbType.VarChar);
                command.Parameters["@SAME_POTEN_DEV_FLAG"].Value = FD.Same_potent_dev_flg;

                command.Parameters.Add("@SAME_POTEN_DEV", System.Data.SqlDbType.VarChar);
                command.Parameters["@SAME_POTEN_DEV"].Value = FD.Same_potent_dev;
                /* ****** 2 */
                command.Parameters.Add("@POTEN_DEV_RLS_FLG", System.Data.SqlDbType.VarChar);
                command.Parameters["@POTEN_DEV_RLS_FLG"].Value = FD.Poten_dev_rls_flg;

                command.Parameters.Add("@POTEN_DEV_RLS", System.Data.SqlDbType.VarChar);
                command.Parameters["@POTEN_DEV_RLS"].Value = FD.Poten_dev_rls;
                /* ****** 3 */
                command.Parameters.Add("@POTEN_DEV_OTH_FLG", System.Data.SqlDbType.VarChar);
                command.Parameters["@POTEN_DEV_OTH_FLG"].Value = FD.Poten_dev_oth_flg;

                command.Parameters.Add("@POTEN_DEV_OTH", System.Data.SqlDbType.VarChar);
                command.Parameters["@POTEN_DEV_OTH"].Value = FD.Poten_dev_oth;
                /* ****** */
                command.Parameters.Add("@ACTION_WHEN_DEV", System.Data.SqlDbType.VarChar);
                command.Parameters["@ACTION_WHEN_DEV"].Value = FD.Action_when_dev;

                command.Parameters.Add("@FILE_UPLOAD_ID", System.Data.SqlDbType.VarChar);
                command.Parameters["@FILE_UPLOAD_ID"].Value = FD.File_upload_id;

                command.Parameters.Add("@QUALITY_PRODUCT", System.Data.SqlDbType.VarChar);
                command.Parameters["@QUALITY_PRODUCT"].Value = FD.Quality_product;

                command.Parameters.Add("@COMPLIANCE", System.Data.SqlDbType.VarChar);
                command.Parameters["@COMPLIANCE"].Value = FD.Compliance;

                command.Parameters.Add("@RISK_OPERATION", System.Data.SqlDbType.VarChar);
                command.Parameters["@RISK_OPERATION"].Value = FD.Risk_operasional;

                command.Parameters.Add("@RISK_FINANCIAL", System.Data.SqlDbType.VarChar);
                command.Parameters["@RISK_FINANCIAL"].Value = FD.Risk_financial;

                command.Parameters.Add("@RISK_ORGANIZATION", System.Data.SqlDbType.VarChar);
                command.Parameters["@RISK_ORGANIZATION"].Value = FD.Risk_organization;

                command.Parameters.Add("@RISK_SECURITY", System.Data.SqlDbType.VarChar);
                command.Parameters["@RISK_SECURITY"].Value = FD.Risk_security;

                command.Parameters.Add("@RISK_HEALTY", System.Data.SqlDbType.VarChar);
                command.Parameters["@RISK_HEALTY"].Value = FD.Risk_healty;

                command.Parameters.Add("@RISK_ENVIRONTMENT", System.Data.SqlDbType.VarChar);
                command.Parameters["@RISK_ENVIRONTMENT"].Value = FD.Risk_environtment;

                command.Parameters.Add("@RISK_INTELLECTUAL", System.Data.SqlDbType.VarChar);
                command.Parameters["@RISK_INTELLECTUAL"].Value = FD.Risk_intelectual;

                command.Parameters.Add("@REQID", System.Data.SqlDbType.VarChar);
                command.Parameters["@REQID"].Value = FD.REQID;
                /* End Details */
                result = (string)command.ExecuteScalar();
            }
            conn.Close();
            ModelData.Add(result);
            return Json(ModelData);
        }

        #region UPLOAD DOWNLOAD LOAD
        public ActionResult UploadAttachment(FormCollection formCollection)
        {
            string FileNameForDB = ""
                , URLAttachment = ""
                , result=""
                , ReqID = formCollection["ReqID"];
            DataTable dt = new DataTable();

            List<string> ModelData = new List<string>();
            SqlConnection conn = new SqlConnection(constr);

            for (int i = 0; i < Request.Files.Count; i++)
            {
                var file = Request.Files[i];
                var fileName = ReqID +'-'+ Path.GetFileName(file.FileName);

                URLAttachment = Path.Combine(@"\\KALBOX-B7.BINTANG7.com\Intranetportal\Intranet Attachment\Deviation\",  fileName);
                //10.167.1.78\Intranetportal\Intranet Attachment\Deviation\
                file.SaveAs(URLAttachment);
                FileNameForDB = fileName;

                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("Insert_form_deviation", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@PILIH", System.Data.SqlDbType.Int);
                        command.Parameters["@PILIH"].Value = 2;

                        command.Parameters.Add("@FILE_NAME_UPLOAD", System.Data.SqlDbType.VarChar);
                        command.Parameters["@FILE_NAME_UPLOAD"].Value = FileNameForDB;

                        command.Parameters.Add("@PATH_FILE", System.Data.SqlDbType.VarChar);
                        command.Parameters["@PATH_FILE"].Value = URLAttachment;

                        command.Parameters.Add("@REQID", System.Data.SqlDbType.VarChar);
                        command.Parameters["@REQID"].Value = ReqID;

                        result = (string)command.ExecuteScalar();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    result = ex.ToString();
                }
            }
            return Json(result);
        }

        public ActionResult LoadAttachment(FormCollection formCollection)
        {
            string ReqID = formCollection["ReqID"];
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
                    command.Parameters["@PILIH"].Value = 3;

                    command.Parameters.Add("@REQID", System.Data.SqlDbType.VarChar);
                    command.Parameters["@REQID"].Value = ReqID;

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

        public ActionResult DeleteAttachment(FormCollection formCollection)
        {
            int tempP = 0;
            /*Delete Data*/
            string ReqID = formCollection["ReqID"], fileName = formCollection["fileName"], result,
                param = formCollection["param"];
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
                    command.Parameters["@PILIH"].Value = 4;

                    command.Parameters.Add("@REQID", System.Data.SqlDbType.VarChar);
                    command.Parameters["@REQID"].Value = ReqID;

                    command.Parameters.Add("@FILE_NAME_UPLOAD", System.Data.SqlDbType.VarChar);
                    command.Parameters["@FILE_NAME_UPLOAD"].Value = fileName;

                    result = (string)command.ExecuteScalar();

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                result = ex.ToString();
                return Json(result);
            }

            /*Delete File*/

            if (!System.IO.File.Exists(param))
            {
                return Json(tempP);
            }

            try
            {
                System.IO.File.Delete(param);
                tempP = 1;

            }
            catch (Exception e)
            {
                
            }
            return Json(tempP);
        }
        #endregion

        public ActionResult ListFormDeviation()
        {
            return View();
        }

        public ActionResult LoadListDeviation()
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
                                             //where tempdeviationHeader.ID_Proposer == FD.Id_proposer
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

        #region Pelaku Remidial

        public ActionResult FormTindakanRemidial()
        {
            return View();
        }



        #endregion
    }
}