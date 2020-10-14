using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class moldMap : EntityTypeConfiguration<mold>
    {
        public moldMap()
        {
            // Primary Key
            this.HasKey(t => t.moldid);

            // Properties
            this.Property(t => t.moldid)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.keterangan)
                .HasMaxLength(65535);

            // Table & Column Mappings
            this.ToTable("mold", "andon");
            this.Property(t => t.moldid).HasColumnName("moldid");
            this.Property(t => t.keterangan).HasColumnName("keterangan");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");
        }
    }
}
