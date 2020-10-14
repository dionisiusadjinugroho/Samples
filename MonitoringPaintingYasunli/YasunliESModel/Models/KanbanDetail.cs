using System;

namespace YasunliESModel.Models
{
    public partial class KanbanDetail
    {
        public System.Guid KanbanDetailId { get; set; }
        public Nullable<int> KanbanId { get; set; }
        public string ItemId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<System.DateTime> TransitTime { get; set; }
        public string NoKanban { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public Nullable<System.DateTime> ReqDate { get; set; }
        public string StrLoc { get; set; }
        public string SupplyArea { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Revisi { get; set; }
        public Nullable<System.DateTime> RevDate { get; set; }
    }
}
