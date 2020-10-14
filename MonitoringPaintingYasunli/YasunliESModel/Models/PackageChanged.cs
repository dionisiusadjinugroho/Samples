using System;

namespace YasunliESModel.Models
{
    public partial class PackageChanged
    {
        public int ID { get; set; }
        public string PackageAkhir { get; set; }
        public Nullable<System.DateTime> TanggalRubah { get; set; }
        public string created_by { get; set; }
        public string PackageID { get; set; }
    }
}
