using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DetailBoMTempMap : EntityTypeConfiguration<DetailBoMTemp>
    {
        public DetailBoMTempMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailBoMID);

            // Properties
            this.Property(t => t.DetailBoMID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DetailBoMTemp", "Inventory");
            this.Property(t => t.DetailBoMID).HasColumnName("DetailBoMID");
            this.Property(t => t.BoMID).HasColumnName("BoMID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
        }
    }
}
