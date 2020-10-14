using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class EngineerWorkshopJobOrderMap : EntityTypeConfiguration<EngineerWorkshopJobOrder>
    {
        public EngineerWorkshopJobOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.JobOrderID);

            // Properties
            this.Property(t => t.MouldCode)
                .HasMaxLength(50);

            this.Property(t => t.MouldName)
                .HasMaxLength(50);

            this.Property(t => t.Tooling)
                .HasMaxLength(50);

            this.Property(t => t.Model)
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.MouldID)
                .HasMaxLength(50);

            this.Property(t => t.NPKEng)
                .HasMaxLength(50);

            this.Property(t => t.NPKWorkshop)
                .HasMaxLength(50);

            this.Property(t => t.NPKDone)
                .HasMaxLength(50);

            this.Property(t => t.NPKFinalize)
                .HasMaxLength(50);

            this.Property(t => t.Judgement)
                .HasMaxLength(5);

            this.Property(t => t.ItemIDOld)
                .HasMaxLength(50);

            this.Property(t => t.ItemIDNew)
                .HasMaxLength(50);

            this.Property(t => t.MouldDefectCategory)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EngineerWorkshopJobOrder", "Shared");
            this.Property(t => t.JobOrderID).HasColumnName("JobOrderID");
            this.Property(t => t.MouldCode).HasColumnName("MouldCode");
            this.Property(t => t.MouldName).HasColumnName("MouldName");
            this.Property(t => t.Tooling).HasColumnName("Tooling");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Approved).HasColumnName("Approved");
            this.Property(t => t.Finished).HasColumnName("Finished");
            this.Property(t => t.Picture).HasColumnName("Picture");
            this.Property(t => t.DetailEng).HasColumnName("DetailEng");
            this.Property(t => t.DetailWorkshop).HasColumnName("DetailWorkshop");
            this.Property(t => t.MouldID).HasColumnName("MouldID");
            this.Property(t => t.NPKEng).HasColumnName("NPKEng");
            this.Property(t => t.NPKWorkshop).HasColumnName("NPKWorkshop");
            this.Property(t => t.NPKDone).HasColumnName("NPKDone");
            this.Property(t => t.NPKFinalize).HasColumnName("NPKFinalize");
            this.Property(t => t.Judgement).HasColumnName("Judgement");
            this.Property(t => t.DetailJudgement).HasColumnName("DetailJudgement");
            this.Property(t => t.Overhaul).HasColumnName("Overhaul");
            this.Property(t => t.ItemIDOld).HasColumnName("ItemIDOld");
            this.Property(t => t.ItemIDNew).HasColumnName("ItemIDNew");
            this.Property(t => t.MouldDefectCategory).HasColumnName("MouldDefectCategory");
        }
    }
}
