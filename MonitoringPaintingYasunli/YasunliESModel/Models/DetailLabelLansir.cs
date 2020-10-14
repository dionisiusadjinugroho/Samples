using System;

namespace YasunliESModel.Models
{
    public partial class DetailLabelLansir
    {
        public int DetailLabelID { get; set; }
        public Nullable<int> LabelID { get; set; }
        public string BarcodeID { get; set; }
        public string Created_By { get; set; }
        public Nullable<int> LabelFG { get; set; }
        public string Leader_Scan { get; set; }
        public string Engineering_Scan { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string created_pecahan_by { get; set; }
        public string CustomerBarcode { get; set; }
        public string LotNo { get; set; }
        public Nullable<bool> LotGuarantee { get; set; }
        public Nullable<bool> Z4M { get; set; }
        public Nullable<bool> SA { get; set; }
        public Nullable<bool> EQZD { get; set; }
    }
}
