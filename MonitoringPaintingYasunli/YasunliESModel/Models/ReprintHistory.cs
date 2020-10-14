using System;

namespace YasunliESModel.Models
{
    public partial class ReprintHistory
    {
        public string BarcodeID { get; set; }
        public string LabelFG { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Position { get; set; }
        public string NextPosition { get; set; }
        public int Id { get; set; }
    }
}
