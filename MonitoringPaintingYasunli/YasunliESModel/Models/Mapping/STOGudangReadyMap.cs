using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class STOGudangReadyMap : EntityTypeConfiguration<STOGudangReady>
    {
        public STOGudangReadyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);



            // Table & Column Mappings
            this.ToTable("STOGudangReady", "dbo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CustomerBarcode).HasColumnName("CustomerBarcode");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.ScanBy).HasColumnName("ScanBy");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");

        }
    }
}
