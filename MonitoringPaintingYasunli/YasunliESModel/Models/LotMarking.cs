using System;

namespace YasunliESModel.Models
{
    public partial class LotMarking
    {
        public System.Guid LotMarkerId { get; set; }
        public string LotNo { get; set; }
        public string ItemId { get; set; }
        public string SppNo { get; set; }
        public Nullable<System.DateTime> MarkDate { get; set; }
        public Nullable<bool> Marking { get; set; }
        public string MarkedBy { get; set; }
    }
}
