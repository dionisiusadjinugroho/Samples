using System;

namespace YasunliESModel.Models
{
    public partial class LimitSampleReturn
    {
        public int LimitSampleReturnId { get; set; }
        public string LimitSampleId { get; set; }
        public string ReturnBy { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
    }
}
