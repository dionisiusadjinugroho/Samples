using System;

namespace YasunliESModel.Models
{
    public partial class ViewKanbanRemain2
    {
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Model { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<System.DateTime> TransitTime { get; set; }
        public string KanbanId { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public string StrLoc { get; set; }
        public string SupplyArea { get; set; }
        public string Customer { get; set; }
    }
}
