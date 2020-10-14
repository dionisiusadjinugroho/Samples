using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class LossTimeDetailMap : EntityTypeConfiguration<LossTimeDetail>
    {
        public LossTimeDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.LossTimeDetailId);

            // Properties
            this.Property(t => t.Division)
                .HasMaxLength(50);

            this.Property(t => t.LossTimeDetail1)
                .HasMaxLength(500);

            this.Property(t => t.TypeLossTime)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LossTimeDetail", "Shared");
            this.Property(t => t.Division).HasColumnName("Division");
            this.Property(t => t.LossTimeDetail1).HasColumnName("LossTimeDetail");
            this.Property(t => t.LossTimeDetailId).HasColumnName("LossTimeDetailId");
            this.Property(t => t.Perbaikan).HasColumnName("Perbaikan");
            this.Property(t => t.TypeLossTime).HasColumnName("TypeLossTime");
        }
    }
}
