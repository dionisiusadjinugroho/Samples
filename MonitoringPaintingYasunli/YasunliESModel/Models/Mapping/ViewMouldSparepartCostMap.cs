using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ViewMouldSparepartCostMap : EntityTypeConfiguration<ViewMouldSparepartCost>
    {
        public ViewMouldSparepartCostMap()
        {
            // Primary Key
            this.HasKey(t => t.JobOrderID);

            // Properties
            this.Property(t => t.JobOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PartName)
                .HasMaxLength(50);

            this.Property(t => t.Currency)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ViewMouldSparepartCost");
            this.Property(t => t.JobOrderID).HasColumnName("JobOrderID");
            this.Property(t => t.PartName).HasColumnName("PartName");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
        }
    }
}
