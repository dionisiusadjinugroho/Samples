using System;

namespace YasunliESModel.Models
{
    public partial class ViewDataDetailBoM
    {
        public int DetailBoMID { get; set; }
        public Nullable<int> BoMID { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
    }
}
