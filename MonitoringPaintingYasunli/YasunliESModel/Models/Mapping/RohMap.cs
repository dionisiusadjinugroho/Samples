using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class RohMap : EntityTypeConfiguration<Roh>
    {
        public RohMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ItemId)
                .HasMaxLength(50);

            this.Property(t => t.SuratJalanNo)
                .HasMaxLength(50);

            this.Property(t => t.LotNumber)
                .HasMaxLength(50);

            this.Property(t => t.UserCreated)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Rohs", "Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.SuratJalanNo).HasColumnName("SuratJalanNo");
            this.Property(t => t.LotNumber).HasColumnName("LotNumber");
            this.Property(t => t.PB).HasColumnName("PB");
            this.Property(t => t.CD).HasColumnName("CD");
            this.Property(t => t.HG).HasColumnName("HG");
            this.Property(t => t.CR).HasColumnName("CR");
            this.Property(t => t.BR).HasColumnName("BR");
            this.Property(t => t.UserCreated).HasColumnName("UserCreated");
        }
    }
}
