using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SuratJalanMaterialMap : EntityTypeConfiguration<SuratJalanMaterial>
    {
        public SuratJalanMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.SuratJalanMaterialID);

            // Properties
            this.Property(t => t.SuratJalanMaterialID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VendorID)
                .HasMaxLength(50);

            this.Property(t => t.ToPlantID)
                .HasMaxLength(50);

            this.Property(t => t.FromPlantID)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeID)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SuratJalanMaterial", "Inventory");
            this.Property(t => t.SuratJalanMaterialID).HasColumnName("SuratJalanMaterialID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ToPlantID).HasColumnName("ToPlantID");
            this.Property(t => t.FromPlantID).HasColumnName("FromPlantID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.SendDate).HasColumnName("SendDate");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
        }
    }
}
