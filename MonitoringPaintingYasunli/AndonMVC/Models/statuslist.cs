using System;

namespace AndonMVC.Models
{
    public partial class statuslist
    {
        public int statusid { get; set; }
        public string statusname { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
    }
}
