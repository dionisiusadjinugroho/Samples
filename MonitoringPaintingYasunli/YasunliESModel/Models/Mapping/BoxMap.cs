using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class BoxMap : EntityTypeConfiguration<Box>
    {
        public BoxMap()
        {
            // Primary Key
            this.HasKey(t => t.BoxNo);

            // Properties
            this.Property(t => t.BoxNo)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.BoxID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BoxTypeID)
                .HasMaxLength(50);

            this.Property(t => t.CustomerID)
                .HasMaxLength(50);

            this.Property(t => t.DivisionID)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Box", "Inventory");
            this.Property(t => t.BoxNo).HasColumnName("BoxNo");
            this.Property(t => t.BoxID).HasColumnName("BoxID");
            this.Property(t => t.BoxTypeID).HasColumnName("BoxTypeID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.DivisionID).HasColumnName("DivisionID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ReceiveDate).HasColumnName("ReceiveDate");
            this.Property(t => t.BoxOut).HasColumnName("BoxOut");
            this.Property(t => t.BoxIn).HasColumnName("BoxIn");
            this.Property(t => t.Isi).HasColumnName("Isi");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
