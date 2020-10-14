using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BoxTypeMap : EntityTypeConfiguration<BoxType>
    {
        public BoxTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.BoxTypeID);

            // Properties
            this.Property(t => t.BoxTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Kategori)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BoxType", "Inventory");
            this.Property(t => t.BoxTypeID).HasColumnName("BoxTypeID");
            this.Property(t => t.BoxTypeName).HasColumnName("BoxTypeName");
            this.Property(t => t.Kategori).HasColumnName("Kategori");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Length).HasColumnName("Length");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
