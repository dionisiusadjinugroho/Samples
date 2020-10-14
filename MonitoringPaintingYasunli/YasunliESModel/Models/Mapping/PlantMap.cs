using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PlantMap : EntityTypeConfiguration<Plant>
    {
        public PlantMap()
        {
            // Primary Key
            this.HasKey(t => t.PlantID);

            // Properties
            this.Property(t => t.PlantID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Plant", "Shared");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.PlantName).HasColumnName("PlantName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.SKEPKB).HasColumnName("SKEPKB");
        }
    }
}
