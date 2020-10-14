using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class LabelLansirMap : EntityTypeConfiguration<LabelLansir>
    {
        public LabelLansirMap()
        {
            // Primary Key
            this.HasKey(t => t.LabelID);

            // Properties
            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.SPPNo)
                .HasMaxLength(50);

            this.Property(t => t.PrintRange)
                .HasMaxLength(50);

            this.Property(t => t.BoxType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LabelLansir", "Shared");
            this.Property(t => t.LabelID).HasColumnName("LabelID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
            this.Property(t => t.PrintRange).HasColumnName("PrintRange");
            this.Property(t => t.BoxType).HasColumnName("BoxType");
            this.Property(t => t.Operator).HasColumnName("Operator");
        }
    }
}
