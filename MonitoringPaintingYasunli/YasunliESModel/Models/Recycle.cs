using System;

namespace YasunliESModel.Models
{
    public partial class Recycle
    {
        public string RecycleId { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string PlantID { get; set; }
        public string created_by { get; set; }
        public string administrator { get; set; }
    }
}
