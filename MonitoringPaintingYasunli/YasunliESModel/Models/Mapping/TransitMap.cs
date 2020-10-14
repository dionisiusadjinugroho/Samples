using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class TransitMap : EntityTypeConfiguration<Transit>
    {
        public TransitMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Gate)
                .HasMaxLength(20);

            this.Property(t => t.DriverID)
                .HasMaxLength(50);

            this.Property(t => t.NoPolisi)
                .HasMaxLength(40);

            this.Property(t => t.CustomerID)
                .HasMaxLength(100);

            this.Property(t => t.BarcodeScannerHWID)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            this.Property(t => t.Closed_By)
                .HasMaxLength(50);

            this.Property(t => t.Adm)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Transit", "Shared");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Gate).HasColumnName("Gate");
            this.Property(t => t.DriverID).HasColumnName("DriverID");
            this.Property(t => t.NoPolisi).HasColumnName("NoPolisi");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.BarcodeScannerHWID).HasColumnName("BarcodeScannerHWID");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.Start_Date).HasColumnName("Start_Date");
            this.Property(t => t.End_Date).HasColumnName("End_Date");
            this.Property(t => t.Closed_By).HasColumnName("Closed_By");
            this.Property(t => t.Printed).HasColumnName("Printed");
            this.Property(t => t.Adm).HasColumnName("Adm");
        }
    }
}
