using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class JobOrderMouldMap : EntityTypeConfiguration<JobOrderMould>
    {
        public JobOrderMouldMap()
        {
            // Primary Key
            this.HasKey(t => t.JobOrderMouldId);

            // Properties
            this.Property(t => t.JobOrderMouldId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MouldCode)
                .HasMaxLength(50);

            this.Property(t => t.ToolingId)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.VerifiedBy)
                .HasMaxLength(50);

            this.Property(t => t.FinishedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("JobOrderMould", "Inventory");
            this.Property(t => t.JobOrderMouldId).HasColumnName("JobOrderMouldId");
            this.Property(t => t.PlantId).HasColumnName("PlantId");
            this.Property(t => t.MouldCode).HasColumnName("MouldCode");
            this.Property(t => t.ToolingId).HasColumnName("ToolingId");
            this.Property(t => t.JenisKerusakanPart).HasColumnName("JenisKerusakanPart");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.JenisKerusakanMould).HasColumnName("JenisKerusakanMould");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.VerifiedBy).HasColumnName("VerifiedBy");
            this.Property(t => t.VerifiedDate).HasColumnName("VerifiedDate");
            this.Property(t => t.FinishedDate).HasColumnName("FinishedDate");
            this.Property(t => t.FinishedBy).HasColumnName("FinishedBy");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
