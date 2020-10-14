using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class StockUploadMap : EntityTypeConfiguration<StockUpload>
    {
        public StockUploadMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Plant)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StockUpload");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.StockAwal).HasColumnName("StockAwal");
            this.Property(t => t.StockMasuk).HasColumnName("StockMasuk");
            this.Property(t => t.StockKeluar).HasColumnName("StockKeluar");
            this.Property(t => t.StockAkhir).HasColumnName("StockAkhir");
            this.Property(t => t.Plant).HasColumnName("Plant");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
