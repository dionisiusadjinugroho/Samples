using System;

namespace YasunliESModel.Models
{
    public partial class PackageDetail
    {
        public System.Guid PackageDetailID { get; set; }
        public string PackageID { get; set; }
        public string BarcodeID { get; set; }
        public Nullable<bool> Status { get; set; }
        public string PlantID { get; set; }
        public string Receive_By { get; set; }
        public string Created_By { get; set; }
    }
}
