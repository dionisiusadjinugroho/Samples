using System;

namespace YasunliESModel.Models
{
    public partial class Claim
    {
        public int ClaimId { get; set; }
        public string CustomerId { get; set; }
        public string MouldId { get; set; }
        public string ItemId { get; set; }
        public string ToolingId { get; set; }
        public string Cavity { get; set; }
        public Nullable<System.DateTime> ClaimDate { get; set; }
        public string ClaimNo { get; set; }
        public string ClaimDetail { get; set; }
        public string RootClause { get; set; }
        public string CounterMeasure { get; set; }
        public Nullable<System.DateTime> EffDate { get; set; }
        public string WINo { get; set; }
        public string FMEANo { get; set; }
        public string PlantId { get; set; }
        public string CreatedBy { get; set; }
        public byte[] Attachment { get; set; }
        public string ReffNo { get; set; }
    }
}
