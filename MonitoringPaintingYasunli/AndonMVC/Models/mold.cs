using System;
using System.Collections.Generic;

namespace AndonMVC.Models
{
    public partial class mold
    {
        public mold()
        {
            this.parts = new List<part>();
        }

        public string moldid { get; set; }
        public string keterangan { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
        public virtual ICollection<part> parts { get; set; }
    }
}
