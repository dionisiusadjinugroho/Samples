using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SellingPriceMap : EntityTypeConfiguration<SellingPrice>
    {
        public SellingPriceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.CustomerId)
                .HasMaxLength(50);

            this.Property(t => t.Created_By)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SellingPrice", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Effective_Date).HasColumnName("Effective_Date");
            this.Property(t => t.Created_By).HasColumnName("Created_By");
            this.Property(t => t.ServicePrice).HasColumnName("ServicePrice");
            this.Property(t => t.MaterialPrice).HasColumnName("MaterialPrice");
        }
    }
}
