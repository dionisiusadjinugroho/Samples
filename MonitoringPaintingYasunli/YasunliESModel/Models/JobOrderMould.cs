using System;

namespace YasunliESModel.Models
{
    public partial class JobOrderMould
    {
        public string JobOrderMouldId { get; set; }
        public string PlantId { get; set; }
        public string MouldCode { get; set; }
        public string ToolingId { get; set; }
        public string JenisKerusakanPart { get; set; }
        public string CreatedBy { get; set; }
        public string Notes { get; set; }
        public string JenisKerusakanMould { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string VerifiedBy { get; set; }
        public Nullable<System.DateTime> VerifiedDate { get; set; }
        public Nullable<System.DateTime> FinishedDate { get; set; }
        public string FinishedBy { get; set; }
        public Nullable<int> status { get; set; }
    }
}
