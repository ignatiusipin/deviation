using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace deviation.Models
{
    [Table("DEVIATION_HEADERS")]
    public class Deviation
    {
        [Key]
        public string REQ_ID { get; set; }
        public string Deviation_no { get; set; }
        public DateTime Creation_date { get; set; }
        public string CR_Date_user { get; set; }
        public string ID_Proposer { get; set; }
        public string Departement { get; set; }
        [Required(ErrorMessage = "Required Problem")]
        public string Problem { get; set; }
        [Required(ErrorMessage = "Required Tanggal Kejadian")]
        public string Date_of_incident { get; set; }
        [Required(ErrorMessage = "Required Lokasi Penginput Deviation")]
        public string Location_site { get; set; }
        [Required(ErrorMessage = "Required Kategori")]
        public string Deviation_category { get; set; }
        public string Deviation_type { get; set; }
        public string Ket_category { get; set; }
        [Required(ErrorMessage = "Required Lokasi Kejadian")]
        public string Location { get; set; }
    }

}