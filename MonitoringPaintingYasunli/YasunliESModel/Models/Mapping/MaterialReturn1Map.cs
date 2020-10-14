using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MaterialReturn1Map : EntityTypeConfiguration<MaterialReturn1>
    {
        public MaterialReturn1Map()
        {
            // Primary Key
            this.HasKey(t => t.ReturnNo);

            // Properties
            this.Property(t => t.ReturnNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FromDiv)
                .HasMaxLength(50);

            this.Property(t => t.ToDiv)
                .HasMaxLength(50);

            this.Property(t => t.Shift)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.VoidBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaterialReturn", "Inventory");
            this.Property(t => t.ReturnNo).HasColumnName("ReturnNo");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.FromDiv).HasColumnName("FromDiv");
            this.Property(t => t.ToDiv).HasColumnName("ToDiv");
            this.Property(t => t.Shift).HasColumnName("Shift");
            this.Property(t => t.ReturnDate).HasColumnName("ReturnDate");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.VoidDescription).HasColumnName("VoidDescription");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.VoidBy).HasColumnName("VoidBy");
            this.Property(t => t.VoidDate).HasColumnName("VoidDate");
            this.Property(t => t.PrintCount).HasColumnName("PrintCount");

            // Relationships
            this.HasOptional(t => t.Division)
                .WithMany(t => t.MaterialReturn1)
                .HasForeignKey(d => d.FromDiv);
            this.HasOptional(t => t.Division1)
                .WithMany(t => t.MaterialReturn11)
                .HasForeignKey(d => d.ToDiv);
            this.HasRequired(t => t.Plant)
                .WithMany(t => t.MaterialReturn1)
                .HasForeignKey(d => d.PlantID);

        }
    }
}