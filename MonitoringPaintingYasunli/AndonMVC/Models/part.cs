using System;

namespace AndonMVC.Models
{
    public partial class part
    {
        public string partid { get; set; }
        public string partname { get; set; }
        public string moldid { get; set; }
        public Nullable<int> number_of_cavity_inmold { get; set; }
        public string keterangan { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
        public virtual mold mold { get; set; }
    }
}
