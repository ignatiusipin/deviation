using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace deviation.Models
{
    [Table("deviation_form_v")]
    public class Deviation_from
    {
        [Key]
        public string REQ_ID { get; set; }
        public string CR_Date_User { get; set; }
        public string Id_proposer { get; set; }
        public string Departement { get; set; }
        public string Problem { get; set; }
        public string Date_of_incident { get; set; }
        public string Location_site { get; set; }
        public string Deviation_category { get; set; }
        public string Deviation_type { get; set; }
        public string Ket_category { get; set; }
        public string Location { get; set; }
        public string User_involved { get; set; }
        public string Order_of_events { get; set; }
        public string SAME_POTEN_DEV_FLAG { get; set; }
        public string Same_poten_dev { get; set; }
        public string POTEN_DEV_RLS_FLG { get; set; }
        public string Poten_dev_rls { get; set; }
        public string POTEN_DEV_OTH_FLG { get; set; }
        public string Poten_dev_oth { get; set; }
        public string Action_when_dev { get; set; }
        
        public string Quality_product { get; set; }
        public string Compliance { get; set; }
        public string RISK_OPERATION { get; set; }
        public string Risk_financial { get; set; }
        public string Risk_organization { get; set; }
        public string Risk_security { get; set; }
        public string Risk_healty { get; set; }
        public string Risk_environtment { get; set; }
        public string RISK_INTELLECTUAL { get; set; }
        public string SEVERTY_DEVIATION { get; set; }
        public string Deviation_no { get; set; }
        public DateTime Creation_date { get; set; }
    }
}