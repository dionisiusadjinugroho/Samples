using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BoxLabelRusakMap : EntityTypeConfiguration<BoxLabelRusak>
    {
        public BoxLabelRusakMap()
        {
            // Primary Key
            this.HasKey(t => t.BoxLabelRusakID);

            // Properties
            this.Property(t => t.BoxNo)
                .HasMaxLength(50);

            this.Property(t => t.BoxID)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BoxLabelRusak", "Inventory");
            this.Property(t => t.BoxLabelRusakID).HasColumnName("BoxLabelRusakID");
            this.Property(t => t.BoxNo).HasColumnName("BoxNo");
            this.Property(t => t.BoxID).HasColumnName("BoxID");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.DateSubmit).HasColumnName("DateSubmit");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
        }
    }
}
