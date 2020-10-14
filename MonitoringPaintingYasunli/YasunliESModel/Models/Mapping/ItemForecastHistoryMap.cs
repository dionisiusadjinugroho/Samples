using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemForecastHistoryMap : EntityTypeConfiguration<ItemForecastHistory>
    {
        public ItemForecastHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemForecastHistoryId);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(200);

            this.Property(t => t.CustomerId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ItemForecastHistory", "Shared");
            this.Property(t => t.ItemForecastHistoryId).HasColumnName("ItemForecastHistoryId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
        }
    }
}
