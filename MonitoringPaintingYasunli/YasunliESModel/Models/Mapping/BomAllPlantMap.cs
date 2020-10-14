using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BomAllPlantMap : EntityTypeConfiguration<BomAllPlant>
    {
        public BomAllPlantMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemIdFG, t.ItemIdWIP, t.DetailBomID });

            // Properties
            this.Property(t => t.ItemIdFG)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemIdWIP)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemIdWIPName)
                .HasMaxLength(250);

            this.Property(t => t.ItemIdWIPModel)
                .HasMaxLength(50);

            this.Property(t => t.Category)
                .HasMaxLength(50);

            this.Property(t => t.DetailBomID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BomAllPlant", "Inventory");
            this.Property(t => t.ItemIdFG).HasColumnName("ItemIdFG");
            this.Property(t => t.ItemIdWIP).HasColumnName("ItemIdWIP");
            this.Property(t => t.ItemIdWIPName).HasColumnName("ItemIdWIPName");
            this.Property(t => t.ItemIdWIPModel).HasColumnName("ItemIdWIPModel");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.DetailBomID).HasColumnName("DetailBomID");
        }
    }
}
