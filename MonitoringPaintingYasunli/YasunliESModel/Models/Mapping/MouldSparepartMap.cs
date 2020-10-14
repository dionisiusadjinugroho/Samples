using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldSparepartMap : EntityTypeConfiguration<MouldSparepart>
    {
        public MouldSparepartMap()
        {
            // Primary Key
            this.HasKey(t => t.SparePartID);

            // Properties
            this.Property(t => t.SparePartID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VendorID)
                .HasMaxLength(50);

            this.Property(t => t.MouldID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MouldSparepart", "Inventory");
            this.Property(t => t.SparePartID).HasColumnName("SparePartID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.MouldID).HasColumnName("MouldID");
            this.Property(t => t.Usage).HasColumnName("Usage");
        }
    }
}
