using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BoxHilangMap : EntityTypeConfiguration<BoxHilang>
    {
        public BoxHilangMap()
        {
            // Primary Key
            this.HasKey(t => t.BoxHilangID);

            // Properties
            this.Property(t => t.BoxNo)
                .HasMaxLength(50);

            this.Property(t => t.BoxID)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BoxHilang", "Inventory");
            this.Property(t => t.BoxHilangID).HasColumnName("BoxHilangID");
            this.Property(t => t.BoxNo).HasColumnName("BoxNo");
            this.Property(t => t.BoxID).HasColumnName("BoxID");
            this.Property(t => t.HistoryBoxReturnID).HasColumnName("HistoryBoxReturnID");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.Date).HasColumnName("Date");
        }
    }
}
