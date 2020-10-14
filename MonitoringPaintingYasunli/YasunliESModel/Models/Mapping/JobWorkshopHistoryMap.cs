using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class JobWorkshopHistoryMap : EntityTypeConfiguration<JobWorkshopHistory>
    {
        public JobWorkshopHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.JobHistoryId);

            // Properties
            this.Property(t => t.StatusNow)
                .HasMaxLength(50);

            this.Property(t => t.StatusNew)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("JobWorkshopHistory", "Shared");
            this.Property(t => t.JobHistoryId).HasColumnName("JobHistoryId");
            this.Property(t => t.JobId).HasColumnName("JobId");
            this.Property(t => t.StatusNow).HasColumnName("StatusNow");
            this.Property(t => t.StatusNew).HasColumnName("StatusNew");
            this.Property(t => t.DateTime).HasColumnName("DateTime");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
        }
    }
}
