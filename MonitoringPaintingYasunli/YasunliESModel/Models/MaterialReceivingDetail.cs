using System;

namespace YasunliESModel.Models
{
    public partial class MaterialReceivingDetail
    {
        public int DetailID { get; set; }
        public string ReceivingID { get; set; }
        public string PONo { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string LotNumber { get; set; }
        public string Location { get; set; }
        public Nullable<int> PODetailID { get; set; }
        public virtual MaterialReceiving MaterialReceiving { get; set; }
    }
}
