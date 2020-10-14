using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class HistoryBoxLeverlansirMap : EntityTypeConfiguration<HistoryBoxLeverlansir>
    {
        public HistoryBoxLeverlansirMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoryBoxLeverlansirID);

            // Properties
            this.Property(t => t.FromPlantID)
                .HasMaxLength(50);

            this.Property(t => t.ToPlantID)
                .HasMaxLength(50);

            this.Property(t => t.DriverID)
                .HasMaxLength(50);

            this.Property(t => t.RentalID)
                .HasMaxLength(50);

            this.Property(t => t.NoPolisi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HistoryBoxLeverlansir", "Inventory");
            this.Property(t => t.HistoryBoxLeverlansirID).HasColumnName("HistoryBoxLeverlansirID");
            this.Property(t => t.FromPlantID).HasColumnName("FromPlantID");
            this.Property(t => t.ToPlantID).HasColumnName("ToPlantID");
            this.Property(t => t.DriverID).HasColumnName("DriverID");
            this.Property(t => t.RentalID).HasColumnName("RentalID");
            this.Property(t => t.NoPolisi).HasColumnName("NoPolisi");
            this.Property(t => t.SendDate).HasColumnName("SendDate");
            this.Property(t => t.ReceivedDate).HasColumnName("ReceivedDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Tipe).HasColumnName("Tipe");
        }
    }
}
