using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SPPMap : EntityTypeConfiguration<SPP>
    {
        public SPPMap()
        {
            // Primary Key
            this.HasKey(t => t.SPPNo);

            // Properties
            this.Property(t => t.SPPNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MachineID)
                .HasMaxLength(50);

            this.Property(t => t.CustomerID)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.MouldID)
                .HasMaxLength(50);

            this.Property(t => t.ToolingID)
                .HasMaxLength(50);

            this.Property(t => t.Cavity)
                .HasMaxLength(50);

            this.Property(t => t.ItemCode)
                .HasMaxLength(50);

            this.Property(t => t.Created_By)
                .HasMaxLength(50);

            this.Property(t => t.Keterangan)
                .HasMaxLength(250);

            this.Property(t => t.Technisi)
                .HasMaxLength(50);

            this.Property(t => t.VerNumber)
                .HasMaxLength(50);

            this.Property(t => t.ClosePacking)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SPP", "Inventory");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.MouldID).HasColumnName("MouldID");
            this.Property(t => t.ToolingID).HasColumnName("ToolingID");
            this.Property(t => t.IssueDate).HasColumnName("IssueDate");
            this.Property(t => t.Cavity).HasColumnName("Cavity");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.Created_By).HasColumnName("Created_By");
            this.Property(t => t.Keterangan).HasColumnName("Keterangan");
            this.Property(t => t.UpTime).HasColumnName("UpTime");
            this.Property(t => t.TechVerDate).HasColumnName("TechVerDate");
            this.Property(t => t.Technisi).HasColumnName("Technisi");
            this.Property(t => t.VerNumber).HasColumnName("VerNumber");
            this.Property(t => t.ClosePacking).HasColumnName("ClosePacking");
            this.Property(t => t.Aktifitas).HasColumnName("Aktifitas");
        }
    }
}
