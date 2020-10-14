using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SamplingCMMHeaderMap : EntityTypeConfiguration<SamplingCMMHeader>
    {
        public SamplingCMMHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.JobNo);

            // Properties
            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.UserId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SamplingCMMHeader", "Inventory");
            this.Property(t => t.JobNo).HasColumnName("JobNo");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.ScanTime).HasColumnName("ScanTime");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Finalized).HasColumnName("Finalized");
        }
    }
}
