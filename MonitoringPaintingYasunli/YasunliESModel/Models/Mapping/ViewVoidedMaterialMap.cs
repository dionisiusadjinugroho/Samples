using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewVoidedMaterialMap : EntityTypeConfiguration<ViewVoidedMaterial>
    {
        public ViewVoidedMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.MATERIALOUTNO);

            // Properties
            this.Property(t => t.MATERIALOUTNO)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ViewVoidedMaterial", "Inventory");
            this.Property(t => t.MATERIALOUTNO).HasColumnName("MATERIALOUTNO");
        }
    }
}
