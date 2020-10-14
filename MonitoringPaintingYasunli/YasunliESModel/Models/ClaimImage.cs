using System;

namespace YasunliESModel.Models
{
    public partial class ClaimImage
    {
        public int ClaimImageId { get; set; }
        public Nullable<int> ClaimId { get; set; }
        public byte[] Image { get; set; }
        public System.DateTime AttachmentDate { get; set; }
    }
}
