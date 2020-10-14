using System;

namespace YasunliESModel.Models
{
    public partial class PurchaseReturn
    {
        public string PurchaseReturnNo { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public string VendorID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Notes { get; set; }
        public string ReceivingID { get; set; }
        public Nullable<int> Status { get; set; }
        public string NoSuratJalanReturn { get; set; }
        public string NoDokumen { get; set; }
        public string NoAJU { get; set; }
        public string NoMobil { get; set; }
        public string TipeDokumen { get; set; }
        public string NoPackingListReturn { get; set; }
        public string VoidBy { get; set; }
        public Nullable<System.DateTime> VoidDate { get; set; }
        public Nullable<int> CurrencyID { get; set; }
    }
}
