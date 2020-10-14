using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemIdStandardMap : EntityTypeConfiguration<ItemIdStandard>
    {
        public ItemIdStandardMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemId);

            // Properties
            this.Property(t => t.ItemId)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.ItemName)
                .HasMaxLength(500);

            this.Property(t => t.NewItemId)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ItemIdStandard", "Inventory");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.NewItemId).HasColumnName("NewItemId");
        }
    }
}
