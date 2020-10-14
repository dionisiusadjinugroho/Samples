using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class EngineeringJobDetailMap : EntityTypeConfiguration<EngineeringJobDetail>
    {
        public EngineeringJobDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.EngineeringJobDetailId);

            // Properties
            this.Property(t => t.Material)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EngineeringJobDetail", "Inventory");
            this.Property(t => t.EngineeringJobDetailId).HasColumnName("EngineeringJobDetailId");
            this.Property(t => t.JobId).HasColumnName("JobId");
            this.Property(t => t.Material).HasColumnName("Material");
            this.Property(t => t.MaterialUsage).HasColumnName("MaterialUsage");
            this.Property(t => t.ManPower).HasColumnName("ManPower");
            this.Property(t => t.WorkHour).HasColumnName("WorkHour");
        }
    }
}
