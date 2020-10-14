using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ScanAlertTempMap : EntityTypeConfiguration<ScanAlertTemp>
    {
        public ScanAlertTempMap()
        {
            // Primary Key
            this.HasKey(t => t.ScanAlertId);

            // Properties
            this.Property(t => t.ScanAlertId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DocumentNo)
                .HasMaxLength(50);

            this.Property(t => t.RequestBy)
                .HasMaxLength(50);

            this.Property(t => t.Division)
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.Model)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .HasMaxLength(100);

            this.Property(t => t.Tujuan)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ScanAlertTemp");
            this.Property(t => t.ScanAlertId).HasColumnName("ScanAlertId");
            this.Property(t => t.AlertDate).HasColumnName("AlertDate");
            this.Property(t => t.DocumentNo).HasColumnName("DocumentNo");
            this.Property(t => t.RequestBy).HasColumnName("RequestBy");
            this.Property(t => t.Division).HasColumnName("Division");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Tujuan).HasColumnName("Tujuan");
        }
    }
}
