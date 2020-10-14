using System;

namespace YasunliESModel.Models
{
    public partial class ViewItemListNew
    {
        public string NamaCustomer { get; set; }
        public string ItemID { get; set; }
        public string KodeItem { get; set; }
        public string ItemName { get; set; }
        public string Model { get; set; }
        public string Kategori { get; set; }
        public Nullable<int> JumlahGambar { get; set; }
        public string Satuan { get; set; }
        public Nullable<decimal> BeratPart { get; set; }
        public string SatuanBeratPart { get; set; }
        public Nullable<decimal> SatuanBeratRunner { get; set; }
        public string GrupMesin { get; set; }
        public string KodeMould { get; set; }
        public string NamaMould { get; set; }
        public string TipeMaterial { get; set; }
        public string ItemComponen { get; set; }
        public string NamaVendor { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Colour { get; set; }
        public string Side { get; set; }
        public Nullable<bool> UsageStop { get; set; }
        public string VersionInfo { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> TanggalDibuat { get; set; }
        public string MDI { get; set; }
        public Nullable<System.DateTime> BerlakuMulai { get; set; }
        public Nullable<System.DateTime> BerlakuSampai { get; set; }
        public string Kelengkapan { get; set; }
        public string QualityLevel { get; set; }
        public Nullable<decimal> ManPower { get; set; }
        public Nullable<decimal> AQL { get; set; }
        public int BQICSInfoPrefix { get; set; }
    }
}
