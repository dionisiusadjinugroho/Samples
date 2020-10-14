using System;

namespace YasunliESModel.Models
{
    public partial class MouldTransactionHeader
    {
        public string MouldTransactionId { get; set; }
        public string NomorKontrak { get; set; }
        public string NomorAju { get; set; }
        public string NomorDokumen { get; set; }
        public Nullable<System.DateTime> TanggalTransaksi { get; set; }
        public Nullable<System.DateTime> TanggalDokumen { get; set; }
        public string RegMasuk { get; set; }
        public string KB { get; set; }
        public string Jenis { get; set; }
        public string JenisBC { get; set; }
        public string Keterangan { get; set; }
        public string VendorID { get; set; }
        public Nullable<System.DateTime> TanggalKontrak { get; set; }
        public string NoSuratJalan { get; set; }
        public Nullable<int> CurrencyID { get; set; }
    }
}
