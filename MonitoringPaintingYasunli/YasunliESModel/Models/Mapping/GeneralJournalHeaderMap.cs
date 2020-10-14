using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class GeneralJournalHeaderMap : EntityTypeConfiguration<GeneralJournalHeader>
    {
        public GeneralJournalHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.JournalNo);

            // Properties
            this.Property(t => t.JournalNo)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("GeneralJournalHeader");
            this.Property(t => t.JournalNo).HasColumnName("JournalNo");
            this.Property(t => t.SourceTransaction).HasColumnName("SourceTransaction");
            this.Property(t => t.SourceDocumentNo).HasColumnName("SourceDocumentNo");
            this.Property(t => t.TransactionDate).HasColumnName("TransactionDate");
            this.Property(t => t.JournalTypeId).HasColumnName("JournalTypeId");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyId");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ApprovedBy).HasColumnName("ApprovedBy");
            this.Property(t => t.VoidBy).HasColumnName("VoidBy");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
