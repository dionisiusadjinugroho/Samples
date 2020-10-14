using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.EmployeeId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.EmployeeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NamaKaryawan)
                .HasMaxLength(255);

            this.Property(t => t.Division)
                .HasMaxLength(50);

            this.Property(t => t.Jabatan)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.IP)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("User", "System");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.NamaKaryawan).HasColumnName("NamaKaryawan");
            this.Property(t => t.Finger).HasColumnName("Finger");
            this.Property(t => t.IsLogin).HasColumnName("IsLogin");
            this.Property(t => t.LastLogin).HasColumnName("LastLogin");
            this.Property(t => t.Division).HasColumnName("Division");
            this.Property(t => t.Jabatan).HasColumnName("Jabatan");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Reprint).HasColumnName("Reprint");
            this.Property(t => t.SplitQty).HasColumnName("SplitQty");
            this.Property(t => t.LabelES).HasColumnName("LabelES");
            this.Property(t => t.LabelPartial).HasColumnName("LabelPartial");
            this.Property(t => t.LimitSample).HasColumnName("LimitSample");
        }
    }
}
