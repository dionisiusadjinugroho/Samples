using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class GateMap : EntityTypeConfiguration<Gate>
    {
        public GateMap()
        {
            // Primary Key
            this.HasKey(t => t.ComputerName);

            // Properties
            this.Property(t => t.ComputerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gate1)
                .HasMaxLength(50);

            this.Property(t => t.AssignedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Gates", "Shared");
            this.Property(t => t.ComputerName).HasColumnName("ComputerName");
            this.Property(t => t.Gate1).HasColumnName("Gate");
            this.Property(t => t.DateAssigned).HasColumnName("DateAssigned");
            this.Property(t => t.AssignedBy).HasColumnName("AssignedBy");
        }
    }
}
