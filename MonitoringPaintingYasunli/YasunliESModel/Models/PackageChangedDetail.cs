using System;

namespace YasunliESModel.Models
{
    public partial class PackageChangedDetail
    {
        public int Id { get; set; }
        public Nullable<int> PackageChanged_Id { get; set; }
        public string BarcodeId { get; set; }
        public string PackageAwal { get; set; }
    }
}
