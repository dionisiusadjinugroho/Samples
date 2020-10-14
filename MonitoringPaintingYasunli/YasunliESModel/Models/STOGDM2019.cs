using System;

namespace YasunliESModel.Models
{
    public partial class STOGDM2019
    {
        public int Urutan { get; set; }
        public string ItemId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string Description { get; set; }
        public string UoM { get; set; }
        public Nullable<decimal> SaldoAwal { get; set; }
        public Nullable<decimal> Pemasukan { get; set; }
        public Nullable<decimal> Pengeluaran { get; set; }
        public Nullable<decimal> SaldoBuku { get; set; }
        public Nullable<decimal> SaldoAwalR { get; set; }
        public Nullable<decimal> PemasukanR { get; set; }
        public Nullable<decimal> PengeluaranR { get; set; }
    }
}
