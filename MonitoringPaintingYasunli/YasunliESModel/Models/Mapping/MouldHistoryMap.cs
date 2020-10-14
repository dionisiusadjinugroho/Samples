using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldHistoryMap : EntityTypeConfiguration<MouldHistory>
    {
        public MouldHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.MouldHistoryID);

            // Properties
            this.Property(t => t.MouldID)
                .HasMaxLength(50);

            this.Property(t => t.ToolingID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MouldHistory", "Inventory");
            this.Property(t => t.MouldHistoryID).HasColumnName("MouldHistoryID");
            this.Property(t => t.MouldID).HasColumnName("MouldID");
            this.Property(t => t.ToolingID).HasColumnName("ToolingID");
            this.Property(t => t.JobOrder).HasColumnName("JobOrder");
            this.Property(t => t.DateStart).HasColumnName("DateStart");
            this.Property(t => t.DateEnd).HasColumnName("DateEnd");
            this.Property(t => t.Repair).HasColumnName("Repair");
            this.Property(t => t.JobDetail).HasColumnName("JobDetail");
        }
    }
}
