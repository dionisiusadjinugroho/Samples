using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class HistoryBoxSusulanMap : EntityTypeConfiguration<HistoryBoxSusulan>
    {
        public HistoryBoxSusulanMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoryBoxSusulanID);

            // Properties
            this.Property(t => t.HistoryBoxSusulanID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            this.Property(t => t.BoxNo)
                .HasMaxLength(50);

            this.Property(t => t.BoxID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HistoryBoxSusulan", "Inventory");
            this.Property(t => t.HistoryBoxSusulanID).HasColumnName("HistoryBoxSusulanID");
            this.Property(t => t.HistoryBoxReturnID).HasColumnName("HistoryBoxReturnID");
            this.Property(t => t.HistoryBoxLeverlansirID).HasColumnName("HistoryBoxLeverlansirID");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.BoxNo).HasColumnName("BoxNo");
            this.Property(t => t.BoxID).HasColumnName("BoxID");
            this.Property(t => t.ScanDate).HasColumnName("ScanDate");
        }
    }
}
