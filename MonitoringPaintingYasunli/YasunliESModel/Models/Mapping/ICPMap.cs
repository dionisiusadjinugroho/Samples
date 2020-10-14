using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ICPMap : EntityTypeConfiguration<ICP>
    {
        public ICPMap()
        {
            // Primary Key
            this.HasKey(t => t.ICPID);

            // Properties
            this.Property(t => t.ICPID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemID)
                .HasMaxLength(50);

            this.Property(t => t.VendorID)
                .HasMaxLength(50);

            this.Property(t => t.CustomerID)
                .HasMaxLength(50);

            this.Property(t => t.Laboratory)
                .HasMaxLength(50);

            this.Property(t => t.CertificateNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ICP", "Inventory");
            this.Property(t => t.ICPID).HasColumnName("ICPID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.Laboratory).HasColumnName("Laboratory");
            this.Property(t => t.CertificateNo).HasColumnName("CertificateNo");
            this.Property(t => t.CertificatePicture).HasColumnName("CertificatePicture");
            this.Property(t => t.IssueDate).HasColumnName("IssueDate");
            this.Property(t => t.Pb).HasColumnName("Pb");
            this.Property(t => t.Cd).HasColumnName("Cd");
            this.Property(t => t.Hg).HasColumnName("Hg");
            this.Property(t => t.Cr).HasColumnName("Cr");
            this.Property(t => t.PBB).HasColumnName("PBB");
            this.Property(t => t.PBDE).HasColumnName("PBDE");
        }
    }
}
