using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class UserAccountMap : EntityTypeConfiguration<UserAccount>
    {
        public UserAccountMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("UserAccount", "Mobile");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.USERNAME).HasColumnName("USERNAME");
            this.Property(t => t.PASSWORD).HasColumnName("PASSWORD");
            this.Property(t => t.OLD_PASSWORD).HasColumnName("OLD_PASSWORD");
        }
    }
}
