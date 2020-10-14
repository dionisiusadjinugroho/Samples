using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class PackageMap : EntityTypeConfiguration<Package>
    {
        public PackageMap()
        {
            // Primary Key
            this.HasKey(t => t.PackageID);

            // Properties
            this.Property(t => t.PackageID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.Created_By)
                .HasMaxLength(50);

            this.Property(t => t.Sended_By)
                .HasMaxLength(50);

            this.Property(t => t.OverRide_By)
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            this.Property(t => t.Checked_By)
                .HasMaxLength(50);

            this.Property(t => t.Authorized_By)
                .HasMaxLength(50);

            this.Property(t => t.FinishedOut)
                .HasMaxLength(50);

            this.Property(t => t.PrintBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Package", "Inventory");
            this.Property(t => t.PackageID).HasColumnName("PackageID");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.Revisi).HasColumnName("Revisi");
            this.Property(t => t.ReceiveDate).HasColumnName("ReceiveDate");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Created_By).HasColumnName("Created_By");
            this.Property(t => t.Sended_By).HasColumnName("Sended_By");
            this.Property(t => t.OverRide_By).HasColumnName("OverRide_By");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Checked_By).HasColumnName("Checked_By");
            this.Property(t => t.Authorized_By).HasColumnName("Authorized_By");
            this.Property(t => t.FinishedOut).HasColumnName("FinishedOut");
            this.Property(t => t.PrintBy).HasColumnName("PrintBy");
            this.Property(t => t.PrintDate).HasColumnName("PrintDate");
        }
    }
}
