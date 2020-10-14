using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YasunliESModel.Models.Mapping
{
    public class MouldMaintenance2018Map : EntityTypeConfiguration<MouldMaintenance2018>
    {
        public MouldMaintenance2018Map()
        {
            // Primary Key
            this.HasKey(t => new { t.MouldCostId, t.DesignWH, t.DesignMP, t.CAMWH, t.CAMMP, t.CNCWH, t.CNCMP, t.WireCutWH, t.WireCutMP, t.EDMWH, t.EDMMP, t.WieldingWH, t.WieldingMP, t.SpottingMP, t.SpottingWH, t.PolishingMP, t.PlishingWH, t.SandblastWH, t.SandblastMP, t.DiasassemblyWH, t.DiasassemblyMP, t.AssemblyWH, t.AssemblyMP, t.WeldingLaserWH, t.WeldingLaserMP, t.HardeningWH, t.HardeningMP, t.EmployeeId, t.SaveDate, t.DryIceWH, t.DryIceMP, t.BubutManualWH, t.BubutManualMP, t.RadialBorWH, t.RadialBorMP, t.MillingManualWH, t.MillingManualMP, t.CNCBubutWH, t.CNCBubutMP, t.GrindingWH, t.GrindingMP, t.MouldCode, t.CustomerName });

            // Properties
            this.Property(t => t.MouldCostId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DesignWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DesignMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CAMWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CAMMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CNCWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CNCMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WireCutWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WireCutMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EDMWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EDMMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WieldingWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WieldingMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SpottingMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SpottingWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PolishingMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PlishingWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SandblastWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SandblastMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiasassemblyWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiasassemblyMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssemblyWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssemblyMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WeldingLaserWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WeldingLaserMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HardeningWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HardeningMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmployeeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DryIceWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DryIceMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BubutManualWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BubutManualMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RadialBorWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RadialBorMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MillingManualWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MillingManualMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CNCBubutWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CNCBubutMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GrindingWH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GrindingMP)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MouldCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MouldName)
                .HasMaxLength(50);

            this.Property(t => t.Tooling)
                .HasMaxLength(50);

            this.Property(t => t.Model)
                .HasMaxLength(50);

            this.Property(t => t.CustomerID)
                .HasMaxLength(50);

            this.Property(t => t.CustomerName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MouldMaintenance2018");
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
            this.Property(t => t.DesignWHCost).HasColumnName("DesignWHCost");
            this.Property(t => t.DesignMPCost).HasColumnName("DesignMPCost");
            this.Property(t => t.CAMWHCost).HasColumnName("CAMWHCost");
            this.Property(t => t.CAMMPCost).HasColumnName("CAMMPCost");
            this.Property(t => t.CNCWHCost).HasColumnName("CNCWHCost");
            this.Property(t => t.CNCMPCost).HasColumnName("CNCMPCost");
            this.Property(t => t.WireCutWHCost).HasColumnName("WireCutWHCost");
            this.Property(t => t.WireCutMPCost).HasColumnName("WireCutMPCost");
            this.Property(t => t.EDMWHCost).HasColumnName("EDMWHCost");
            this.Property(t => t.EDMMPCost).HasColumnName("EDMMPCost");
            this.Property(t => t.WieldingWHCost).HasColumnName("WieldingWHCost");
            this.Property(t => t.WieldingMPCost).HasColumnName("WieldingMPCost");
            this.Property(t => t.SpottingMPCost).HasColumnName("SpottingMPCost");
            this.Property(t => t.SpottingWHCost).HasColumnName("SpottingWHCost");
            this.Property(t => t.PlishingMPCost).HasColumnName("PlishingMPCost");
            this.Property(t => t.PlishingWHCost).HasColumnName("PlishingWHCost");
            this.Property(t => t.SandblastWHCost).HasColumnName("SandblastWHCost");
            this.Property(t => t.SandblastMPCost).HasColumnName("SandblastMPCost");
            this.Property(t => t.DiasassemblyWHCost).HasColumnName("DiasassemblyWHCost");
            this.Property(t => t.DiasassemblyMPCost).HasColumnName("DiasassemblyMPCost");
            this.Property(t => t.AssemblyWHCost).HasColumnName("AssemblyWHCost");
            this.Property(t => t.AssemblyMPCost).HasColumnName("AssemblyMPCost");
            this.Property(t => t.WeldingLaserWHCost).HasColumnName("WeldingLaserWHCost");
            this.Property(t => t.WeldingLaserMPCost).HasColumnName("WeldingLaserMPCost");
            this.Property(t => t.HardeningWHCost).HasColumnName("HardeningWHCost");
            this.Property(t => t.HardeningMPCost).HasColumnName("HardeningMPCost");
            this.Property(t => t.DryIceWHCost).HasColumnName("DryIceWHCost");
            this.Property(t => t.DryIceMPCost).HasColumnName("DryIceMPCost");
            this.Property(t => t.BubutManualWHCost).HasColumnName("BubutManualWHCost");
            this.Property(t => t.BubutManualMPCost).HasColumnName("BubutManualMPCost");
            this.Property(t => t.RadialBorWHCost).HasColumnName("RadialBorWHCost");
            this.Property(t => t.RadialBorMPCost).HasColumnName("RadialBorMPCost");
            this.Property(t => t.MillingManualWHCost).HasColumnName("MillingManualWHCost");
            this.Property(t => t.MillingManualMPCost).HasColumnName("MillingManualMPCost");
            this.Property(t => t.CNCBubutWHCost).HasColumnName("CNCBubutWHCost");
            this.Property(t => t.CNCBubutMPCost).HasColumnName("CNCBubutMPCost");
            this.Property(t => t.MouldCode).HasColumnName("MouldCode");
            this.Property(t => t.MouldName).HasColumnName("MouldName");
            this.Property(t => t.Tooling).HasColumnName("Tooling");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
        }
    }
}
