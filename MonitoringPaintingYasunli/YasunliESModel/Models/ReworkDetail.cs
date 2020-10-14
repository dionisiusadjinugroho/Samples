using System;

namespace YasunliESModel.Models
{
    public partial class ReworkDetail
    {
        public System.Guid ReworkDetailID { get; set; }
        public string ReworkID { get; set; }
        public string BarcodeID { get; set; }
        public Nullable<bool> Status { get; set; }
        public string PlantID { get; set; }
        public string Receive_By { get; set; }
        public string Created_By { get; set; }
        public string Position { get; set; }
        public string NextPosition { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
        public Nullable<int> Qty { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Model { get; set; }
    }
}
