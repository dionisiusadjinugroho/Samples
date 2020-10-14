using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DriverDetailMap : EntityTypeConfiguration<DriverDetail>
    {
        public DriverDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.DriverDetailID);

            // Properties
            this.Property(t => t.DriverID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DriverDetail", "Shared");
            this.Property(t => t.DriverDetailID).HasColumnName("DriverDetailID");
            this.Property(t => t.DriverID).HasColumnName("DriverID");
            this.Property(t => t.Finger).HasColumnName("Finger");
        }
    }
}
