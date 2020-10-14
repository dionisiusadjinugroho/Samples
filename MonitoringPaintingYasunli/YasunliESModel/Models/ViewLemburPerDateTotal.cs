using System;

namespace YasunliESModel.Models
{
    public partial class ViewLemburPerDateTotal
    {
        public string PackageID { get; set; }
        public string BarcodeID { get; set; }
        public string KirimKe { get; set; }
        public string QCOut { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public string SPPNo { get; set; }
        public string InjectionCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string MainModel { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<decimal> SPQ { get; set; }
        public string BoxType { get; set; }
        public string ADM { get; set; }
        public string Planner { get; set; }
    }
}
