using System;

namespace YasunliESModel.Models
{
    public partial class Roh
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string SuratJalanNo { get; set; }
        public string LotNumber { get; set; }
        public Nullable<int> PB { get; set; }
        public Nullable<int> CD { get; set; }
        public Nullable<int> HG { get; set; }
        public Nullable<int> CR { get; set; }
        public Nullable<int> BR { get; set; }
        public string UserCreated { get; set; }
    }
}
