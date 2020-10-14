using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemPlantMappingMap : EntityTypeConfiguration<ItemPlantMapping>
    {
        public ItemPlantMappingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemId, t.MaterialName, t.Plant });

            // Properties
            this.Property(t => t.ItemId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MaterialName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Plant)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ItemPlantMapping", "Inventory");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.MaterialName).HasColumnName("MaterialName");
            this.Property(t => t.Plant).HasColumnName("Plant");
        }
    }
}
