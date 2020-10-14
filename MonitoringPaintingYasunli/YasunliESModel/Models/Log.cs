using System;

namespace YasunliESModel.Models
{
    public partial class Log
    {
        public System.Guid LogID { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
        public string FormName { get; set; }
        public string Action { get; set; }
        public string Username { get; set; }
        public string DocumentNo { get; set; }
        public string LastValue { get; set; }
    }
}
