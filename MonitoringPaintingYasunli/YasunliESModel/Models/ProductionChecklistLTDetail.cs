using System;

namespace YasunliESModel.Models
{
    public partial class ProductionChecklistLTDetail
    {
        public System.Guid ProductionCheckLisLTDetailtId { get; set; }
        public Nullable<System.Guid> ProductionCheckListId { get; set; }
        public string Cause { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<decimal> TotalLTMinutes { get; set; }
        public string PIC { get; set; }
        public string LeaderProduksi { get; set; }
    }
}
