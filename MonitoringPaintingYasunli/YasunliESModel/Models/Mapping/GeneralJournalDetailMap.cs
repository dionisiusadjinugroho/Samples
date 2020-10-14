using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class GeneralJournalDetailMap : EntityTypeConfiguration<GeneralJournalDetail>
    {
        public GeneralJournalDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.GeneralJournalDetailId);

            // Properties
            this.Property(t => t.GeneralJournalDetailId)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.JournalId)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("GeneralJournalDetail");
            this.Property(t => t.GeneralJournalDetailId).HasColumnName("GeneralJournalDetailId");
            this.Property(t => t.JournalId).HasColumnName("JournalId");
            this.Property(t => t.LineItemId).HasColumnName("LineItemId");
            this.Property(t => t.AccountCode).HasColumnName("AccountCode");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DocumentNo).HasColumnName("DocumentNo");
            this.Property(t => t.Debit).HasColumnName("Debit");
            this.Property(t => t.Credit).HasColumnName("Credit");
            this.Property(t => t.Rate).HasColumnName("Rate");
        }
    }
}
