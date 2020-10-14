using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class RequestOrderMap : EntityTypeConfiguration<RequestOrder>
    {
        public RequestOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestID);

            // Properties
            this.Property(t => t.RequestID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DivisionID)
                .HasMaxLength(50);

            this.Property(t => t.Model)
                .HasMaxLength(50);

            this.Property(t => t.SppNo)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.FromPlant)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RequestOrder", "Inventory");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.DivisionID).HasColumnName("DivisionID");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.SppNo).HasColumnName("SppNo");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.FromPlant).HasColumnName("FromPlant");
        }
    }
}
