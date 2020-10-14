using System;

namespace YasunliESModel.Models
{
    public partial class ViewMutasiGDMJanuari
    {
        public Nullable<long> No { get; set; }
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public string Sat { get; set; }
        public Nullable<decimal> SaldoAwal { get; set; }
        public Nullable<decimal> Pemasukan { get; set; }
        public Nullable<decimal> PemasukanSistem { get; set; }
        public Nullable<decimal> Pengeluaran { get; set; }
        public Nullable<decimal> Penyesuaian { get; set; }
        public Nullable<decimal> SaldoBuku { get; set; }
        public int StockOpname { get; set; }
        public int Selisih { get; set; }
        public string Ket { get; set; }
    }
}
