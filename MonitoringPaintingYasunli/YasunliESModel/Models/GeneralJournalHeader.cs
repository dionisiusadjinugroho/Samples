using System;

namespace YasunliESModel.Models
{
    public partial class GeneralJournalHeader
    {
        public string JournalNo { get; set; }
        public string SourceTransaction { get; set; }
        public string SourceDocumentNo { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string JournalTypeId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public string ApprovedBy { get; set; }
        public string VoidBy { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
