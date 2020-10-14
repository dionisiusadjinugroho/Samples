using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class ListNGMap : EntityTypeConfiguration<ListNG>
    {
        public ListNGMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NG)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ListNG", "Shared");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NG).HasColumnName("NG");
        }
    }
}
