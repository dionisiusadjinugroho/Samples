using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BoMTempP1Map : EntityTypeConfiguration<BoMTempP1>
    {
        public BoMTempP1Map()
        {
            // Primary Key
            this.HasKey(t => t.BoMID);

            // Properties
            this.Property(t => t.BoMID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BoMTempP1", "Inventory");
            this.Property(t => t.BoMID).HasColumnName("BoMID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
        }
    }
}
