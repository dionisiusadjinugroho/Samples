using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class LotMarkingMap : EntityTypeConfiguration<LotMarking>
    {
        public LotMarkingMap()
        {
            // Primary Key
            this.HasKey(t => t.LotMarkerId);

            // Properties
            this.Property(t => t.LotNo)
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.SppNo)
                .HasMaxLength(50);

            this.Property(t => t.MarkedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LotMarking", "Quality");
            this.Property(t => t.LotMarkerId).HasColumnName("LotMarkerId");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.SppNo).HasColumnName("SppNo");
            this.Property(t => t.MarkDate).HasColumnName("MarkDate");
            this.Property(t => t.Marking).HasColumnName("Marking");
            this.Property(t => t.MarkedBy).HasColumnName("MarkedBy");
        }
    }
}
