using System.Data.Entity.ModelConfiguration;

namespace AndonMVC.Models.Mapping
{
    public class jobhistoryMap : EntityTypeConfiguration<jobhistory>
    {
        public jobhistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.job_no, t.partid, t.cavity, t.moldid, t.mold_tooling });

            // Properties
            this.Property(t => t.machine)
                .HasMaxLength(65535);

            this.Property(t => t.job_no)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.partid)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.cavity)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.moldid)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.mold_tooling)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("jobhistory", "andon");
            this.Property(t => t.machine).HasColumnName("machine");
            this.Property(t => t.job_no).HasColumnName("job_no");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.strokenumber).HasColumnName("strokenumber");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.updatedate).HasColumnName("updatedate");
            this.Property(t => t.partid).HasColumnName("partid");
            this.Property(t => t.cavity).HasColumnName("cavity");
            this.Property(t => t.moldid).HasColumnName("moldid");
            this.Property(t => t.mold_tooling).HasColumnName("mold_tooling");
        }
    }
}
