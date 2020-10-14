using System;

namespace YasunliESModel.Models
{
    public partial class ECN
    {
        public string OldItem { get; set; }
        public string NewItem { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public byte[] Approval { get; set; }
    }
}
