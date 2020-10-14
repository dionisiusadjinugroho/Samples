using System;

namespace YasunliESModel.Models
{
    public partial class MouldRepairDetail
    {
        public int DetailMouldRepairId { get; set; }
        public Nullable<int> MouldRepairId { get; set; }
        public Nullable<int> SparepartId { get; set; }
        public Nullable<decimal> Qty { get; set; }
    }
}
