using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class reasonlistMap : EntityTypeConfiguration<reasonlist>
    {
        public reasonlistMap()
        {
            // Primary Key
            this.HasKey(t => t.reasonid);

            // Properties
            this.Property(t => t.reasonid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.reasonname)
                .HasMaxLength(65535);

            // Table & Column Mappings
            this.ToTable("reasonlist", "andon");
            this.Property(t => t.reasonid).HasColumnName("reasonid");
            this.Property(t => t.reasonname).HasColumnName("reasonname");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");
        }
    }
}
