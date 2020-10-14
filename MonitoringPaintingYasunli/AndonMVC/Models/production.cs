using System;

namespace AndonMVC.Models
{
    public partial class production
    {
        public string machine { get; set; }
        public string job_no { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
        public string run_time { get; set; }
        public string idle_time { get; set; }
        public string moldid { get; set; }
        public string mold_tooling { get; set; }
        public string OEE { get; set; }
        public string qty_target { get; set; }
        public string qty_stroke { get; set; }
        public string qty_total { get; set; }
        public string total_qty_ok { get; set; }
        public string total_qty_ng { get; set; }
        public string plandowntime { get; set; }
        public string performance { get; set; }
        public string quality { get; set; }
        public string availability { get; set; }
    }
}
