using System;

namespace YasunliESModel.Models
{
    public partial class MouldTransactionDetail
    {
        public string DetailId { get; set; }
        public string MouldId { get; set; }
        public string NamaMould { get; set; }
        public string Tooling { get; set; }
        public string KodeBarang { get; set; }
        public Nullable<int> Jumlah { get; set; }
        public string Satuan { get; set; }
        public string Jenis { get; set; }
        public Nullable<decimal> Berat { get; set; }
        public Nullable<System.DateTime> JatuhTempo { get; set; }
        public string MouldTransactionId { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public string Model { get; set; }
    }
}
