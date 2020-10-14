using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MasterRejectMap : EntityTypeConfiguration<MasterReject>
    {
        public MasterRejectMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ItemID, t.Char });

            // Properties
            this.Property(t => t.ItemID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Char)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.STD)
                .HasMaxLength(300);

            this.Property(t => t.UL)
                .HasMaxLength(50);

            this.Property(t => t.LL)
                .HasMaxLength(50);

            this.Property(t => t.Result)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MasterReject", "Inventory");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Char).HasColumnName("Char");
            this.Property(t => t.STD).HasColumnName("STD");
            this.Property(t => t.UL).HasColumnName("UL");
            this.Property(t => t.LL).HasColumnName("LL");
            this.Property(t => t.Result).HasColumnName("Result");
        }
    }
}
