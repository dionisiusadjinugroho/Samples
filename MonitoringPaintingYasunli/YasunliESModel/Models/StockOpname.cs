using System;

namespace YasunliESModel.Models
{
    public partial class StockOpname
    {
        public string StockOpnameID { get; set; }
        public string PlantID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<byte> Started { get; set; }
        public string TableName { get; set; }
        public string Printing { get; set; }
        public string Painting { get; set; }
        public string Assembling { get; set; }
        public string Finishing { get; set; }
        public string Gudang { get; set; }
        public string Delivery { get; set; }
        public string TablePrinting { get; set; }
        public string TablePainting { get; set; }
        public string TableAssembling { get; set; }
        public string TableFinishing { get; set; }
        public string TableGudang { get; set; }
        public string TableDelivery { get; set; }
    }
}
