using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldComponentDetailMap : EntityTypeConfiguration<MouldComponentDetail>
    {
        public MouldComponentDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MouldComponentId, t.JobId });

            // Properties
            this.Property(t => t.MouldComponentId)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.JobId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MouldComponentDetail", "Shared");
            this.Property(t => t.MouldComponentId).HasColumnName("MouldComponentId");
            this.Property(t => t.JobId).HasColumnName("JobId");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
        }
    }
}
