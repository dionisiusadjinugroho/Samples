using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ItemDrawingMap : EntityTypeConfiguration<ItemDrawing>
    {
        public ItemDrawingMap()
        {
            // Primary Key
            this.HasKey(t => t.ItemDrawingId);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.FileName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ItemDrawing", "Inventory");
            this.Property(t => t.ItemDrawingId).HasColumnName("ItemDrawingId");
            this.Property(t => t.Drawing).HasColumnName("Drawing");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.AttachmentDate).HasColumnName("AttachmentDate");
            this.Property(t => t.FileName).HasColumnName("FileName");
        }
    }
}
