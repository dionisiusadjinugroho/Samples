using System;

namespace YasunliESModel.Models
{
    public partial class JobOrder
    {
        public string JobID { get; set; }
        public string ItemID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string DivisionID { get; set; }
        public string SPPNo { get; set; }
        public string Description { get; set; }
        public string PlantID { get; set; }
        public string Keterangan { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string PMaterial { get; set; }
    }
}
