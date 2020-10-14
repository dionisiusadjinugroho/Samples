using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ClaimMap : EntityTypeConfiguration<Claim>
    {
        public ClaimMap()
        {
            // Primary Key
            this.HasKey(t => t.ClaimId);

            // Properties
            this.Property(t => t.CustomerId)
                .HasMaxLength(50);

            this.Property(t => t.MouldId)
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.ToolingId)
                .HasMaxLength(50);

            this.Property(t => t.Cavity)
                .HasMaxLength(50);

            this.Property(t => t.ClaimNo)
                .HasMaxLength(50);

            this.Property(t => t.WINo)
                .HasMaxLength(50);

            this.Property(t => t.FMEANo)
                .HasMaxLength(50);

            this.Property(t => t.PlantId)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.ReffNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Claim", "Inventory");
            this.Property(t => t.ClaimId).HasColumnName("ClaimId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.MouldId).HasColumnName("MouldId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ToolingId).HasColumnName("ToolingId");
            this.Property(t => t.Cavity).HasColumnName("Cavity");
            this.Property(t => t.ClaimDate).HasColumnName("ClaimDate");
            this.Property(t => t.ClaimNo).HasColumnName("ClaimNo");
            this.Property(t => t.ClaimDetail).HasColumnName("ClaimDetail");
            this.Property(t => t.RootClause).HasColumnName("RootClause");
            this.Property(t => t.CounterMeasure).HasColumnName("CounterMeasure");
            this.Property(t => t.EffDate).HasColumnName("EffDate");
            this.Property(t => t.WINo).HasColumnName("WINo");
            this.Property(t => t.FMEANo).HasColumnName("FMEANo");
            this.Property(t => t.PlantId).HasColumnName("PlantId");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Attachment).HasColumnName("Attachment");
            this.Property(t => t.ReffNo).HasColumnName("ReffNo");
        }
    }
}
