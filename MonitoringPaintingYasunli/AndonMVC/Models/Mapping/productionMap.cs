using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class productionMap : EntityTypeConfiguration<production>
    {
        public productionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.job_no, t.moldid, t.mold_tooling });

            // Properties
            this.Property(t => t.machine)
                .HasMaxLength(65535);

            this.Property(t => t.job_no)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.run_time)
                .HasMaxLength(30);

            this.Property(t => t.idle_time)
                .HasMaxLength(30);

            this.Property(t => t.moldid)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.mold_tooling)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.OEE)
                .HasMaxLength(100);

            this.Property(t => t.qty_target)
                .HasMaxLength(30);

            this.Property(t => t.qty_stroke)
                .HasMaxLength(30);

            this.Property(t => t.qty_total)
                .HasMaxLength(30);

            this.Property(t => t.total_qty_ok)
                .HasMaxLength(30);

            this.Property(t => t.total_qty_ng)
                .HasMaxLength(30);

            this.Property(t => t.plandowntime)
                .HasMaxLength(30);

            this.Property(t => t.performance)
                .HasMaxLength(30);

            this.Property(t => t.quality)
                .HasMaxLength(30);

            this.Property(t => t.availability)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("production", "andon");
            this.Property(t => t.machine).HasColumnName("machine");
            this.Property(t => t.job_no).HasColumnName("job_no");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");
            this.Property(t => t.run_time).HasColumnName("run_time");
            this.Property(t => t.idle_time).HasColumnName("idle_time");
            this.Property(t => t.moldid).HasColumnName("moldid");
            this.Property(t => t.mold_tooling).HasColumnName("mold_tooling");
            this.Property(t => t.OEE).HasColumnName("OEE");
            this.Property(t => t.qty_target).HasColumnName("qty_target");
            this.Property(t => t.qty_stroke).HasColumnName("qty_stroke");
            this.Property(t => t.qty_total).HasColumnName("qty_total");
            this.Property(t => t.total_qty_ok).HasColumnName("total_qty_ok");
            this.Property(t => t.total_qty_ng).HasColumnName("total_qty_ng");
            this.Property(t => t.plandowntime).HasColumnName("plandowntime");
            this.Property(t => t.performance).HasColumnName("performance");
            this.Property(t => t.quality).HasColumnName("quality");
            this.Property(t => t.availability).HasColumnName("availability");
        }
    }
}
