using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BQICSMarkingMap : EntityTypeConfiguration<BQICSMarking>
    {
        public BQICSMarkingMap()
        {
            // Primary Key
            this.HasKey(t => t.BQICSMarkingId);

            // Properties
            this.Property(t => t.LotNo)
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.SppNo)
                .HasMaxLength(50);

            this.Property(t => t.InspectionResult)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BQICSMarking", "Quality");
            this.Property(t => t.BQICSMarkingId).HasColumnName("BQICSMarkingId");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.SppNo).HasColumnName("SppNo");
            this.Property(t => t.MarkDate).HasColumnName("MarkDate");
            this.Property(t => t.Marking).HasColumnName("Marking");
            this.Property(t => t.InspectionResult).HasColumnName("InspectionResult");
            this.Property(t => t.ConfirmedDate).HasColumnName("ConfirmedDate");
            this.Property(t => t.InspectingDate).HasColumnName("InspectingDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Note).HasColumnName("Note");
        }
    }
}
