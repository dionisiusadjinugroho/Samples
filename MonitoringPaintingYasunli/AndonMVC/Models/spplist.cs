using System;

namespace AndonMVC.Models
{
    public partial class spplist
    {
        public int sppid { get; set; }
        public string sppname { get; set; }
        public string customer_name { get; set; }
        public string moldid { get; set; }
        public string mold_tooling { get; set; }
        public string mold_material { get; set; }
        public Nullable<int> std_cycle_time { get; set; }
        public string partid { get; set; }
        public string cavity { get; set; }
        public string keterangan { get; set; }
        public Nullable<int> targetstroke { get; set; }
        public Nullable<int> plandowntime { get; set; }
        public string flag { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
    }
}
