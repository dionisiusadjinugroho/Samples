namespace YasunliESModel.Models
{
    public partial class ItemDrawing
    {
        public int ItemDrawingId { get; set; }
        public byte[] Drawing { get; set; }
        public string ItemId { get; set; }
        public System.DateTime AttachmentDate { get; set; }
        public string FileName { get; set; }
    }
}
