using System;

namespace YasunliESModel.Models
{
    public partial class PSIDetail
    {
        public System.Guid PSIDetailId { get; set; }
        public Nullable<System.Guid> PSIUniqueId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Qty { get; set; }
    }
}
