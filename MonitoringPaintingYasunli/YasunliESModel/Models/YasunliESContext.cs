using AndonMVC;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using YasunliESModel.Models.Mapping;

namespace YasunliESModel.Models
{
    [DbConfigurationType(typeof(MultipleDbConfiguration))]
    public partial class YasunliESContext : DbContext
    {
        static YasunliESContext()
        {
            Database.SetInitializer<YasunliESContext>(null);
        }

        public YasunliESContext(string connectionString)
            : base(connectionString)
        {
            var objectContext = (this as IObjectContextAdapter).ObjectContext;
            // Sets the command timeout for all the commands
            objectContext.CommandTimeout = 500;
        }

        public DbSet<MonitoringPainting> MonitoringPaintings { get; set; }
        public DbSet<BCDetail> BCDetails { get; set; }
        public DbSet<BCHeader> BCHeaders { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<GeneralJournalDetail> GeneralJournalDetails { get; set; }
        public DbSet<GeneralJournalHeader> GeneralJournalHeaders { get; set; }
        public DbSet<ItemQtyDailyTemp> ItemQtyDailyTemps { get; set; }
        public DbSet<ItemTemp> ItemTemps { get; set; }
        public DbSet<KanbanDetailTemp> KanbanDetailTemps { get; set; }
        public DbSet<KanbanFulfilmentTemp> KanbanFulfilmentTemps { get; set; }
        public DbSet<MMDiff2018> MMDiff2018 { get; set; }
        public DbSet<MouldMaintenance2018> MouldMaintenance2018 { get; set; }
        public DbSet<MST_RAW> MST_RAW { get; set; }
        public DbSet<ScanAlertTemp> ScanAlertTemps { get; set; }
        public DbSet<StockUpload> StockUploads { get; set; }
        public DbSet<STOGDM2019> STOGDM2019 { get; set; }
        public DbSet<RecordRFID> RecordRFIDs { get; set; }
        public DbSet<AdjustStockHistory> AdjustStockHistories { get; set; }
        public DbSet<AlatUkur> AlatUkurs { get; set; }
        public DbSet<AlatUkurImage1> AlatUkurImage1 { get; set; }
        public DbSet<Assembling> Assemblings { get; set; }
        public DbSet<BarcodeScanner> BarcodeScanners { get; set; }
        public DbSet<BoM> BoMs { get; set; }
        public DbSet<BomAllPlant> BomAllPlants { get; set; }
        public DbSet<BoMTemp> BoMTemps { get; set; }
        public DbSet<BoMTempP1> BoMTempP1 { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<BoxHilang> BoxHilangs { get; set; }
        public DbSet<BoxLabelRusak> BoxLabelRusaks { get; set; }
        public DbSet<BoxLocation> BoxLocations { get; set; }
        public DbSet<BoxPairing> BoxPairings { get; set; }
        public DbSet<BoxRusak> BoxRusaks { get; set; }
        public DbSet<BoxType> BoxTypes { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<ClaimImage> ClaimImages { get; set; }
        public DbSet<CMM> CMMs { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<DeliveryToken> DeliveryTokens { get; set; }
        public DbSet<DetailAssembling> DetailAssemblings { get; set; }
        public DbSet<DetailBoM> DetailBoMs { get; set; }
        public DbSet<DetailBoMTemp> DetailBoMTemps { get; set; }
        public DbSet<DetailBomTempP1> DetailBomTempP1 { get; set; }
        public DbSet<DetailHistoryBoxDelivery> DetailHistoryBoxDeliveries { get; set; }
        public DbSet<DetailHistoryBoxLeverlansir> DetailHistoryBoxLeverlansirs { get; set; }
        public DbSet<DetailHistoryBoxReturn> DetailHistoryBoxReturns { get; set; }
        public DbSet<DetailLabel> DetailLabels { get; set; }
        public DbSet<DetailOverpacking> DetailOverpackings { get; set; }
        public DbSet<DetailReceiving> DetailReceivings { get; set; }
        public DbSet<DetailReturnPart> DetailReturnParts { get; set; }
        public DbSet<DetailSuratJalanMaterial> DetailSuratJalanMaterials { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<ECN> ECNs { get; set; }
        public DbSet<EngineeringCase> EngineeringCases { get; set; }
        public DbSet<EngineeringJobDetail> EngineeringJobDetails { get; set; }
        public DbSet<EngineeringJobOrder> EngineeringJobOrders { get; set; }
        public DbSet<ErrorBoxLog1> ErrorBoxLog1 { get; set; }
        public DbSet<HistoryBoxDelivery> HistoryBoxDeliveries { get; set; }
        public DbSet<HistoryBoxHilang> HistoryBoxHilangs { get; set; }
        public DbSet<HistoryBoxLeverlansir> HistoryBoxLeverlansirs { get; set; }
        public DbSet<HistoryBoxReturn> HistoryBoxReturns { get; set; }
        public DbSet<HistoryBoxSusulan> HistoryBoxSusulans { get; set; }
        public DbSet<ICP> ICPs { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemAttachment> ItemAttachments { get; set; }
        public DbSet<ItemDrawing> ItemDrawings { get; set; }
        public DbSet<ItemIdStandard> ItemIdStandards { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }
        public DbSet<ItemPicMaster> ItemPicMasters { get; set; }
        public DbSet<ItemPlantMapping> ItemPlantMappings { get; set; }
        public DbSet<ItemQtyDaily> ItemQtyDailies { get; set; }
        public DbSet<ItemQuantity> ItemQuantities { get; set; }
        public DbSet<ItemQuantitiesDetail> ItemQuantitiesDetails { get; set; }
        public DbSet<ItemSkillMapping> ItemSkillMappings { get; set; }
        public DbSet<JenisKerusakanMould> JenisKerusakanMoulds { get; set; }
        public DbSet<JenisKerusakanPart> JenisKerusakanParts { get; set; }
        public DbSet<JobOrder> JobOrders { get; set; }
        public DbSet<JobOrderMould> JobOrderMoulds { get; set; }
        public DbSet<Kanban> Kanbans { get; set; }
        public DbSet<KanbanDetail> KanbanDetails { get; set; }
        public DbSet<KanbanException> KanbanExceptions { get; set; }
        public DbSet<KanbanFulfilment> KanbanFulfilments { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationQuantity> LocationQuantities { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineGroup> MachineGroups { get; set; }
        public DbSet<MasterReject> MasterRejects { get; set; }
        public DbSet<MaterialAdjustment> MaterialAdjustments { get; set; }
        public DbSet<MaterialAdjustmentDetail> MaterialAdjustmentDetails { get; set; }
        public DbSet<MaterialItemQuantity> MaterialItemQuantities { get; set; }
        public DbSet<MaterialOut> MaterialOuts { get; set; }
        public DbSet<MaterialOutDetail> MaterialOutDetails { get; set; }
        public DbSet<MaterialPallet> MaterialPallets { get; set; }
        public DbSet<MaterialReceiving> MaterialReceivings { get; set; }
        public DbSet<MaterialReceivingDetail> MaterialReceivingDetails { get; set; }
        public DbSet<MaterialReturn1> MaterialReturn1 { get; set; }
        public DbSet<MaterialReturnDetail1> MaterialReturnDetail1 { get; set; }
        public DbSet<MaterialToRequestOrder> MaterialToRequestOrders { get; set; }
        public DbSet<MixingDetail> MixingDetails { get; set; }
        public DbSet<MixingHeader> MixingHeaders { get; set; }
        public DbSet<MixingMachine> MixingMachines { get; set; }
        public DbSet<MixingToRequestOrder> MixingToRequestOrders { get; set; }
        public DbSet<Mould> Moulds { get; set; }
        public DbSet<MouldHistory> MouldHistories { get; set; }
        public DbSet<MouldSparepart> MouldSpareparts { get; set; }
        public DbSet<MouldSparepart1> MouldSparepart1 { get; set; }
        public DbSet<MouldTransactionDetail> MouldTransactionDetails { get; set; }
        public DbSet<MouldTransactionHeader> MouldTransactionHeaders { get; set; }
        public DbSet<NGBox> NGBoxes { get; set; }
        public DbSet<Overpacking> Overpackings { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageChanged> PackageChangeds { get; set; }
        public DbSet<PackageChangedDetail> PackageChangedDetails { get; set; }
        public DbSet<PackageDetail> PackageDetails { get; set; }
        public DbSet<PartLabelChanged> PartLabelChangeds { get; set; }
        public DbSet<PartTransaction> PartTransactions { get; set; }
        public DbSet<PaymentTerm> PaymentTerms { get; set; }
        public DbSet<PickingListDetail> PickingListDetails { get; set; }
        public DbSet<PickingListHeader> PickingListHeaders { get; set; }
        public DbSet<PSI> PSIs { get; set; }
        public DbSet<PSIDetail> PSIDetails { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<PurchaseOrderSubcon> PurchaseOrderSubcons { get; set; }
        public DbSet<PurchaseOrderSubconDetail> PurchaseOrderSubconDetails { get; set; }
        public DbSet<PurchaseReturn> PurchaseReturns { get; set; }
        public DbSet<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
        public DbSet<QtyHoldDaily> QtyHoldDailies { get; set; }
        public DbSet<Receiving> Receivings { get; set; }
        public DbSet<Recycle> Recycles { get; set; }
        public DbSet<RecycleDetail> RecycleDetails { get; set; }
        public DbSet<RecyclingLabel> RecyclingLabels { get; set; }
        public DbSet<ReprintHistory> ReprintHistories { get; set; }
        public DbSet<RePrintSuratJalanHistory> RePrintSuratJalanHistories { get; set; }
        public DbSet<RequestOrder> RequestOrders { get; set; }
        public DbSet<RequestOrderDetail> RequestOrderDetails { get; set; }
        public DbSet<ResponseKanban> ResponseKanbans { get; set; }
        public DbSet<ReturnPart> ReturnParts { get; set; }
        public DbSet<Rework> Reworks { get; set; }
        public DbSet<ReworkDetail> ReworkDetails { get; set; }
        public DbSet<Roh> Rohs { get; set; }
        public DbSet<Sack> Sacks { get; set; }
        public DbSet<SacksDetail> SacksDetails { get; set; }
        public DbSet<SalesReturn> SalesReturns { get; set; }
        public DbSet<SalesReturnDetail> SalesReturnDetails { get; set; }
        public DbSet<SamplingCMMDetail> SamplingCMMDetails { get; set; }
        public DbSet<SamplingCMMHeader> SamplingCMMHeaders { get; set; }
        public DbSet<SamplingDetail> SamplingDetails { get; set; }
        public DbSet<SamplingHeader> SamplingHeaders { get; set; }
        public DbSet<SamplingSizeNode> SamplingSizeNodes { get; set; }
        public DbSet<ScanGate> ScanGates { get; set; }
        public DbSet<SellingPrice> SellingPrices { get; set; }
        public DbSet<Sparepart2ndProcess> Sparepart2ndProcess { get; set; }
        public DbSet<SPP> SPPs { get; set; }
        public DbSet<SPQ> SPQs { get; set; }
        public DbSet<StockGudangHarian> StockGudangHarians { get; set; }
        public DbSet<SuratJalanDelivery> SuratJalanDeliveries { get; set; }
        public DbSet<SuratJalanMaterial> SuratJalanMaterials { get; set; }
        public DbSet<TransactionScrap> TransactionScraps { get; set; }
        public DbSet<TransactionScrapDetail> TransactionScrapDetails { get; set; }
        public DbSet<UoM> UoMs { get; set; }
        public DbSet<UomConversion> UomConversions { get; set; }
        public DbSet<BQICSException> BQICSExceptions { get; set; }
        public DbSet<BQICSMarking> BQICSMarkings { get; set; }
        public DbSet<CMMHeader> CMMHeaders { get; set; }
        public DbSet<LimitSample> LimitSamples { get; set; }
        public DbSet<LimitSampleDetail> LimitSampleDetails { get; set; }
        public DbSet<LimitSampleReturn> LimitSampleReturns { get; set; }
        public DbSet<LotMarking> LotMarkings { get; set; }
        public DbSet<QueueGate> QueueGates { get; set; }
        public DbSet<RejectImage> RejectImages { get; set; }
        public DbSet<Sampling> Samplings { get; set; }
        public DbSet<SingleSampling> SingleSamplings { get; set; }
        public DbSet<CM> CMS { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DetailLabelLansir> DetailLabelLansirs { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverDetail> DriverDetails { get; set; }
        public DbSet<EmployeeList> EmployeeLists { get; set; }
        public DbSet<EngineeringAttachment> EngineeringAttachments { get; set; }
        public DbSet<EngineerWorkshopJobOrder> EngineerWorkshopJobOrders { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<HistoryHoldQC> HistoryHoldQCs { get; set; }
        public DbSet<HoldQC> HoldQCs { get; set; }
        public DbSet<ItemForecast> ItemForecasts { get; set; }
        public DbSet<ItemForecastHistory> ItemForecastHistories { get; set; }
        public DbSet<JOAttachment> JOAttachments { get; set; }
        public DbSet<JobWorkshopHistory> JobWorkshopHistories { get; set; }
        public DbSet<LabelLansir> LabelLansirs { get; set; }
        public DbSet<Leverlansir> Leverlansirs { get; set; }
        public DbSet<ListNG> ListNGs { get; set; }
        public DbSet<LossTimeDetail> LossTimeDetails { get; set; }
        public DbSet<Mobil> Mobils { get; set; }
        public DbSet<MouldComponentDetail> MouldComponentDetails { get; set; }
        public DbSet<MouldRepairCost> MouldRepairCosts { get; set; }
        public DbSet<MouldRepairDetail> MouldRepairDetails { get; set; }
        public DbSet<MouldRepairPrice> MouldRepairPrices { get; set; }
        public DbSet<MouldSparepartCost> MouldSparepartCosts { get; set; }
        public DbSet<OperatorAbsent> OperatorAbsents { get; set; }
        public DbSet<PartTransactionLansir> PartTransactionLansirs { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<ProductionCheckList> ProductionCheckLists { get; set; }
        public DbSet<ProductionChecklistLTDetail> ProductionChecklistLTDetails { get; set; }
        public DbSet<ProductionCheckListNGDetail> ProductionCheckListNGDetails { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<ScanAlert> ScanAlerts { get; set; }
        public DbSet<StockOpname> StockOpnames { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingHeader> TrainingHeaders { get; set; }
        public DbSet<TrainingModule> TrainingModules { get; set; }
        public DbSet<Transit> Transits { get; set; }
        public DbSet<Troubleshooting> Troubleshootings { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<WorkShift> WorkShifts { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<MasterLog> MasterLogs { get; set; }
        public DbSet<NumberingFormat> NumberingFormats { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ViewJOAssyItemList> ViewJOAssyItemLists { get; set; }
        public DbSet<ViewLemburPerDateTotal> ViewLemburPerDateTotals { get; set; }
        public DbSet<ViewMouldRepairCosting> ViewMouldRepairCostings { get; set; }
        public DbSet<ViewMouldSparepartCost> ViewMouldSparepartCosts { get; set; }
        public DbSet<ViewWarehouseOutDetail> ViewWarehouseOutDetails { get; set; }
        public DbSet<ItemListNew> ItemListNews { get; set; }
        public DbSet<ViewAbsensiOperator1> ViewAbsensiOperator1 { get; set; }
        public DbSet<ViewDataBoM> ViewDataBoMs { get; set; }
        public DbSet<ViewDataDetailBoM> ViewDataDetailBoMs { get; set; }
        public DbSet<ViewItemList> ViewItemLists { get; set; }
        public DbSet<ViewItemListNew> ViewItemListNews { get; set; }
        public DbSet<ViewItemSTO> ViewItemSTOes { get; set; }
        public DbSet<ViewKanbanRemain> ViewKanbanRemains { get; set; }
        public DbSet<ViewKanbanRemain2> ViewKanbanRemain2 { get; set; }
        public DbSet<ViewMutasiGDMDesember> ViewMutasiGDMDesembers { get; set; }
        public DbSet<ViewMutasiGDMJanuari> ViewMutasiGDMJanuaris { get; set; }
        public DbSet<ViewPORemainAccounting> ViewPORemainAccountings { get; set; }
        public DbSet<ViewReworkOut> ViewReworkOuts { get; set; }
        public DbSet<ViewScanOutAlertList> ViewScanOutAlertLists { get; set; }
        public DbSet<ViewSkillMappingSPP> ViewSkillMappingSPPs { get; set; }
        public DbSet<ViewStockDaysByDispatch> ViewStockDaysByDispatches { get; set; }
        public DbSet<ViewVoidedMaterial> ViewVoidedMaterials { get; set; }
        public DbSet<BQICSAlertList> BQICSAlertLists { get; set; }
        public DbSet<ViewBQICSAlertList> ViewBQICSAlertLists { get; set; }
        public DbSet<ViewOperatorToMachine> ViewOperatorToMachines { get; set; }
        public DbSet<ViewEmployeeList> ViewEmployeeLists { get; set; }
        public DbSet<ViewEmployeeList2> ViewEmployeeList2 { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

        public DbSet<SPPActivity> SPPActivitys { get; set; }
        public DbSet<TempLocationGudang> TempLocationGudangs { get; set; }
        public DbSet<STOGudangReady> STOGudangReadys { get; set; }
        public DbSet<PartTransactionInjection> PartTransactionInjections { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MonitoringPaintingMap());
            modelBuilder.Configurations.Add(new BCDetailMap());
            modelBuilder.Configurations.Add(new BCHeaderMap());
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new GeneralJournalDetailMap());
            modelBuilder.Configurations.Add(new GeneralJournalHeaderMap());
            modelBuilder.Configurations.Add(new ItemQtyDailyTempMap());
            modelBuilder.Configurations.Add(new ItemTempMap());
            modelBuilder.Configurations.Add(new KanbanDetailTempMap());
            modelBuilder.Configurations.Add(new KanbanFulfilmentTempMap());
            modelBuilder.Configurations.Add(new MMDiff2018Map());
            modelBuilder.Configurations.Add(new MouldMaintenance2018Map());
            modelBuilder.Configurations.Add(new MST_RAWMap());
            modelBuilder.Configurations.Add(new ScanAlertTempMap());
            modelBuilder.Configurations.Add(new StockUploadMap());
            modelBuilder.Configurations.Add(new STOGDM2019Map());
            modelBuilder.Configurations.Add(new RecordRFIDMap());
            modelBuilder.Configurations.Add(new AdjustStockHistoryMap());
            modelBuilder.Configurations.Add(new AlatUkurMap());
            modelBuilder.Configurations.Add(new AlatUkurImage1Map());
            modelBuilder.Configurations.Add(new AssemblingMap());
            modelBuilder.Configurations.Add(new BarcodeScannerMap());
            modelBuilder.Configurations.Add(new BoMMap());
            modelBuilder.Configurations.Add(new BomAllPlantMap());
            modelBuilder.Configurations.Add(new BoMTempMap());
            modelBuilder.Configurations.Add(new BoMTempP1Map());
            modelBuilder.Configurations.Add(new BoxMap());
            modelBuilder.Configurations.Add(new BoxHilangMap());
            modelBuilder.Configurations.Add(new BoxLabelRusakMap());
            modelBuilder.Configurations.Add(new BoxLocationMap());
            modelBuilder.Configurations.Add(new BoxPairingMap());
            modelBuilder.Configurations.Add(new BoxRusakMap());
            modelBuilder.Configurations.Add(new BoxTypeMap());
            modelBuilder.Configurations.Add(new ClaimMap());
            modelBuilder.Configurations.Add(new ClaimImageMap());
            modelBuilder.Configurations.Add(new CMMMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new DeliveryTokenMap());
            modelBuilder.Configurations.Add(new DetailAssemblingMap());
            modelBuilder.Configurations.Add(new DetailBoMMap());
            modelBuilder.Configurations.Add(new DetailBoMTempMap());
            modelBuilder.Configurations.Add(new DetailBomTempP1Map());
            modelBuilder.Configurations.Add(new DetailHistoryBoxDeliveryMap());
            modelBuilder.Configurations.Add(new DetailHistoryBoxLeverlansirMap());
            modelBuilder.Configurations.Add(new DetailHistoryBoxReturnMap());
            modelBuilder.Configurations.Add(new DetailLabelMap());
            modelBuilder.Configurations.Add(new DetailOverpackingMap());
            modelBuilder.Configurations.Add(new DetailReceivingMap());
            modelBuilder.Configurations.Add(new DetailReturnPartMap());
            modelBuilder.Configurations.Add(new DetailSuratJalanMaterialMap());
            modelBuilder.Configurations.Add(new DivisionMap());
            modelBuilder.Configurations.Add(new ECNMap());
            modelBuilder.Configurations.Add(new EngineeringCaseMap());
            modelBuilder.Configurations.Add(new EngineeringJobDetailMap());
            modelBuilder.Configurations.Add(new EngineeringJobOrderMap());
            modelBuilder.Configurations.Add(new ErrorBoxLog1Map());
            modelBuilder.Configurations.Add(new HistoryBoxDeliveryMap());
            modelBuilder.Configurations.Add(new HistoryBoxHilangMap());
            modelBuilder.Configurations.Add(new HistoryBoxLeverlansirMap());
            modelBuilder.Configurations.Add(new HistoryBoxReturnMap());
            modelBuilder.Configurations.Add(new HistoryBoxSusulanMap());
            modelBuilder.Configurations.Add(new ICPMap());
            modelBuilder.Configurations.Add(new ItemMap());
            modelBuilder.Configurations.Add(new ItemAttachmentMap());
            modelBuilder.Configurations.Add(new ItemDrawingMap());
            modelBuilder.Configurations.Add(new ItemIdStandardMap());
            modelBuilder.Configurations.Add(new ItemImageMap());
            modelBuilder.Configurations.Add(new ItemPicMasterMap());
            modelBuilder.Configurations.Add(new ItemPlantMappingMap());
            modelBuilder.Configurations.Add(new ItemQtyDailyMap());
            modelBuilder.Configurations.Add(new ItemQuantityMap());
            modelBuilder.Configurations.Add(new ItemQuantitiesDetailMap());
            modelBuilder.Configurations.Add(new ItemSkillMappingMap());
            modelBuilder.Configurations.Add(new JenisKerusakanMouldMap());
            modelBuilder.Configurations.Add(new JenisKerusakanPartMap());
            modelBuilder.Configurations.Add(new JobOrderMap());
            modelBuilder.Configurations.Add(new JobOrderMouldMap());
            modelBuilder.Configurations.Add(new KanbanMap());
            modelBuilder.Configurations.Add(new KanbanDetailMap());
            modelBuilder.Configurations.Add(new KanbanExceptionMap());
            modelBuilder.Configurations.Add(new KanbanFulfilmentMap());
            modelBuilder.Configurations.Add(new LabelMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new LocationQuantityMap());
            modelBuilder.Configurations.Add(new MachineMap());
            modelBuilder.Configurations.Add(new MachineGroupMap());
            modelBuilder.Configurations.Add(new MasterRejectMap());
            modelBuilder.Configurations.Add(new MaterialAdjustmentMap());
            modelBuilder.Configurations.Add(new MaterialAdjustmentDetailMap());
            modelBuilder.Configurations.Add(new MaterialItemQuantityMap());
            modelBuilder.Configurations.Add(new MaterialOutMap());
            modelBuilder.Configurations.Add(new MaterialOutDetailMap());
            modelBuilder.Configurations.Add(new MaterialPalletMap());
            modelBuilder.Configurations.Add(new MaterialReceivingMap());
            modelBuilder.Configurations.Add(new MaterialReceivingDetailMap());
            modelBuilder.Configurations.Add(new MaterialReturn1Map());
            modelBuilder.Configurations.Add(new MaterialReturnDetail1Map());
            modelBuilder.Configurations.Add(new MaterialToRequestOrderMap());
            modelBuilder.Configurations.Add(new MixingDetailMap());
            modelBuilder.Configurations.Add(new MixingHeaderMap());
            modelBuilder.Configurations.Add(new MixingMachineMap());
            modelBuilder.Configurations.Add(new MixingToRequestOrderMap());
            modelBuilder.Configurations.Add(new MouldMap());
            modelBuilder.Configurations.Add(new MouldHistoryMap());
            modelBuilder.Configurations.Add(new MouldSparepartMap());
            modelBuilder.Configurations.Add(new MouldSparepart1Map());
            modelBuilder.Configurations.Add(new MouldTransactionDetailMap());
            modelBuilder.Configurations.Add(new MouldTransactionHeaderMap());
            modelBuilder.Configurations.Add(new NGBoxMap());
            modelBuilder.Configurations.Add(new OverpackingMap());
            modelBuilder.Configurations.Add(new PackageMap());
            modelBuilder.Configurations.Add(new PackageChangedMap());
            modelBuilder.Configurations.Add(new PackageChangedDetailMap());
            modelBuilder.Configurations.Add(new PackageDetailMap());
            modelBuilder.Configurations.Add(new PartLabelChangedMap());
            modelBuilder.Configurations.Add(new PartTransactionMap());
            modelBuilder.Configurations.Add(new PaymentTermMap());
            modelBuilder.Configurations.Add(new PickingListDetailMap());
            modelBuilder.Configurations.Add(new PickingListHeaderMap());
            modelBuilder.Configurations.Add(new PSIMap());
            modelBuilder.Configurations.Add(new PSIDetailMap());
            modelBuilder.Configurations.Add(new PurchaseOrderMap());
            modelBuilder.Configurations.Add(new PurchaseOrderDetailMap());
            modelBuilder.Configurations.Add(new PurchaseOrderSubconMap());
            modelBuilder.Configurations.Add(new PurchaseOrderSubconDetailMap());
            modelBuilder.Configurations.Add(new PurchaseReturnMap());
            modelBuilder.Configurations.Add(new PurchaseReturnDetailMap());
            modelBuilder.Configurations.Add(new QtyHoldDailyMap());
            modelBuilder.Configurations.Add(new ReceivingMap());
            modelBuilder.Configurations.Add(new RecycleMap());
            modelBuilder.Configurations.Add(new RecycleDetailMap());
            modelBuilder.Configurations.Add(new RecyclingLabelMap());
            modelBuilder.Configurations.Add(new ReprintHistoryMap());
            modelBuilder.Configurations.Add(new RePrintSuratJalanHistoryMap());
            modelBuilder.Configurations.Add(new RequestOrderMap());
            modelBuilder.Configurations.Add(new RequestOrderDetailMap());
            modelBuilder.Configurations.Add(new ResponseKanbanMap());
            modelBuilder.Configurations.Add(new ReturnPartMap());
            modelBuilder.Configurations.Add(new ReworkMap());
            modelBuilder.Configurations.Add(new ReworkDetailMap());
            modelBuilder.Configurations.Add(new RohMap());
            modelBuilder.Configurations.Add(new SackMap());
            modelBuilder.Configurations.Add(new SacksDetailMap());
            modelBuilder.Configurations.Add(new SalesReturnMap());
            modelBuilder.Configurations.Add(new SalesReturnDetailMap());
            modelBuilder.Configurations.Add(new SamplingCMMDetailMap());
            modelBuilder.Configurations.Add(new SamplingCMMHeaderMap());
            modelBuilder.Configurations.Add(new SamplingDetailMap());
            modelBuilder.Configurations.Add(new SamplingHeaderMap());
            modelBuilder.Configurations.Add(new SamplingSizeNodeMap());
            modelBuilder.Configurations.Add(new ScanGateMap());
            modelBuilder.Configurations.Add(new SellingPriceMap());
            modelBuilder.Configurations.Add(new Sparepart2ndProcessMap());
            modelBuilder.Configurations.Add(new SPPMap());
            modelBuilder.Configurations.Add(new SPQMap());
            modelBuilder.Configurations.Add(new StockGudangHarianMap());
            modelBuilder.Configurations.Add(new SuratJalanDeliveryMap());
            modelBuilder.Configurations.Add(new SuratJalanMaterialMap());
            modelBuilder.Configurations.Add(new TransactionScrapMap());
            modelBuilder.Configurations.Add(new TransactionScrapDetailMap());
            modelBuilder.Configurations.Add(new UoMMap());
            modelBuilder.Configurations.Add(new UomConversionMap());
            modelBuilder.Configurations.Add(new BQICSExceptionMap());
            modelBuilder.Configurations.Add(new BQICSMarkingMap());
            modelBuilder.Configurations.Add(new CMMHeaderMap());
            modelBuilder.Configurations.Add(new LimitSampleMap());
            modelBuilder.Configurations.Add(new LimitSampleDetailMap());
            modelBuilder.Configurations.Add(new LimitSampleReturnMap());
            modelBuilder.Configurations.Add(new LotMarkingMap());
            modelBuilder.Configurations.Add(new QueueGateMap());
            modelBuilder.Configurations.Add(new RejectImageMap());
            modelBuilder.Configurations.Add(new SamplingMap());
            modelBuilder.Configurations.Add(new SingleSamplingMap());
            modelBuilder.Configurations.Add(new CMMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new DetailLabelLansirMap());
            modelBuilder.Configurations.Add(new DriverMap());
            modelBuilder.Configurations.Add(new DriverDetailMap());
            modelBuilder.Configurations.Add(new EmployeeListMap());
            modelBuilder.Configurations.Add(new EngineeringAttachmentMap());
            modelBuilder.Configurations.Add(new EngineerWorkshopJobOrderMap());
            modelBuilder.Configurations.Add(new GateMap());
            modelBuilder.Configurations.Add(new HistoryHoldQCMap());
            modelBuilder.Configurations.Add(new HoldQCMap());
            modelBuilder.Configurations.Add(new ItemForecastMap());
            modelBuilder.Configurations.Add(new ItemForecastHistoryMap());
            modelBuilder.Configurations.Add(new JOAttachmentMap());
            modelBuilder.Configurations.Add(new JobWorkshopHistoryMap());
            modelBuilder.Configurations.Add(new LabelLansirMap());
            modelBuilder.Configurations.Add(new LeverlansirMap());
            modelBuilder.Configurations.Add(new ListNGMap());
            modelBuilder.Configurations.Add(new LossTimeDetailMap());
            modelBuilder.Configurations.Add(new MobilMap());
            modelBuilder.Configurations.Add(new MouldComponentDetailMap());
            modelBuilder.Configurations.Add(new MouldRepairCostMap());
            modelBuilder.Configurations.Add(new MouldRepairDetailMap());
            modelBuilder.Configurations.Add(new MouldRepairPriceMap());
            modelBuilder.Configurations.Add(new MouldSparepartCostMap());
            modelBuilder.Configurations.Add(new OperatorAbsentMap());
            modelBuilder.Configurations.Add(new PartTransactionLansirMap());
            modelBuilder.Configurations.Add(new PlantMap());
            modelBuilder.Configurations.Add(new ProductionCheckListMap());
            modelBuilder.Configurations.Add(new ProductionChecklistLTDetailMap());
            modelBuilder.Configurations.Add(new ProductionCheckListNGDetailMap());
            modelBuilder.Configurations.Add(new RentalMap());
            modelBuilder.Configurations.Add(new ScanAlertMap());
            modelBuilder.Configurations.Add(new StockOpnameMap());
            modelBuilder.Configurations.Add(new TrainingMap());
            modelBuilder.Configurations.Add(new TrainingHeaderMap());
            modelBuilder.Configurations.Add(new TrainingModuleMap());
            modelBuilder.Configurations.Add(new TransitMap());
            modelBuilder.Configurations.Add(new TroubleshootingMap());
            modelBuilder.Configurations.Add(new VendorMap());
            modelBuilder.Configurations.Add(new WorkShiftMap());
            modelBuilder.Configurations.Add(new LogMap());
            modelBuilder.Configurations.Add(new MasterLogMap());
            modelBuilder.Configurations.Add(new NumberingFormatMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new ViewJOAssyItemListMap());
            modelBuilder.Configurations.Add(new ViewLemburPerDateTotalMap());
            modelBuilder.Configurations.Add(new ViewMouldRepairCostingMap());
            modelBuilder.Configurations.Add(new ViewMouldSparepartCostMap());
            modelBuilder.Configurations.Add(new ViewWarehouseOutDetailMap());
            modelBuilder.Configurations.Add(new ItemListNewMap());
            modelBuilder.Configurations.Add(new ViewAbsensiOperator1Map());
            modelBuilder.Configurations.Add(new ViewDataBoMMap());
            modelBuilder.Configurations.Add(new ViewDataDetailBoMMap());
            modelBuilder.Configurations.Add(new ViewItemListMap());
            modelBuilder.Configurations.Add(new ViewItemListNewMap());
            modelBuilder.Configurations.Add(new ViewItemSTOMap());
            modelBuilder.Configurations.Add(new ViewKanbanRemainMap());
            modelBuilder.Configurations.Add(new ViewKanbanRemain2Map());
            modelBuilder.Configurations.Add(new ViewMutasiGDMDesemberMap());
            modelBuilder.Configurations.Add(new ViewMutasiGDMJanuariMap());
            modelBuilder.Configurations.Add(new ViewPORemainAccountingMap());
            modelBuilder.Configurations.Add(new ViewReworkOutMap());
            modelBuilder.Configurations.Add(new ViewScanOutAlertListMap());
            modelBuilder.Configurations.Add(new ViewSkillMappingSPPMap());
            modelBuilder.Configurations.Add(new ViewStockDaysByDispatchMap());
            modelBuilder.Configurations.Add(new ViewVoidedMaterialMap());
            modelBuilder.Configurations.Add(new BQICSAlertListMap());
            modelBuilder.Configurations.Add(new ViewBQICSAlertListMap());
            modelBuilder.Configurations.Add(new ViewOperatorToMachineMap());
            modelBuilder.Configurations.Add(new ViewEmployeeListMap());
            modelBuilder.Configurations.Add(new ViewEmployeeList2Map());
            modelBuilder.Configurations.Add(new UserAccountMap());

            modelBuilder.Configurations.Add(new SPPActivityMap());
            modelBuilder.Configurations.Add(new TempLocationGudangMap());
            modelBuilder.Configurations.Add(new STOGudangReadyMap());
            modelBuilder.Configurations.Add(new PartTransactionInjectionMap());

        }
    }
}
