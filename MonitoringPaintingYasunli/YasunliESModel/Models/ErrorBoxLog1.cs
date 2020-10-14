using System;

namespace YasunliESModel.Models
{
    public partial class ErrorBoxLog1
    {
        public int Id { get; set; }
        public string BarcodeId { get; set; }
        public Nullable<System.DateTime> ScanDate { get; set; }
        public string Gate { get; set; }
        public string LogedInUser { get; set; }
        public string ErrorText { get; set; }
        public string Posisi { get; set; }
        public string Form { get; set; }
        public string NextPosition { get; set; }
    }
}
