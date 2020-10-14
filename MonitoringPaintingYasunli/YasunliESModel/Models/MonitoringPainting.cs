namespace YasunliESModel.Models
{
    public partial class MonitoringPainting
    {
        public int ID { get; set; }
        public string BarcodeID { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string Model { get; set; }
        public string BarcodeIDBox { get; set; }
        public int ScanCount { get; set; }
        public string Judge { get; set; }
        public string ScanBy { get; set; }

    }
}
