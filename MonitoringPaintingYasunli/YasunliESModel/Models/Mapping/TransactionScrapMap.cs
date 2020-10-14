using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class TransactionScrapMap : EntityTypeConfiguration<TransactionScrap>
    {
        public TransactionScrapMap()
        {
            // Primary Key
            this.HasKey(t => t.TransactionScrapNo);

            // Properties
            this.Property(t => t.TransactionScrapNo)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.JenisDokumen)
                .HasMaxLength(50);

            this.Property(t => t.NoDokumen)
                .HasMaxLength(250);

            this.Property(t => t.NoInvoice)
                .HasMaxLength(250);

            this.Property(t => t.NoSuratJalan)
                .HasMaxLength(250);

            this.Property(t => t.CompanyDestinationID)
                .HasMaxLength(50);

            this.Property(t => t.PlantID)
                .HasMaxLength(50);

            this.Property(t => t.NoAju)
                .HasMaxLength(250);

            this.Property(t => t.VoidBy)
                .HasMaxLength(250);

            this.Property(t => t.Tax_Type)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(250);

            this.Property(t => t.Status_Transaction)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("TransactionScrap", "Inventory");
            this.Property(t => t.TransactionScrapNo).HasColumnName("TransactionScrapNo");
            this.Property(t => t.JenisDokumen).HasColumnName("JenisDokumen");
            this.Property(t => t.NoDokumen).HasColumnName("NoDokumen");
            this.Property(t => t.DocumentDate).HasColumnName("DocumentDate");
            this.Property(t => t.NoInvoice).HasColumnName("NoInvoice");
            this.Property(t => t.NoSuratJalan).HasColumnName("NoSuratJalan");
            this.Property(t => t.CompanyDestinationID).HasColumnName("CompanyDestinationID");
            this.Property(t => t.PlantID).HasColumnName("PlantID");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.NoAju).HasColumnName("NoAju");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.VoidBy).HasColumnName("VoidBy");
            this.Property(t => t.VoidDate).HasColumnName("VoidDate");
            this.Property(t => t.VoidDescription).HasColumnName("VoidDescription");
            this.Property(t => t.Total_Qty).HasColumnName("Total_Qty");
            this.Property(t => t.Total_GrossWeight).HasColumnName("Total_GrossWeight");
            this.Property(t => t.Total_Tax).HasColumnName("Total_Tax");
            this.Property(t => t.Total_DPP).HasColumnName("Total_DPP");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Tax_Type).HasColumnName("Tax_Type");
            this.Property(t => t.Tax_Percent).HasColumnName("Tax_Percent");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Status_Transaction).HasColumnName("Status_Transaction");
        }
    }
}
