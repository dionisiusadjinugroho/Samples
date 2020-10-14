using System;

namespace YasunliESModel.Models
{
    public partial class TransactionScrap
    {
        public string TransactionScrapNo { get; set; }
        public string JenisDokumen { get; set; }
        public string NoDokumen { get; set; }
        public Nullable<System.DateTime> DocumentDate { get; set; }
        public string NoInvoice { get; set; }
        public string NoSuratJalan { get; set; }
        public string CompanyDestinationID { get; set; }
        public string PlantID { get; set; }
        public Nullable<int> Status { get; set; }
        public string NoAju { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public string VoidBy { get; set; }
        public Nullable<System.DateTime> VoidDate { get; set; }
        public string VoidDescription { get; set; }
        public Nullable<decimal> Total_Qty { get; set; }
        public Nullable<decimal> Total_GrossWeight { get; set; }
        public Nullable<decimal> Total_Tax { get; set; }
        public Nullable<decimal> Total_DPP { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Tax_Type { get; set; }
        public Nullable<decimal> Tax_Percent { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Status_Transaction { get; set; }
    }
}
