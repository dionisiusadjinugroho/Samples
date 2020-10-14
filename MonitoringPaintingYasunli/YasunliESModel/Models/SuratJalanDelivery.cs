using System;

namespace YasunliESModel.Models
{
    public partial class SuratJalanDelivery
    {
        public string NoSuratJalan { get; set; }
        public Nullable<int> TransitID { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> tanggalSJ { get; set; }
        public Nullable<int> printed { get; set; }
    }
}
