using System;

namespace YasunliESModel.Models
{
    public partial class RequestOrderDetail
    {
        public System.Guid RequestOrderDetailID { get; set; }
        public string RequestID { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<System.DateTime> Tanggal { get; set; }
        public string SPPNo { get; set; }
        public string Tooling { get; set; }
        public string Cavity { get; set; }
    }
}
