using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class historyreasonlistMap : EntityTypeConfiguration<historyreasonlist>
    {
        public historyreasonlistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sppname, t.reasonid });

            // Properties
            this.Property(t => t.sppname)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.reasonid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.reasonname)
                .HasMaxLength(65535);

            // Table & Column Mappings
            this.ToTable("historyreasonlist", "andon");
            this.Property(t => t.sppname).HasColumnName("sppname");
            this.Property(t => t.reasonid).HasColumnName("reasonid");
            this.Property(t => t.reasonname).HasColumnName("reasonname");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");
        }
    }
}
