using System;

namespace YasunliESModel.Models
{
    public partial class BCDetail
    {
        public System.Guid DetailId { get; set; }
        public string ItemId { get; set; }
        public Nullable<decimal> BeratPart { get; set; }
        public Nullable<decimal> BeratKemasan { get; set; }
        public string NoSuratJalan { get; set; }
        public Nullable<decimal> PricePerUnnit { get; set; }
        public Nullable<decimal> JumlahSatuan { get; set; }
        public string NoPackingList { get; set; }
        public Nullable<decimal> NilaiPabean { get; set; }
        public Nullable<int> JumlahBox { get; set; }
    }
}
