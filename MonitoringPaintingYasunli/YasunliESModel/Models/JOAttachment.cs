using System;

namespace YasunliESModel.Models
{
    public partial class JOAttachment
    {
        public int JOAttachmentID { get; set; }
        public Nullable<int> JobOrderID { get; set; }
        public byte[] PDFAttachment { get; set; }
        public Nullable<System.DateTime> AttachmentDate { get; set; }
        public byte[] PictureENG { get; set; }
    }
}
