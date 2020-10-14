using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ErrorBoxLog1Map : EntityTypeConfiguration<ErrorBoxLog1>
    {
        public ErrorBoxLog1Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BarcodeId)
                .HasMaxLength(50);

            this.Property(t => t.Gate)
                .HasMaxLength(50);

            this.Property(t => t.LogedInUser)
                .HasMaxLength(50);

            this.Property(t => t.ErrorText)
                .HasMaxLength(250);

            this.Property(t => t.Posisi)
                .HasMaxLength(50);

            this.Property(t => t.Form)
                .HasMaxLength(50);

            this.Property(t => t.NextPosition)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ErrorBoxLog", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BarcodeId).HasColumnName("BarcodeId");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
            this.Property(t => t.Gate).HasColumnName("Gate");
            this.Property(t => t.LogedInUser).HasColumnName("LogedInUser");
            this.Property(t => t.ErrorText).HasColumnName("ErrorText");
            this.Property(t => t.Posisi).HasColumnName("Posisi");
            this.Property(t => t.Form).HasColumnName("Form");
            this.Property(t => t.NextPosition).HasColumnName("NextPosition");
        }
    }
}
