using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class spplistMap : EntityTypeConfiguration<spplist>
    {
        public spplistMap()
        {
            // Primary Key
            this.HasKey(t => t.sppid);

            // Properties
            this.Property(t => t.sppname)
                .HasMaxLength(250);

            this.Property(t => t.customer_name)
                .HasMaxLength(250);

            this.Property(t => t.moldid)
                .HasMaxLength(250);

            this.Property(t => t.mold_tooling)
                .HasMaxLength(30);

            this.Property(t => t.mold_material)
                .HasMaxLength(150);

            this.Property(t => t.partid)
                .HasMaxLength(20);

            this.Property(t => t.cavity)
                .HasMaxLength(20);

            this.Property(t => t.keterangan)
                .HasMaxLength(65535);

            this.Property(t => t.flag)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("spplist", "andon");
            this.Property(t => t.sppid).HasColumnName("sppid");
            this.Property(t => t.sppname).HasColumnName("sppname");
            this.Property(t => t.customer_name).HasColumnName("customer_name");
            this.Property(t => t.moldid).HasColumnName("moldid");
            this.Property(t => t.mold_tooling).HasColumnName("mold_tooling");
            this.Property(t => t.mold_material).HasColumnName("mold_material");
            this.Property(t => t.std_cycle_time).HasColumnName("std_cycle_time");
            this.Property(t => t.partid).HasColumnName("partid");
            this.Property(t => t.cavity).HasColumnName("cavity");
            this.Property(t => t.keterangan).HasColumnName("keterangan");
            this.Property(t => t.targetstroke).HasColumnName("targetstroke");
            this.Property(t => t.plandowntime).HasColumnName("plandowntime");
            this.Property(t => t.flag).HasColumnName("flag");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");
        }
    }
}
