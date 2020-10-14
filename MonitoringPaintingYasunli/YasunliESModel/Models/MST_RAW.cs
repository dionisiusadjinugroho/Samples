using System;

namespace YasunliESModel.Models
{
    public partial class MST_RAW
    {
        public string FCID { get; set; }
        public string FCNAME { get; set; }
        public string FCID_ALT { get; set; }
        public string FCPRC_CODE { get; set; }
        public string FCID_CUST { get; set; }
        public string FCID_SUPL { get; set; }
        public string FCMAIN { get; set; }
        public string FCSUB { get; set; }
        public string FC_PO { get; set; }
        public string FCRACK { get; set; }
        public string FCMETHODE { get; set; }
        public string FCPACKING { get; set; }
        public string FCMIXING { get; set; }
        public Nullable<decimal> FNMIN { get; set; }
        public Nullable<decimal> FNMAX { get; set; }
        public Nullable<decimal> FNSALE_A { get; set; }
        public Nullable<decimal> FNSALE_B { get; set; }
        public Nullable<decimal> FNSALE_C { get; set; }
        public Nullable<decimal> FNSALE_D { get; set; }
        public Nullable<decimal> FNSALE_E { get; set; }
        public Nullable<decimal> FNSALE_F { get; set; }
        public Nullable<decimal> FNSALE_G { get; set; }
        public Nullable<decimal> FNDISCOUNT { get; set; }
        public Nullable<bool> FLCONTINUE { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public string FCDOC { get; set; }
    }
}
