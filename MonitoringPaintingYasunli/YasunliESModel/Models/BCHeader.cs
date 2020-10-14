using System;

namespace YasunliESModel.Models
{
    public partial class BCHeader
    {
        public string NoPackingList { get; set; }
        public string NoTglPendaftaran { get; set; }
        public Nullable<System.DateTime> Tanggal { get; set; }
        public string NamaPerusahaan { get; set; }
        public string Alamat { get; set; }
        public string NoKontrak { get; set; }
        public string EXBC40 { get; set; }
        public Nullable<System.DateTime> TanggalEXBC { get; set; }
        public string JenisPengankut { get; set; }
        public string NomorPolisi { get; set; }
        public Nullable<int> JumlahKemasan { get; set; }
        public string JenisKemasan { get; set; }
        public string JenisTrans { get; set; }
        public string Keterangan { get; set; }
        public Nullable<System.DateTime> TglPendaftaran { get; set; }
        public string NoInvoice { get; set; }
        public string FinalDestination { get; set; }
        public string NomorPengajuan { get; set; }
        public Nullable<decimal> BeratKotor { get; set; }
        public Nullable<decimal> BeratBersih { get; set; }
        public string NPWPCustomer { get; set; }
        public string NamaCustomer { get; set; }
        public string NomorIzinPTBCustomer { get; set; }
        public string AlamatCustomer { get; set; }
        public string PosTarifHS { get; set; }
        public Nullable<System.DateTime> TanggalKontrak { get; set; }
        public string JenisValutaAsing { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string NPWPSender { get; set; }
        public string NamaSender { get; set; }
        public string NomorIzinPTBSender { get; set; }
        public string AlamatSender { get; set; }
        public string KantorAsal { get; set; }
        public string KantorTujuan { get; set; }
        public string JenisTPBAsal { get; set; }
        public string JenisTPBTujuan { get; set; }
        public Nullable<decimal> Volume { get; set; }
        public string NoSegel { get; set; }
        public Nullable<decimal> IdrRate { get; set; }
    }
}
