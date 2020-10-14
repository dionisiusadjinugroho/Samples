using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class partMap : EntityTypeConfiguration<part>
    {
        public partMap()
        {
            // Primary Key
            this.HasKey(t => t.partid);

            // Properties
            this.Property(t => t.partid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.partname)
                .HasMaxLength(65535);

            this.Property(t => t.moldid)
                .HasMaxLength(250);

            this.Property(t => t.keterangan)
                .HasMaxLength(65535);

            // Table & Column Mappings
            this.ToTable("part", "andon");
            this.Property(t => t.partid).HasColumnName("partid");
            this.Property(t => t.partname).HasColumnName("partname");
            this.Property(t => t.moldid).HasColumnName("moldid");
            this.Property(t => t.number_of_cavity_inmold).HasColumnName("number_of_cavity_inmold");
            this.Property(t => t.keterangan).HasColumnName("keterangan");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");

            // Relationships
            this.HasOptional(t => t.mold)
                .WithMany(t => t.parts)
                .HasForeignKey(d => d.moldid);

        }
    }
}
