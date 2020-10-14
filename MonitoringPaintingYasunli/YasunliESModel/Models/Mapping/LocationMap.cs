using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.LocationID, t.PlantID });

            // Properties
            this.Property(t => t.LocationID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DivisionID)
                .HasMaxLength(50);

            this.Property(t => t.LocationName)
                .HasMaxLength(50);

            this.Property(t => t.Model)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Location", "Inventory");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.DivisionID).HasColumnName("DivisionID");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.Model).HasColumnName("Model");
        }
    }
}
