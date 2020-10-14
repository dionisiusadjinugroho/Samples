using System;

namespace YasunliESModel.Models
{
    public partial class BQICSMarking
    {
        public System.Guid BQICSMarkingId { get; set; }
        public string LotNo { get; set; }
        public string ItemId { get; set; }
        public string SppNo { get; set; }
        public Nullable<System.DateTime> MarkDate { get; set; }
        public Nullable<bool> Marking { get; set; }
        public string InspectionResult { get; set; }
        public Nullable<System.DateTime> ConfirmedDate { get; set; }
        public Nullable<System.DateTime> InspectingDate { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
    }
}
