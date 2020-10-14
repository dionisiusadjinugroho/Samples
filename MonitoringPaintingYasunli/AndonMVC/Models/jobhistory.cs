using System;

namespace AndonMVC.Models
{
    public partial class jobhistory
    {
        public string machine { get; set; }
        public string job_no { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public Nullable<int> strokenumber { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
        public string partid { get; set; }
        public string cavity { get; set; }
        public string moldid { get; set; }
        public string mold_tooling { get; set; }
    }
}
