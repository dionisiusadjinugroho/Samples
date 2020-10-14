using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class statuslistMap : EntityTypeConfiguration<statuslist>
    {
        public statuslistMap()
        {
            // Primary Key
            this.HasKey(t => t.statusid);

            // Properties
            this.Property(t => t.statusid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.statusname)
                .HasMaxLength(65535);

            // Table & Column Mappings
            this.ToTable("statuslist", "andon");
            this.Property(t => t.statusid).HasColumnName("statusid");
            this.Property(t => t.statusname).HasColumnName("statusname");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");
        }
    }
}
