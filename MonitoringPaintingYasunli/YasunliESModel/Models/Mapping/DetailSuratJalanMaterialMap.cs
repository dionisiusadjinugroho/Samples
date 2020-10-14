using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DetailSuratJalanMaterialMap : EntityTypeConfiguration<DetailSuratJalanMaterial>
    {
        public DetailSuratJalanMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.DetailSuratJalanMaterialID);

            // Properties
            this.Property(t => t.SuratJalanMaterialID)
                .HasMaxLength(50);

            this.Property(t => t.Barcode)
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.LotNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DetailSuratJalanMaterial", "Inventory");
            this.Property(t => t.DetailSuratJalanMaterialID).HasColumnName("DetailSuratJalanMaterialID");
            this.Property(t => t.SuratJalanMaterialID).HasColumnName("SuratJalanMaterialID");
            this.Property(t => t.Barcode).HasColumnName("Barcode");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.ScanTime).HasColumnName("ScanTime");
            this.Property(t => t.ReceivedDate).HasColumnName("ReceivedDate");
        }
    }
}
