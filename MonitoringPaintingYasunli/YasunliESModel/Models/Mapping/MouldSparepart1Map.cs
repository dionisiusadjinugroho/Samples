using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldSparepart1Map : EntityTypeConfiguration<MouldSparepart1>
    {
        public MouldSparepart1Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PartID)
                .HasMaxLength(50);

            this.Property(t => t.PartName)
                .HasMaxLength(50);

            this.Property(t => t.MainSupplier)
                .HasMaxLength(50);

            this.Property(t => t.UnitMeasurement)
                .HasMaxLength(50);

            this.Property(t => t.InputUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MouldSparepart1", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PartID).HasColumnName("PartID");
            this.Property(t => t.PartName).HasColumnName("PartName");
            this.Property(t => t.MainSupplier).HasColumnName("MainSupplier");
            this.Property(t => t.UnitMeasurement).HasColumnName("UnitMeasurement");
            this.Property(t => t.InputDate).HasColumnName("InputDate");
            this.Property(t => t.InputUser).HasColumnName("InputUser");
        }
    }
}
