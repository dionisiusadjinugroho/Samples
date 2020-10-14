using System;

namespace YasunliESModel.Models
{
    public partial class ItemQuantity
    {
        public System.Guid ItemQuantitiesID { get; set; }
        public string ItemID { get; set; }
        public string Location { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<short> Status { get; set; }
        public string DocumentNo { get; set; }
        public string FromDocumentNo { get; set; }
        public string Type { get; set; }
        public string LotNo { get; set; }
        public string PlantID { get; set; }
        public string FromDiv { get; set; }
        public string ToDiv { get; set; }
        public string admID { get; set; }
        public string plannerID { get; set; }
        public string LocationID { get; set; }
        public string ReceiveBy { get; set; }
        public string TokenId { get; set; }
        public Nullable<System.DateTime> TokenDate { get; set; }
    }
}
