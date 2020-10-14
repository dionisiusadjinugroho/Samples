namespace YasunliESModel.Models
{
    public partial class ItemImage
    {
        public int ItemImageId { get; set; }
        public string ItemId { get; set; }
        public byte[] Image { get; set; }
        public System.DateTime AttachmentDate { get; set; }
        public string FileExt { get; set; }
    }
}
