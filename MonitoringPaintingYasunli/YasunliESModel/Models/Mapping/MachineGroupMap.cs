using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MachineGroupMap : EntityTypeConfiguration<MachineGroup>
    {
        public MachineGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.MachineGroupID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MachineGroup", "Inventory");
            this.Property(t => t.MachineGroupID).HasColumnName("MachineGroupID");
            this.Property(t => t.ClampingForce).HasColumnName("ClampingForce");
        }
    }
}
