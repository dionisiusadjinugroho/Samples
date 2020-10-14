using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class UomConversionMap : EntityTypeConfiguration<UomConversion>
    {
        public UomConversionMap()
        {
            // Primary Key
            this.HasKey(t => t.UoMConversionID);

            // Properties
            this.Property(t => t.UoMID)
                .HasMaxLength(50);

            this.Property(t => t.UnitToConvert)
                .HasMaxLength(50);

            this.Property(t => t.UnitEquivalent)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UomConversion", "Inventory");
            this.Property(t => t.UoMConversionID).HasColumnName("UoMConversionID");
            this.Property(t => t.UoMID).HasColumnName("UoMID");
            this.Property(t => t.UnitToConvert).HasColumnName("UnitToConvert");
            this.Property(t => t.UnitEquivalent).HasColumnName("UnitEquivalent");
            this.Property(t => t.MultiplicationFactor).HasColumnName("MultiplicationFactor");
        }
    }
}
