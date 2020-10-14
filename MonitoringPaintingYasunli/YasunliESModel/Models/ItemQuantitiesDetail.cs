using System;

namespace YasunliESModel.Models
{
    public partial class ItemQuantitiesDetail
    {
        public System.Guid ItemQuantitiesDetailID { get; set; }
        public string BarcodeID { get; set; }
        public Nullable<System.Guid> ItemQuantitiesID { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
    }
}
