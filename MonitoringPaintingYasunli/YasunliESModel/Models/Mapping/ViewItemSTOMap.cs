using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewItemSTOMap : EntityTypeConfiguration<ViewItemSTO>
    {
        public ViewItemSTOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemID, t.ItemName, t.Keterangan });

            // Properties
            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired();

            this.Property(t => t.UoM)
                .HasMaxLength(50);

            this.Property(t => t.Keterangan)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("ViewItemSTO", "Inventory");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.UoM).HasColumnName("UoM");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
        }
    }
}
