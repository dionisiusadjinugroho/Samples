using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class TempLocationGudangMap : EntityTypeConfiguration<TempLocationGudang>
    {
        public TempLocationGudangMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);


            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            this.Property(t => t.Pairing_By)
                .HasMaxLength(50);


            // Table & Column Mappings
            this.ToTable("TempLocationGudang", "dbo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Pairing_By).HasColumnName("Pairing_By");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
            this.Property(t => t.NextPosition).HasColumnName("NextPosition");
            this.Property(t => t.RFID).HasColumnName("RFID");
        }
    }
}
