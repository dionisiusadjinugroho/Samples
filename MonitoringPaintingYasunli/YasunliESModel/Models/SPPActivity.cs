using System;

namespace YasunliESModel.Models
{
    public partial class SPPActivity
    {
        public int ID { get; set; }
        public string SPPNo { get; set; }
        public Nullable<int> Activity { get; set; }
        public Nullable<DateTime> ActivityDate { get; set; }
        public string ActivityBy { get; set; }

    }
}
