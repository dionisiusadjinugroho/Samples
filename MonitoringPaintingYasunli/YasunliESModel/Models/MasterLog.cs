using System;

namespace YasunliESModel.Models
{
    public partial class MasterLog
    {
        public int MasterLogID { get; set; }
        public string tableName { get; set; }
        public Nullable<System.DateTime> commitDate { get; set; }
        public string Action { get; set; }
        public string NIK { get; set; }
        public string Data { get; set; }
    }
}
