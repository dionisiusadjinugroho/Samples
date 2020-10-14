using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemPicMasterMap : EntityTypeConfiguration<ItemPicMaster>
    {
        public ItemPicMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemId);

            // Properties
            this.Property(t => t.ItemId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ItemPicMaster", "Inventory");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemPic).HasColumnName("ItemPic");
        }
    }
}
