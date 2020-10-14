using System;

namespace YasunliESModel.Models
{
    public partial class EngineeringAttachment
    {
        public int EngineeringAttachmentId { get; set; }
        public Nullable<int> CaseId { get; set; }
        public byte[] Image { get; set; }
        public System.DateTime AttachmentDate { get; set; }
        public string AttachmentType { get; set; }
        public string Attachmentname { get; set; }
        public Nullable<int> EngineeringJobId { get; set; }
        public string FileExt { get; set; }
    }
}
