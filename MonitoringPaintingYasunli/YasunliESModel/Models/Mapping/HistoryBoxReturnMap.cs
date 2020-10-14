using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class HistoryBoxReturnMap : EntityTypeConfiguration<HistoryBoxReturn>
    {
        public HistoryBoxReturnMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoryBoxReturnID);

            // Properties
            this.Property(t => t.CustomerID)
                .HasMaxLength(50);

            this.Property(t => t.RentalID)
                .HasMaxLength(50);

            this.Property(t => t.DriverID)
                .HasMaxLength(50);

            this.Property(t => t.NoPolisi)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            this.Property(t => t.ReferenceCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HistoryBoxReturn", "Inventory");
            this.Property(t => t.HistoryBoxReturnID).HasColumnName("HistoryBoxReturnID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.RentalID).HasColumnName("RentalID");
            this.Property(t => t.DriverID).HasColumnName("DriverID");
            this.Property(t => t.NoPolisi).HasColumnName("NoPolisi");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.DateReturn).HasColumnName("DateReturn");
            this.Property(t => t.ReferenceCode).HasColumnName("ReferenceCode");
        }
    }
}
