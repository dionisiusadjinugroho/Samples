using System;

namespace AndonMVC.Models
{
    public partial class historyreasonlist
    {
        public string sppname { get; set; }
        public int reasonid { get; set; }
        public string reasonname { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
    }
}
