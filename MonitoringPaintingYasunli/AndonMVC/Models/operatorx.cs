using System;

namespace AndonMVC.Models
{
    public partial class operatorx
    {
        public string operatorid { get; set; }
        public string nama { get; set; }
        public string divisi { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
    }
}
