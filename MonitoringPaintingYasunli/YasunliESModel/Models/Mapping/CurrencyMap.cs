using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class CurrencyMap : EntityTypeConfiguration<Currency>
    {
        public CurrencyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.KodeCurrency)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Currency", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.KodeCurrency).HasColumnName("KodeCurrency");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
        }
    }
}
