using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogID);

            // Properties
            this.Property(t => t.FormName)
                .HasMaxLength(50);

            this.Property(t => t.Action)
                .HasMaxLength(50);

            this.Property(t => t.Username)
                .HasMaxLength(50);

            this.Property(t => t.DocumentNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Logs", "System");
            this.Property(t => t.LogID).HasColumnName("LogID");
            this.Property(t => t.LogDate).HasColumnName("LogDate");
            this.Property(t => t.FormName).HasColumnName("FormName");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.DocumentNo).HasColumnName("DocumentNo");
            this.Property(t => t.LastValue).HasColumnName("LastValue");
        }
    }
}
