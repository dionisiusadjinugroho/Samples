using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldMap : EntityTypeConfiguration<Mould>
    {
        public MouldMap()
        {
            // Primary Key
            this.HasKey(t => t.MouldID);

            // Properties
            this.Property(t => t.MouldID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CustomerID)
                .HasMaxLength(50);

            this.Property(t => t.MachineID)
                .HasMaxLength(50);

            this.Property(t => t.ClampingForce)
                .HasMaxLength(50);

            this.Property(t => t.MouldCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MouldName)
                .HasMaxLength(50);

            this.Property(t => t.ToolingID)
                .HasMaxLength(50);

            this.Property(t => t.Cavity)
                .HasMaxLength(50);

            this.Property(t => t.Maker)
                .HasMaxLength(50);

            this.Property(t => t.Model)
                .HasMaxLength(50);

            this.Property(t => t.Gate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Mould", "Inventory");
            this.Property(t => t.MouldID).HasColumnName("MouldID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.ClampingForce).HasColumnName("ClampingForce");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.MouldCode).HasColumnName("MouldCode");
            this.Property(t => t.MouldName).HasColumnName("MouldName");
            this.Property(t => t.ToolingID).HasColumnName("ToolingID");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Length).HasColumnName("Length");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.HotRunner).HasColumnName("HotRunner");
            this.Property(t => t.SprueDiameter).HasColumnName("SprueDiameter");
            this.Property(t => t.SprueRadius).HasColumnName("SprueRadius");
            this.Property(t => t.TriplePlate).HasColumnName("TriplePlate");
            this.Property(t => t.Cavity).HasColumnName("Cavity");
            this.Property(t => t.Maker).HasColumnName("Maker");
            this.Property(t => t.ComDate).HasColumnName("ComDate");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.Overhaul).HasColumnName("Overhaul");
            this.Property(t => t.Gate).HasColumnName("Gate");
            this.Property(t => t.FamilyMould).HasColumnName("FamilyMould");
        }
    }
}
