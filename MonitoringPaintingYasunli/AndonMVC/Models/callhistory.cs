using System;

namespace AndonMVC.Models
{
    public partial class callhistory
    {
        public int callseq { get; set; }
        public Nullable<int> sppseq { get; set; }
        public string personid { get; set; }
        public Nullable<int> idcall { get; set; }
        public Nullable<int> epochstart { get; set; }
        public Nullable<int> epochend { get; set; }
        public string iscomplete { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
    }
}
