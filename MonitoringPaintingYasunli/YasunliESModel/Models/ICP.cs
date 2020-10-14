using System;

namespace YasunliESModel.Models
{
    public partial class ICP
    {
        public string ICPID { get; set; }
        public string ItemID { get; set; }
        public string VendorID { get; set; }
        public string CustomerID { get; set; }
        public string Laboratory { get; set; }
        public string CertificateNo { get; set; }
        public byte[] CertificatePicture { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<decimal> Pb { get; set; }
        public Nullable<decimal> Cd { get; set; }
        public Nullable<decimal> Hg { get; set; }
        public Nullable<decimal> Cr { get; set; }
        public Nullable<decimal> PBB { get; set; }
        public Nullable<decimal> PBDE { get; set; }
    }
}
