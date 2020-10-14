using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PSIMap : EntityTypeConfiguration<PSI>
    {
        public PSIMap()
        {
            // Primary Key
            this.HasKey(t => t.PSIUniqueId);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.Customer)
                .HasMaxLength(50);

            this.Property(t => t.Plant)
                .HasMaxLength(50);

            this.Property(t => t.MachineNo)
                .HasMaxLength(50);

            this.Property(t => t.FileName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PSI", "Inventory");
            this.Property(t => t.PSIUniqueId).HasColumnName("PSIUniqueId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.IEIStock).HasColumnName("IEIStock");
            this.Property(t => t.RawStock).HasColumnName("RawStock");
            this.Property(t => t.GITStock).HasColumnName("GITStock");
            this.Property(t => t.OSReq).HasColumnName("OSReq");
            this.Property(t => t.YasunliStock).HasColumnName("YasunliStock");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.HoldQty).HasColumnName("HoldQty");
            this.Property(t => t.Plant).HasColumnName("Plant");
            this.Property(t => t.MachineNo).HasColumnName("MachineNo");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.FileName).HasColumnName("FileName");
        }
    }
}
