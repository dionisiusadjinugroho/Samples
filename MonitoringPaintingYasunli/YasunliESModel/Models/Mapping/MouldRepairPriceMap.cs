using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldRepairPriceMap : EntityTypeConfiguration<MouldRepairPrice>
    {
        public MouldRepairPriceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ItemProcess)
                .HasMaxLength(200);

            this.Property(t => t.Created_By)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MouldRepairPrice", "Shared");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.ItemProcess).HasColumnName("ItemProcess");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Effective_Date).HasColumnName("Effective_Date");
            this.Property(t => t.Created_By).HasColumnName("Created_By");
        }
    }
}
