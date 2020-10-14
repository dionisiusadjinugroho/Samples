using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BoxLocationMap : EntityTypeConfiguration<BoxLocation>
    {
        public BoxLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.BoxLocationID);

            // Properties
            this.Property(t => t.BoxID)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.DivisionID)
                .HasMaxLength(50);

            this.Property(t => t.CustomerID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BoxLocation", "Inventory");
            this.Property(t => t.BoxLocationID).HasColumnName("BoxLocationID");
            this.Property(t => t.BoxID).HasColumnName("BoxID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.DivisionID).HasColumnName("DivisionID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.Dates).HasColumnName("Dates");
        }
    }
}
