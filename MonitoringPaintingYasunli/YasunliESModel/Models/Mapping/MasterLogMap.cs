using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MasterLogMap : EntityTypeConfiguration<MasterLog>
    {
        public MasterLogMap()
        {
            // Primary Key
            this.HasKey(t => t.MasterLogID);

            // Properties
            this.Property(t => t.tableName)
                .HasMaxLength(50);

            this.Property(t => t.Action)
                .HasMaxLength(50);

            this.Property(t => t.NIK)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MasterLog", "System");
            this.Property(t => t.MasterLogID).HasColumnName("MasterLogID");
            this.Property(t => t.tableName).HasColumnName("tableName");
            this.Property(t => t.commitDate).HasColumnName("commitDate");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.NIK).HasColumnName("NIK");
            this.Property(t => t.Data).HasColumnName("Data");
        }
    }
}
