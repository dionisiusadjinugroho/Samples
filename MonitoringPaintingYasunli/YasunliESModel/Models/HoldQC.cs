using System;

namespace YasunliESModel.Models
{
    public partial class HoldQC
    {
        public string HoldQCID { get; set; }
        public string BarcodeID { get; set; }
        public string HoldStatusID { get; set; }
        public string ClaimNo { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
        public string UserHold { get; set; }
        public string Keterangan { get; set; }
        public Nullable<System.DateTime> HoldDate { get; set; }
        public string UserRelease { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
    }
}
