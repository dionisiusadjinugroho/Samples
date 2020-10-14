using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PurchaseReturnMap : EntityTypeConfiguration<PurchaseReturn>
    {
        public PurchaseReturnMap()
        {
            // Primary Key
            this.HasKey(t => t.PurchaseReturnNo);

            // Properties
            this.Property(t => t.PurchaseReturnNo)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("PurchaseReturn", "Inventory");
            this.Property(t => t.PurchaseReturnNo).HasColumnName("PurchaseReturnNo");
            this.Property(t => t.ReturnDate).HasColumnName("ReturnDate");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.ReceivingID).HasColumnName("ReceivingID");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.NoSuratJalanReturn).HasColumnName("NoSuratJalanReturn");
            this.Property(t => t.NoDokumen).HasColumnName("NoDokumen");
            this.Property(t => t.NoAJU).HasColumnName("NoAJU");
            this.Property(t => t.NoMobil).HasColumnName("NoMobil");
            this.Property(t => t.TipeDokumen).HasColumnName("TipeDokumen");
            this.Property(t => t.NoPackingListReturn).HasColumnName("NoPackingListReturn");
            this.Property(t => t.VoidBy).HasColumnName("VoidBy");
            this.Property(t => t.VoidDate).HasColumnName("VoidDate");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
        }
    }
}
