using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PartTransactionInjectionMap : EntityTypeConfiguration<PartTransactionInjection>
    {
        public PartTransactionInjectionMap()
        {
            // Primary Key
            this.HasKey(t => t.BarcodeID);

            // Properties
            this.Property(t => t.BarcodeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.Position)
                .HasMaxLength(50);

            this.Property(t => t.NextPosition)
                .HasMaxLength(50);

            this.Property(t => t.LastScanPosition)
                .HasMaxLength(50);

            this.Property(t => t.Scan_By)
                .HasMaxLength(50);

            this.Property(t => t.LastPosition)
                .HasMaxLength(50);

            this.Property(t => t.Discontinue_Authorize)
                .HasMaxLength(50);

            this.Property(t => t.return_mark)
                .HasMaxLength(50);

            this.Property(t => t.QCOut)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PartTransactionInjection", "dbo");
            this.Property(t => t.BarcodeID).HasColumnName("BarcodeID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.NextPosition).HasColumnName("NextPosition");
            this.Property(t => t.LastScanPosition).HasColumnName("LastScanPosition");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Scan_By).HasColumnName("Scan_By");
            this.Property(t => t.LastPosition).HasColumnName("LastPosition");
            this.Property(t => t.Discontinue_Authorize).HasColumnName("Discontinue_Authorize");
            this.Property(t => t.return_mark).HasColumnName("return_mark");
            this.Property(t => t.created_date).HasColumnName("created_date");
            this.Property(t => t.is_ES).HasColumnName("is_ES");
            this.Property(t => t.pecahan).HasColumnName("pecahan");
            this.Property(t => t.QCOut).HasColumnName("QCOut");
        }
    }
}
