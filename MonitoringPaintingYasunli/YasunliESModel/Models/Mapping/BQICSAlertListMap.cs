using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BQICSAlertListMap : EntityTypeConfiguration<BQICSAlertList>
    {
        public BQICSAlertListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemName, t.MainModel, t.Keterangan, t.QtyGudang, t.QtyKeluarDelivery });

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

            this.Property(t => t.SppNo)
                .HasMaxLength(50);

            this.Property(t => t.Keterangan)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.QtyGudang)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QtyKeluarDelivery)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BQICSAlertList", "Quality");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.MainModel).HasColumnName("MainModel");
            this.Property(t => t.SppNo).HasColumnName("SppNo");
            this.Property(t => t.MulaiSPP).HasColumnName("MulaiSPP");
            this.Property(t => t.TutupSPP).HasColumnName("TutupSPP");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
            this.Property(t => t.CheckDate).HasColumnName("CheckDate");
            this.Property(t => t.QtyGudang).HasColumnName("QtyGudang");
            this.Property(t => t.QtyKeluarDelivery).HasColumnName("QtyKeluarDelivery");
            this.Property(t => t.Note).HasColumnName("Note");
        }
    }
}
