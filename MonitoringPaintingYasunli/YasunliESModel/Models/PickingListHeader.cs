using System;

namespace YasunliESModel.Models
{
    public partial class PickingListHeader
    {
        public int Id { get; set; }
        public string ItemID { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<int> Cavity { get; set; }
        public Nullable<int> Tooling { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string PlantID { get; set; }
    }
}
