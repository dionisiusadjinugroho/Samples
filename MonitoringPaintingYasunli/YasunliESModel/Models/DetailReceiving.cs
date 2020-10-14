using System;

namespace YasunliESModel.Models
{
    public partial class DetailReceiving
    {
        public string DetailReceivingID { get; set; }
        public string ReceivingID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string LotNumber { get; set; }
        public string ItemId { get; set; }
        public string PurchaseOrderId { get; set; }
        public string Location { get; set; }
        public string Jenis { get; set; }
    }
}
