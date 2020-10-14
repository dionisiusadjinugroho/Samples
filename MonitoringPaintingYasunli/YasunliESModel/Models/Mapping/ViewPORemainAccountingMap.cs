using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewPORemainAccountingMap : EntityTypeConfiguration<ViewPORemainAccounting>
    {
        public ViewPORemainAccountingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PONo, t.VendorName, t.Plant, t.ItemID, t.ItemName, t.QtyReceive, t.SisaPO, t.StatusPO });

            // Properties
            this.Property(t => t.PONo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VendorName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PoType)
                .HasMaxLength(50);

            this.Property(t => t.Plant)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired();

            this.Property(t => t.QtyReceive)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SisaPO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KodeCurrency)
                .HasMaxLength(50);

            this.Property(t => t.StatusPO)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("ViewPORemainAccounting", "Inventory");
            this.Property(t => t.PONo).HasColumnName("PONo");
            this.Property(t => t.PoDate).HasColumnName("PoDate");
            this.Property(t => t.VendorName).HasColumnName("VendorName");
            this.Property(t => t.PoType).HasColumnName("PoType");
            this.Property(t => t.Plant).HasColumnName("Plant");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.QtyReceive).HasColumnName("QtyReceive");
            this.Property(t => t.SisaPO).HasColumnName("SisaPO");
            this.Property(t => t.KodeCurrency).HasColumnName("KodeCurrency");
            this.Property(t => t.Harga).HasColumnName("Harga");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            this.Property(t => t.TotalPriceReceive).HasColumnName("TotalPriceReceive");
            this.Property(t => t.StatusPO).HasColumnName("StatusPO");
        }
    }
}
