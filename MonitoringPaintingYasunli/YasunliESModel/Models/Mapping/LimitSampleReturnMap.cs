using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class LimitSampleReturnMap : EntityTypeConfiguration<LimitSampleReturn>
    {
        public LimitSampleReturnMap()
        {
            // Primary Key
            this.HasKey(t => t.LimitSampleReturnId);

            // Properties
            this.Property(t => t.LimitSampleId)
                .HasMaxLength(50);

            this.Property(t => t.ReturnBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LimitSampleReturn", "Quality");
            this.Property(t => t.LimitSampleReturnId).HasColumnName("LimitSampleReturnId");
            this.Property(t => t.LimitSampleId).HasColumnName("LimitSampleId");
            this.Property(t => t.ReturnBy).HasColumnName("ReturnBy");
            this.Property(t => t.ReturnDate).HasColumnName("ReturnDate");
        }
    }
}
