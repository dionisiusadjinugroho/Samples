using System;
using System.Collections.Generic;

namespace YasunliESModel.Models
{
    public partial class MaterialReceiving
    {
        public MaterialReceiving()
        {
            this.MaterialReceivingDetails = new List<MaterialReceivingDetail>();
        }

        public string ReceivingID { get; set; }
        public string PlantID { get; set; }
        public string VendorID { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public string SuratJalanNo { get; set; }
        public Nullable<System.DateTime> ReceivingDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public Nullable<int> Status { get; set; }
        public string VoidBy { get; set; }
        public Nullable<System.DateTime> VoidDate { get; set; }
        public string VoidDescription { get; set; }
        public string NoInvoice { get; set; }
        public string NoPackingList { get; set; }
        public string NoDokumen { get; set; }
        public string NoMobil { get; set; }
        public Nullable<System.DateTime> DocumentDate { get; set; }
        public string NoPengajuan { get; set; }
        public string JenisDokumen { get; set; }
        public Nullable<System.DateTime> TglSuratJalan { get; set; }
        public string NomorAju { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual ICollection<MaterialReceivingDetail> MaterialReceivingDetails { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
