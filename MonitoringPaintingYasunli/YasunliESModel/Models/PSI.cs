using System;

namespace YasunliESModel.Models
{
    public partial class PSI
    {
        public System.Guid PSIUniqueId { get; set; }
        public string ItemId { get; set; }
        public string Customer { get; set; }
        public Nullable<decimal> IEIStock { get; set; }
        public Nullable<decimal> RawStock { get; set; }
        public Nullable<decimal> GITStock { get; set; }
        public Nullable<decimal> OSReq { get; set; }
        public Nullable<decimal> YasunliStock { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> HoldQty { get; set; }
        public string Plant { get; set; }
        public string MachineNo { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string FileName { get; set; }
    }
}
