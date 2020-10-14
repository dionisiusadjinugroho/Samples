using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class LimitSampleDetailMap : EntityTypeConfiguration<LimitSampleDetail>
    {
        public LimitSampleDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.LimitSampleDetailId);

            // Properties
            this.Property(t => t.LimitSampleId)
                .HasMaxLength(50);

            this.Property(t => t.UsedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LimitSampleDetail", "Quality");
            this.Property(t => t.LimitSampleDetailId).HasColumnName("LimitSampleDetailId");
            this.Property(t => t.LimitSampleId).HasColumnName("LimitSampleId");
            this.Property(t => t.UsedBy).HasColumnName("UsedBy");
            this.Property(t => t.UsedDate).HasColumnName("UsedDate");
        }
    }
}
