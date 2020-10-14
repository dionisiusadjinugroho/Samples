using System;

namespace YasunliESModel.Models
{
    public partial class AlatUkur
    {
        public string NoRegister { get; set; }
        public string NamaAlatUkur { get; set; }
        public string Range { get; set; }
        public string NoSeri { get; set; }
        public string Merk { get; set; }
        public Nullable<System.DateTime> TglPembelian { get; set; }
        public string FactPengguna { get; set; }
        public string DeptPengguna { get; set; }
        public string Grade { get; set; }
        public Nullable<int> Kalibrasi { get; set; }
        public Nullable<int> Verifikasi { get; set; }
    }
}
