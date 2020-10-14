using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemAttachmentMap : EntityTypeConfiguration<ItemAttachment>
    {
        public ItemAttachmentMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemAttachmentId);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.FileExt)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ItemAttachment", "Inventory");
            this.Property(t => t.ItemAttachmentId).HasColumnName("ItemAttachmentId");
            this.Property(t => t.Attachment).HasColumnName("Attachment");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.AttachmentDate).HasColumnName("AttachmentDate");
            this.Property(t => t.FileExt).HasColumnName("FileExt");
        }
    }
}
