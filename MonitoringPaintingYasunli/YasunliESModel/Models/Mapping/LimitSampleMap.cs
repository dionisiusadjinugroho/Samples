using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class LimitSampleMap : EntityTypeConfiguration<LimitSample>
    {
        public LimitSampleMap()
        {
            // Primary Key
            this.HasKey(t => t.LimitSampleId);

            // Properties
            this.Property(t => t.LimitSampleId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CustomerId)
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.NGCriteria)
                .HasMaxLength(200);

            this.Property(t => t.Zona)
                .HasMaxLength(200);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.ZonaANGCriteria)
                .HasMaxLength(250);

            this.Property(t => t.ZonaBNGCriteria)
                .HasMaxLength(250);

            this.Property(t => t.ZonaCNGCriteria)
                .HasMaxLength(250);

            this.Property(t => t.ZonaDNGCriteria)
                .HasMaxLength(250);

            this.Property(t => t.LimitIndex)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("LimitSample", "Quality");
            this.Property(t => t.LimitSampleId).HasColumnName("LimitSampleId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.NGCriteria).HasColumnName("NGCriteria");
            this.Property(t => t.Zona).HasColumnName("Zona");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.ZonaANGCriteria).HasColumnName("ZonaANGCriteria");
            this.Property(t => t.ZonaBNGCriteria).HasColumnName("ZonaBNGCriteria");
            this.Property(t => t.ZonaCNGCriteria).HasColumnName("ZonaCNGCriteria");
            this.Property(t => t.ZonaDNGCriteria).HasColumnName("ZonaDNGCriteria");
            this.Property(t => t.ZonaARemarks).HasColumnName("ZonaARemarks");
            this.Property(t => t.ZonaBRemarks).HasColumnName("ZonaBRemarks");
            this.Property(t => t.ZonaCRemarks).HasColumnName("ZonaCRemarks");
            this.Property(t => t.ZonaDRemarks).HasColumnName("ZonaDRemarks");
            this.Property(t => t.LimitIndex).HasColumnName("LimitIndex");
        }
    }
}
