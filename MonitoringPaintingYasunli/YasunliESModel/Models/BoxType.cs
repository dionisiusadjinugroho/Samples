using System;

namespace YasunliESModel.Models
{
    public partial class BoxType
    {
        public string BoxTypeID { get; set; }
        public string BoxTypeName { get; set; }
        public string Kategori { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Height { get; set; }
        public string Description { get; set; }
    }
}
