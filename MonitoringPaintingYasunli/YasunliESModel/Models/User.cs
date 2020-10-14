using System;

namespace YasunliESModel.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string NamaKaryawan { get; set; }
        public string Finger { get; set; }
        public Nullable<bool> IsLogin { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public string Division { get; set; }
        public string Jabatan { get; set; }
        public string PlantID { get; set; }
        public string IP { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Reprint { get; set; }
        public Nullable<bool> SplitQty { get; set; }
        public Nullable<bool> LabelES { get; set; }
        public Nullable<bool> LabelPartial { get; set; }
        public Nullable<bool> LimitSample { get; set; }
    }
}
