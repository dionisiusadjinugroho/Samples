using System;

namespace YasunliESModel.Models
{
    public partial class LimitSample
    {
        public string LimitSampleId { get; set; }
        public string CustomerId { get; set; }
        public string ItemId { get; set; }
        public string NGCriteria { get; set; }
        public string Zona { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Remarks { get; set; }
        public string ZonaANGCriteria { get; set; }
        public string ZonaBNGCriteria { get; set; }
        public string ZonaCNGCriteria { get; set; }
        public string ZonaDNGCriteria { get; set; }
        public string ZonaARemarks { get; set; }
        public string ZonaBRemarks { get; set; }
        public string ZonaCRemarks { get; set; }
        public string ZonaDRemarks { get; set; }
        public int LimitIndex { get; set; }
    }
}
