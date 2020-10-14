using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DetailBoMMap : EntityTypeConfiguration<DetailBoM>
    {
        public DetailBoMMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailBoMID);

            // Properties
            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DetailBoM", "Inventory");
            this.Property(t => t.DetailBoMID).HasColumnName("DetailBoMID");
            this.Property(t => t.BoMID).HasColumnName("BoMID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
        }
    }
}
