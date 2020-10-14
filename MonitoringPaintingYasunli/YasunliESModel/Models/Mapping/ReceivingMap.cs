using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ReceivingMap : EntityTypeConfiguration<Receiving>
    {
        public ReceivingMap()
        {
            // Primary Key
            this.HasKey(t => t.ReceivingID);

            // Properties
            this.Property(t => t.ReceivingID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VendorID)
                .HasMaxLength(50);

            this.Property(t => t.POID)
                .HasMaxLength(50);

            this.Property(t => t.SuratJalanNo)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Receiving", "Inventory");
            this.Property(t => t.ReceivingID).HasColumnName("ReceivingID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.POID).HasColumnName("POID");
            this.Property(t => t.SuratJalanNo).HasColumnName("SuratJalanNo");
            this.Property(t => t.Tanggal).HasColumnName("Tanggal");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
        }
    }
}
