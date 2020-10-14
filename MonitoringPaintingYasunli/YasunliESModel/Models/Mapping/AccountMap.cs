using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountId);

            // Properties
            this.Property(t => t.AccountId)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.AccountName)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Account");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.AccountType).HasColumnName("AccountType");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.Hierarchy).HasColumnName("Hierarchy");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsLastChild).HasColumnName("IsLastChild");
        }
    }
}
