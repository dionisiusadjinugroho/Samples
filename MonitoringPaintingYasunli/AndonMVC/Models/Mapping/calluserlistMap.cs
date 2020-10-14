using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class calluserlistMap : EntityTypeConfiguration<calluserlist>
    {
        public calluserlistMap()
        {
            // Primary Key
            this.HasKey(t => t.calluserid);

            // Properties
            this.Property(t => t.calluserid)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.nama)
                .HasMaxLength(65535);

            this.Property(t => t.divisi)
                .HasMaxLength(65535);

            // Table & Column Mappings
            this.ToTable("calluserlist", "andon");
            this.Property(t => t.calluserid).HasColumnName("calluserid");
            this.Property(t => t.nama).HasColumnName("nama");
            this.Property(t => t.divisi).HasColumnName("divisi");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");
        }
    }
}
