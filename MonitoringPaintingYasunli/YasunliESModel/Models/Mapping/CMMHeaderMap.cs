using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class CMMHeaderMap : EntityTypeConfiguration<CMMHeader>
    {
        public CMMHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.JobId);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.LotNo)
                .HasMaxLength(50);

            this.Property(t => t.MeasuredBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CMMHeader", "Quality");
            this.Property(t => t.JobId).HasColumnName("JobId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.CMMPass).HasColumnName("CMMPass");
            this.Property(t => t.MeasuringDate).HasColumnName("MeasuringDate");
            this.Property(t => t.MeasuredBy).HasColumnName("MeasuredBy");
        }
    }
}
