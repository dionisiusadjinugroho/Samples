using System;

namespace YasunliESModel.Models
{
    public partial class PaymentTerm
    {
        public string PaymentTermID { get; set; }
        public string Description { get; set; }
        public Nullable<short> Due { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<short> PaymentTermType { get; set; }
    }
}
