using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemImageMap : EntityTypeConfiguration<ItemImage>
    {
        public ItemImageMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemImageId);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.FileExt)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ItemImage", "Inventory");
            this.Property(t => t.ItemImageId).HasColumnName("ItemImageId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.AttachmentDate).HasColumnName("AttachmentDate");
            this.Property(t => t.FileExt).HasColumnName("FileExt");
        }
    }
}
