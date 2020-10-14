using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class Sparepart2ndProcessMap : EntityTypeConfiguration<Sparepart2ndProcess>
    {
        public Sparepart2ndProcessMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ItemCode)
                .HasMaxLength(50);

            this.Property(t => t.RequestID)
                .HasMaxLength(50);

            this.Property(t => t.SackID)
                .HasMaxLength(50);

            this.Property(t => t.DocumentNo)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.Divisi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sparepart2ndProcess", "Inventory");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.SackID).HasColumnName("SackID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.DocumentNo).HasColumnName("DocumentNo");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Divisi).HasColumnName("Divisi");
            this.Property(t => t.SendDate).HasColumnName("SendDate");
        }
    }
}
