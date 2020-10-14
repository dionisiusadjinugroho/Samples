using System.Collections.Generic;

namespace YasunliESModel.Models
{
    public partial class Division
    {
        public Division()
        {
            this.MaterialOuts = new List<MaterialOut>();
            this.MaterialOuts1 = new List<MaterialOut>();
            this.MaterialReturn1 = new List<MaterialReturn1>();
            this.MaterialReturn11 = new List<MaterialReturn1>();
        }

        public string DivisionID { get; set; }
        public string DivisionName { get; set; }
        public virtual ICollection<MaterialOut> MaterialOuts { get; set; }
        public virtual ICollection<MaterialOut> MaterialOuts1 { get; set; }
        public virtual ICollection<MaterialReturn1> MaterialReturn1 { get; set; }
        public virtual ICollection<MaterialReturn1> MaterialReturn11 { get; set; }
    }
}
