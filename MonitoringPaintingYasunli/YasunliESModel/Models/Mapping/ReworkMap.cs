using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ReworkMap : EntityTypeConfiguration<Rework>
    {
        public ReworkMap()
        {
            // Primary Key
            this.HasKey(t => t.ReworkID);

            // Properties
            this.Property(t => t.ReworkID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.Created_By)
                .HasMaxLength(50);

            this.Property(t => t.Sended_By)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Rework", "Inventory");
            this.Property(t => t.ReworkID).HasColumnName("ReworkID");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.Revisi).HasColumnName("Revisi");
            this.Property(t => t.ReceiveDate).HasColumnName("ReceiveDate");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Created_By).HasColumnName("Created_By");
            this.Property(t => t.Sended_By).HasColumnName("Sended_By");
        }
    }
}
