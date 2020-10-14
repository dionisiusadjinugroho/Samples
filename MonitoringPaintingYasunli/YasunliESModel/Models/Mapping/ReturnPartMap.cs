using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ReturnPartMap : EntityTypeConfiguration<ReturnPart>
    {
        public ReturnPartMap()
        {
            // Primary Key
            this.HasKey(t => t.ReturnPartID);

            // Properties
            this.Property(t => t.ReturnPartID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NoSuratJalan)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CustomerID)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.submited_by)
                .HasMaxLength(50);

            this.Property(t => t.created_by)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ReturnPart", "Inventory");
            this.Property(t => t.ReturnPartID).HasColumnName("ReturnPartID");
            this.Property(t => t.NoSuratJalan).HasColumnName("NoSuratJalan");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.submited_by).HasColumnName("submited_by");
            this.Property(t => t.created_by).HasColumnName("created_by");
            this.Property(t => t.created_date).HasColumnName("created_date");
        }
    }
}
