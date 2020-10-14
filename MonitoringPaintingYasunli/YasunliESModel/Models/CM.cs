using System;

namespace YasunliESModel.Models
{
    public partial class CM
    {
        public int CMSId { get; set; }
        public Nullable<decimal> Inspection { get; set; }
        public Nullable<decimal> Cutting { get; set; }
        public Nullable<decimal> Assembling { get; set; }
        public Nullable<decimal> Marking { get; set; }
        public Nullable<decimal> Packing { get; set; }
        public Nullable<int> OperatorQty { get; set; }
        public Nullable<decimal> CycleTime { get; set; }
        public Nullable<System.DateTime> CMSDate { get; set; }
        public string EmployeeId { get; set; }
        public string SPPNo { get; set; }
    }
}
