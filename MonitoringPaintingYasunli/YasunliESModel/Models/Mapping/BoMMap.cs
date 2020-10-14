using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BoMMap : EntityTypeConfiguration<BoM>
    {
        public BoMMap()
        {
            // Primary Key
            this.HasKey(t => t.BoMID);

            // Properties
            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BoM", "Inventory");
            this.Property(t => t.BoMID).HasColumnName("BoMID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
        }
    }
}
