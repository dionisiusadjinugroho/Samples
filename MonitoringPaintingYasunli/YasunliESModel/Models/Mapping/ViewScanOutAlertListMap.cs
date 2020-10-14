using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewScanOutAlertListMap : EntityTypeConfiguration<ViewScanOutAlertList>
    {
        public ViewScanOutAlertListMap()
        {
            // Primary Key
            this.HasKey(t => t.Keterangan);

            // Properties
            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .HasMaxLength(100);

            this.Property(t => t.MainModel)
                .HasMaxLength(50);

            this.Property(t => t.Gudang)
                .HasMaxLength(306);

            this.Property(t => t.QC)
                .HasMaxLength(306);

            this.Property(t => t.Tujuan)
                .HasMaxLength(50);

            this.Property(t => t.Keterangan)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ViewScanOutAlertList", "Inventory");
            this.Property(t => t.NO).HasColumnName("NO");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.MainModel).HasColumnName("MainModel");
            this.Property(t => t.JamSave).HasColumnName("JamSave");
            this.Property(t => t.Gudang).HasColumnName("Gudang");
            this.Property(t => t.JamGudang).HasColumnName("JamGudang");
            this.Property(t => t.QC).HasColumnName("QC");
            this.Property(t => t.JamQC).HasColumnName("JamQC");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Tujuan).HasColumnName("Tujuan");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
        }
    }
}
