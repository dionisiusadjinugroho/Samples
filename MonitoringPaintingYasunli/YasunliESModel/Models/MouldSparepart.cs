using System;

namespace YasunliESModel.Models
{
    public partial class MouldSparepart
    {
        public string SparePartID { get; set; }
        public string VendorID { get; set; }
        public string MouldID { get; set; }
        public Nullable<int> Usage { get; set; }
    }
}
