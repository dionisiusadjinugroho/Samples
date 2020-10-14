using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class RePrintSuratJalanHistoryMap : EntityTypeConfiguration<RePrintSuratJalanHistory>
    {
        public RePrintSuratJalanHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Created_By)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RePrintSuratJalanHistory", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RePrintDate).HasColumnName("RePrintDate");
            this.Property(t => t.Created_By).HasColumnName("Created_By");
        }
    }
}
