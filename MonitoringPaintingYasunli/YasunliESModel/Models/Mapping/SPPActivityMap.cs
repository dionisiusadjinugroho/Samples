using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class SPPActivityMap : EntityTypeConfiguration<SPPActivity>
    {
        public SPPActivityMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);


            // Table & Column Mappings
            this.ToTable("SPPActivity", "Inventory");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SPPNo).HasColumnName("SPPNo");
            this.Property(t => t.Activity).HasColumnName("Activity");
            this.Property(t => t.ActivityDate).HasColumnName("ActivityDate");
            this.Property(t => t.ActivityBy).HasColumnName("ActivityBy");

        }
    }
}
