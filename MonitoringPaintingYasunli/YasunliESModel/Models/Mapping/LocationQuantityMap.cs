using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class LocationQuantityMap : EntityTypeConfiguration<LocationQuantity>
    {
        public LocationQuantityMap()
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

            this.Property(t => t.DocumentID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LocationQuantities", "Inventory");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.DocumentID).HasColumnName("DocumentID");
            this.Property(t => t.LastEdited).HasColumnName("LastEdited");
        }
    }
}
