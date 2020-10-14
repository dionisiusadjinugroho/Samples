using System;

namespace YasunliESModel.Models
{
    public partial class Driver
    {
        public string DriverID { get; set; }
        public string RentalID { get; set; }
        public string NamaDriver { get; set; }
        public string AlamatDriver { get; set; }
        public string TempatLahir { get; set; }
        public Nullable<System.DateTime> TanggalLahir { get; set; }
        public string NoKTP { get; set; }
        public string NoSIM { get; set; }
        public Nullable<System.DateTime> ValidUntil { get; set; }
        public string Finger { get; set; }
    }
}
