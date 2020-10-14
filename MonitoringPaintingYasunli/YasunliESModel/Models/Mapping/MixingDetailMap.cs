using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MixingDetailMap : EntityTypeConfiguration<MixingDetail>
    {
        public MixingDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.MixingDetailId);

            // Properties
            this.Property(t => t.MixingId)
                .HasMaxLength(50);

            this.Property(t => t.SackId)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.DocumentNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MixingDetail", "Inventory");
            this.Property(t => t.MixingDetailId).HasColumnName("MixingDetailId");
            this.Property(t => t.MixingId).HasColumnName("MixingId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.SackId).HasColumnName("SackId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.ScanTime).HasColumnName("ScanTime");
            this.Property(t => t.DocumentNo).HasColumnName("DocumentNo");
        }
    }
}
