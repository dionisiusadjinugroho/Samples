using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewItemListMap : EntityTypeConfiguration<ViewItemList>
    {
        public ViewItemListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemID, t.KodeItem, t.NamaItem, t.Model, t.Kategori, t.TipeMaterial, t.Kelengkapan, t.BQICSInfoPrefix });

            // Properties
            this.Property(t => t.NamaCustomer)
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KodeItem)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NamaItem)
                .IsRequired();

            this.Property(t => t.Model)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Kategori)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SubKategori)
                .HasMaxLength(50);

            this.Property(t => t.Satuan)
                .HasMaxLength(50);

            this.Property(t => t.SatuanBeratPart)
                .HasMaxLength(50);

            this.Property(t => t.SatuanBeratRunner)
                .HasMaxLength(50);

            this.Property(t => t.GrupMesin)
                .HasMaxLength(50);

            this.Property(t => t.KodeMould)
                .HasMaxLength(50);

            this.Property(t => t.NamaMould)
                .HasMaxLength(50);

            this.Property(t => t.TipeMaterial)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemComponent)
                .HasMaxLength(50);

            this.Property(t => t.NamaVendor)
                .HasMaxLength(200);

            this.Property(t => t.Colour)
                .HasMaxLength(50);

            this.Property(t => t.Side)
                .HasMaxLength(50);

            this.Property(t => t.VersionInfo)
                .HasMaxLength(10);

            this.Property(t => t.LastModifiedBy)
                .HasMaxLength(50);

            this.Property(t => t.MDI)
                .HasMaxLength(50);

            this.Property(t => t.Kelengkapan)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.QualityLevel)
                .HasMaxLength(50);

            this.Property(t => t.BQICSInfoPrefix)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ViewItemList", "Inventory");
            this.Property(t => t.NamaCustomer).HasColumnName("NamaCustomer");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.KodeItem).HasColumnName("KodeItem");
            this.Property(t => t.NamaItem).HasColumnName("NamaItem");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.Kategori).HasColumnName("Kategori");
            this.Property(t => t.SubKategori).HasColumnName("SubKategori");
            this.Property(t => t.JumlahGambar).HasColumnName("JumlahGambar");
            this.Property(t => t.Satuan).HasColumnName("Satuan");
            this.Property(t => t.BeratPart).HasColumnName("BeratPart");
            this.Property(t => t.SatuanBeratPart).HasColumnName("SatuanBeratPart");
            this.Property(t => t.BeratRunner).HasColumnName("BeratRunner");
            this.Property(t => t.SatuanBeratRunner).HasColumnName("SatuanBeratRunner");
            this.Property(t => t.GrupMesin).HasColumnName("GrupMesin");
            this.Property(t => t.KodeMould).HasColumnName("KodeMould");
            this.Property(t => t.NamaMould).HasColumnName("NamaMould");
            this.Property(t => t.TipeMaterial).HasColumnName("TipeMaterial");
            this.Property(t => t.ItemComponent).HasColumnName("ItemComponent");
            this.Property(t => t.NamaVendor).HasColumnName("NamaVendor");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Colour).HasColumnName("Colour");
            this.Property(t => t.Side).HasColumnName("Side");
            this.Property(t => t.UsageStop).HasColumnName("UsageStop");
            this.Property(t => t.VersionInfo).HasColumnName("VersionInfo");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.TanggalDibuat).HasColumnName("TanggalDibuat");
            this.Property(t => t.MDI).HasColumnName("MDI");
            this.Property(t => t.BerlakuMulai).HasColumnName("BerlakuMulai");
            this.Property(t => t.BerlakuSampai).HasColumnName("BerlakuSampai");
            this.Property(t => t.Kelengkapan).HasColumnName("Kelengkapan");
            this.Property(t => t.QualityLevel).HasColumnName("QualityLevel");
            this.Property(t => t.ManPower).HasColumnName("ManPower");
            this.Property(t => t.AQL).HasColumnName("AQL");
            this.Property(t => t.BQICSInfoPrefix).HasColumnName("BQICSInfoPrefix");
        }
    }
}
