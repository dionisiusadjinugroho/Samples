using System;

namespace YasunliESModel.Models
{
    public partial class GeneralJournalDetail
    {
        public string GeneralJournalDetailId { get; set; }
        public string JournalId { get; set; }
        public Nullable<int> LineItemId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public string DocumentNo { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> Rate { get; set; }
    }
}
