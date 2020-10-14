using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldRepairCostMap : EntityTypeConfiguration<MouldRepairCost>
    {
        public MouldRepairCostMap()
        {
            // Primary Key
            this.HasKey(t => t.MouldCostId);

            // Properties
            this.Property(t => t.EmployeeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MouldRepairCost", "Shared");
            this.Property(t => t.MouldCostId).HasColumnName("MouldCostId");
            this.Property(t => t.JobId).HasColumnName("JobId");
            this.Property(t => t.DesignWH).HasColumnName("DesignWH");
            this.Property(t => t.DesignMP).HasColumnName("DesignMP");
            this.Property(t => t.CAMWH).HasColumnName("CAMWH");
            this.Property(t => t.CAMMP).HasColumnName("CAMMP");
            this.Property(t => t.CNCWH).HasColumnName("CNCWH");
            this.Property(t => t.CNCMP).HasColumnName("CNCMP");
            this.Property(t => t.WireCutWH).HasColumnName("WireCutWH");
            this.Property(t => t.WireCutMP).HasColumnName("WireCutMP");
            this.Property(t => t.EDMWH).HasColumnName("EDMWH");
            this.Property(t => t.EDMMP).HasColumnName("EDMMP");
            this.Property(t => t.WieldingWH).HasColumnName("WieldingWH");
            this.Property(t => t.WieldingMP).HasColumnName("WieldingMP");
            this.Property(t => t.SpottingMP).HasColumnName("SpottingMP");
            this.Property(t => t.SpottingWH).HasColumnName("SpottingWH");
            this.Property(t => t.PolishingMP).HasColumnName("PolishingMP");
            this.Property(t => t.PlishingWH).HasColumnName("PlishingWH");
            this.Property(t => t.SandblastWH).HasColumnName("SandblastWH");
            this.Property(t => t.SandblastMP).HasColumnName("SandblastMP");
            this.Property(t => t.DiasassemblyWH).HasColumnName("DiasassemblyWH");
            this.Property(t => t.DiasassemblyMP).HasColumnName("DiasassemblyMP");
            this.Property(t => t.AssemblyWH).HasColumnName("AssemblyWH");
            this.Property(t => t.AssemblyMP).HasColumnName("AssemblyMP");
            this.Property(t => t.WeldingLaserWH).HasColumnName("WeldingLaserWH");
            this.Property(t => t.WeldingLaserMP).HasColumnName("WeldingLaserMP");
            this.Property(t => t.HardeningWH).HasColumnName("HardeningWH");
            this.Property(t => t.HardeningMP).HasColumnName("HardeningMP");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.SaveDate).HasColumnName("SaveDate");
            this.Property(t => t.DryIceWH).HasColumnName("DryIceWH");
            this.Property(t => t.DryIceMP).HasColumnName("DryIceMP");
            this.Property(t => t.BubutManualWH).HasColumnName("BubutManualWH");
            this.Property(t => t.BubutManualMP).HasColumnName("BubutManualMP");
            this.Property(t => t.RadialBorWH).HasColumnName("RadialBorWH");
            this.Property(t => t.RadialBorMP).HasColumnName("RadialBorMP");
            this.Property(t => t.MillingManualWH).HasColumnName("MillingManualWH");
            this.Property(t => t.MillingManualMP).HasColumnName("MillingManualMP");
            this.Property(t => t.CNCBubutWH).HasColumnName("CNCBubutWH");
            this.Property(t => t.CNCBubutMP).HasColumnName("CNCBubutMP");
            this.Property(t => t.GrindingWH).HasColumnName("GrindingWH");
            this.Property(t => t.GrindingMP).HasColumnName("GrindingMP");
        }
    }
}
