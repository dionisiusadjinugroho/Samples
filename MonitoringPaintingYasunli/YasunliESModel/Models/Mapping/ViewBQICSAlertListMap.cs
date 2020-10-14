using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewBQICSAlertListMap : EntityTypeConfiguration<ViewBQICSAlertList>
    {
        public ViewBQICSAlertListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemName, t.MainModel, t.Keterangan, t.X, t.QtyGudang, t.QtyKeluarDelivery });

            // Properties
            this.Property(t => t.LotNo)
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired();

            this.Property(t => t.MainModel)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SPPNo)
                .HasMaxLength(50);

            this.Property(t => t.InspectionResult)
                .HasMaxLength(50);

            this.Property(t => t.Note)
                .HasMaxLength(200);

            this.Property(t => t.Keterangan)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.X)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.QtyGudang)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QtyKeluarDelivery)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ViewBQICSAlertList", "Quality");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.MainModel).HasColumnName("MainModel");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
            this.Property(t => t.MulaiSPP).HasColumnName("MulaiSPP");
            this.Property(t => t.InspectionResult).HasColumnName("InspectionResult");
            this.Property(t => t.TutupSPP).HasColumnName("TutupSPP");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
            this.Property(t => t.X).HasColumnName("X");
            this.Property(t => t.CheckDate).HasColumnName("CheckDate");
            this.Property(t => t.QtyGudang).HasColumnName("QtyGudang");
            this.Property(t => t.QtyKeluarDelivery).HasColumnName("QtyKeluarDelivery");
        }
    }
}
