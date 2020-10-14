using System;

namespace YasunliESModel.Models
{
    public partial class Mobil
    {
        public string NoPolisi { get; set; }
        public string RentalID { get; set; }
        public string TipeMobil { get; set; }
        public string NoSTNK { get; set; }
        public Nullable<System.DateTime> ValidDate { get; set; }
    }
}
