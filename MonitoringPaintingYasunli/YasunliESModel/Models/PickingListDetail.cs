using System;

namespace YasunliESModel.Models
{
    public partial class PickingListDetail
    {
        public int Id { get; set; }
        public Nullable<int> PickingListHeaderId { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
    }
}
