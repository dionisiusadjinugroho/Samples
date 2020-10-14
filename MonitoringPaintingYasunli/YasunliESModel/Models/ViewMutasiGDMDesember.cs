using System;

namespace YasunliESModel.Models
{
    public partial class ViewMutasiGDMDesember
    {
        public Nullable<long> No { get; set; }
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public string Sat { get; set; }
        public Nullable<decimal> SaldoAwal { get; set; }
        public Nullable<decimal> Pemasukan { get; set; }
        public decimal PemasukanSistem { get; set; }
        public Nullable<decimal> Pengeluaran { get; set; }
        public int Penyesuaian { get; set; }
        public Nullable<decimal> SaldoBukuSistem { get; set; }
        public Nullable<decimal> SaldoBuku { get; set; }
        public Nullable<decimal> StockOpname { get; set; }
        public decimal Selisih { get; set; }
        public string Ket { get; set; }
    }
}
