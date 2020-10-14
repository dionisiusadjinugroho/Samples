using System;

namespace AndonMVC.Models
{
    public partial class part_on_mold
    {
        public string partid { get; set; }
        public string partname { get; set; }
        public string moldid { get; set; }
        public string moldname { get; set; }
        public Nullable<int> number_of_cavity_inmold { get; set; }
        public string keterangan { get; set; }
    }
}
