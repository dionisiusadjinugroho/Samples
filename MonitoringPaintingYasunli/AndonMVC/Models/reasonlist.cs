using System;

namespace AndonMVC.Models
{
    public partial class reasonlist
    {
        public int reasonid { get; set; }
        public string reasonname { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
    }
}
