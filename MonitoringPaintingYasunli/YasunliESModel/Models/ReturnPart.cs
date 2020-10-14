using System;

namespace YasunliESModel.Models
{
    public partial class ReturnPart
    {
        public string ReturnPartID { get; set; }
        public string NoSuratJalan { get; set; }
        public string CustomerID { get; set; }
        public string PlantID { get; set; }
        public string submited_by { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
    }
}
