using System;

namespace YasunliESModel.Models
{
    public partial class SuratJalanMaterial
    {
        public string SuratJalanMaterialID { get; set; }
        public string VendorID { get; set; }
        public string ToPlantID { get; set; }
        public string FromPlantID { get; set; }
        public string EmployeeID { get; set; }
        public Nullable<System.DateTime> SendDate { get; set; }
        public string PlantID { get; set; }
    }
}
