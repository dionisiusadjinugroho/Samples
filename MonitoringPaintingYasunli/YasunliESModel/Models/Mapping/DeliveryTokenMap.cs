using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class DeliveryTokenMap : EntityTypeConfiguration<DeliveryToken>
    {
        public DeliveryTokenMap()
        {
            // Primary Key
            this.HasKey(t => t.DeliveryTokenId);

            // Properties
            this.Property(t => t.TokenId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.Created_By)
                .HasMaxLength(50);

            this.Property(t => t.Sended_By)
                .HasMaxLength(50);

            this.Property(t => t.OverRide_By)
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            this.Property(t => t.Checked_By)
                .HasMaxLength(50);

            this.Property(t => t.Authorized_By)
                .HasMaxLength(50);

            this.Property(t => t.FinishedOut)
                .HasMaxLength(50);

            this.Property(t => t.PrintBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DeliveryToken", "Inventory");
            this.Property(t => t.TokenId).HasColumnName("TokenId");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.Revisi).HasColumnName("Revisi");
            this.Property(t => t.ReceiveDate).HasColumnName("ReceiveDate");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Created_By).HasColumnName("Created_By");
            this.Property(t => t.Sended_By).HasColumnName("Sended_By");
            this.Property(t => t.OverRide_By).HasColumnName("OverRide_By");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Checked_By).HasColumnName("Checked_By");
            this.Property(t => t.Authorized_By).HasColumnName("Authorized_By");
            this.Property(t => t.FinishedOut).HasColumnName("FinishedOut");
            this.Property(t => t.PrintBy).HasColumnName("PrintBy");
            this.Property(t => t.PrintDate).HasColumnName("PrintDate");
            this.Property(t => t.DeliveryTokenId).HasColumnName("DeliveryTokenId");
            this.Property(t => t.TokenDate).HasColumnName("TokenDate");
        }
    }
}
