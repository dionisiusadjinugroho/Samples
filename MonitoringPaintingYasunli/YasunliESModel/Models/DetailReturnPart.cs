using System;

namespace YasunliESModel.Models
{
    public partial class DetailReturnPart
    {
        public int DetailReturnPartID { get; set; }
        public string ReturnPartID { get; set; }
        public string ItemID { get; set; }
        public Nullable<int> Qty { get; set; }
        public string SPQID { get; set; }
        public Nullable<int> SPQQty { get; set; }
        public string ToolingId { get; set; }
        public string Cavity { get; set; }
    }
}
