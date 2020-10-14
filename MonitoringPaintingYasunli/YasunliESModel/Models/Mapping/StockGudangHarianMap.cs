using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class StockGudangHarianMap : EntityTypeConfiguration<StockGudangHarian>
    {
        public StockGudangHarianMap()
        {
            // Primary Key
            this.HasKey(t => t.CountID);

            // Properties
            this.Property(t => t.PlantID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StockGudangHarian", "Inventory");
            this.Property(t => t.CountID).HasColumnName("CountID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Tanggal).HasColumnName("Tanggal");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
        }
    }
}
