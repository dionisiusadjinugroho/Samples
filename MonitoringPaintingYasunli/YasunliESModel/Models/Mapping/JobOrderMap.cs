using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class JobOrderMap : EntityTypeConfiguration<JobOrder>
    {
        public JobOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.JobID);

            // Properties
            this.Property(t => t.JobID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.DivisionID)
                .HasMaxLength(50);

            this.Property(t => t.SPPNo)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.Keterangan)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.PMaterial)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("JobOrder", "Inventory");
            this.Property(t => t.JobID).HasColumnName("JobID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.DivisionID).HasColumnName("DivisionID");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.PMaterial).HasColumnName("PMaterial");
        }
    }
}
