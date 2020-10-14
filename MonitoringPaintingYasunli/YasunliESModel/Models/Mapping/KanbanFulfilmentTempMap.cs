using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class KanbanFulfilmentTempMap : EntityTypeConfiguration<KanbanFulfilmentTemp>
    {
        public KanbanFulfilmentTempMap()
        {
            // Primary Key
            this.HasKey(t => t.KanbanFulfilmentId);

            // Properties
            this.Property(t => t.KanbanFulfilmentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BarcodeId)
                .HasMaxLength(50);

            this.Property(t => t.KanbanId)
                .HasMaxLength(50);

            this.Property(t => t.SendedBy)
                .HasMaxLength(50);

            this.Property(t => t.CheckedBy)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("KanbanFulfilmentTemp");
            this.Property(t => t.KanbanFulfilmentId).HasColumnName("KanbanFulfilmentId");
            this.Property(t => t.BarcodeId).HasColumnName("BarcodeId");
            this.Property(t => t.KanbanId).HasColumnName("KanbanId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
            this.Property(t => t.SendedBy).HasColumnName("SendedBy");
            this.Property(t => t.CheckedBy).HasColumnName("CheckedBy");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
        }
    }
}
