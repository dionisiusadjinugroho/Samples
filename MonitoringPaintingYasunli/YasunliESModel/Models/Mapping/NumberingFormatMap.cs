using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class NumberingFormatMap : EntityTypeConfiguration<NumberingFormat>
    {
        public NumberingFormatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FormID, t.PlantID });

            // Properties
            this.Property(t => t.FormID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NumberingForm)
                .HasMaxLength(50);

            this.Property(t => t.LastInserted)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Reserved)
                .HasMaxLength(50);

            this.Property(t => t.AdditionalInfo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("NumberingFormat", "System");
            this.Property(t => t.FormID).HasColumnName("FormID");
            this.Property(t => t.NumberingForm).HasColumnName("NumberingForm");
            this.Property(t => t.LastInserted).HasColumnName("LastInserted");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Reserved).HasColumnName("Reserved");
            this.Property(t => t.AdditionalInfo).HasColumnName("AdditionalInfo");
        }
    }
}
