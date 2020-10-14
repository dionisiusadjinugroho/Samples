using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemQuantitiesDetailMap : EntityTypeConfiguration<ItemQuantitiesDetail>
    {
        public ItemQuantitiesDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemQuantitiesDetailID);

            // Properties
            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ItemQuantitiesDetail", "Inventory");
            this.Property(t => t.ItemQuantitiesDetailID).HasColumnName("ItemQuantitiesDetailID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.ItemQuantitiesID).HasColumnName("ItemQuantitiesID");
            this.Property(t => t.created_date).HasColumnName("created_date");
        }
    }
}
