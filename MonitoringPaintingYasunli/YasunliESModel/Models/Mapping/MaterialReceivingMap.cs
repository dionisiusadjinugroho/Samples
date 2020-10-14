using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MaterialReceivingMap : EntityTypeConfiguration<MaterialReceiving>
    {
        public MaterialReceivingMap()
        {
            // Primary Key
            this.HasKey(t => t.ReceivingID);

            // Properties
            this.Property(t => t.ReceivingID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VendorID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SuratJalanNo)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.VoidBy)
                .HasMaxLength(50);

            this.Property(t => t.NoInvoice)
                .HasMaxLength(50);

            this.Property(t => t.NoPackingList)
                .HasMaxLength(50);

            this.Property(t => t.NoDokumen)
                .HasMaxLength(50);

            this.Property(t => t.NoMobil)
                .HasMaxLength(50);

            this.Property(t => t.NoPengajuan)
                .HasMaxLength(50);

            this.Property(t => t.JenisDokumen)
                .HasMaxLength(50);

            this.Property(t => t.NomorAju)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialReceiving", "Inventory");
            this.Property(t => t.ReceivingID).HasColumnName("ReceivingID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.SuratJalanNo).HasColumnName("SuratJalanNo");
            this.Property(t => t.ReceivingDate).HasColumnName("ReceivingDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.PrintCount).HasColumnName("PrintCount");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.VoidBy).HasColumnName("VoidBy");
            this.Property(t => t.VoidDate).HasColumnName("VoidDate");
            this.Property(t => t.VoidDescription).HasColumnName("VoidDescription");
            this.Property(t => t.NoInvoice).HasColumnName("NoInvoice");
            this.Property(t => t.NoPackingList).HasColumnName("NoPackingList");
            this.Property(t => t.NoDokumen).HasColumnName("NoDokumen");
            this.Property(t => t.NoMobil).HasColumnName("NoMobil");
            this.Property(t => t.DocumentDate).HasColumnName("DocumentDate");
            this.Property(t => t.NoPengajuan).HasColumnName("NoPengajuan");
            this.Property(t => t.JenisDokumen).HasColumnName("JenisDokumen");
            this.Property(t => t.TglSuratJalan).HasColumnName("TglSuratJalan");
            this.Property(t => t.NomorAju).HasColumnName("NomorAju");

            // Relationships
            this.HasRequired(t => t.Plant)
                .WithMany(t => t.MaterialReceivings)
                .HasForeignKey(d => d.PlantID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.MaterialReceivings)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
