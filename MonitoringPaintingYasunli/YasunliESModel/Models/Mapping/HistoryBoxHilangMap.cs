using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class HistoryBoxHilangMap : EntityTypeConfiguration<HistoryBoxHilang>
    {
        public HistoryBoxHilangMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoryBoxHilangID);

            // Properties
            this.Property(t => t.BoxNo)
                .HasMaxLength(50);

            this.Property(t => t.BoxID)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HistoryBoxHilang", "Inventory");
            this.Property(t => t.HistoryBoxHilangID).HasColumnName("HistoryBoxHilangID");
            this.Property(t => t.HistoryBoxReturnID).HasColumnName("HistoryBoxReturnID");
            this.Property(t => t.BoxNo).HasColumnName("BoxNo");
            this.Property(t => t.BoxID).HasColumnName("BoxID");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.ScanTime).HasColumnName("ScanTime");
        }
    }
}
