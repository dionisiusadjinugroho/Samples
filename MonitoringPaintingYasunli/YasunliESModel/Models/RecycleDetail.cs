using System;

namespace YasunliESModel.Models
{
    public partial class RecycleDetail
    {
        public int Id { get; set; }
        public string BoxNo { get; set; }
        public string DocumentNo { get; set; }
        public string JobOrderId { get; set; }
        public string SPPNo { get; set; }
        public string RecycleId { get; set; }
        public Nullable<decimal> Qty { get; set; }
    }
}
