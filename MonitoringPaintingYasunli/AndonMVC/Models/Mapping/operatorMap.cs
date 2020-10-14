using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class operatorMap : EntityTypeConfiguration<operatorx>
    {
        public operatorMap()
        {
            // Primary Key
            this.HasKey(t => t.operatorid);

            // Properties
            this.Property(t => t.operatorid)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.nama)
                .HasMaxLength(65535);

            this.Property(t => t.divisi)
                .HasMaxLength(65535);

            // Table & Column Mappings
            this.ToTable("operator", "andon");
            this.Property(t => t.operatorid).HasColumnName("operatorid");
            this.Property(t => t.nama).HasColumnName("nama");
            this.Property(t => t.divisi).HasColumnName("divisi");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");
        }
    }
}
