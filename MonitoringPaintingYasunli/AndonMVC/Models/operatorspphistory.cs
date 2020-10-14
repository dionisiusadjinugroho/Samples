using System;

namespace AndonMVC.Models
{
    public partial class operatorspphistory
    {
        public int opsppseq { get; set; }
        public string operatorid { get; set; }
        public Nullable<int> sppseq { get; set; }
        public Nullable<int> epochstart { get; set; }
        public Nullable<int> epochend { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
    }
}
