namespace YasunliESModel.Models
{
    public partial class ItemAttachment
    {
        public int ItemAttachmentId { get; set; }
        public byte[] Attachment { get; set; }
        public string ItemId { get; set; }
        public System.DateTime AttachmentDate { get; set; }
        public string FileExt { get; set; }
    }
}
