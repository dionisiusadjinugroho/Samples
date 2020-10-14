using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class RecordRFIDMap : EntityTypeConfiguration<RecordRFID>
    {
        public RecordRFIDMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IEIBoxID, t.ID });

            // Properties
            this.Property(t => t.IEIBoxID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RFID)
                .HasMaxLength(50);

            this.Property(t => t.BarcodeID)
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("RecordRFID", "EPSON");
            this.Property(t => t.IEIBoxID).HasColumnName("IEIBoxID");
            this.Property(t => t.RFID).HasColumnName("RFID");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.POSTJson).HasColumnName("POSTJson");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
