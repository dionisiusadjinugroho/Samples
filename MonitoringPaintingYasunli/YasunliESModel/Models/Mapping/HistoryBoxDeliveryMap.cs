using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class HistoryBoxDeliveryMap : EntityTypeConfiguration<HistoryBoxDelivery>
    {
        public HistoryBoxDeliveryMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoryBoxDeliveryID);

            // Properties
            this.Property(t => t.RentalID)
                .HasMaxLength(50);

            this.Property(t => t.DriverID)
                .HasMaxLength(50);

            this.Property(t => t.CustomerID)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.DivisionID)
                .HasMaxLength(50);

            this.Property(t => t.NoPolisi)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HistoryBoxDelivery", "Inventory");
            this.Property(t => t.HistoryBoxDeliveryID).HasColumnName("HistoryBoxDeliveryID");
            this.Property(t => t.RentalID).HasColumnName("RentalID");
            this.Property(t => t.DriverID).HasColumnName("DriverID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.DivisionID).HasColumnName("DivisionID");
            this.Property(t => t.NoPolisi).HasColumnName("NoPolisi");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
        }
    }
}
