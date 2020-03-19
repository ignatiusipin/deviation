using deviation.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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

                command.Parameters.Add("@SEVERTY_DEVIATION", System.Data.SqlDbType.VarChar);
                command.Parameters["@SEVERTY_DEVIATION"].Value = FD.Severty_dev;

                /* End Details */
                result = (string)command.ExecuteScalar();
            }
            conn.Close();

            return Json(ModelData);
        }

    }
}