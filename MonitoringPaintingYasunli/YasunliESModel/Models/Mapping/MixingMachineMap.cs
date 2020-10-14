using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MixingMachineMap : EntityTypeConfiguration<MixingMachine>
    {
        public MixingMachineMap()
        {
            // Primary Key
            this.HasKey(t => t.MixingMachineId);

            // Properties
            this.Property(t => t.MixingId)
                .HasMaxLength(50);

            this.Property(t => t.SackId)
                .HasMaxLength(50);

            this.Property(t => t.SppNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MixingMachine", "Inventory");
            this.Property(t => t.MixingMachineId).HasColumnName("MixingMachineId");
            this.Property(t => t.MixingId).HasColumnName("MixingId");
            this.Property(t => t.SackId).HasColumnName("SackId");
            this.Property(t => t.SppNo).HasColumnName("SppNo");
            this.Property(t => t.DateTime).HasColumnName("DateTime");
        }
    }
}
