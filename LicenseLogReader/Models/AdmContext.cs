using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LicenseLogReader.Models
{
    public partial class AdmContext : DbContext
    {
        public AdmContext()
        {
        }

        public AdmContext(DbContextOptions<AdmContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<ActionLog> ActionLog { get; set; }
        //public virtual DbSet<ActionType> ActionType { get; set; }
        //public virtual DbSet<AudKosgu> AudKosgu { get; set; }
        //public virtual DbSet<AudOperName> AudOperName { get; set; }
        //public virtual DbSet<AudSelKosgu> AudSelKosgu { get; set; }
        //public virtual DbSet<BrrepAgreementParams> BrrepAgreementParams { get; set; }
        //public virtual DbSet<BrrepAgreements> BrrepAgreements { get; set; }
        //public virtual DbSet<BrrepChangeShield> BrrepChangeShield { get; set; }
        //public virtual DbSet<BrrepDoneReportArc> BrrepDoneReportArc { get; set; }
        //public virtual DbSet<BrrepDoneReportBest> BrrepDoneReportBest { get; set; }
        //public virtual DbSet<BrrepDoneReportSmd> BrrepDoneReportSmd { get; set; }
        //public virtual DbSet<BrrepDoneReportToc> BrrepDoneReportToc { get; set; }
        //public virtual DbSet<BrrepF0503121> BrrepF0503121 { get; set; }
        //public virtual DbSet<BrrepF0503121S> BrrepF0503121S { get; set; }
        //public virtual DbSet<BrrepF0503127D> BrrepF0503127D { get; set; }
        //public virtual DbSet<BrrepF0503127F> BrrepF0503127F { get; set; }
        //public virtual DbSet<BrrepF0503127FS> BrrepF0503127FS { get; set; }
        //public virtual DbSet<BrrepF0503127R> BrrepF0503127R { get; set; }
        //public virtual DbSet<BrrepF0503137D> BrrepF0503137D { get; set; }
        //public virtual DbSet<BrrepF0503137F> BrrepF0503137F { get; set; }
        //public virtual DbSet<BrrepF0503137FS> BrrepF0503137FS { get; set; }
        //public virtual DbSet<BrrepF0503137R> BrrepF0503137R { get; set; }
        //public virtual DbSet<BrrepF0503721> BrrepF0503721 { get; set; }
        //public virtual DbSet<BrrepF0503721S> BrrepF0503721S { get; set; }
        //public virtual DbSet<BrrepF0503737D> BrrepF0503737D { get; set; }
        //public virtual DbSet<BrrepF0503737F> BrrepF0503737F { get; set; }
        //public virtual DbSet<BrrepF0503737R> BrrepF0503737R { get; set; }
        //public virtual DbSet<BrrepF0503737S> BrrepF0503737S { get; set; }
        //public virtual DbSet<BrrepF0503738> BrrepF0503738 { get; set; }
        //public virtual DbSet<BrrepFormHistory> BrrepFormHistory { get; set; }
        //public virtual DbSet<BrrepFormWorks> BrrepFormWorks { get; set; }
        //public virtual DbSet<BrrepGovTransferIncome> BrrepGovTransferIncome { get; set; }
        //public virtual DbSet<BrrepGovTransferIncomeE> BrrepGovTransferIncomeE { get; set; }
        //public virtual DbSet<BrrepGovTransferIncomeK> BrrepGovTransferIncomeK { get; set; }
        //public virtual DbSet<BrrepGovTransferIncomeKe> BrrepGovTransferIncomeKe { get; set; }
        //public virtual DbSet<BrrepKs> BrrepKs { get; set; }
        //public virtual DbSet<BrrepKsGroup> BrrepKsGroup { get; set; }
        //public virtual DbSet<BrrepRemainsCauses> BrrepRemainsCauses { get; set; }
        //public virtual DbSet<BrrepRemainsCausesK> BrrepRemainsCausesK { get; set; }
        //public virtual DbSet<BrrepSubsidiesAdministrative> BrrepSubsidiesAdministrative { get; set; }
        //public virtual DbSet<BrrepSubsidiesCourt> BrrepSubsidiesCourt { get; set; }
        //public virtual DbSet<BrrepSubsidiesExp> BrrepSubsidiesExp { get; set; }
        //public virtual DbSet<BrrepSubsidiesMinors> BrrepSubsidiesMinors { get; set; }
        //public virtual DbSet<BrrepSubsidiesMore> BrrepSubsidiesMore { get; set; }
        //public virtual DbSet<BrrepSubsidiesNeed> BrrepSubsidiesNeed { get; set; }
        //public virtual DbSet<BrrepSubsidiesNeedAdmin> BrrepSubsidiesNeedAdmin { get; set; }
        //public virtual DbSet<BrrepSubsidiesNeedCourt> BrrepSubsidiesNeedCourt { get; set; }
        //public virtual DbSet<BrrepSubsidiesNeedExp> BrrepSubsidiesNeedExp { get; set; }
        //public virtual DbSet<BrrepSubsidiesUses> BrrepSubsidiesUses { get; set; }
        //public virtual DbSet<BrrepSubsidiesUsesCourt> BrrepSubsidiesUsesCourt { get; set; }
        //public virtual DbSet<BrrepSubsidiesUsesVus> BrrepSubsidiesUsesVus { get; set; }
        //public virtual DbSet<BrrepTransferCost> BrrepTransferCost { get; set; }
        //public virtual DbSet<BrrepTransferCostK> BrrepTransferCostK { get; set; }
        //public virtual DbSet<BrrepTrustFunds> BrrepTrustFunds { get; set; }
        //public virtual DbSet<BrrepTrustFundsCopy> BrrepTrustFundsCopy { get; set; }
        //public virtual DbSet<BrrepTrustFundsE> BrrepTrustFundsE { get; set; }
        //public virtual DbSet<BrrepTrustFundsK> BrrepTrustFundsK { get; set; }
        //public virtual DbSet<BrrepTrustFundsKe> BrrepTrustFundsKe { get; set; }
        //public virtual DbSet<BrrepVfkMap> BrrepVfkMap { get; set; }
        //public virtual DbSet<CommentType> CommentType { get; set; }
        //public virtual DbSet<CurFooterBgti> CurFooterBgti { get; set; }
        //public virtual DbSet<CurFooterBsDoneArc> CurFooterBsDoneArc { get; set; }
        //public virtual DbSet<CurFooterBsDoneBest> CurFooterBsDoneBest { get; set; }
        //public virtual DbSet<CurFooterBsDoneSmd> CurFooterBsDoneSmd { get; set; }
        //public virtual DbSet<CurFooterBsDoneToc> CurFooterBsDoneToc { get; set; }
        //public virtual DbSet<CurFooterBsMore> CurFooterBsMore { get; set; }
        //public virtual DbSet<CurFooterBsNeed> CurFooterBsNeed { get; set; }
        //public virtual DbSet<CurFooterBsNeedAdmin> CurFooterBsNeedAdmin { get; set; }
        //public virtual DbSet<CurFooterBsNeedCourt> CurFooterBsNeedCourt { get; set; }
        //public virtual DbSet<CurFooterBsNeedExp> CurFooterBsNeedExp { get; set; }
        //public virtual DbSet<CurFooterBsa> CurFooterBsa { get; set; }
        //public virtual DbSet<CurFooterBsc> CurFooterBsc { get; set; }
        //public virtual DbSet<CurFooterBse> CurFooterBse { get; set; }
        //public virtual DbSet<CurFooterBsm> CurFooterBsm { get; set; }
        //public virtual DbSet<CurFooterBtf> CurFooterBtf { get; set; }
        //public virtual DbSet<CurFooterF0503121> CurFooterF0503121 { get; set; }
        //public virtual DbSet<CurFooterNotice> CurFooterNotice { get; set; }
        //public virtual DbSet<CurFooterNp> CurFooterNp { get; set; }
        //public virtual DbSet<CurPeriod> CurPeriod { get; set; }
        //public virtual DbSet<Department> Department { get; set; }
        //public virtual DbSet<DictAimedmeans> DictAimedmeans { get; set; }
        //public virtual DbSet<DictBcCcodeClass> DictBcCcodeClass { get; set; }
        //public virtual DbSet<DictBcCcodeExpenditure> DictBcCcodeExpenditure { get; set; }
        //public virtual DbSet<DictBcCcodeGroup> DictBcCcodeGroup { get; set; }
        //public virtual DbSet<DictBcCcodeMainFunds> DictBcCcodeMainFunds { get; set; }
        //public virtual DbSet<DictBcCcodeMainFundsGrbs> DictBcCcodeMainFundsGrbs { get; set; }
        //public virtual DbSet<DictBcGcodeOperClass> DictBcGcodeOperClass { get; set; }
        //public virtual DbSet<DictBcIcodeIncome> DictBcIcodeIncome { get; set; }
        //public virtual DbSet<DictBcIcodeMainAdmin> DictBcIcodeMainAdmin { get; set; }
        //public virtual DbSet<DictCoatValues> DictCoatValues { get; set; }
        //public virtual DbSet<DictDirection> DictDirection { get; set; }
        //public virtual DbSet<DictDocumentInfo> DictDocumentInfo { get; set; }
        //public virtual DbSet<DictJob> DictJob { get; set; }
        //public virtual DbSet<DictJobs> DictJobs { get; set; }
        //public virtual DbSet<DictMeasureUnit> DictMeasureUnit { get; set; }
        //public virtual DbSet<DictMinistryOrdersContracts> DictMinistryOrdersContracts { get; set; }
        //public virtual DbSet<DictMo> DictMo { get; set; }
        //public virtual DbSet<DictPayTurn> DictPayTurn { get; set; }
        //public virtual DbSet<DictPayroll> DictPayroll { get; set; }
        //public virtual DbSet<DictPersonalAccount> DictPersonalAccount { get; set; }
        //public virtual DbSet<DictRemainFundsCodes> DictRemainFundsCodes { get; set; }
        //public virtual DbSet<DictStatus> DictStatus { get; set; }
        //public virtual DbSet<DictSubkesr> DictSubkesr { get; set; }
        //public virtual DbSet<DictSubprog> DictSubprog { get; set; }
        //public virtual DbSet<DictSubsidy> DictSubsidy { get; set; }
        //public virtual DbSet<DictUserInfo> DictUserInfo { get; set; }
        //public virtual DbSet<DictbrMoHeadJob> DictbrMoHeadJob { get; set; }
        //public virtual DbSet<DictbrUserInfo> DictbrUserInfo { get; set; }
        //public virtual DbSet<DictfeoBudgType> DictfeoBudgType { get; set; }
        //public virtual DbSet<DictfeoDocument> DictfeoDocument { get; set; }
        //public virtual DbSet<DictfeoEconomClass> DictfeoEconomClass { get; set; }
        //public virtual DbSet<DictfeoMinistryOrders> DictfeoMinistryOrders { get; set; }
        //public virtual DbSet<DictscArrangement> DictscArrangement { get; set; }
        //public virtual DbSet<DictscBadReason> DictscBadReason { get; set; }
        //public virtual DbSet<DictscBg2Char> DictscBg2Char { get; set; }
        //public virtual DbSet<DictscBg3Small> DictscBg3Small { get; set; }
        //public virtual DbSet<DictscBudgUses> DictscBudgUses { get; set; }
        //public virtual DbSet<DictscBuySize> DictscBuySize { get; set; }
        //public virtual DbSet<DictscForms> DictscForms { get; set; }
        //public virtual DbSet<DictscOkpd> DictscOkpd { get; set; }
        //public virtual DbSet<DictscOrderState> DictscOrderState { get; set; }
        //public virtual DbSet<DictscPlaceForm> DictscPlaceForm { get; set; }
        //public virtual DbSet<DictscPlaceMode> DictscPlaceMode { get; set; }
        //public virtual DbSet<DictscPlacingOrder> DictscPlacingOrder { get; set; }
        //public virtual DbSet<DictscPlanSum> DictscPlanSum { get; set; }
        //public virtual DbSet<DictscPpSourceFinance> DictscPpSourceFinance { get; set; }
        //public virtual DbSet<DictscProductionType> DictscProductionType { get; set; }
        //public virtual DbSet<DictscSettingGoods> DictscSettingGoods { get; set; }
        //public virtual DbSet<DictscSmallBusiness> DictscSmallBusiness { get; set; }
        //public virtual DbSet<DictscSourceFinance> DictscSourceFinance { get; set; }
        //public virtual DbSet<DictscSupplier> DictscSupplier { get; set; }
        //public virtual DbSet<DictscSupplierCopy> DictscSupplierCopy { get; set; }
        //public virtual DbSet<DictscTerminatedReason> DictscTerminatedReason { get; set; }
        //public virtual DbSet<DictscUserInfo> DictscUserInfo { get; set; }
        //public virtual DbSet<DocDetail> DocDetail { get; set; }
        //public virtual DbSet<Document> Document { get; set; }
        //public virtual DbSet<DocumentFileList> DocumentFileList { get; set; }
        //public virtual DbSet<DsuComment> DsuComment { get; set; }
        //public virtual DbSet<DsuRequest> DsuRequest { get; set; }
        //public virtual DbSet<DsuRequestFile> DsuRequestFile { get; set; }
        //public virtual DbSet<ExecList> ExecList { get; set; }
        //public virtual DbSet<FeoActivities> FeoActivities { get; set; }
        //public virtual DbSet<FeoActivitiesClass> FeoActivitiesClass { get; set; }
        //public virtual DbSet<FeoAssets> FeoAssets { get; set; }
        //public virtual DbSet<FeoAssets2016> FeoAssets2016 { get; set; }
        //public virtual DbSet<FeoAssets2016Class> FeoAssets2016Class { get; set; }
        //public virtual DbSet<FeoAssets2016Detail> FeoAssets2016Detail { get; set; }
        //public virtual DbSet<FeoAssets2016Kosgu> FeoAssets2016Kosgu { get; set; }
        //public virtual DbSet<FeoAssetsClass> FeoAssetsClass { get; set; }
        //public virtual DbSet<FeoAssetsDetail> FeoAssetsDetail { get; set; }
        //public virtual DbSet<FeoAssetsLine> FeoAssetsLine { get; set; }
        //public virtual DbSet<FeoBudgClass2016> FeoBudgClass2016 { get; set; }
        //public virtual DbSet<FeoCassMove> FeoCassMove { get; set; }
        //public virtual DbSet<FeoCassMoveDetail> FeoCassMoveDetail { get; set; }
        //public virtual DbSet<FeoCassPlan> FeoCassPlan { get; set; }
        //public virtual DbSet<FeoCassPlanDetail> FeoCassPlanDetail { get; set; }
        //public virtual DbSet<FeoDefault> FeoDefault { get; set; }
        //public virtual DbSet<FeoEstimate> FeoEstimate { get; set; }
        //public virtual DbSet<FeoEstimateDetail> FeoEstimateDetail { get; set; }
        //public virtual DbSet<FeoEstimateMove> FeoEstimateMove { get; set; }
        //public virtual DbSet<FeoEstimateMoveDetail> FeoEstimateMoveDetail { get; set; }
        //public virtual DbSet<FeoFhd2016Class> FeoFhd2016Class { get; set; }
        //public virtual DbSet<FeoFhdmove2016> FeoFhdmove2016 { get; set; }
        //public virtual DbSet<FeoFinPos2016> FeoFinPos2016 { get; set; }
        //public virtual DbSet<FeoFinPos2016Class> FeoFinPos2016Class { get; set; }
        //public virtual DbSet<FeoLiabilities> FeoLiabilities { get; set; }
        //public virtual DbSet<FeoLiabilities2016> FeoLiabilities2016 { get; set; }
        //public virtual DbSet<FeoLiabilities2016Detail> FeoLiabilities2016Detail { get; set; }
        //public virtual DbSet<FeoLiabilities2016DetailClass> FeoLiabilities2016DetailClass { get; set; }
        //public virtual DbSet<FeoLiabilitiesDetail> FeoLiabilitiesDetail { get; set; }
        //public virtual DbSet<FeoParams> FeoParams { get; set; }
        //public virtual DbSet<FeoPayGoods2016> FeoPayGoods2016 { get; set; }
        //public virtual DbSet<FeoPayGoods2016Class> FeoPayGoods2016Class { get; set; }
        //public virtual DbSet<FeoPayments> FeoPayments { get; set; }
        //public virtual DbSet<FeoPayments2016> FeoPayments2016 { get; set; }
        //public virtual DbSet<FeoPayments2016Class> FeoPayments2016Class { get; set; }
        //public virtual DbSet<FeoPayments2016Detail> FeoPayments2016Detail { get; set; }
        //public virtual DbSet<FeoPayments2016Kosgu> FeoPayments2016Kosgu { get; set; }
        //public virtual DbSet<FeoPaymentsClass> FeoPaymentsClass { get; set; }
        //public virtual DbSet<FeoPaymentsDetail> FeoPaymentsDetail { get; set; }
        //public virtual DbSet<FeoReceipts> FeoReceipts { get; set; }
        //public virtual DbSet<FeoReceipts2016> FeoReceipts2016 { get; set; }
        //public virtual DbSet<FeoReceipts2016Class> FeoReceipts2016Class { get; set; }
        //public virtual DbSet<FeoReceipts2016Detail> FeoReceipts2016Detail { get; set; }
        //public virtual DbSet<FeoReceipts2016Kosgu> FeoReceipts2016Kosgu { get; set; }
        //public virtual DbSet<FeoReceiptsClass> FeoReceiptsClass { get; set; }
        //public virtual DbSet<FeoReceiptsDetail> FeoReceiptsDetail { get; set; }
        //public virtual DbSet<FeoReference> FeoReference { get; set; }
        //public virtual DbSet<FeoRemains> FeoRemains { get; set; }
        //public virtual DbSet<FeoRemains2016> FeoRemains2016 { get; set; }
        //public virtual DbSet<FeoRemains2016Class> FeoRemains2016Class { get; set; }
        //public virtual DbSet<FeoRemains2016Detail> FeoRemains2016Detail { get; set; }
        //public virtual DbSet<FeoSubsidyCode2016> FeoSubsidyCode2016 { get; set; }
        //public virtual DbSet<KasoF0503121> KasoF0503121 { get; set; }
        //public virtual DbSet<KasoF0503121S> KasoF0503121S { get; set; }
        //public virtual DbSet<KasoF0503130> KasoF0503130 { get; set; }
        //public virtual DbSet<KasoF0503130S> KasoF0503130S { get; set; }
        //public virtual DbSet<Kladr> Kladr { get; set; }
        //public virtual DbSet<McAppealReport> McAppealReport { get; set; }
        //public virtual DbSet<McAppealTheme> McAppealTheme { get; set; }
        //public virtual DbSet<McAppealTypes> McAppealTypes { get; set; }
        //public virtual DbSet<McCmoFault> McCmoFault { get; set; }
        //public virtual DbSet<McDuty> McDuty { get; set; }
        //public virtual DbSet<McLimitations> McLimitations { get; set; }
        //public virtual DbSet<McLimitationsCmoReport> McLimitationsCmoReport { get; set; }
        //public virtual DbSet<McLimitationsReport> McLimitationsReport { get; set; }
        //public virtual DbSet<McLimitationsTypes> McLimitationsTypes { get; set; }
        //public virtual DbSet<McMedOrg> McMedOrg { get; set; }
        //public virtual DbSet<McMo> McMo { get; set; }
        //public virtual DbSet<McMoFault> McMoFault { get; set; }
        //public virtual DbSet<McMoFaultTypes> McMoFaultTypes { get; set; }
        //public virtual DbSet<McMrf> McMrf { get; set; }
        //public virtual DbSet<McPositive> McPositive { get; set; }
        //public virtual DbSet<McPositiveReport> McPositiveReport { get; set; }
        //public virtual DbSet<McReport> McReport { get; set; }
        //public virtual DbSet<McSmo> McSmo { get; set; }
        //public virtual DbSet<McTalk> McTalk { get; set; }
        //public virtual DbSet<McUserDate> McUserDate { get; set; }
        //public virtual DbSet<MsDistrict> MsDistrict { get; set; }
        //public virtual DbSet<MsDistrictClass> MsDistrictClass { get; set; }
        //public virtual DbSet<NormAuto> NormAuto { get; set; }
        //public virtual DbSet<NormAutoDetail> NormAutoDetail { get; set; }
        //public virtual DbSet<NormComment> NormComment { get; set; }
        //public virtual DbSet<NormCommunication> NormCommunication { get; set; }
        //public virtual DbSet<NormCommunicationDetail> NormCommunicationDetail { get; set; }
        //public virtual DbSet<NormComputer> NormComputer { get; set; }
        //public virtual DbSet<NormComputerDetail> NormComputerDetail { get; set; }
        //public virtual DbSet<NormDetailWorkpositionCross> NormDetailWorkpositionCross { get; set; }
        //public virtual DbSet<NormDocuments> NormDocuments { get; set; }
        //public virtual DbSet<NormDocumentsDetail> NormDocumentsDetail { get; set; }
        //public virtual DbSet<NormEducation> NormEducation { get; set; }
        //public virtual DbSet<NormEducationDetail> NormEducationDetail { get; set; }
        //public virtual DbSet<NormEquipment> NormEquipment { get; set; }
        //public virtual DbSet<NormEquipmentDetail> NormEquipmentDetail { get; set; }
        //public virtual DbSet<NormEscortPo> NormEscortPo { get; set; }
        //public virtual DbSet<NormEscortPoDetail> NormEscortPoDetail { get; set; }
        //public virtual DbSet<NormEscortSps> NormEscortSps { get; set; }
        //public virtual DbSet<NormEscortSpsDetail> NormEscortSpsDetail { get; set; }
        //public virtual DbSet<NormFile> NormFile { get; set; }
        //public virtual DbSet<NormFireDepartment> NormFireDepartment { get; set; }
        //public virtual DbSet<NormFireDepartmentDetail> NormFireDepartmentDetail { get; set; }
        //public virtual DbSet<NormGroup> NormGroup { get; set; }
        //public virtual DbSet<NormHelicopter> NormHelicopter { get; set; }
        //public virtual DbSet<NormHelicopterDetail> NormHelicopterDetail { get; set; }
        //public virtual DbSet<NormHousehold> NormHousehold { get; set; }
        //public virtual DbSet<NormHouseholdDetail> NormHouseholdDetail { get; set; }
        //public virtual DbSet<NormInternet> NormInternet { get; set; }
        //public virtual DbSet<NormInternetDetail> NormInternetDetail { get; set; }
        //public virtual DbSet<NormItem> NormItem { get; set; }
        //public virtual DbSet<NormItemDetail> NormItemDetail { get; set; }
        //public virtual DbSet<NormKosgu> NormKosgu { get; set; }
        //public virtual DbSet<NormKvr> NormKvr { get; set; }
        //public virtual DbSet<NormMedicine> NormMedicine { get; set; }
        //public virtual DbSet<NormMedicineDetail> NormMedicineDetail { get; set; }
        //public virtual DbSet<NormModule> NormModule { get; set; }
        //public virtual DbSet<NormOther> NormOther { get; set; }
        //public virtual DbSet<NormOtherDetail> NormOtherDetail { get; set; }
        //public virtual DbSet<NormOveralls> NormOveralls { get; set; }
        //public virtual DbSet<NormOverallsDetail> NormOverallsDetail { get; set; }
        //public virtual DbSet<NormPartition> NormPartition { get; set; }
        //public virtual DbSet<NormReference> NormReference { get; set; }
        //public virtual DbSet<NormReferenceKvrCross> NormReferenceKvrCross { get; set; }
        //public virtual DbSet<NormReferenceOkpdCross> NormReferenceOkpdCross { get; set; }
        //public virtual DbSet<NormReferenceType> NormReferenceType { get; set; }
        //public virtual DbSet<NormRent> NormRent { get; set; }
        //public virtual DbSet<NormRepairs> NormRepairs { get; set; }
        //public virtual DbSet<NormRepairsDetail> NormRepairsDetail { get; set; }
        //public virtual DbSet<NormSecurity> NormSecurity { get; set; }
        //public virtual DbSet<NormSecurityDetail> NormSecurityDetail { get; set; }
        //public virtual DbSet<NormService> NormService { get; set; }
        //public virtual DbSet<NormTypographic> NormTypographic { get; set; }
        //public virtual DbSet<NormTypographicDetail> NormTypographicDetail { get; set; }
        //public virtual DbSet<NormUtilities> NormUtilities { get; set; }
        //public virtual DbSet<NormUtilitiesDetail> NormUtilitiesDetail { get; set; }
        //public virtual DbSet<NormWork> NormWork { get; set; }
        //public virtual DbSet<NormWorkposition> NormWorkposition { get; set; }
        //public virtual DbSet<NormWwfWork> NormWwfWork { get; set; }
        //public virtual DbSet<NormWwfWorkDetail> NormWwfWorkDetail { get; set; }
        //public virtual DbSet<Priority> Priority { get; set; }
        //public virtual DbSet<RefDocType> RefDocType { get; set; }
        //public virtual DbSet<RefProfessions> RefProfessions { get; set; }
        //public virtual DbSet<Refugee> Refugee { get; set; }
        //public virtual DbSet<ReminderType> ReminderType { get; set; }
        //public virtual DbSet<SmGroupJob> SmGroupJob { get; set; }
        //public virtual DbSet<SmJob> SmJob { get; set; }
        //public virtual DbSet<SmMonthSalary> SmMonthSalary { get; set; }
        //public virtual DbSet<SmMonthSalaryDetail> SmMonthSalaryDetail { get; set; }
        //public virtual DbSet<SmPaymentOrder> SmPaymentOrder { get; set; }
        //public virtual DbSet<SmPaymentOrderDetail> SmPaymentOrderDetail { get; set; }
        //public virtual DbSet<SmSourceFinance> SmSourceFinance { get; set; }
        //public virtual DbSet<Status> Status { get; set; }
        //public virtual DbSet<StcontBg2Svod> StcontBg2Svod { get; set; }
        //public virtual DbSet<StcontBg3SmallBusiness> StcontBg3SmallBusiness { get; set; }
        //public virtual DbSet<StcontBg3Svod> StcontBg3Svod { get; set; }
        //public virtual DbSet<StcontContractVeg> StcontContractVeg { get; set; }
        //public virtual DbSet<StcontFormHistory> StcontFormHistory { get; set; }
        //public virtual DbSet<StcontFormWorks> StcontFormWorks { get; set; }
        //public virtual DbSet<StcontGoods> StcontGoods { get; set; }
        //public virtual DbSet<StcontGoodsAdmin> StcontGoodsAdmin { get; set; }
        //public virtual DbSet<StcontGoodsSvod> StcontGoodsSvod { get; set; }
        //public virtual DbSet<StcontListContractVeg> StcontListContractVeg { get; set; }
        //public virtual DbSet<StcontNp2Svod> StcontNp2Svod { get; set; }
        //public virtual DbSet<StcontNp3Svod> StcontNp3Svod { get; set; }
        //public virtual DbSet<StcontNp4Svod> StcontNp4Svod { get; set; }
        //public virtual DbSet<StcontPayCharge> StcontPayCharge { get; set; }
        //public virtual DbSet<StcontPlaceModeCharacteristic> StcontPlaceModeCharacteristic { get; set; }
        //public virtual DbSet<StcontPlacing> StcontPlacing { get; set; }
        //public virtual DbSet<StcontPlacingSvod> StcontPlacingSvod { get; set; }
        //public virtual DbSet<StcontPlacingSvodOld> StcontPlacingSvodOld { get; set; }
        //public virtual DbSet<StcontProductionList> StcontProductionList { get; set; }
        //public virtual DbSet<StcontSbStatistic> StcontSbStatistic { get; set; }
        //public virtual DbSet<StcontSbSvod> StcontSbSvod { get; set; }
        //public virtual DbSet<StcontSd2Svod> StcontSd2Svod { get; set; }
        //public virtual DbSet<StcontSd3Svod> StcontSd3Svod { get; set; }
        //public virtual DbSet<StcontSd4Svod> StcontSd4Svod { get; set; }
        //public virtual DbSet<StcontStateContract> StcontStateContract { get; set; }
        //public virtual DbSet<StcontSupplierUser> StcontSupplierUser { get; set; }
        //public virtual DbSet<StcontVeg> StcontVeg { get; set; }
        //public virtual DbSet<Streets> Streets { get; set; }
        //public virtual DbSet<SysBase> SysBase { get; set; }
        //public virtual DbSet<SysChanges> SysChanges { get; set; }
        //public virtual DbSet<SysLog> SysLog { get; set; }
        //public virtual DbSet<SysModule> SysModule { get; set; }
        //public virtual DbSet<SysNews> SysNews { get; set; }
        //public virtual DbSet<SysPeriodType> SysPeriodType { get; set; }
        //public virtual DbSet<SysRole> SysRole { get; set; }
        //public virtual DbSet<SysRoleModule> SysRoleModule { get; set; }
        //public virtual DbSet<SysTalFileLoads> SysTalFileLoads { get; set; }
        //public virtual DbSet<SysUser> SysUser { get; set; }
        //public virtual DbSet<SysUserGroup> SysUserGroup { get; set; }
        //public virtual DbSet<SysUserLogin> SysUserLogin { get; set; }
        //public virtual DbSet<SysUserNews> SysUserNews { get; set; }
        //public virtual DbSet<SysUserRole> SysUserRole { get; set; }
        //public virtual DbSet<SzpAccord> SzpAccord { get; set; }
        //public virtual DbSet<SzpPresident> SzpPresident { get; set; }
        //public virtual DbSet<SzpReport> SzpReport { get; set; }
        //public virtual DbSet<SzpRows> SzpRows { get; set; }
        //public virtual DbSet<SzpToMrot> SzpToMrot { get; set; }
        //public virtual DbSet<TablesIds> TablesIds { get; set; }
        public virtual DbSet<TsqlLicence> TsqlLicence { get; set; }
        public virtual DbSet<TsqlLog> TsqlLog { get; set; }
        //public virtual DbSet<TsqlRole> TsqlRole { get; set; }
        //public virtual DbSet<UmpVolunteer> UmpVolunteer { get; set; }
        //public virtual DbSet<UmpVolunteerClass> UmpVolunteerClass { get; set; }
        //public virtual DbSet<UmpVolunteerMo> UmpVolunteerMo { get; set; }
        //public virtual DbSet<Users> Users { get; set; }
        //public virtual DbSet<ViewAssets2016NameCode> ViewAssets2016NameCode { get; set; }
        //public virtual DbSet<ViewBcCcodeMainFundsGrbs> ViewBcCcodeMainFundsGrbs { get; set; }
        //public virtual DbSet<ViewDictbrUserInfo> ViewDictbrUserInfo { get; set; }
        //public virtual DbSet<ViewDictscUserInfo> ViewDictscUserInfo { get; set; }
        //public virtual DbSet<ViewMcAppealThemeTypes> ViewMcAppealThemeTypes { get; set; }
        //public virtual DbSet<ViewMcMedorgMoMrf> ViewMcMedorgMoMrf { get; set; }
        //public virtual DbSet<ViewMcMrfSysUser> ViewMcMrfSysUser { get; set; }
        //public virtual DbSet<ViewMcSmoSysUser> ViewMcSmoSysUser { get; set; }
        //public virtual DbSet<ViewNormGroup> ViewNormGroup { get; set; }
        //public virtual DbSet<ViewPaymentOrder> ViewPaymentOrder { get; set; }
        //public virtual DbSet<ViewPayments2016NameCode> ViewPayments2016NameCode { get; set; }
        //public virtual DbSet<ViewReceipts2016NameCode> ViewReceipts2016NameCode { get; set; }
        //public virtual DbSet<ViewRemains2016NameCode> ViewRemains2016NameCode { get; set; }
        //public virtual DbSet<ViewStateContract> ViewStateContract { get; set; }
        //public virtual DbSet<ViewSysLog> ViewSysLog { get; set; }
        //public virtual DbSet<ViewSysRoleModule> ViewSysRoleModule { get; set; }
        //public virtual DbSet<ViewSysUserRole> ViewSysUserRole { get; set; }
        //public virtual DbSet<ViewVfkMap> ViewVfkMap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SERV2012\\TALWEB;User Id=sa;Password=dw*405Xddqd;Initial Catalog=Adm; Timeout=200;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          /*  modelBuilder.Entity<ActionLog>(entity =>
            {
                entity.HasKey(e => e.IdActionLog)
                    .HasName("PK__ACTION_L__BE4E8E527EA500A6")
                    .IsClustered(false);

                entity.ToTable("ACTION_LOG");

                entity.Property(e => e.IdActionLog).HasColumnName("ID_ACTION_LOG");

                entity.Property(e => e.ActDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACT_DATE");

                entity.Property(e => e.ActDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ACT_DESCRIPTION");

                entity.Property(e => e.IdActionType).HasColumnName("ID_ACTION_TYPE");

                entity.Property(e => e.IdUser).HasColumnName("ID_USER");

                entity.Property(e => e.Ip)
                    .HasMaxLength(16)
                    .HasColumnName("IP");
            });

            modelBuilder.Entity<ActionType>(entity =>
            {
                entity.HasKey(e => e.IdActionType)
                    .HasName("PK__ACTION_T__D4484B120275918A")
                    .IsClustered(false);

                entity.ToTable("ACTION_TYPE");

                entity.Property(e => e.IdActionType).HasColumnName("ID_ACTION_TYPE");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<AudKosgu>(entity =>
            {
                entity.HasKey(e => e.IdKosgu)
                    .HasName("PK__aud_kosg__FC42E70AD3429A60");

                entity.ToTable("aud_kosgu");

                entity.Property(e => e.IdKosgu).HasColumnName("id_kosgu");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AudOperName>(entity =>
            {
                entity.HasKey(e => e.IdOperName)
                    .HasName("PK__aud_oper__5CC4891C7B58AE6B");

                entity.ToTable("aud_oper_name");

                entity.Property(e => e.IdOperName).HasColumnName("id_oper_name");

                entity.Property(e => e.OperName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("oper_name");
            });

            modelBuilder.Entity<AudSelKosgu>(entity =>
            {
                entity.HasKey(e => e.IdSelKosgu)
                    .HasName("PK__aud_sel___6EFF97775BBDE763");

                entity.ToTable("aud_sel_kosgu");

                entity.Property(e => e.IdSelKosgu).HasColumnName("id_sel_kosgu");

                entity.Property(e => e.IdKosgu).HasColumnName("id_kosgu");

                entity.Property(e => e.IdOperName).HasColumnName("id_oper_name");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.OperSum)
                    .HasColumnType("money")
                    .HasColumnName("oper_sum");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.HasOne(d => d.IdKosguNavigation)
                    .WithMany(p => p.AudSelKosgu)
                    .HasForeignKey(d => d.IdKosgu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aud_sel_k__id_ko__18659E00");

                entity.HasOne(d => d.IdOperNameNavigation)
                    .WithMany(p => p.AudSelKosgu)
                    .HasForeignKey(d => d.IdOperName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aud_sel_k__id_op__045EA553");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.AudSelKosgu)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aud_sel_k__id_us__0552C98C");
            });

            modelBuilder.Entity<BrrepAgreementParams>(entity =>
            {
                entity.HasKey(e => e.IdAgreementParam)
                    .HasName("PK__brrep_ag__01A4D66317FABE55");

                entity.ToTable("brrep_agreement_params");

                entity.HasIndex(e => new { e.IdAgreement, e.IdUser }, "UQ__brrep_ag__D05AD9261AD72B00")
                    .IsUnique();

                entity.Property(e => e.IdAgreementParam).HasColumnName("id_agreement_param");

                entity.Property(e => e.ActYear).HasColumnName("act_year");

                entity.Property(e => e.DateAgreement)
                    .HasColumnType("date")
                    .HasColumnName("date_agreement");

                entity.Property(e => e.IdAgreement).HasColumnName("id_agreement");

                entity.Property(e => e.IdBcIcodeIncome).HasColumnName("id_bc_icode_income");

                entity.Property(e => e.IdBcIcodeMainAdmin).HasColumnName("id_bc_icode_main_admin");

                entity.Property(e => e.IdMoHeadJob).HasColumnName("id_mo_head_job");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Num)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("num");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total_price");

                entity.HasOne(d => d.IdAgreementNavigation)
                    .WithMany(p => p.BrrepAgreementParams)
                    .HasForeignKey(d => d.IdAgreement)
                    .HasConstraintName("FK__brrep_agr__id_ag__3F348707");

                entity.HasOne(d => d.IdBcIcodeIncomeNavigation)
                    .WithMany(p => p.BrrepAgreementParams)
                    .HasForeignKey(d => d.IdBcIcodeIncome)
                    .HasConstraintName("FK__brrep_agr__id_bc__411CCF79");

                entity.HasOne(d => d.IdBcIcodeMainAdminNavigation)
                    .WithMany(p => p.BrrepAgreementParams)
                    .HasForeignKey(d => d.IdBcIcodeMainAdmin)
                    .HasConstraintName("FK__brrep_agr__id_bc__4210F3B2");

                entity.HasOne(d => d.IdMoHeadJobNavigation)
                    .WithMany(p => p.BrrepAgreementParams)
                    .HasForeignKey(d => d.IdMoHeadJob)
                    .HasConstraintName("FK__brrep_agr__id_mo__4028AB40");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.BrrepAgreementParams)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__brrep_agr__id_us__430517EB");
            });

            modelBuilder.Entity<BrrepAgreements>(entity =>
            {
                entity.HasKey(e => e.IdAgreement)
                    .HasName("PK__brrep_ag__BD77CD441DB397AB");

                entity.ToTable("brrep_agreements");

                entity.Property(e => e.IdAgreement).HasColumnName("id_agreement");

                entity.Property(e => e.MenuOrder).HasColumnName("menu_order");

                entity.Property(e => e.Mnemo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mnemo");

                entity.Property(e => e.MoType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("mo_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BrrepChangeShield>(entity =>
            {
                entity.HasKey(e => e.IdChangeShield)
                    .HasName("PK__brrep_ch__960F0651027DFC89");

                entity.ToTable("brrep_change_shield");

                entity.Property(e => e.IdChangeShield).HasColumnName("id_change_shield");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IsClosed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_closed");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("table_name");
            });

            modelBuilder.Entity<BrrepDoneReportArc>(entity =>
            {
                entity.HasKey(e => e.IdDoneReportArc)
                    .HasName("PK__brrep_do__1E912A3D721BB27A");

                entity.ToTable("brrep_done_report_arc");

                entity.Property(e => e.IdDoneReportArc).HasColumnName("id_done_report_arc");

                entity.Property(e => e.DoneKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_kray");

                entity.Property(e => e.DoneLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_local");

                entity.Property(e => e.DoneSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_sum");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PactKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_kray");

                entity.Property(e => e.PactLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_local");

                entity.Property(e => e.PactSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_sum");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.UnusedKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_kray");

                entity.Property(e => e.UnusedLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_local");

                entity.Property(e => e.UnusedSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_sum");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.BrrepDoneReportArc)
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_don__id_mo__3BB9C735");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.BrrepDoneReportArc)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_don__id_pe__3CADEB6E");
            });

            modelBuilder.Entity<BrrepDoneReportBest>(entity =>
            {
                entity.HasKey(e => e.IdDoneReportBest)
                    .HasName("PK__brrep_do__952417F489123EFC");

                entity.ToTable("brrep_done_report_best");

                entity.Property(e => e.IdDoneReportBest).HasColumnName("id_done_report_best");

                entity.Property(e => e.DoneKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_kray");

                entity.Property(e => e.DoneLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_local");

                entity.Property(e => e.DoneSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_sum");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PactKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_kray");

                entity.Property(e => e.PactLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_local");

                entity.Property(e => e.PactSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_sum");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.UnusedKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_kray");

                entity.Property(e => e.UnusedLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_local");

                entity.Property(e => e.UnusedSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_sum");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.BrrepDoneReportBest)
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_don__id_mo__427BD35D");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.BrrepDoneReportBest)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_don__id_pe__436FF796");
            });

            modelBuilder.Entity<BrrepDoneReportSmd>(entity =>
            {
                entity.HasKey(e => e.IdDoneReportSmd)
                    .HasName("PK__brrep_do__2312121B04D7E7E0");

                entity.ToTable("brrep_done_report_smd");

                entity.Property(e => e.IdDoneReportSmd).HasColumnName("id_done_report_smd");

                entity.Property(e => e.DoneKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_kray");

                entity.Property(e => e.DoneLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_local");

                entity.Property(e => e.DoneSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_sum");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PactKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_kray");

                entity.Property(e => e.PactLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_local");

                entity.Property(e => e.PactSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_sum");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.UnusedKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_kray");

                entity.Property(e => e.UnusedLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_local");

                entity.Property(e => e.UnusedSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_sum");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.BrrepDoneReportSmd)
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_don__id_mo__464C6441");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.BrrepDoneReportSmd)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_don__id_pe__4740887A");
            });

            modelBuilder.Entity<BrrepDoneReportToc>(entity =>
            {
                entity.HasKey(e => e.IdDoneReportToc)
                    .HasName("PK__brrep_do__1DA4FDFC14270A6D");

                entity.ToTable("brrep_done_report_toc");

                entity.Property(e => e.IdDoneReportToc).HasColumnName("id_done_report_toc");

                entity.Property(e => e.DoneKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_kray");

                entity.Property(e => e.DoneLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_local");

                entity.Property(e => e.DoneSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("done_sum");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PactKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_kray");

                entity.Property(e => e.PactLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_local");

                entity.Property(e => e.PactSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pact_sum");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.UnusedKray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_kray");

                entity.Property(e => e.UnusedLocal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_local");

                entity.Property(e => e.UnusedSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unused_sum");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.BrrepDoneReportToc)
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_don__id_mo__3EAB4279");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.BrrepDoneReportToc)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_don__id_pe__3F9F66B2");
            });

            modelBuilder.Entity<BrrepF0503121>(entity =>
            {
                entity.HasKey(e => e.IdF0503121)
                    .HasName("PK__brrep_f0__BC661E5F20900456");

                entity.ToTable("brrep_f0503121");

                entity.HasIndex(e => e.Code, "brrep_f0503121_idx");

                entity.HasIndex(e => e.IdMo, "brrep_f0503121_idx2");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503121_idx3");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503121_idx4");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503121_idx5");

                entity.Property(e => e.IdF0503121).HasColumnName("id_f0503121");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.Itogo)
                    .HasColumnType("money")
                    .HasColumnName("itogo");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<BrrepF0503121S>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_f0503121_s");

                entity.HasIndex(e => e.Code, "brrep_f0503121_s_idx");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Code2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code2");

                entity.Property(e => e.PokazName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("pokaz_name");
            });

            modelBuilder.Entity<BrrepF0503127D>(entity =>
            {
                entity.HasKey(e => e.IdF0503127D)
                    .HasName("PK__brrep_f0__8BE28DA3236C7101");

                entity.ToTable("brrep_f0503127_D");

                entity.HasIndex(e => e.Code, "brrep_f0503127_D_idx");

                entity.HasIndex(e => e.IdBcIcodeMainAdmin, "brrep_f0503127_D_idx2");

                entity.HasIndex(e => e.IdBcIcodeIncome, "brrep_f0503127_D_idx3");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503127_D_idx4");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503127_D_idx5");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503127_D_idx6");

                entity.HasIndex(e => e.IdMo, "brrep_f0503127_D_idx7");

                entity.Property(e => e.IdF0503127D).HasColumnName("id_f0503127_D");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.Cr4)
                    .HasColumnType("money")
                    .HasColumnName("cr4");

                entity.Property(e => e.Cr5)
                    .HasColumnType("money")
                    .HasColumnName("cr5");

                entity.Property(e => e.Cr6)
                    .HasColumnType("money")
                    .HasColumnName("cr6");

                entity.Property(e => e.IdBcIcodeIncome).HasColumnName("id_bc_icode_income");

                entity.Property(e => e.IdBcIcodeMainAdmin).HasColumnName("id_bc_icode_main_admin");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<BrrepF0503127F>(entity =>
            {
                entity.HasKey(e => e.IdF0503127F)
                    .HasName("PK__brrep_f0__8BE28DBD2648DDAC");

                entity.ToTable("brrep_f0503127_F");

                entity.HasIndex(e => e.Code, "brrep_f0503127_F_idx");

                entity.HasIndex(e => e.IdMo, "brrep_f0503127_F_idx2");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503127_F_idx3");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503127_F_idx4");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503127_F_idx5");

                entity.Property(e => e.IdF0503127F).HasColumnName("id_f0503127_F");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.Cr4)
                    .HasColumnType("money")
                    .HasColumnName("cr4");

                entity.Property(e => e.Cr5)
                    .HasColumnType("money")
                    .HasColumnName("cr5");

                entity.Property(e => e.Cr6)
                    .HasColumnType("money")
                    .HasColumnName("cr6");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<BrrepF0503127FS>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_f0503127_F_s");

                entity.HasIndex(e => e.Code, "brrep_f0503127_F_s_idx");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.PokazName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pokaz_name");
            });

            modelBuilder.Entity<BrrepF0503127R>(entity =>
            {
                entity.HasKey(e => e.IdF0503127R)
                    .HasName("PK__brrep_f0__8BE28DB129254A57");

                entity.ToTable("brrep_f0503127_R");

                entity.HasIndex(e => e.Code, "brrep_f0503127_R_idx");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503127_R_idx10");

                entity.HasIndex(e => e.IdBcCcodeMainFunds2, "brrep_f0503127_R_idx2");

                entity.HasIndex(e => e.IdBcCcodeGroup, "brrep_f0503127_R_idx3");

                entity.HasIndex(e => e.IdBcCcodeExpenditure, "brrep_f0503127_R_idx4");

                entity.HasIndex(e => e.IdBcCcodeClass, "brrep_f0503127_R_idx5");

                entity.HasIndex(e => e.IdBcGcodeOperClass, "brrep_f0503127_R_idx6");

                entity.HasIndex(e => e.IdMo, "brrep_f0503127_R_idx7");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503127_R_idx8");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503127_R_idx9");

                entity.Property(e => e.IdF0503127R).HasColumnName("id_f0503127_R");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.Cr4)
                    .HasColumnType("money")
                    .HasColumnName("cr4");

                entity.Property(e => e.Cr5)
                    .HasColumnType("money")
                    .HasColumnName("cr5");

                entity.Property(e => e.Cr6)
                    .HasColumnType("money")
                    .HasColumnName("cr6");

                entity.Property(e => e.Cr7)
                    .HasColumnType("money")
                    .HasColumnName("cr7");

                entity.Property(e => e.Cr8)
                    .HasColumnType("money")
                    .HasColumnName("cr8");

                entity.Property(e => e.IdBcCcodeClass).HasColumnName("id_bc_ccode_class");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeGroup).HasColumnName("id_bc_ccode_group");

                entity.Property(e => e.IdBcCcodeMainFunds2).HasColumnName("id_bc_ccode_main_funds_2");

                entity.Property(e => e.IdBcGcodeOperClass).HasColumnName("id_bc_gcode_oper_class");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<BrrepF0503137D>(entity =>
            {
                entity.HasKey(e => e.IdF0503137D)
                    .HasName("PK__brrep_f0__ECD42C3F2C01B702");

                entity.ToTable("brrep_f0503137_D");

                entity.HasIndex(e => e.Code, "brrep_f0503137_D_idx");

                entity.HasIndex(e => e.IdBcIcodeMainAdmin, "brrep_f0503137_D_idx2");

                entity.HasIndex(e => e.IdBcIcodeIncome, "brrep_f0503137_D_idx3");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503137_D_idx4");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503137_D_idx5");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503137_D_idx6");

                entity.HasIndex(e => e.IdMo, "brrep_f0503137_D_idx7");

                entity.Property(e => e.IdF0503137D).HasColumnName("id_f0503137_D");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.Cr4)
                    .HasColumnType("money")
                    .HasColumnName("cr4");

                entity.Property(e => e.Cr5)
                    .HasColumnType("money")
                    .HasColumnName("cr5");

                entity.Property(e => e.Cr6)
                    .HasColumnType("money")
                    .HasColumnName("cr6");

                entity.Property(e => e.IdBcIcodeIncome).HasColumnName("id_bc_icode_income");

                entity.Property(e => e.IdBcIcodeMainAdmin).HasColumnName("id_bc_icode_main_admin");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<BrrepF0503137F>(entity =>
            {
                entity.HasKey(e => e.IdF0503137F)
                    .HasName("PK__brrep_f0__ECD42C3D2EDE23AD");

                entity.ToTable("brrep_f0503137_F");

                entity.HasIndex(e => e.Code, "brrep_f0503137_F_idx");

                entity.HasIndex(e => e.IdMo, "brrep_f0503137_F_idx2");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503137_F_idx3");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503137_F_idx4");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503137_F_idx5");

                entity.Property(e => e.IdF0503137F).HasColumnName("id_f0503137_F");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.Cr4)
                    .HasColumnType("money")
                    .HasColumnName("cr4");

                entity.Property(e => e.Cr5)
                    .HasColumnType("money")
                    .HasColumnName("cr5");

                entity.Property(e => e.Cr6)
                    .HasColumnType("money")
                    .HasColumnName("cr6");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<BrrepF0503137FS>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_f0503137_F_s");

                entity.HasIndex(e => e.Code, "brrep_f0503137_F_s_idx");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.PokazName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pokaz_name");
            });

            modelBuilder.Entity<BrrepF0503137R>(entity =>
            {
                entity.HasKey(e => e.IdF0503137R)
                    .HasName("PK__brrep_f0__ECD42C0931BA9058");

                entity.ToTable("brrep_f0503137_R");

                entity.HasIndex(e => e.Code, "brrep_f0503137_R_idx");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503137_R_idx10");

                entity.HasIndex(e => e.IdBcCcodeMainFunds2, "brrep_f0503137_R_idx2");

                entity.HasIndex(e => e.IdBcCcodeGroup, "brrep_f0503137_R_idx3");

                entity.HasIndex(e => e.IdBcCcodeExpenditure, "brrep_f0503137_R_idx4");

                entity.HasIndex(e => e.IdBcCcodeClass, "brrep_f0503137_R_idx5");

                entity.HasIndex(e => e.IdBcGcodeOperClass, "brrep_f0503137_R_idx6");

                entity.HasIndex(e => e.IdMo, "brrep_f0503137_R_idx7");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503137_R_idx8");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503137_R_idx9");

                entity.Property(e => e.IdF0503137R).HasColumnName("id_f0503137_R");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.Cr4)
                    .HasColumnType("money")
                    .HasColumnName("cr4");

                entity.Property(e => e.Cr5)
                    .HasColumnType("money")
                    .HasColumnName("cr5");

                entity.Property(e => e.Cr6)
                    .HasColumnType("money")
                    .HasColumnName("cr6");

                entity.Property(e => e.IdBcCcodeClass).HasColumnName("id_bc_ccode_class");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeGroup).HasColumnName("id_bc_ccode_group");

                entity.Property(e => e.IdBcCcodeMainFunds2).HasColumnName("id_bc_ccode_main_funds_2");

                entity.Property(e => e.IdBcGcodeOperClass).HasColumnName("id_bc_gcode_oper_class");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<BrrepF0503721>(entity =>
            {
                entity.HasKey(e => e.IdF0503721)
                    .HasName("PK__brrep_f0__B2EB17E53496FD03");

                entity.ToTable("brrep_f0503721");

                entity.HasIndex(e => e.Code, "brrep_f0503721_idx");

                entity.HasIndex(e => e.IdMo, "brrep_f0503721_idx2");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503721_idx3");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503721_idx4");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503721_idx5");

                entity.Property(e => e.IdF0503721).HasColumnName("id_f0503721");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.Itogo)
                    .HasColumnType("money")
                    .HasColumnName("itogo");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<BrrepF0503721S>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_f0503721_s");

                entity.HasIndex(e => e.Code, "brrep_f0503721_s_idx");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Code2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code2");

                entity.Property(e => e.PokazName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("pokaz_name");
            });

            modelBuilder.Entity<BrrepF0503737D>(entity =>
            {
                entity.HasKey(e => e.IdF0503737D)
                    .HasName("PK__brrep_f0__55007B8D377369AE");

                entity.ToTable("brrep_f0503737_D");

                entity.HasIndex(e => e.Code, "brrep_f0503737_D_idx");

                entity.HasIndex(e => e.IdMo, "brrep_f0503737_D_idx2");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503737_D_idx3");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503737_D_idx4");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503737_D_idx5");

                entity.HasIndex(e => e.TipFin, "brrep_f0503737_D_idx6");

                entity.Property(e => e.IdF0503737D).HasColumnName("id_f0503737_D");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.Cr4)
                    .HasColumnType("money")
                    .HasColumnName("cr4");

                entity.Property(e => e.Cr5)
                    .HasColumnType("money")
                    .HasColumnName("cr5");

                entity.Property(e => e.Cr6)
                    .HasColumnType("money")
                    .HasColumnName("cr6");

                entity.Property(e => e.Cr7)
                    .HasColumnType("money")
                    .HasColumnName("cr7");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.TipFin).HasColumnName("tip_fin");
            });

            modelBuilder.Entity<BrrepF0503737F>(entity =>
            {
                entity.HasKey(e => e.IdF0503737F)
                    .HasName("PK__brrep_f0__55007B8B3A4FD659");

                entity.ToTable("brrep_f0503737_F");

                entity.HasIndex(e => e.Code, "brrep_f0503737_F_idx");

                entity.HasIndex(e => e.IdMo, "brrep_f0503737_F_idx2");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503737_F_idx3");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503737_F_idx4");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503737_F_idx5");

                entity.HasIndex(e => e.TipFin, "brrep_f0503737_F_idx6");

                entity.Property(e => e.IdF0503737F).HasColumnName("id_f0503737_F");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.Cr4)
                    .HasColumnType("money")
                    .HasColumnName("cr4");

                entity.Property(e => e.Cr5)
                    .HasColumnType("money")
                    .HasColumnName("cr5");

                entity.Property(e => e.Cr6)
                    .HasColumnType("money")
                    .HasColumnName("cr6");

                entity.Property(e => e.Cr7)
                    .HasColumnType("money")
                    .HasColumnName("cr7");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.TipFin).HasColumnName("tip_fin");
            });

            modelBuilder.Entity<BrrepF0503737R>(entity =>
            {
                entity.HasKey(e => e.IdF0503737R)
                    .HasName("PK__brrep_f0__55007BFF3D2C4304");

                entity.ToTable("brrep_f0503737_R");

                entity.HasIndex(e => e.Code, "brrep_f0503737_R_idx");

                entity.HasIndex(e => e.IdMo, "brrep_f0503737_R_idx2");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503737_R_idx3");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503737_R_idx4");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503737_R_idx5");

                entity.HasIndex(e => e.TipFin, "brrep_f0503737_R_idx6");

                entity.Property(e => e.IdF0503737R).HasColumnName("id_f0503737_R");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.Cr4)
                    .HasColumnType("money")
                    .HasColumnName("cr4");

                entity.Property(e => e.Cr5)
                    .HasColumnType("money")
                    .HasColumnName("cr5");

                entity.Property(e => e.Cr6)
                    .HasColumnType("money")
                    .HasColumnName("cr6");

                entity.Property(e => e.Cr7)
                    .HasColumnType("money")
                    .HasColumnName("cr7");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.TipFin).HasColumnName("tip_fin");
            });

            modelBuilder.Entity<BrrepF0503737S>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__brrep_f0__357D4CF84008AFAF");

                entity.ToTable("brrep_f0503737_s");

                entity.HasIndex(e => e.Ftype, "brrep_f0503737_s_idx");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Code2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code2");

                entity.Property(e => e.Ftype).HasColumnName("ftype");

                entity.Property(e => e.PokazName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pokaz_name");

                entity.Property(e => e.Xindex).HasColumnName("xindex");
            });

            modelBuilder.Entity<BrrepF0503738>(entity =>
            {
                entity.HasKey(e => e.IdF0503738)
                    .HasName("PK__brrep_f0__B2EB1FCD42E51C5A");

                entity.ToTable("brrep_f0503738");

                entity.HasIndex(e => e.IdBcGcodeOperClass, "brrep_f0503738_idx");

                entity.HasIndex(e => e.TipFin, "brrep_f0503738_idx2");

                entity.HasIndex(e => e.IdMo, "brrep_f0503738_idx3");

                entity.HasIndex(e => e.IdPeriodType, "brrep_f0503738_idx4");

                entity.HasIndex(e => e.PeriodYear, "brrep_f0503738_idx5");

                entity.HasIndex(e => e.PeriodValue, "brrep_f0503738_idx6");

                entity.Property(e => e.IdF0503738).HasColumnName("id_f0503738");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.Cr4)
                    .HasColumnType("money")
                    .HasColumnName("cr4");

                entity.Property(e => e.Cr5)
                    .HasColumnType("money")
                    .HasColumnName("cr5");

                entity.Property(e => e.Cr6)
                    .HasColumnType("money")
                    .HasColumnName("cr6");

                entity.Property(e => e.Cr7)
                    .HasColumnType("money")
                    .HasColumnName("cr7");

                entity.Property(e => e.Cr8)
                    .HasColumnType("money")
                    .HasColumnName("cr8");

                entity.Property(e => e.IdBcGcodeOperClass).HasColumnName("id_bc_gcode_oper_class");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.TipFin).HasColumnName("tip_fin");
            });

            modelBuilder.Entity<BrrepFormHistory>(entity =>
            {
                entity.HasKey(e => e.IdFormHistory)
                    .HasName("PK__brrep_fo__B1C413B745C18905");

                entity.ToTable("brrep_form_history");

                entity.Property(e => e.IdFormHistory).HasColumnName("id_form_history");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_create")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFormWorks).HasColumnName("id_form_works");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("text");

                entity.HasOne(d => d.IdFormWorksNavigation)
                    .WithMany(p => p.BrrepFormHistory)
                    .HasForeignKey(d => d.IdFormWorks)
                    .HasConstraintName("FK__brrep_for__id_fo__43F93C24");
            });

            modelBuilder.Entity<BrrepFormWorks>(entity =>
            {
                entity.HasKey(e => e.IdFormWorks)
                    .HasName("PK__brrep_fo__7E369BC8489DF5B0");

                entity.ToTable("brrep_form_works");

                entity.Property(e => e.IdFormWorks).HasColumnName("id_form_works");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdForms).HasColumnName("id_forms");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.KsStatus).HasColumnName("ks_status");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.HasOne(d => d.IdFormsNavigation)
                    .WithMany(p => p.BrrepFormWorks)
                    .HasForeignKey(d => d.IdForms)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_for__id_fo__44ED605D");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.BrrepFormWorks)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_for__id_pe__45E18496");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.BrrepFormWorks)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_for__id_st__46D5A8CF");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.BrrepFormWorks)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_for__id_us__47C9CD08");
            });

            modelBuilder.Entity<BrrepGovTransferIncome>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_gov_transfer_income");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdBcIcodeIncome).HasColumnName("id_bc_icode_income");

                entity.Property(e => e.IdBcIcodeMainAdmin).HasColumnName("id_bc_icode_main_admin");

                entity.Property(e => e.IdGovTransferIncome)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_gov_transfer_income");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumBalanceBeginActual)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin_actual");

                entity.Property(e => e.SumBalanceBeginTotal)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin_total");

                entity.Property(e => e.SumCashOutcome)
                    .HasColumnType("money")
                    .HasColumnName("sum_cash_outcome");

                entity.Property(e => e.SumFactExp)
                    .HasColumnType("money")
                    .HasColumnName("sum_fact_exp");

                entity.Property(e => e.SumOldRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_old_remains");

                entity.Property(e => e.SumReceivedBudg)
                    .HasColumnType("money")
                    .HasColumnName("sum_received_budg");

                entity.Property(e => e.SumRefund)
                    .HasColumnType("money")
                    .HasColumnName("sum_refund");

                entity.Property(e => e.SumReturnedNeeds)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_needs");

                entity.Property(e => e.SumReturnedRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_remains");
            });

            modelBuilder.Entity<BrrepGovTransferIncomeE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_gov_transfer_income_e");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdBcIcodeIncome).HasColumnName("id_bc_icode_income");

                entity.Property(e => e.IdBcIcodeMainAdmin).HasColumnName("id_bc_icode_main_admin");

                entity.Property(e => e.IdGovTransferIncomeE)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_gov_transfer_income_e");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumBalanceBeginActual)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin_actual");

                entity.Property(e => e.SumBalanceBeginTotal)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin_total");

                entity.Property(e => e.SumCashOutcome)
                    .HasColumnType("money")
                    .HasColumnName("sum_cash_outcome");

                entity.Property(e => e.SumFactExp)
                    .HasColumnType("money")
                    .HasColumnName("sum_fact_exp");

                entity.Property(e => e.SumOldRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_old_remains");

                entity.Property(e => e.SumReceivedBudg)
                    .HasColumnType("money")
                    .HasColumnName("sum_received_budg");

                entity.Property(e => e.SumRefund)
                    .HasColumnType("money")
                    .HasColumnName("sum_refund");

                entity.Property(e => e.SumReturnedNeeds)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_needs");

                entity.Property(e => e.SumReturnedRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_remains");
            });

            modelBuilder.Entity<BrrepGovTransferIncomeK>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_gov_transfer_income_k");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdBcIcodeIncome).HasColumnName("id_bc_icode_income");

                entity.Property(e => e.IdBcIcodeMainAdmin).HasColumnName("id_bc_icode_main_admin");

                entity.Property(e => e.IdGovTransferIncomeK)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_gov_transfer_income_k");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumBalanceBeginActual)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin_actual");

                entity.Property(e => e.SumBalanceBeginTotal)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin_total");

                entity.Property(e => e.SumCashOutcome)
                    .HasColumnType("money")
                    .HasColumnName("sum_cash_outcome");

                entity.Property(e => e.SumFactExp)
                    .HasColumnType("money")
                    .HasColumnName("sum_fact_exp");

                entity.Property(e => e.SumOldRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_old_remains");

                entity.Property(e => e.SumReceivedBudg)
                    .HasColumnType("money")
                    .HasColumnName("sum_received_budg");

                entity.Property(e => e.SumRefund)
                    .HasColumnType("money")
                    .HasColumnName("sum_refund");

                entity.Property(e => e.SumReturnedNeeds)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_needs");

                entity.Property(e => e.SumReturnedRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_remains");
            });

            modelBuilder.Entity<BrrepGovTransferIncomeKe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_gov_transfer_income_ke");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdBcIcodeIncome).HasColumnName("id_bc_icode_income");

                entity.Property(e => e.IdBcIcodeMainAdmin).HasColumnName("id_bc_icode_main_admin");

                entity.Property(e => e.IdGovTransferIncomeKe)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_gov_transfer_income_ke");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumBalanceBeginActual)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin_actual");

                entity.Property(e => e.SumBalanceBeginTotal)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin_total");

                entity.Property(e => e.SumCashOutcome)
                    .HasColumnType("money")
                    .HasColumnName("sum_cash_outcome");

                entity.Property(e => e.SumFactExp)
                    .HasColumnType("money")
                    .HasColumnName("sum_fact_exp");

                entity.Property(e => e.SumOldRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_old_remains");

                entity.Property(e => e.SumReceivedBudg)
                    .HasColumnType("money")
                    .HasColumnName("sum_received_budg");

                entity.Property(e => e.SumRefund)
                    .HasColumnType("money")
                    .HasColumnName("sum_refund");

                entity.Property(e => e.SumReturnedNeeds)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_needs");

                entity.Property(e => e.SumReturnedRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_remains");
            });

            modelBuilder.Entity<BrrepKs>(entity =>
            {
                entity.ToTable("brrep_ks");

                entity.HasIndex(e => e.Istest, "brrep_ks_idx");

                entity.HasIndex(e => e.Doit, "brrep_ks_idx2");

                entity.HasIndex(e => e.GroupId, "brrep_ks_idx3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Doit).HasColumnName("doit");

                entity.Property(e => e.Formula)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("formula");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Istest).HasColumnName("istest");

                entity.Property(e => e.Koment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("koment");

                entity.Property(e => e.Ktype).HasColumnName("ktype");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BrrepKsGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK__brrep_ks__D57795A0653A345E");

                entity.ToTable("brrep_ks_group");

                entity.HasIndex(e => e.Kaz, "brrep_ks_group_idx");

                entity.HasIndex(e => e.Bud, "brrep_ks_group_idx1");

                entity.HasIndex(e => e.M4, "brrep_ks_group_idx10");

                entity.HasIndex(e => e.M5, "brrep_ks_group_idx11");

                entity.HasIndex(e => e.M6, "brrep_ks_group_idx12");

                entity.HasIndex(e => e.M7, "brrep_ks_group_idx13");

                entity.HasIndex(e => e.M8, "brrep_ks_group_idx18");

                entity.HasIndex(e => e.M9, "brrep_ks_group_idx19");

                entity.HasIndex(e => e.Avt, "brrep_ks_group_idx2");

                entity.HasIndex(e => e.M10, "brrep_ks_group_idx20");

                entity.HasIndex(e => e.M11, "brrep_ks_group_idx21");

                entity.HasIndex(e => e.M12, "brrep_ks_group_idx22");

                entity.HasIndex(e => e.K1, "brrep_ks_group_idx3");

                entity.HasIndex(e => e.K2, "brrep_ks_group_idx4");

                entity.HasIndex(e => e.K3, "brrep_ks_group_idx5");

                entity.HasIndex(e => e.K4, "brrep_ks_group_idx6");

                entity.HasIndex(e => e.M1, "brrep_ks_group_idx7");

                entity.HasIndex(e => e.M2, "brrep_ks_group_idx8");

                entity.HasIndex(e => e.M3, "brrep_ks_group_idx9");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Avt).HasColumnName("avt");

                entity.Property(e => e.Bud).HasColumnName("bud");

                entity.Property(e => e.Forms)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("forms");

                entity.Property(e => e.K1).HasColumnName("k1");

                entity.Property(e => e.K2).HasColumnName("k2");

                entity.Property(e => e.K3).HasColumnName("k3");

                entity.Property(e => e.K4).HasColumnName("k4");

                entity.Property(e => e.Kaz).HasColumnName("kaz");

                entity.Property(e => e.M1).HasColumnName("m1");

                entity.Property(e => e.M10).HasColumnName("m10");

                entity.Property(e => e.M11).HasColumnName("m11");

                entity.Property(e => e.M12).HasColumnName("m12");

                entity.Property(e => e.M2).HasColumnName("m2");

                entity.Property(e => e.M3).HasColumnName("m3");

                entity.Property(e => e.M4).HasColumnName("m4");

                entity.Property(e => e.M5).HasColumnName("m5");

                entity.Property(e => e.M6).HasColumnName("m6");

                entity.Property(e => e.M7).HasColumnName("m7");

                entity.Property(e => e.M8).HasColumnName("m8");

                entity.Property(e => e.M9).HasColumnName("m9");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BrrepRemainsCauses>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_remains_causes");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdRemainFundsCodes).HasColumnName("id_remain_funds_codes");

                entity.Property(e => e.IdRemainsCauses)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_remains_causes");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_remains");
            });

            modelBuilder.Entity<BrrepRemainsCausesK>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_remains_causes_k");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdRemainFundsCodes).HasColumnName("id_remain_funds_codes");

                entity.Property(e => e.IdRemainsCausesK)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_remains_causes_k");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_remains");
            });

            modelBuilder.Entity<BrrepSubsidiesAdministrative>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_subsidies_administrative");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSubsidiesAdministrative)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_subsidies_administrative");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumBalanceBegin)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin");

                entity.Property(e => e.SumProducedCostBegin)
                    .HasColumnType("money")
                    .HasColumnName("sum_produced_cost_begin");

                entity.Property(e => e.SumProducedCostRep)
                    .HasColumnType("money")
                    .HasColumnName("sum_produced_cost_rep");

                entity.Property(e => e.SumReceivedMoBegin)
                    .HasColumnType("money")
                    .HasColumnName("sum_received_mo_begin");

                entity.Property(e => e.SumRecievedMoRep)
                    .HasColumnType("money")
                    .HasColumnName("sum_recieved_mo_rep");

                entity.Property(e => e.SumReturnedNeeds)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_needs")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.SumReturnedRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_remains")
                    .HasDefaultValueSql("((0.0000))");
            });

            modelBuilder.Entity<BrrepSubsidiesCourt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_subsidies_court");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSubsidiesCourt)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_subsidies_court");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumBalanceBeginKrd)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin_krd");

                entity.Property(e => e.SumBalanceBeginSkov)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin_skov");

                entity.Property(e => e.SumBalanceBeginThrd)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin_thrd");

                entity.Property(e => e.SumProducedCostKrd)
                    .HasColumnType("money")
                    .HasColumnName("sum_produced_cost_krd");

                entity.Property(e => e.SumProducedCostSkov)
                    .HasColumnType("money")
                    .HasColumnName("sum_produced_cost_skov");

                entity.Property(e => e.SumProducedCostThrd)
                    .HasColumnType("money")
                    .HasColumnName("sum_produced_cost_thrd");

                entity.Property(e => e.SumReceivedMoKrd)
                    .HasColumnType("money")
                    .HasColumnName("sum_received_mo_krd");

                entity.Property(e => e.SumReceivedMoSkov)
                    .HasColumnType("money")
                    .HasColumnName("sum_received_mo_skov");

                entity.Property(e => e.SumReceivedMoThrd)
                    .HasColumnType("money")
                    .HasColumnName("sum_received_mo_thrd");

                entity.Property(e => e.SumRecoveredRemKrd)
                    .HasColumnType("money")
                    .HasColumnName("sum_recovered_rem_krd");

                entity.Property(e => e.SumRecoveredRemSkov)
                    .HasColumnType("money")
                    .HasColumnName("sum_recovered_rem_skov");

                entity.Property(e => e.SumRecoveredRemThrd)
                    .HasColumnType("money")
                    .HasColumnName("sum_recovered_rem_thrd");

                entity.Property(e => e.SumReturnedRemKrd)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_rem_krd");

                entity.Property(e => e.SumReturnedRemSkov)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_rem_skov");

                entity.Property(e => e.SumReturnedRemThrd)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_rem_thrd");
            });

            modelBuilder.Entity<BrrepSubsidiesExp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_subsidies_exp");

                entity.Property(e => e.CntInductee).HasColumnName("cnt_inductee");

                entity.Property(e => e.CntMilitaryComb).HasColumnName("cnt_military_comb");

                entity.Property(e => e.CntMilitaryLiberated).HasColumnName("cnt_military_liberated");

                entity.Property(e => e.CntReserveOfficier).HasColumnName("cnt_reserve_officier");

                entity.Property(e => e.CntReserveSoldier).HasColumnName("cnt_reserve_soldier");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSubsidiesExp)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_subsidies_exp");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumBudgTransfer)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_budg_transfer");

                entity.Property(e => e.SumRecievedRep)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_recieved_rep");

                entity.Property(e => e.SumRecievedYtd)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_recieved_ytd");

                entity.Property(e => e.SumReportComb)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_report_comb");

                entity.Property(e => e.SumReportInventory)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_report_inventory");

                entity.Property(e => e.SumReportLiberated)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_report_liberated");

                entity.Property(e => e.SumReportRental)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_report_rental");

                entity.Property(e => e.SumReportServices)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_report_services");

                entity.Property(e => e.SumReportTransport)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_report_transport");

                entity.Property(e => e.SumReportTravel)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_report_travel");

                entity.Property(e => e.SumReportUtility)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_report_utility");

                entity.Property(e => e.SumSpendedYtd)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_spended_ytd");

                entity.Property(e => e.ValWorkTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("val_work_time");
            });

            modelBuilder.Entity<BrrepSubsidiesMinors>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_subsidies_minors");

                entity.Property(e => e.CntStaff).HasColumnName("cnt_staff");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSubsidiesMinors)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_subsidies_minors");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumBalanceBegin)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin");

                entity.Property(e => e.SumProducedCostBegin)
                    .HasColumnType("money")
                    .HasColumnName("sum_produced_cost_begin");

                entity.Property(e => e.SumProducedCostRep)
                    .HasColumnType("money")
                    .HasColumnName("sum_produced_cost_rep");

                entity.Property(e => e.SumProducedSalaryBegin)
                    .HasColumnType("money")
                    .HasColumnName("sum_produced_salary_begin");

                entity.Property(e => e.SumProducedSalaryRep)
                    .HasColumnType("money")
                    .HasColumnName("sum_produced_salary_rep");

                entity.Property(e => e.SumReceivedMoBegin)
                    .HasColumnType("money")
                    .HasColumnName("sum_received_mo_begin");

                entity.Property(e => e.SumRecievedMoRep)
                    .HasColumnType("money")
                    .HasColumnName("sum_recieved_mo_rep");

                entity.Property(e => e.SumReturnedNeeds)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_needs")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.SumReturnedRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_remains")
                    .HasDefaultValueSql("((0.0000))");
            });

            modelBuilder.Entity<BrrepSubsidiesMore>(entity =>
            {
                entity.HasKey(e => e.IdSubsidiesMore)
                    .HasName("PK__brrep_su__C13B8E02FBA4F38A");

                entity.ToTable("brrep_subsidies_more");

                entity.Property(e => e.IdSubsidiesMore).HasColumnName("id_subsidies_more");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumNeedMore)
                    .HasColumnType("money")
                    .HasColumnName("sum_need_more");

                entity.HasOne(d => d.IdBcCcodeMainFundsNavigation)
                    .WithMany(p => p.BrrepSubsidiesMore)
                    .HasForeignKey(d => d.IdBcCcodeMainFunds)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_bc__185B7C5F");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.BrrepSubsidiesMore)
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_mo__194FA098");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.BrrepSubsidiesMore)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_pe__1A43C4D1");
            });

            modelBuilder.Entity<BrrepSubsidiesNeed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_subsidies_need");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdSubsidiesNeed)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_subsidies_need");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.Sum1kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_1kv_need");

                entity.Property(e => e.Sum2kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_2kv_need");

                entity.Property(e => e.Sum3kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_3kv_need");

                entity.Property(e => e.Sum4kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_4kv_need");

                entity.Property(e => e.SumYearGiven)
                    .HasColumnType("money")
                    .HasColumnName("sum_year_given");

                entity.HasOne(d => d.IdBcCcodeMainFundsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdBcCcodeMainFunds)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_bc__6A46A039");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_mo__6C2EE8AB");
            });

            modelBuilder.Entity<BrrepSubsidiesNeedAdmin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_subsidies_need_admin");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdSubsidiesNeedAdmin)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_subsidies_need_admin");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.Sum10mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_10m_need");

                entity.Property(e => e.Sum11mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_11m_need");

                entity.Property(e => e.Sum12mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_12m_need");

                entity.Property(e => e.Sum1kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_1kv_need");

                entity.Property(e => e.Sum1mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_1m_need");

                entity.Property(e => e.Sum2kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_2kv_need");

                entity.Property(e => e.Sum2mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_2m_need");

                entity.Property(e => e.Sum3kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_3kv_need");

                entity.Property(e => e.Sum3mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_3m_need");

                entity.Property(e => e.Sum4kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_4kv_need");

                entity.Property(e => e.Sum4mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_4m_need");

                entity.Property(e => e.Sum5mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_5m_need");

                entity.Property(e => e.Sum6mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_6m_need");

                entity.Property(e => e.Sum7mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_7m_need");

                entity.Property(e => e.Sum8mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_8m_need");

                entity.Property(e => e.Sum9mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_9m_need");

                entity.Property(e => e.SumYearGiven)
                    .HasColumnType("money")
                    .HasColumnName("sum_year_given");

                entity.HasOne(d => d.IdBcCcodeExpenditureNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdBcCcodeExpenditure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_bc__4E89772B");

                entity.HasOne(d => d.IdBcCcodeMainFundsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdBcCcodeMainFunds)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_bc__4D9552F2");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_mo__4F7D9B64");
            });

            modelBuilder.Entity<BrrepSubsidiesNeedCourt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_subsidies_need_court");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdSubsidiesNeedCourt)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_subsidies_need_court");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.Sum1kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_1kv_need");

                entity.Property(e => e.Sum2kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_2kv_need");

                entity.Property(e => e.Sum3kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_3kv_need");

                entity.Property(e => e.Sum4kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_4kv_need");

                entity.Property(e => e.SumYearGiven)
                    .HasColumnType("money")
                    .HasColumnName("sum_year_given");

                entity.HasOne(d => d.IdBcCcodeExpenditureNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdBcCcodeExpenditure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_bc__553674BA");

                entity.HasOne(d => d.IdBcCcodeMainFundsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdBcCcodeMainFunds)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_bc__54425081");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_mo__562A98F3");
            });

            modelBuilder.Entity<BrrepSubsidiesNeedExp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_subsidies_need_exp");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdSubsidiesNeedExp)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_subsidies_need_exp");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.Sum10mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_10m_need");

                entity.Property(e => e.Sum11mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_11m_need");

                entity.Property(e => e.Sum12mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_12m_need");

                entity.Property(e => e.Sum1kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_1kv_need");

                entity.Property(e => e.Sum1mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_1m_need");

                entity.Property(e => e.Sum2kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_2kv_need");

                entity.Property(e => e.Sum2mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_2m_need");

                entity.Property(e => e.Sum3kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_3kv_need");

                entity.Property(e => e.Sum3mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_3m_need");

                entity.Property(e => e.Sum4kvNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_4kv_need");

                entity.Property(e => e.Sum4mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_4m_need");

                entity.Property(e => e.Sum5mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_5m_need");

                entity.Property(e => e.Sum6mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_6m_need");

                entity.Property(e => e.Sum7mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_7m_need");

                entity.Property(e => e.Sum8mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_8m_need");

                entity.Property(e => e.Sum9mNeed)
                    .HasColumnType("money")
                    .HasColumnName("sum_9m_need");

                entity.Property(e => e.SumYearGiven)
                    .HasColumnType("money")
                    .HasColumnName("sum_year_given");

                entity.HasOne(d => d.IdBcCcodeExpenditureNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdBcCcodeExpenditure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_bc__47DC799C");

                entity.HasOne(d => d.IdBcCcodeMainFundsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdBcCcodeMainFunds)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_bc__46E85563");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_sub__id_mo__48D09DD5");
            });

            modelBuilder.Entity<BrrepSubsidiesUses>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_subsidies_uses");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSubsidiesUses)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_subsidies_uses");

                entity.Property(e => e.NameOther)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("name_other");

                entity.Property(e => e.Note)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.OtherKvr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("other_kvr");

                entity.Property(e => e.OtherName)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("other_name");

                entity.Property(e => e.OtherSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("other_sum");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.ReportDate).HasColumnName("report_date");

                entity.Property(e => e.SumCommunication)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_communication");

                entity.Property(e => e.SumIntentory)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_intentory");

                entity.Property(e => e.SumOffset)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_offset");

                entity.Property(e => e.SumOther)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_other");

                entity.Property(e => e.SumPost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_post");

                entity.Property(e => e.SumStationery)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_stationery");

                entity.Property(e => e.SumTech)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_tech");

                entity.Property(e => e.SumTransport)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_transport");
            });

            modelBuilder.Entity<BrrepSubsidiesUsesCourt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_subsidies_uses_court");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSubsidiesUsesCourt)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_subsidies_uses_court");

                entity.Property(e => e.Note)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.OtherKvr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("other_kvr");

                entity.Property(e => e.OtherName)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("other_name");

                entity.Property(e => e.OtherSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("other_sum");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.ReportDate).HasColumnName("report_date");

                entity.Property(e => e.SumPost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_post");

                entity.Property(e => e.SumPublish)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_publish");

                entity.Property(e => e.SumStationery)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_stationery");
            });

            modelBuilder.Entity<BrrepSubsidiesUsesVus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_subsidies_uses_vus");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSubsidiesUsesVus)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_subsidies_uses_vus");

                entity.Property(e => e.NameConsumables)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("name_consumables");

                entity.Property(e => e.Note)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.OtherKvr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("other_kvr");

                entity.Property(e => e.OtherName)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("other_name");

                entity.Property(e => e.OtherSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("other_sum");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.ReportDate).HasColumnName("report_date");

                entity.Property(e => e.SumCommTech)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_comm_tech");

                entity.Property(e => e.SumCommunication)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_communication");

                entity.Property(e => e.SumConsumables)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_consumables");

                entity.Property(e => e.SumFurniture)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_furniture");

                entity.Property(e => e.SumIntentory)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_intentory");

                entity.Property(e => e.SumKvr121)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_kvr121");

                entity.Property(e => e.SumKvr122)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_kvr122");

                entity.Property(e => e.SumKvr129)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_kvr129");

                entity.Property(e => e.SumRent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_rent");

                entity.Property(e => e.SumTech)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_tech");

                entity.Property(e => e.SumTransport)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_transport");

                entity.Property(e => e.SumUtilities)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sum_utilities");
            });

            modelBuilder.Entity<BrrepTransferCost>(entity =>
            {
                entity.HasKey(e => e.IdTransferCost)
                    .HasName("PK__brrep_tr__A7E5447231E2BB63");

                entity.ToTable("brrep_transfer_cost");

                entity.Property(e => e.IdTransferCost).HasColumnName("id_transfer_cost");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcIcodeIncome).HasColumnName("id_bc_icode_income");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumBalanceBegin)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin");

                entity.Property(e => e.SumFactCosts)
                    .HasColumnType("money")
                    .HasColumnName("sum_fact_costs");

                entity.Property(e => e.SumReceivedBudg)
                    .HasColumnType("money")
                    .HasColumnName("sum_received_budg");

                entity.Property(e => e.SumRecoverRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_recover_remains");

                entity.Property(e => e.SumReturnedRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_remains");

                entity.HasOne(d => d.IdBcCcodeExpenditureNavigation)
                    .WithMany(p => p.BrrepTransferCost)
                    .HasForeignKey(d => d.IdBcCcodeExpenditure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_tra__id_bc__1BF70319");

                entity.HasOne(d => d.IdBcIcodeIncomeNavigation)
                    .WithMany(p => p.BrrepTransferCost)
                    .HasForeignKey(d => d.IdBcIcodeIncome)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_tra__id_bc__1CEB2752");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.BrrepTransferCost)
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_tra__id_mo__1DDF4B8B");
            });

            modelBuilder.Entity<BrrepTransferCostK>(entity =>
            {
                entity.HasKey(e => e.IdTransferCostK)
                    .HasName("PK__brrep_tr__D44BF1FC38BA9023");

                entity.ToTable("brrep_transfer_cost_k");

                entity.Property(e => e.IdTransferCostK).HasColumnName("id_transfer_cost_k");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcIcodeIncome).HasColumnName("id_bc_icode_income");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumBalanceBegin)
                    .HasColumnType("money")
                    .HasColumnName("sum_balance_begin");

                entity.Property(e => e.SumFactCosts)
                    .HasColumnType("money")
                    .HasColumnName("sum_fact_costs");

                entity.Property(e => e.SumReceivedBudg)
                    .HasColumnType("money")
                    .HasColumnName("sum_received_budg");

                entity.Property(e => e.SumRecoverRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_recover_remains");

                entity.Property(e => e.SumReturnedRemains)
                    .HasColumnType("money")
                    .HasColumnName("sum_returned_remains");

                entity.HasOne(d => d.IdBcCcodeExpenditureNavigation)
                    .WithMany(p => p.BrrepTransferCostK)
                    .HasForeignKey(d => d.IdBcCcodeExpenditure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_tra__id_bc__2F09D78D");

                entity.HasOne(d => d.IdBcIcodeIncomeNavigation)
                    .WithMany(p => p.BrrepTransferCostK)
                    .HasForeignKey(d => d.IdBcIcodeIncome)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_tra__id_bc__2FFDFBC6");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.BrrepTransferCostK)
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__brrep_tra__id_mo__30F21FFF");
            });

            modelBuilder.Entity<BrrepTrustFunds>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_trust_funds");

                entity.Property(e => e.IdBcCcodeClass).HasColumnName("id_bc_ccode_class");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeGroup).HasColumnName("id_bc_ccode_group");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdBcCcodeMainFunds2).HasColumnName("id_bc_ccode_main_funds_2");

                entity.Property(e => e.IdBcGcodeOperClass).HasColumnName("id_bc_gcode_oper_class");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdTrustFunds)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_trust_funds");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumCashOutcome)
                    .HasColumnType("money")
                    .HasColumnName("sum_cash_outcome");
            });

            modelBuilder.Entity<BrrepTrustFundsCopy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_trust_funds_copy");

                entity.Property(e => e.IdBcCcodeClass).HasColumnName("id_bc_ccode_class");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeGroup).HasColumnName("id_bc_ccode_group");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdBcCcodeMainFunds2).HasColumnName("id_bc_ccode_main_funds_2");

                entity.Property(e => e.IdBcGcodeOperClass).HasColumnName("id_bc_gcode_oper_class");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdTrustFunds)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_trust_funds");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumCashOutcome)
                    .HasColumnType("money")
                    .HasColumnName("sum_cash_outcome");
            });

            modelBuilder.Entity<BrrepTrustFundsE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_trust_funds_e");

                entity.Property(e => e.IdBcCcodeClass).HasColumnName("id_bc_ccode_class");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeGroup).HasColumnName("id_bc_ccode_group");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdBcCcodeMainFunds2).HasColumnName("id_bc_ccode_main_funds_2");

                entity.Property(e => e.IdBcGcodeOperClass).HasColumnName("id_bc_gcode_oper_class");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdTrustFundsE)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_trust_funds_e");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumCashOutcome)
                    .HasColumnType("money")
                    .HasColumnName("sum_cash_outcome");
            });

            modelBuilder.Entity<BrrepTrustFundsK>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_trust_funds_k");

                entity.Property(e => e.IdBcCcodeClass).HasColumnName("id_bc_ccode_class");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeGroup).HasColumnName("id_bc_ccode_group");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdBcCcodeMainFunds2).HasColumnName("id_bc_ccode_main_funds_2");

                entity.Property(e => e.IdBcGcodeOperClass).HasColumnName("id_bc_gcode_oper_class");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdTrustFundsK)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_trust_funds_k");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumCashOutcome)
                    .HasColumnType("money")
                    .HasColumnName("sum_cash_outcome");
            });

            modelBuilder.Entity<BrrepTrustFundsKe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_trust_funds_ke");

                entity.Property(e => e.IdBcCcodeClass).HasColumnName("id_bc_ccode_class");

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.IdBcCcodeGroup).HasColumnName("id_bc_ccode_group");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.IdBcCcodeMainFunds2).HasColumnName("id_bc_ccode_main_funds_2");

                entity.Property(e => e.IdBcGcodeOperClass).HasColumnName("id_bc_gcode_oper_class");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdTrustFundsKe)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_trust_funds_ke");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumCashOutcome)
                    .HasColumnType("money")
                    .HasColumnName("sum_cash_outcome");
            });

            modelBuilder.Entity<BrrepVfkMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("brrep_vfk_map");

                entity.Property(e => e.IdBcCcodeClass).HasColumnName("id_bc_ccode_class");

                entity.Property(e => e.IdBcGcodeOperClass).HasColumnName("id_bc_gcode_oper_class");

                entity.Property(e => e.IdVfkMap)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_vfk_map");
            });

            modelBuilder.Entity<CommentType>(entity =>
            {
                entity.HasKey(e => e.IdCommentType)
                    .HasName("PK__COMMENT___1E7F77ED0646226E")
                    .IsClustered(false);

                entity.ToTable("COMMENT_TYPE");

                entity.Property(e => e.IdCommentType).HasColumnName("ID_COMMENT_TYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<CurFooterBgti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bgti");

                entity.Property(e => e.BudgName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("budg_name");

                entity.Property(e => e.FinancialAuthority)
                    .HasMaxLength(1020)
                    .IsUnicode(false)
                    .HasColumnName("financial_authority");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");
            });

            modelBuilder.Entity<CurFooterBsDoneArc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bs_done_arc");

                entity.Property(e => e.Boss)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("boss");

                entity.Property(e => e.ExecName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_name");

                entity.Property(e => e.ExecPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_post");

                entity.Property(e => e.ExecTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_tel");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");

                entity.Property(e => e.ReportDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("report_date");

                entity.Property(e => e.ReportNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("report_number");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cur_foote__id_mo__3E9633E0");
            });

            modelBuilder.Entity<CurFooterBsDoneBest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bs_done_best");

                entity.Property(e => e.Boss)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("boss");

                entity.Property(e => e.ExecName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_name");

                entity.Property(e => e.ExecPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_post");

                entity.Property(e => e.ExecTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_tel");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");

                entity.Property(e => e.ReportDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("report_date");

                entity.Property(e => e.ReportNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("report_number");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cur_foote__id_mo__4B11195E");
            });

            modelBuilder.Entity<CurFooterBsDoneSmd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bs_done_smd");

                entity.Property(e => e.Boss)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("boss");

                entity.Property(e => e.ExecName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_name");

                entity.Property(e => e.ExecPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_post");

                entity.Property(e => e.ExecTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_tel");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");

                entity.Property(e => e.ReportDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("report_date");

                entity.Property(e => e.ReportNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("report_number");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cur_foote__id_mo__4CF961D0");
            });

            modelBuilder.Entity<CurFooterBsDoneToc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bs_done_toc");

                entity.Property(e => e.Boss)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("boss");

                entity.Property(e => e.ExecName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_name");

                entity.Property(e => e.ExecPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_post");

                entity.Property(e => e.ExecTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_tel");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");

                entity.Property(e => e.ReportDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("report_date");

                entity.Property(e => e.ReportNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("report_number");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cur_foote__id_mo__4928D0EC");
            });

            modelBuilder.Entity<CurFooterBsMore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bs_more");

                entity.Property(e => e.Boss)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("boss");

                entity.Property(e => e.ExecName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_name");

                entity.Property(e => e.ExecPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_post");

                entity.Property(e => e.ExecTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_tel");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");
            });

            modelBuilder.Entity<CurFooterBsNeed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bs_need");

                entity.Property(e => e.Boss)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("boss");

                entity.Property(e => e.ExecName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_name");

                entity.Property(e => e.ExecPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_post");

                entity.Property(e => e.ExecTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_tel");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");
            });

            modelBuilder.Entity<CurFooterBsNeedAdmin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bs_need_admin");

                entity.Property(e => e.Boss)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("boss");

                entity.Property(e => e.ExecName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_name");

                entity.Property(e => e.ExecPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_post");

                entity.Property(e => e.ExecTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_tel");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");
            });

            modelBuilder.Entity<CurFooterBsNeedCourt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bs_need_court");

                entity.Property(e => e.Boss)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("boss");

                entity.Property(e => e.ExecName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_name");

                entity.Property(e => e.ExecPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_post");

                entity.Property(e => e.ExecTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_tel");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");
            });

            modelBuilder.Entity<CurFooterBsNeedExp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bs_need_exp");

                entity.Property(e => e.Boss)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("boss");

                entity.Property(e => e.ExecName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_name");

                entity.Property(e => e.ExecPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_post");

                entity.Property(e => e.ExecTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_tel");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");
            });

            modelBuilder.Entity<CurFooterBsa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bsa");

                entity.Property(e => e.FinancialAuthority)
                    .HasMaxLength(1020)
                    .IsUnicode(false)
                    .HasColumnName("financial_authority");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.Manager)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("manager");

                entity.Property(e => e.Performer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("performer");
            });

            modelBuilder.Entity<CurFooterBsc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bsc");

                entity.Property(e => e.FinancialAuthority)
                    .HasMaxLength(1020)
                    .IsUnicode(false)
                    .HasColumnName("financial_authority");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.Manager)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("manager");

                entity.Property(e => e.PerformerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("performer_name");

                entity.Property(e => e.PerformerTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("performer_tel");
            });

            modelBuilder.Entity<CurFooterBse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bse");

                entity.Property(e => e.FinancialAuthority)
                    .HasMaxLength(1020)
                    .IsUnicode(false)
                    .HasColumnName("financial_authority");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");

                entity.Property(e => e.MainBuhPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh_post");

                entity.Property(e => e.Manager)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("manager");

                entity.Property(e => e.ManagerPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("manager_post");

                entity.Property(e => e.PerformerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("performer_name");

                entity.Property(e => e.PerformerPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("performer_post");

                entity.Property(e => e.PerformerTel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("performer_tel");
            });

            modelBuilder.Entity<CurFooterBsm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_bsm");

                entity.Property(e => e.FinancialAuthority)
                    .HasMaxLength(1020)
                    .IsUnicode(false)
                    .HasColumnName("financial_authority");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.Manager)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("manager");

                entity.Property(e => e.Performer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("performer");
            });

            modelBuilder.Entity<CurFooterBtf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_btf");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");

                entity.Property(e => e.Manager)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("manager");

                entity.Property(e => e.ManagerFin)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("manager_fin");
            });

            modelBuilder.Entity<CurFooterF0503121>(entity =>
            {
                entity.HasKey(e => e.IdMo)
                    .HasName("PK__cur_foot__01488BA72CC0D111");

                entity.ToTable("cur_footer_f0503121");

                entity.Property(e => e.IdMo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_mo");

                entity.Property(e => e.Glbk)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("glbk");

                entity.Property(e => e.Glbuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("glbuh");

                entity.Property(e => e.Glbuhd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("glbuhd");

                entity.Property(e => e.Manager)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("manager");

                entity.Property(e => e.Managerd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("managerd");

                entity.Property(e => e.Orgname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("orgname");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithOne(p => p.CurFooterF0503121)
                    .HasForeignKey<CurFooterF0503121>(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cur_foote__id_mo__0C73FD10");
            });

            modelBuilder.Entity<CurFooterNotice>(entity =>
            {
                entity.HasKey(e => e.IdMo)
                    .HasName("PK__cur_foot__01488BA73AC0DDB4");

                entity.ToTable("cur_footer_notice");

                entity.Property(e => e.IdMo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_mo");

                entity.Property(e => e.Boss)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("boss");

                entity.Property(e => e.ExecName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_name");

                entity.Property(e => e.ExecPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("exec_post");

                entity.Property(e => e.MainBuh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("main_buh");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithOne(p => p.CurFooterNotice)
                    .HasForeignKey<CurFooterNotice>(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cur_foote__id_mo__552F8075");
            });

            modelBuilder.Entity<CurFooterNp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_footer_np");

                entity.Property(e => e.BudgFull)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("budg_full");

                entity.Property(e => e.BudgSmp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("budg_smp");

                entity.Property(e => e.BudgSum)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("budg_sum");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");
            });

            modelBuilder.Entity<CurPeriod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cur_period");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.IdDepartment)
                    .HasName("PK__DEPARTME__F98EBB3C0A16B352")
                    .IsClustered(false);

                entity.ToTable("DEPARTMENT");

                entity.Property(e => e.IdDepartment).HasColumnName("ID_DEPARTMENT");

                entity.Property(e => e.IdParent).HasColumnName("ID_PARENT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<DictAimedmeans>(entity =>
            {
                entity.HasKey(e => e.IdAimedmeans)
                    .HasName("PK__dict_aim__D5859DFC35561712");

                entity.ToTable("dict_aimedmeans");

                entity.HasIndex(e => e.Code, "IX_dict_aimedmeans_code");

                entity.Property(e => e.IdAimedmeans).HasColumnName("id_aimedmeans");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictBcCcodeClass>(entity =>
            {
                entity.HasKey(e => e.IdBcCcodeClass)
                    .HasName("PK__dict_bc___F99728F4383283BD");

                entity.ToTable("dict_bc_ccode_class");

                entity.HasIndex(e => e.Code, "UQ__dict_bc___357D4CF93B0EF068")
                    .IsUnique();

                entity.Property(e => e.IdBcCcodeClass).HasColumnName("id_bc_ccode_class");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictBcCcodeExpenditure>(entity =>
            {
                entity.HasKey(e => e.IdBcCcodeExpenditure)
                    .HasName("PK__dict_bc___562BFB4A3DEB5D13");

                entity.ToTable("dict_bc_ccode_expenditure");

                entity.HasIndex(e => e.Code, "UQ__dict_bc___357D4CF940C7C9BE")
                    .IsUnique();

                entity.Property(e => e.IdBcCcodeExpenditure).HasColumnName("id_bc_ccode_expenditure");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IsFed)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_fed")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);

                entity.Property(e => e.IsGorod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_gorod")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);

                entity.Property(e => e.IsKray)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_kray")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);

                entity.Property(e => e.IsRaion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_raion")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictBcCcodeGroup>(entity =>
            {
                entity.HasKey(e => e.IdBcCcodeGroup)
                    .HasName("PK__dict_bc___A21B57CB43A43669");

                entity.ToTable("dict_bc_ccode_group");

                entity.HasIndex(e => e.Code, "UQ__dict_bc___357D4CF94680A314")
                    .IsUnique();

                entity.Property(e => e.IdBcCcodeGroup).HasColumnName("id_bc_ccode_group");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictBcCcodeMainFunds>(entity =>
            {
                entity.HasKey(e => e.IdBcCcodeMainFunds)
                    .HasName("PK__dict_bc___D490A124495D0FBF");

                entity.ToTable("dict_bc_ccode_main_funds");

                entity.HasIndex(e => e.Code, "UQ__dict_bc___357D4CF94C397C6A")
                    .IsUnique();

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Visible)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("visible")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DictBcCcodeMainFundsGrbs>(entity =>
            {
                entity.HasKey(e => e.IdBcCcodeMainFundsGrbs)
                    .HasName("PK__dict_bc___E08A0D0F4F15E915");

                entity.ToTable("dict_bc_ccode_main_funds_grbs");

                entity.Property(e => e.IdBcCcodeMainFundsGrbs).HasColumnName("id_bc_ccode_main_funds_grbs");

                entity.Property(e => e.GrbsCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("grbs_code");

                entity.Property(e => e.IdBcCcodeMainFunds).HasColumnName("id_bc_ccode_main_funds");

                entity.HasOne(d => d.IdBcCcodeMainFundsNavigation)
                    .WithMany(p => p.DictBcCcodeMainFundsGrbs)
                    .HasForeignKey(d => d.IdBcCcodeMainFunds)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dict_bc_c__id_bc__0F5069BB");
            });

            modelBuilder.Entity<DictBcGcodeOperClass>(entity =>
            {
                entity.HasKey(e => e.IdBcGcodeOperClass)
                    .HasName("PK__dict_bc___BC18344851F255C0");

                entity.ToTable("dict_bc_gcode_oper_class");

                entity.HasIndex(e => e.Code, "UQ__dict_bc___357D4CF954CEC26B")
                    .IsUnique();

                entity.Property(e => e.IdBcGcodeOperClass).HasColumnName("id_bc_gcode_oper_class");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictBcIcodeIncome>(entity =>
            {
                entity.HasKey(e => e.IdBcIcodeIncome)
                    .HasName("PK__dict_bc___BF1C1CE357AB2F16");

                entity.ToTable("dict_bc_icode_income");

                entity.HasIndex(e => e.Code, "UQ__dict_bc___357D4CF95A879BC1")
                    .IsUnique();

                entity.Property(e => e.IdBcIcodeIncome).HasColumnName("id_bc_icode_income");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.CodeLevel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("code_level")
                    .IsFixedLength(true);

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IsFed)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_fed")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);

                entity.Property(e => e.IsKray)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_kray")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictBcIcodeMainAdmin>(entity =>
            {
                entity.HasKey(e => e.IdBcIcodeMainAdmin)
                    .HasName("PK__dict_bc___2234BE695D64086C");

                entity.ToTable("dict_bc_icode_main_admin");

                entity.HasIndex(e => e.Code, "UQ__dict_bc___357D4CF960407517")
                    .IsUnique();

                entity.Property(e => e.IdBcIcodeMainAdmin).HasColumnName("id_bc_icode_main_admin");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictCoatValues>(entity =>
            {
                entity.HasKey(e => e.IdCoatValues)
                    .HasName("PK__dict_coa__A2B95AC3631CE1C2");

                entity.ToTable("dict_coat_values");

                entity.HasIndex(e => e.Code, "IX_dict_coat_values_code");

                entity.Property(e => e.IdCoatValues).HasColumnName("id_coat_values");

                entity.Property(e => e.Code)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictDirection>(entity =>
            {
                entity.HasKey(e => e.IdDirection)
                    .HasName("PK__dict_dir__C4173DF065F94E6D");

                entity.ToTable("dict_direction");

                entity.HasIndex(e => e.Code, "IX_dict_direction_code");

                entity.Property(e => e.IdDirection).HasColumnName("id_direction");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictDocumentInfo>(entity =>
            {
                entity.HasKey(e => e.IdDocumentInfo)
                    .HasName("PK__dict_doc__587AA72968D5BB18");

                entity.ToTable("dict_document_info");

                entity.HasComment("Данные для печати соглашений");

                entity.HasIndex(e => e.IdUser, "UQ__dict_doc__D2D146366BB227C3")
                    .IsUnique();

                entity.Property(e => e.IdDocumentInfo).HasColumnName("id_document_info");

                entity.Property(e => e.AdmRedactionDate)
                    .HasColumnType("date")
                    .HasColumnName("adm_redaction_date");

                entity.Property(e => e.AdmRedactionNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("adm_redaction_number");

                entity.Property(e => e.BankName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("bank_name");

                entity.Property(e => e.Bik)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bik");

                entity.Property(e => e.BuhFio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("buh_fio");

                entity.Property(e => e.Charter)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("charter");

                entity.Property(e => e.CharterDate)
                    .HasColumnType("date")
                    .HasColumnName("charter_date");

                entity.Property(e => e.CharterNum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("charter_num");

                entity.Property(e => e.DirectorFio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("director_fio");

                entity.Property(e => e.DirectorFirstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("director_firstname");

                entity.Property(e => e.DirectorSecondname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("director_secondname");

                entity.Property(e => e.DirectorSurname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("director_surname");

                entity.Property(e => e.IdJob).HasColumnName("id_job");

                entity.Property(e => e.IdMinistryOrdersContracts).HasColumnName("id_ministry_orders_contracts");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.InflectDirectorFio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("inflect_director_fio")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);

                entity.Property(e => e.Kpp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("kpp");

                entity.Property(e => e.LegalName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("legal_name");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("order_date");

                entity.Property(e => e.OrderNum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("order_num");

                entity.Property(e => e.PayAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pay_account");

                entity.HasOne(d => d.IdJobNavigation)
                    .WithMany(p => p.DictDocumentInfo)
                    .HasForeignKey(d => d.IdJob)
                    .HasConstraintName("FK__dict_docu__id_jo__10448DF4");

                entity.HasOne(d => d.IdMinistryOrdersContractsNavigation)
                    .WithMany(p => p.DictDocumentInfo)
                    .HasForeignKey(d => d.IdMinistryOrdersContracts)
                    .HasConstraintName("FK__dict_docu__id_mi__63E6E8C9");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.DictDocumentInfo)
                    .HasForeignKey<DictDocumentInfo>(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dict_docu__id_us__1138B22D");
            });

            modelBuilder.Entity<DictJob>(entity =>
            {
                entity.HasKey(e => e.IdJob)
                    .HasName("PK__dict_job__D366B1F76E8E946E");

                entity.ToTable("dict_job");

                entity.HasComment("Справочник должностей");

                entity.Property(e => e.IdJob).HasColumnName("id_job");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictJobs>(entity =>
            {
                entity.HasKey(e => e.IdJobs)
                    .HasName("PK__dict_job__D366B1F7553C1C77");

                entity.ToTable("dict_jobs");

                entity.Property(e => e.IdJobs).HasColumnName("id_jobs");

                entity.Property(e => e.Mnemo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mnemo");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictMeasureUnit>(entity =>
            {
                entity.HasKey(e => e.IdMeasureUnit)
                    .HasName("PK__dict_mea__00E7C4F6716B0119");

                entity.ToTable("dict_measure_unit");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.NameFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.NameShort)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_short");

                entity.Property(e => e.Okei)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("okei");
            });

            modelBuilder.Entity<DictMinistryOrdersContracts>(entity =>
            {
                entity.HasKey(e => e.IdMinistryOrdersContracts)
                    .HasName("PK__dict_min__7D75A7B8F293A20B");

                entity.ToTable("dict_ministry_orders_contracts");

                entity.Property(e => e.IdMinistryOrdersContracts).HasColumnName("id_ministry_orders_contracts");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Number)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("number");
            });

            modelBuilder.Entity<DictMo>(entity =>
            {
                entity.HasKey(e => e.IdMo)
                    .HasName("PK__dict_mo__01488BA774476DC4");

                entity.ToTable("dict_mo");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.BseSort).HasColumnName("bse_sort");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdGrbs).HasColumnName("id_grbs");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.Inn)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.NameFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.NameShort)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("name_short");

                entity.Property(e => e.Oktmo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("oktmo");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<DictPayTurn>(entity =>
            {
                entity.HasKey(e => e.IdPayTurn)
                    .HasName("PK__dict_pay__0928538A9B2CC2C9");

                entity.ToTable("dict_pay_turn");

                entity.Property(e => e.IdPayTurn).HasColumnName("id_pay_turn");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OrderNum).HasColumnName("order_num");
            });

            modelBuilder.Entity<DictPayroll>(entity =>
            {
                entity.HasKey(e => e.IdPayroll)
                    .HasName("PK__dict_pay__F81183165433FBB4");

                entity.ToTable("dict_payroll");

                entity.Property(e => e.IdPayroll).HasColumnName("id_payroll");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Mnemo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("mnemo");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictPersonalAccount>(entity =>
            {
                entity.HasKey(e => e.IdPersonalAccount)
                    .HasName("PK__dict_per__C452AABF7723DA6F");

                entity.ToTable("dict_personal_account");

                entity.HasIndex(e => e.Code, "IX_personal_account_code");

                entity.Property(e => e.IdPersonalAccount).HasColumnName("id_personal_account");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Inn)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.DictPersonalAccount)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__dict_pers__id_us__122CD666");
            });

            modelBuilder.Entity<DictRemainFundsCodes>(entity =>
            {
                entity.HasKey(e => e.IdRemainFundsCodes)
                    .HasName("PK__dict_rem__33B523727A00471A");

                entity.ToTable("dict_remain_funds_codes");

                entity.Property(e => e.IdRemainFundsCodes).HasColumnName("id_remain_funds_codes");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictStatus>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__dict_sta__5D2DC6E87CDCB3C5");

                entity.ToTable("dict_status");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictSubkesr>(entity =>
            {
                entity.HasKey(e => e.IdSubkesr)
                    .HasName("PK__dict_sub__92B068AC7FB92070");

                entity.ToTable("dict_subkesr");

                entity.Property(e => e.IdSubkesr).HasColumnName("id_subkesr");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictSubprog>(entity =>
            {
                entity.HasKey(e => e.IdSubprog)
                    .HasName("PK__dict_sub__2EEEDA392290298C");

                entity.ToTable("dict_subprog");

                entity.Property(e => e.IdSubprog).HasColumnName("id_subprog");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.NameFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.NameShort)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_short");
            });

            modelBuilder.Entity<DictSubsidy>(entity =>
            {
                entity.HasKey(e => e.IdSubsidy)
                    .HasName("PK__dict_sub__CDCFB8A002958D1B");

                entity.ToTable("dict_subsidy");

                entity.HasIndex(e => e.Code, "IX_dict_subsidy_code");

                entity.Property(e => e.IdSubsidy).HasColumnName("id_subsidy");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictUserInfo>(entity =>
            {
                entity.HasKey(e => e.IdUserInfo)
                    .HasName("PK__dict_use__DB6D8AC60571F9C6");

                entity.ToTable("dict_user_info");

                entity.HasIndex(e => e.IdUser, "UQ__dict_use__D2D14636084E6671")
                    .IsUnique();

                entity.Property(e => e.IdUserInfo).HasColumnName("id_user_info");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("contact_person");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FisAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("fis_address");

                entity.Property(e => e.IdBudgType).HasColumnName("id_budg_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.IsRegistered).HasColumnName("is_registered");

                entity.Property(e => e.Tel)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("tel");

                entity.Property(e => e.Url)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.Property(e => e.YrAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("yr_address");

                entity.HasOne(d => d.IdBudgTypeNavigation)
                    .WithMany(p => p.DictUserInfo)
                    .HasForeignKey(d => d.IdBudgType)
                    .HasConstraintName("fk_dict_user_info_budg_type");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.DictUserInfo)
                    .HasForeignKey<DictUserInfo>(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dict_user__id_us__1320FA9F");
            });

            modelBuilder.Entity<DictbrMoHeadJob>(entity =>
            {
                entity.HasKey(e => e.IdMoHeadJob)
                    .HasName("PK__dictbr_m__53906E630B2AD31C");

                entity.ToTable("dictbr_mo_head_job");

                entity.Property(e => e.IdMoHeadJob).HasColumnName("id_mo_head_job");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictbrUserInfo>(entity =>
            {
                entity.HasKey(e => e.IdUserInfo)
                    .HasName("PK__dictbr_u__DB6D8AC60E073FC7");

                entity.ToTable("dictbr_user_info");

                entity.HasIndex(e => e.IdUser, "UQ__dictbr_u__D2D1463610E3AC72")
                    .IsUnique();

                entity.Property(e => e.IdUserInfo).HasColumnName("id_user_info");

                entity.Property(e => e.AddressDoc)
                    .IsRequired()
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("address_doc");

                entity.Property(e => e.AddressFact)
                    .IsRequired()
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("address_fact");

                entity.Property(e => e.Bank)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bank");

                entity.Property(e => e.Bik)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("bik");

                entity.Property(e => e.BuhEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("buh_email");

                entity.Property(e => e.BuhFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("buh_fio");

                entity.Property(e => e.BuhTel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("buh_tel");

                entity.Property(e => e.DepType).HasColumnName("dep_type");

                entity.Property(e => e.IdBcIcodeMainAdmin).HasColumnName("id_bc_icode_main_admin");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.Kpp)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("kpp");

                entity.Property(e => e.Ls)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ls");

                entity.Property(e => e.ManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("manager_email");

                entity.Property(e => e.ManagerFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("manager_fio");

                entity.Property(e => e.ManagerTel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("manager_tel");

                entity.Property(e => e.MoDeputyFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mo_deputy_fio");

                entity.Property(e => e.MoMainEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("mo_main_email");

                entity.Property(e => e.MoMainFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mo_main_fio");

                entity.Property(e => e.MoMainIoFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mo_main_io_fio");

                entity.Property(e => e.MoMainTel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mo_main_tel");

                entity.Property(e => e.Okato)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("okato");

                entity.Property(e => e.Okpo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("okpo");

                entity.Property(e => e.RespEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("resp_email");

                entity.Property(e => e.RespFio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("resp_fio");

                entity.Property(e => e.RespPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("resp_post");

                entity.Property(e => e.RespTel)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("resp_tel");

                entity.Property(e => e.Rs)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rs");

                entity.HasOne(d => d.IdBcIcodeMainAdminNavigation)
                    .WithMany(p => p.DictbrUserInfo)
                    .HasForeignKey(d => d.IdBcIcodeMainAdmin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dictbr_us__id_bc__14151ED8");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.DictbrUserInfo)
                    .HasForeignKey<DictbrUserInfo>(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dictbr_us__id_us__15094311");
            });

            modelBuilder.Entity<DictfeoBudgType>(entity =>
            {
                entity.HasKey(e => e.IdBudgType)
                    .HasName("PK__dictfeo___ABA2CEB654F51E45");

                entity.ToTable("dictfeo_budg_type");

                entity.Property(e => e.IdBudgType).HasColumnName("id_budg_type");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictfeoDocument>(entity =>
            {
                entity.HasKey(e => e.IdDocument)
                    .HasName("PK__dictfeo___D5F2A16F13C0191D");

                entity.ToTable("dictfeo_document");

                entity.Property(e => e.IdDocument).HasColumnName("id_document");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Mnemo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mnemo");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("template_name");
            });

            modelBuilder.Entity<DictfeoEconomClass>(entity =>
            {
                entity.HasKey(e => e.IdEconomClass)
                    .HasName("PK__dictfeo___B1EDAC40169C85C8");

                entity.ToTable("dictfeo_econom_class");

                entity.HasIndex(e => e.Mnemo, "IX_dictfeo_econom_class")
                    .IsUnique();

                entity.Property(e => e.IdEconomClass).HasColumnName("id_econom_class");

                entity.Property(e => e.Canedit)
                    .HasColumnName("canedit")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Haschild)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("haschild")
                    .IsFixedLength(true);

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.Mnemo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mnemo");

                entity.Property(e => e.Name)
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Optional)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("optional")
                    .IsFixedLength(true);

                entity.Property(e => e.TreeLevel)
                    .HasColumnName("tree_level")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DictfeoMinistryOrders>(entity =>
            {
                entity.HasKey(e => e.IdMinistryOrders)
                    .HasName("PK__feo_mini__8EB8EF0A30E02366");

                entity.ToTable("dictfeo_ministry_orders");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Num)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("num");
            });

            modelBuilder.Entity<DictscArrangement>(entity =>
            {
                entity.HasKey(e => e.IdArrangement)
                    .HasName("PK__dictsc_a__0D58395F1978F273");

                entity.ToTable("dictsc_arrangement");

                entity.Property(e => e.IdArrangement).HasColumnName("id_arrangement");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.NameFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.NameShort)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_short");
            });

            modelBuilder.Entity<DictscBadReason>(entity =>
            {
                entity.HasKey(e => e.IdBadReason)
                    .HasName("PK__dictsc_b__211C67641C555F1E");

                entity.ToTable("dictsc_bad_reason");

                entity.Property(e => e.IdBadReason).HasColumnName("id_bad_reason");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictscBg2Char>(entity =>
            {
                entity.HasKey(e => e.IdBg2Char)
                    .HasName("PK__dictsc_b__D49444C51F31CBC9");

                entity.ToTable("dictsc_bg2_char");

                entity.Property(e => e.IdBg2Char).HasColumnName("id_bg2_char");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictscBg3Small>(entity =>
            {
                entity.HasKey(e => e.IdBg3Small)
                    .HasName("PK__dictsc_b__C05B4659220E3874");

                entity.ToTable("dictsc_bg3_small");

                entity.Property(e => e.IdBg3Small).HasColumnName("id_bg3_small");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictscBudgUses>(entity =>
            {
                entity.HasKey(e => e.IdBudgUses)
                    .HasName("PK__dictsc_b__99967F93E1771F4E");

                entity.ToTable("dictsc_budg_uses");

                entity.Property(e => e.IdBudgUses).HasColumnName("id_budg_uses");

                entity.Property(e => e.BuyBudg)
                    .HasColumnType("money")
                    .HasColumnName("buy_budg");

                entity.Property(e => e.BuySmp)
                    .HasColumnType("money")
                    .HasColumnName("buy_smp");

                entity.Property(e => e.BuyVnebudg)
                    .HasColumnType("money")
                    .HasColumnName("buy_vnebudg");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.UsesBudg)
                    .HasColumnType("money")
                    .HasColumnName("uses_budg");

                entity.Property(e => e.UsesVnebudg)
                    .HasColumnType("money")
                    .HasColumnName("uses_vnebudg");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.DictscBudgUses)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dictsc_bu__id_us__7A6B26C5");
            });

            modelBuilder.Entity<DictscBuySize>(entity =>
            {
                entity.HasKey(e => e.IdBuySize)
                    .HasName("PK__dictsc_b__D7F3F568671F9752");

                entity.ToTable("dictsc_buy_size");

                entity.Property(e => e.IdBuySize).HasColumnName("id_buy_size");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PastYearCredit)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("past_year_credit");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.ThisYearMoney)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("this_year_money");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.DictscBuySize)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dictsc_bu__id_us__289C05C9");
            });

            modelBuilder.Entity<DictscForms>(entity =>
            {
                entity.HasKey(e => e.IdForms)
                    .HasName("PK__dictsc_f__A8D6EBC824EAA51F");

                entity.ToTable("dictsc_forms");

                entity.Property(e => e.IdForms).HasColumnName("id_forms");

                entity.Property(e => e.NameFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.NameShort)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_short");
            });

            modelBuilder.Entity<DictscOkpd>(entity =>
            {
                entity.HasKey(e => e.IdOkpd)
                    .HasName("PK__dictsc_o__50046D47E2CC620D");

                entity.ToTable("dictsc_okpd");

                entity.Property(e => e.IdOkpd).HasColumnName("id_okpd");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.Name)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictscOrderState>(entity =>
            {
                entity.HasKey(e => e.IdOrderState)
                    .HasName("PK__dictsc_o__4B0404CE27C711CA");

                entity.ToTable("dictsc_order_state");

                entity.Property(e => e.IdOrderState).HasColumnName("id_order_state");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictscPlaceForm>(entity =>
            {
                entity.HasKey(e => e.IdPlaceForm)
                    .HasName("PK__dictsc_p__5DC7E98929CF55CD");

                entity.ToTable("dictsc_place_form");

                entity.HasIndex(e => new { e.Code, e.Section }, "UQ__dictsc_p__43DF9A202CABC278")
                    .IsUnique();

                entity.Property(e => e.IdPlaceForm).HasColumnName("id_place_form");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Col10)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col10")
                    .IsFixedLength(true);

                entity.Property(e => e.Col11)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col11")
                    .IsFixedLength(true);

                entity.Property(e => e.Col12)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col12")
                    .IsFixedLength(true);

                entity.Property(e => e.Col13)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col13")
                    .IsFixedLength(true);

                entity.Property(e => e.Col14)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col14")
                    .IsFixedLength(true);

                entity.Property(e => e.Col15)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col15")
                    .IsFixedLength(true);

                entity.Property(e => e.Col16)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col16")
                    .IsFixedLength(true);

                entity.Property(e => e.Col4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col4")
                    .IsFixedLength(true);

                entity.Property(e => e.Col5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col5")
                    .IsFixedLength(true);

                entity.Property(e => e.Col6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col6")
                    .IsFixedLength(true);

                entity.Property(e => e.Col7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col7")
                    .IsFixedLength(true);

                entity.Property(e => e.Col8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col8")
                    .IsFixedLength(true);

                entity.Property(e => e.Col9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("col9")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Section).HasColumnName("section");
            });

            modelBuilder.Entity<DictscPlaceMode>(entity =>
            {
                entity.HasKey(e => e.IdPlaceMode)
                    .HasName("PK__dictsc_p__72A536A92AA37E75");

                entity.ToTable("dictsc_place_mode");

                entity.Property(e => e.IdPlaceMode).HasColumnName("id_place_mode");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.EisCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("eis_code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictscPlacingOrder>(entity =>
            {
                entity.HasKey(e => e.IdPlacingOrder)
                    .HasName("PK__dictsc_p__C72C5ECB2D7FEB20");

                entity.ToTable("dictsc_placing_order");

                entity.Property(e => e.IdPlacingOrder).HasColumnName("id_placing_order");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.IsFolder).HasColumnName("is_folder");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdParentNavigation)
                    .WithMany(p => p.InverseIdParentNavigation)
                    .HasForeignKey(d => d.IdParent)
                    .HasConstraintName("FK__dictsc_pl__id_pa__15FD674A");
            });

            modelBuilder.Entity<DictscPlanSum>(entity =>
            {
                entity.HasKey(e => e.IdPlanSum)
                    .HasName("PK__dictsc_p__D9885D14305C57CB");

                entity.ToTable("dictsc_plan_sum");

                entity.Property(e => e.IdPlanSum).HasColumnName("id_plan_sum");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.PlannedSum)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("planned_sum");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.DictscPlanSum)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dictsc_pl__id_us__16F18B83");
            });

            modelBuilder.Entity<DictscPpSourceFinance>(entity =>
            {
                entity.HasKey(e => e.IdSourceFinance)
                    .HasName("PK__dictsc_p__FBE26AC23338C476");

                entity.ToTable("dictsc_pp_source_finance");

                entity.Property(e => e.IdSourceFinance).HasColumnName("id_source_finance");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(CONVERT([date],'2010-01-01',(0)))");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictscProductionType>(entity =>
            {
                entity.HasKey(e => e.IdProductionType)
                    .HasName("PK__dictsc_p__3423207636153121");

                entity.ToTable("dictsc_production_type");

                entity.Property(e => e.IdProductionType).HasColumnName("id_production_type");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.IsFolder).HasColumnName("is_folder");

                entity.Property(e => e.NameFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.ReportOrder).HasColumnName("report_order");

                entity.HasOne(d => d.IdParentNavigation)
                    .WithMany(p => p.InverseIdParentNavigation)
                    .HasForeignKey(d => d.IdParent)
                    .HasConstraintName("FK__dictsc_pr__id_pa__17E5AFBC");
            });

            modelBuilder.Entity<DictscSettingGoods>(entity =>
            {
                entity.HasKey(e => e.IdSettingGoods)
                    .HasName("PK__dictsc_s__DAB8585B38F19DCC");

                entity.ToTable("dictsc_setting_goods");

                entity.HasIndex(e => new { e.IdUser, e.IdPeriodType, e.PeriodValue, e.PeriodYear }, "UQ__dictsc_s__383727313BCE0A77")
                    .IsUnique();

                entity.Property(e => e.IdSettingGoods).HasColumnName("id_setting_goods");

                entity.Property(e => e.GoodsSvod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("goods_svod")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.DictscSettingGoods)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dictsc_se__id_pe__18D9D3F5");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.DictscSettingGoods)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dictsc_se__id_us__19CDF82E");
            });

            modelBuilder.Entity<DictscSmallBusiness>(entity =>
            {
                entity.HasKey(e => e.IdSmallBusiness)
                    .HasName("PK__dictsc_s__DF3C478F3EAA7722");

                entity.ToTable("dictsc_small_business");

                entity.Property(e => e.IdSmallBusiness).HasColumnName("id_small_business");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.IsFolder).HasColumnName("is_folder");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdParentNavigation)
                    .WithMany(p => p.InverseIdParentNavigation)
                    .HasForeignKey(d => d.IdParent)
                    .HasConstraintName("FK__dictsc_sm__id_pa__1AC21C67");
            });

            modelBuilder.Entity<DictscSourceFinance>(entity =>
            {
                entity.HasKey(e => e.IdSourceFinance)
                    .HasName("PK__dictsc_s__FBE26AC24186E3CD");

                entity.ToTable("dictsc_source_finance");

                entity.Property(e => e.IdSourceFinance).HasColumnName("id_source_finance");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictscSupplier>(entity =>
            {
                entity.HasKey(e => e.IdSupplier)
                    .HasName("PK__dictsc_s__F6C576E644635078");

                entity.ToTable("dictsc_supplier");

                entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.HeadFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("head_fio");

                entity.Property(e => e.HeadJob)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("head_job");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Inn)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.Kpp)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("kpp");

                entity.Property(e => e.NameFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.OkopfOkfs)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("okopf_okfs");

                entity.Property(e => e.Okpo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("okpo");

                entity.Property(e => e.Oksm)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("oksm");

                entity.Property(e => e.Oktmo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("oktmo");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<DictscSupplierCopy>(entity =>
            {
                entity.HasKey(e => e.IdSupplier)
                    .HasName("PK__dictsc_s__F6C576E63B6F08E7");

                entity.ToTable("dictsc_supplier_copy");

                entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.HeadFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("head_fio");

                entity.Property(e => e.HeadJob)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("head_job");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Inn)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.Kpp)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("kpp");

                entity.Property(e => e.NameFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.OkopfOkfs)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("okopf_okfs");

                entity.Property(e => e.Okpo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("okpo");

                entity.Property(e => e.Oksm)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("oksm");

                entity.Property(e => e.Oktmo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("oktmo");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<DictscTerminatedReason>(entity =>
            {
                entity.HasKey(e => e.IdTerminatedReason)
                    .HasName("PK__dictsc_t__D9F1ABAB473FBD23");

                entity.ToTable("dictsc_terminated_reason");

                entity.Property(e => e.IdTerminatedReason).HasColumnName("id_terminated_reason");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DictscUserInfo>(entity =>
            {
                entity.HasKey(e => e.IdUserInfo)
                    .HasName("PK__dictsc_u__C19E18BB3B3CEB8B");

                entity.ToTable("dictsc_user_info");

                entity.HasIndex(e => e.IdUser, "UQ__dictsc_u__D2D146361CD12DC4")
                    .IsUnique();

                entity.Property(e => e.IdUserInfo).HasColumnName("id_user_info");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Inn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.Kpp)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("kpp");

                entity.Property(e => e.Locality)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("locality");

                entity.Property(e => e.OkopfOkfs)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("okopf_okfs");

                entity.Property(e => e.Okpo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("okpo");

                entity.Property(e => e.Oktmo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("oktmo");

                entity.Property(e => e.PublicLegal)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("public_legal");

                entity.Property(e => e.Street)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("street");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("zip_code");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.DictscUserInfo)
                    .HasForeignKey<DictscUserInfo>(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dictsc_us__id_us__66A359E3");
            });

            modelBuilder.Entity<DocDetail>(entity =>
            {
                entity.HasKey(e => e.IdDocDetail)
                    .HasName("PK__DOC_DETA__9860C8630DE74436")
                    .IsClustered(false);

                entity.ToTable("DOC_DETAIL");

                entity.Property(e => e.IdDocDetail).HasColumnName("ID_DOC_DETAIL");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("COMMENT");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATE");

                entity.Property(e => e.IdCommentType).HasColumnName("ID_COMMENT_TYPE");

                entity.Property(e => e.IdDocument).HasColumnName("ID_DOCUMENT");

                entity.Property(e => e.IdExecList).HasColumnName("ID_EXEC_LIST");

                entity.Property(e => e.IdUsers).HasColumnName("ID_USERS");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.IdDocument)
                    .HasName("PK__DOCUMENT__96AA13B811B7D51A")
                    .IsClustered(false);

                entity.ToTable("DOCUMENT");

                entity.Property(e => e.IdDocument).HasColumnName("ID_DOCUMENT");

                entity.Property(e => e.Deadline)
                    .HasColumnType("datetime")
                    .HasColumnName("DEADLINE");

                entity.Property(e => e.DocDateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("DOC_DATE_CREATE");

                entity.Property(e => e.DocDateExecute)
                    .HasColumnType("datetime")
                    .HasColumnName("DOC_DATE_EXECUTE");

                entity.Property(e => e.DocNumber).HasColumnName("DOC_NUMBER");

                entity.Property(e => e.Expered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXPERED")
                    .HasDefaultValueSql("(N'0')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdExecList).HasColumnName("ID_EXEC_LIST");

                entity.Property(e => e.IdPriority).HasColumnName("ID_PRIORITY");

                entity.Property(e => e.IdReminderType).HasColumnName("ID_REMINDER_TYPE");

                entity.Property(e => e.IdStatus).HasColumnName("ID_STATUS");

                entity.Property(e => e.IdUsers).HasColumnName("ID_USERS");

                entity.Property(e => e.ShotOrder)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("SHOT_ORDER");
            });

            modelBuilder.Entity<DocumentFileList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DOCUMENT_FILE_LIST");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("COMMENT");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasColumnName("FILENAME");

                entity.Property(e => e.IdDocDetail).HasColumnName("ID_DOC_DETAIL");

                entity.Property(e => e.IdDocumentFileList)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_DOCUMENT_FILE_LIST");
            });

            modelBuilder.Entity<DsuComment>(entity =>
            {
                entity.HasKey(e => e.IdComment)
                    .HasName("PK__dsu_comm__7E14AC8503498E59");

                entity.ToTable("dsu_comment");

                entity.Property(e => e.IdComment).HasColumnName("id_comment");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.IdRequest).HasColumnName("id_request");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Text)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("text");

                entity.HasOne(d => d.IdRequestNavigation)
                    .WithMany(p => p.DsuComment)
                    .HasForeignKey(d => d.IdRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dsu_comme__id_re__169D511F");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.DsuComment)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dsu_comme__id_st__18859991");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.DsuComment)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dsu_comme__id_us__17917558");
            });

            modelBuilder.Entity<DsuRequest>(entity =>
            {
                entity.HasKey(e => e.IdRequest)
                    .HasName("PK__dsu_requ__7ADC39FC52E3114A");

                entity.ToTable("dsu_request");

                entity.Property(e => e.IdRequest).HasColumnName("id_request");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.DateCreate).HasColumnName("date_create");

                entity.Property(e => e.DeliveryDate)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("delivery_date");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdPayTurn).HasColumnName("id_pay_turn");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OtherThings)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("other_things");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.PlaceAndWay)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("place_and_way");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Reason)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.WarrantyDate).HasColumnName("warranty_date");

                entity.Property(e => e.WithNds)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("with_nds")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.DsuRequest)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dsu_reque__id_me__613564A7");

                entity.HasOne(d => d.IdPayTurnNavigation)
                    .WithMany(p => p.DsuRequest)
                    .HasForeignKey(d => d.IdPayTurn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dsu_reque__id_pa__622988E0");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.DsuRequest)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dsu_reque__id_st__6505F58B");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.DsuRequest)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dsu_reque__id_us__6411D152");
            });

            modelBuilder.Entity<DsuRequestFile>(entity =>
            {
                entity.HasKey(e => e.IdRequestFile)
                    .HasName("PK__dsu_requ__DC932E5BC0400224");

                entity.ToTable("dsu_request_file");

                entity.Property(e => e.IdRequestFile).HasColumnName("id_request_file");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileData)
                    .IsRequired()
                    .HasColumnName("file_data");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("file_name");

                entity.Property(e => e.IdRequest).HasColumnName("id_request");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdRequestNavigation)
                    .WithMany(p => p.DsuRequestFile)
                    .HasForeignKey(d => d.IdRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dsu_reque__id_re__6F8383FE");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.DsuRequestFile)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dsu_reque__id_us__7077A837");
            });

            modelBuilder.Entity<ExecList>(entity =>
            {
                entity.HasKey(e => e.IdExecList)
                    .HasName("PK__EXEC_LIS__C4752A1A1864D2A9");

                entity.ToTable("EXEC_LIST");

                entity.Property(e => e.IdExecList).HasColumnName("ID_EXEC_LIST");

                entity.Property(e => e.IdChild).HasColumnName("ID_CHILD");

                entity.Property(e => e.IdDocument).HasColumnName("ID_DOCUMENT");

                entity.Property(e => e.IdStatus).HasColumnName("ID_STATUS");

                entity.Property(e => e.IdUsers).HasColumnName("ID_USERS");

                entity.Property(e => e.NextRemind)
                    .HasColumnType("datetime")
                    .HasColumnName("NEXT_REMIND");

                entity.Property(e => e.Remind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REMIND")
                    .HasDefaultValueSql("(N'0')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<FeoActivities>(entity =>
            {
                entity.HasKey(e => e.IdActivities)
                    .HasName("PK__feo_acti__01233F835CBC9C64");

                entity.ToTable("feo_activities");

                entity.Property(e => e.IdActivities).HasColumnName("id_activities");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.IdActivitiesClass).HasColumnName("id_activities_class");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.HasOne(d => d.IdActivitiesClassNavigation)
                    .WithMany(p => p.FeoActivities)
                    .HasForeignKey(d => d.IdActivitiesClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_activ__id_ac__2A6452AA");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoActivities)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_activ__id_us__2B5876E3");
            });

            modelBuilder.Entity<FeoActivitiesClass>(entity =>
            {
                entity.HasKey(e => e.IdActivitiesClass)
                    .HasName("PK__feo_acti__A3353D834E2C392A");

                entity.ToTable("feo_activities_class");

                entity.Property(e => e.IdActivitiesClass).HasColumnName("id_activities_class");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FeoAssets>(entity =>
            {
                entity.HasKey(e => e.IdAssets)
                    .HasName("PK__feo_asse__C90A3316D18D4A47");

                entity.ToTable("feo_assets");

                entity.Property(e => e.IdAssets).HasColumnName("id_assets");

                entity.Property(e => e.AssetsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("assets_date");

                entity.Property(e => e.AssetsNum).HasColumnName("assets_num");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("price");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoAssets)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__feo_asset__id_us__5C7AD12B");
            });

            modelBuilder.Entity<FeoAssets2016>(entity =>
            {
                entity.HasKey(e => e.IdAssets2016)
                    .HasName("PK__feo_asse__FD97561CE15889CA");

                entity.ToTable("feo_assets2016");

                entity.Property(e => e.IdAssets2016).HasColumnName("id_assets2016");

                entity.Property(e => e.CapInvest)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("cap_invest");

                entity.Property(e => e.GosQuest)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("gos_quest");

                entity.Property(e => e.IdAssets2016Class).HasColumnName("id_assets2016_class");

                entity.Property(e => e.IdBudgClass2016).HasColumnName("id_budg_class2016");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.OtherSourceGrant)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_source_grant");

                entity.Property(e => e.OtherSourceSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_source_sum");

                entity.Property(e => e.OtherSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_sum");

                entity.Property(e => e.OtherSumDet)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_sum_det");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumFull)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("sum_full");

                entity.HasOne(d => d.IdAssets2016ClassNavigation)
                    .WithMany(p => p.FeoAssets2016)
                    .HasForeignKey(d => d.IdAssets2016Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_asset__id_as__7F44EA7B");

                entity.HasOne(d => d.IdBudgClass2016Navigation)
                    .WithMany(p => p.FeoAssets2016)
                    .HasForeignKey(d => d.IdBudgClass2016)
                    .HasConstraintName("FK__feo_asset__id_bu__3C4DF8BB");

                entity.HasOne(d => d.IdMinistryOrdersNavigation)
                    .WithMany(p => p.FeoAssets2016)
                    .HasForeignKey(d => d.IdMinistryOrders)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_asset__id_mi__00390EB4");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoAssets2016)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__feo_asset__id_st__69209F32");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoAssets2016)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_asset__id_us__7E50C642");
            });

            modelBuilder.Entity<FeoAssets2016Class>(entity =>
            {
                entity.HasKey(e => e.IdAssets2016Class)
                    .HasName("PK__feo_asse__ED5883B5ADCE0573");

                entity.ToTable("feo_assets2016_class");

                entity.Property(e => e.IdAssets2016Class).HasColumnName("id_assets2016_class");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.IdFhdClass).HasColumnName("id_fhd_class");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FeoAssets2016Detail>(entity =>
            {
                entity.HasKey(e => e.IdAssets2016Detail)
                    .HasName("PK__feo_asse__21A4C4C464FF3DC2");

                entity.ToTable("feo_assets2016_detail");

                entity.Property(e => e.IdAssets2016Detail).HasColumnName("id_assets2016_detail");

                entity.Property(e => e.IdAssets2016).HasColumnName("id_assets2016");

                entity.Property(e => e.IdFhd2016Class).HasColumnName("id_fhd2016_class");

                entity.Property(e => e.Sum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("sum");

                entity.HasOne(d => d.IdAssets2016Navigation)
                    .WithMany(p => p.FeoAssets2016Detail)
                    .HasForeignKey(d => d.IdAssets2016)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_asset__id_as__03157B5F");

                entity.HasOne(d => d.IdFhd2016ClassNavigation)
                    .WithMany(p => p.FeoAssets2016Detail)
                    .HasForeignKey(d => d.IdFhd2016Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_asset__id_fh__04099F98");
            });

            modelBuilder.Entity<FeoAssets2016Kosgu>(entity =>
            {
                entity.HasKey(e => e.IdAssets2016Kosgu)
                    .HasName("PK__feo_asse__1E6C2BCD4736F770");

                entity.ToTable("feo_assets2016_kosgu");

                entity.Property(e => e.IdAssets2016Kosgu).HasColumnName("id_assets2016_kosgu");

                entity.Property(e => e.CapInvest)
                    .HasColumnType("money")
                    .HasColumnName("cap_invest");

                entity.Property(e => e.GosQuest)
                    .HasColumnType("money")
                    .HasColumnName("gos_quest");

                entity.Property(e => e.IdAssets2016).HasColumnName("id_assets2016");

                entity.Property(e => e.IdEconomClass).HasColumnName("id_econom_class");

                entity.Property(e => e.OtherSourceGrant)
                    .HasColumnType("money")
                    .HasColumnName("other_source_grant");

                entity.Property(e => e.OtherSourceSum)
                    .HasColumnType("money")
                    .HasColumnName("other_source_sum");

                entity.HasOne(d => d.IdAssets2016Navigation)
                    .WithMany(p => p.FeoAssets2016Kosgu)
                    .HasForeignKey(d => d.IdAssets2016)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_asset__id_as__6EA46E5E");

                entity.HasOne(d => d.IdEconomClassNavigation)
                    .WithMany(p => p.FeoAssets2016Kosgu)
                    .HasForeignKey(d => d.IdEconomClass)
                    .HasConstraintName("FK__feo_asset__id_ec__6DB04A25");
            });

            modelBuilder.Entity<FeoAssetsClass>(entity =>
            {
                entity.HasKey(e => e.IdAssetsClass)
                    .HasName("PK__feo_asse__6759EDE1E880EF6D");

                entity.ToTable("feo_assets_class");

                entity.Property(e => e.IdAssetsClass).HasColumnName("id_assets_class");

                entity.Property(e => e.CanEdit).HasColumnName("can_edit");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.Mnemo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mnemo");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.TreeLevel).HasColumnName("tree_level");
            });

            modelBuilder.Entity<FeoAssetsDetail>(entity =>
            {
                entity.HasKey(e => e.IdAssetsDetail)
                    .HasName("PK__feo_asse__D99E7BE843697968");

                entity.ToTable("feo_assets_detail");

                entity.Property(e => e.IdAssetsDetail).HasColumnName("id_assets_detail");

                entity.Property(e => e.AssetsSum)
                    .HasColumnType("money")
                    .HasColumnName("assets_sum");

                entity.Property(e => e.IdAssets).HasColumnName("id_assets");

                entity.Property(e => e.IdAssetsClass).HasColumnName("id_assets_class");

                entity.HasOne(d => d.IdAssetsNavigation)
                    .WithMany(p => p.FeoAssetsDetail)
                    .HasForeignKey(d => d.IdAssets)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_asset__id_as__1400103F");
            });

            modelBuilder.Entity<FeoAssetsLine>(entity =>
            {
                entity.HasKey(e => e.IdAssetsLine)
                    .HasName("PK__feo_asse__53E338162AE60EB7");

                entity.ToTable("feo_assets_line");

                entity.Property(e => e.IdAssetsLine).HasColumnName("id_assets_line");

                entity.Property(e => e.AssetsSum)
                    .HasColumnType("money")
                    .HasColumnName("assets_sum");

                entity.Property(e => e.IdAssetsClass).HasColumnName("id_assets_class");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoAssetsLine)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_asset__id_us__2E49F227");
            });

            modelBuilder.Entity<FeoBudgClass2016>(entity =>
            {
                entity.HasKey(e => e.IdBudgClass2016)
                    .HasName("PK__feo_budg__4ECD50D2FED1B00E");

                entity.ToTable("feo_budg_class2016");

                entity.Property(e => e.IdBudgClass2016).HasColumnName("id_budg_class2016");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FeoCassMove>(entity =>
            {
                entity.HasKey(e => e.IdCassMove)
                    .HasName("PK__feo_cass__82A71FD64A1C29CE");

                entity.ToTable("feo_cass_move");

                entity.Property(e => e.IdCassMove).HasColumnName("id_cass_move");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("approve_date");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_create")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModify)
                    .HasColumnType("datetime")
                    .HasColumnName("date_modify");

                entity.Property(e => e.DocNumber).HasColumnName("doc_number");

                entity.Property(e => e.Executor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("executor");

                entity.Property(e => e.IdAimedmeans).HasColumnName("id_aimedmeans");

                entity.Property(e => e.IdArrangement).HasColumnName("id_arrangement");

                entity.Property(e => e.IdCoatValues).HasColumnName("id_coat_values");

                entity.Property(e => e.IdDirection).HasColumnName("id_direction");

                entity.Property(e => e.IdDocument).HasColumnName("id_document");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPersonalAccount).HasColumnName("id_personal_account");

                entity.Property(e => e.IdSourceFinance).HasColumnName("id_source_finance");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdSubsidy).HasColumnName("id_subsidy");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodYear)
                    .HasColumnName("period_year")
                    .HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("price");

                entity.Property(e => e.RejectionReason)
                    .HasColumnType("text")
                    .HasColumnName("rejection_reason");

                entity.HasOne(d => d.IdAimedmeansNavigation)
                    .WithMany(p => p.FeoCassMove)
                    .HasForeignKey(d => d.IdAimedmeans)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_ai__1CAA64D9");

                entity.HasOne(d => d.IdArrangementNavigation)
                    .WithMany(p => p.FeoCassMove)
                    .HasForeignKey(d => d.IdArrangement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_ar__1D9E8912");

                entity.HasOne(d => d.IdCoatValuesNavigation)
                    .WithMany(p => p.FeoCassMove)
                    .HasForeignKey(d => d.IdCoatValues)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_co__1E92AD4B");

                entity.HasOne(d => d.IdDirectionNavigation)
                    .WithMany(p => p.FeoCassMove)
                    .HasForeignKey(d => d.IdDirection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_di__1F86D184");

                entity.HasOne(d => d.IdDocumentNavigation)
                    .WithMany(p => p.FeoCassMove)
                    .HasForeignKey(d => d.IdDocument)
                    .HasConstraintName("FK__feo_cass___id_do__207AF5BD");

                entity.HasOne(d => d.IdPersonalAccountNavigation)
                    .WithMany(p => p.FeoCassMove)
                    .HasForeignKey(d => d.IdPersonalAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_pe__216F19F6");

                entity.HasOne(d => d.IdSourceFinanceNavigation)
                    .WithMany(p => p.FeoCassMove)
                    .HasForeignKey(d => d.IdSourceFinance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_so__22633E2F");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoCassMove)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_st__23576268");

                entity.HasOne(d => d.IdSubsidyNavigation)
                    .WithMany(p => p.FeoCassMove)
                    .HasForeignKey(d => d.IdSubsidy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_su__244B86A1");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoCassMove)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_us__253FAADA");
            });

            modelBuilder.Entity<FeoCassMoveDetail>(entity =>
            {
                entity.HasKey(e => e.IdCassMoveDetail)
                    .HasName("PK__feo_cass__778B14504DECBAB2");

                entity.ToTable("feo_cass_move_detail");

                entity.Property(e => e.IdCassMoveDetail).HasColumnName("id_cass_move_detail");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.Amount1)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("amount1");

                entity.Property(e => e.Amount2)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("amount2");

                entity.Property(e => e.Amount3)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("amount3");

                entity.Property(e => e.IdCassMove).HasColumnName("id_cass_move");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.HasOne(d => d.IdCassMoveNavigation)
                    .WithMany(p => p.FeoCassMoveDetail)
                    .HasForeignKey(d => d.IdCassMove)
                    .HasConstraintName("FK__feo_cass___id_ca__2633CF13");
            });

            modelBuilder.Entity<FeoCassPlan>(entity =>
            {
                entity.HasKey(e => e.IdCassPlan)
                    .HasName("PK__feo_cass__585FD94F50C9275D");

                entity.ToTable("feo_cass_plan");

                entity.Property(e => e.IdCassPlan).HasColumnName("id_cass_plan");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("approve_date");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_create")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModify)
                    .HasColumnType("datetime")
                    .HasColumnName("date_modify");

                entity.Property(e => e.DocNumber).HasColumnName("doc_number");

                entity.Property(e => e.Executor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("executor");

                entity.Property(e => e.IdAimedmeans).HasColumnName("id_aimedmeans");

                entity.Property(e => e.IdArrangement).HasColumnName("id_arrangement");

                entity.Property(e => e.IdCoatValues).HasColumnName("id_coat_values");

                entity.Property(e => e.IdDirection).HasColumnName("id_direction");

                entity.Property(e => e.IdDocument).HasColumnName("id_document");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPersonalAccount).HasColumnName("id_personal_account");

                entity.Property(e => e.IdSourceFinance).HasColumnName("id_source_finance");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdSubsidy).HasColumnName("id_subsidy");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.InterfaceType).HasColumnName("interface_type");

                entity.Property(e => e.PeriodYear)
                    .HasColumnName("period_year")
                    .HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("price");

                entity.Property(e => e.RejectionReason)
                    .HasColumnType("text")
                    .HasColumnName("rejection_reason");

                entity.HasOne(d => d.IdAimedmeansNavigation)
                    .WithMany(p => p.FeoCassPlan)
                    .HasForeignKey(d => d.IdAimedmeans)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_ai__2727F34C");

                entity.HasOne(d => d.IdArrangementNavigation)
                    .WithMany(p => p.FeoCassPlan)
                    .HasForeignKey(d => d.IdArrangement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_ar__281C1785");

                entity.HasOne(d => d.IdCoatValuesNavigation)
                    .WithMany(p => p.FeoCassPlan)
                    .HasForeignKey(d => d.IdCoatValues)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_co__29103BBE");

                entity.HasOne(d => d.IdDirectionNavigation)
                    .WithMany(p => p.FeoCassPlan)
                    .HasForeignKey(d => d.IdDirection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_di__2A045FF7");

                entity.HasOne(d => d.IdDocumentNavigation)
                    .WithMany(p => p.FeoCassPlan)
                    .HasForeignKey(d => d.IdDocument)
                    .HasConstraintName("FK__feo_cass___id_do__2AF88430");

                entity.HasOne(d => d.IdPersonalAccountNavigation)
                    .WithMany(p => p.FeoCassPlan)
                    .HasForeignKey(d => d.IdPersonalAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_pe__2BECA869");

                entity.HasOne(d => d.IdSourceFinanceNavigation)
                    .WithMany(p => p.FeoCassPlan)
                    .HasForeignKey(d => d.IdSourceFinance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_so__2CE0CCA2");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoCassPlan)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_st__2DD4F0DB");

                entity.HasOne(d => d.IdSubsidyNavigation)
                    .WithMany(p => p.FeoCassPlan)
                    .HasForeignKey(d => d.IdSubsidy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_su__2EC91514");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoCassPlan)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_cass___id_us__2FBD394D");
            });

            modelBuilder.Entity<FeoCassPlanDetail>(entity =>
            {
                entity.HasKey(e => e.IdCassPlanDetail)
                    .HasName("PK__feo_cass__79C1DCF15499B841");

                entity.ToTable("feo_cass_plan_detail");

                entity.Property(e => e.IdCassPlanDetail).HasColumnName("id_cass_plan_detail");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.Amount1)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("amount1");

                entity.Property(e => e.Amount2)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("amount2");

                entity.Property(e => e.Amount3)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("amount3");

                entity.Property(e => e.IdCassPlan).HasColumnName("id_cass_plan");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.HasOne(d => d.IdCassPlanNavigation)
                    .WithMany(p => p.FeoCassPlanDetail)
                    .HasForeignKey(d => d.IdCassPlan)
                    .HasConstraintName("FK__feo_cass___id_ca__30B15D86");
            });

            modelBuilder.Entity<FeoDefault>(entity =>
            {
                entity.HasKey(e => e.IdDefault)
                    .HasName("PK__feo_defa__21AABDBE577624EC");

                entity.ToTable("feo_default");

                entity.Property(e => e.IdDefault).HasColumnName("id_default");

                entity.Property(e => e.IdAimedmeans).HasColumnName("id_aimedmeans");

                entity.Property(e => e.IdArrangement).HasColumnName("id_arrangement");

                entity.Property(e => e.IdCoatValues).HasColumnName("id_coat_values");

                entity.Property(e => e.IdDirection).HasColumnName("id_direction");

                entity.Property(e => e.IdDocument).HasColumnName("id_document");

                entity.Property(e => e.IdPersonalAccount).HasColumnName("id_personal_account");

                entity.Property(e => e.IdSourceFinance).HasColumnName("id_source_finance");

                entity.Property(e => e.IdSubsidy).HasColumnName("id_subsidy");

                entity.Property(e => e.InterfaceNum).HasColumnName("interface_num");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdAimedmeansNavigation)
                    .WithMany(p => p.FeoDefault)
                    .HasForeignKey(d => d.IdAimedmeans)
                    .HasConstraintName("FK__feo_defau__id_ai__31A581BF");

                entity.HasOne(d => d.IdArrangementNavigation)
                    .WithMany(p => p.FeoDefault)
                    .HasForeignKey(d => d.IdArrangement)
                    .HasConstraintName("FK__feo_defau__id_ar__3299A5F8");

                entity.HasOne(d => d.IdCoatValuesNavigation)
                    .WithMany(p => p.FeoDefault)
                    .HasForeignKey(d => d.IdCoatValues)
                    .HasConstraintName("FK__feo_defau__id_co__338DCA31");

                entity.HasOne(d => d.IdDirectionNavigation)
                    .WithMany(p => p.FeoDefault)
                    .HasForeignKey(d => d.IdDirection)
                    .HasConstraintName("FK__feo_defau__id_di__3481EE6A");

                entity.HasOne(d => d.IdDocumentNavigation)
                    .WithMany(p => p.FeoDefault)
                    .HasForeignKey(d => d.IdDocument)
                    .HasConstraintName("FK__feo_defau__id_do__357612A3");

                entity.HasOne(d => d.IdPersonalAccountNavigation)
                    .WithMany(p => p.FeoDefault)
                    .HasForeignKey(d => d.IdPersonalAccount)
                    .HasConstraintName("FK__feo_defau__id_pe__366A36DC");

                entity.HasOne(d => d.IdSourceFinanceNavigation)
                    .WithMany(p => p.FeoDefault)
                    .HasForeignKey(d => d.IdSourceFinance)
                    .HasConstraintName("FK__feo_defau__id_so__375E5B15");

                entity.HasOne(d => d.IdSubsidyNavigation)
                    .WithMany(p => p.FeoDefault)
                    .HasForeignKey(d => d.IdSubsidy)
                    .HasConstraintName("FK__feo_defau__id_su__38527F4E");
            });

            modelBuilder.Entity<FeoEstimate>(entity =>
            {
                entity.HasKey(e => e.IdEstimate)
                    .HasName("PK__feo_esti__42E4F0855A529197");

                entity.ToTable("feo_estimate");

                entity.HasIndex(e => e.IdMo, "IX_FK_feo_estimate_dict_mo");

                entity.HasIndex(e => e.IdSourceFinance, "IX_FK_feo_estimate_dict_source");

                entity.HasIndex(e => e.IdStatus, "IX_FK_feo_estimate_dict_status");

                entity.Property(e => e.IdEstimate).HasColumnName("id_estimate");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("approve_date");

                entity.Property(e => e.Comment)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_create")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModify)
                    .HasColumnType("datetime")
                    .HasColumnName("date_modify");

                entity.Property(e => e.DocNumber).HasColumnName("doc_number");

                entity.Property(e => e.Executor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("executor");

                entity.Property(e => e.IdAimedmeans).HasColumnName("id_aimedmeans");

                entity.Property(e => e.IdArrangement).HasColumnName("id_arrangement");

                entity.Property(e => e.IdCoatValues).HasColumnName("id_coat_values");

                entity.Property(e => e.IdDirection).HasColumnName("id_direction");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPersonalAccount).HasColumnName("id_personal_account");

                entity.Property(e => e.IdSourceFinance).HasColumnName("id_source_finance");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdSubkesr).HasColumnName("id_subkesr");

                entity.Property(e => e.IdSubprog).HasColumnName("id_subprog");

                entity.Property(e => e.IdSubsidy).HasColumnName("id_subsidy");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodYear)
                    .HasColumnName("period_year")
                    .HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("price");

                entity.Property(e => e.RejectionReason)
                    .HasColumnType("text")
                    .HasColumnName("rejection_reason");

                entity.HasOne(d => d.IdAimedmeansNavigation)
                    .WithMany(p => p.FeoEstimate)
                    .HasForeignKey(d => d.IdAimedmeans)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_ai__3946A387");

                entity.HasOne(d => d.IdArrangementNavigation)
                    .WithMany(p => p.FeoEstimate)
                    .HasForeignKey(d => d.IdArrangement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_ar__3A3AC7C0");

                entity.HasOne(d => d.IdCoatValuesNavigation)
                    .WithMany(p => p.FeoEstimate)
                    .HasForeignKey(d => d.IdCoatValues)
                    .HasConstraintName("FK__feo_estim__id_co__3B2EEBF9");

                entity.HasOne(d => d.IdDirectionNavigation)
                    .WithMany(p => p.FeoEstimate)
                    .HasForeignKey(d => d.IdDirection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_di__3C231032");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.FeoEstimate)
                    .HasForeignKey(d => d.IdMo)
                    .HasConstraintName("FK__feo_estim__id_mo__3D17346B");

                entity.HasOne(d => d.IdPersonalAccountNavigation)
                    .WithMany(p => p.FeoEstimate)
                    .HasForeignKey(d => d.IdPersonalAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_pe__3E0B58A4");

                entity.HasOne(d => d.IdSourceFinanceNavigation)
                    .WithMany(p => p.FeoEstimate)
                    .HasForeignKey(d => d.IdSourceFinance)
                    .HasConstraintName("FK__feo_estim__id_so__3EFF7CDD");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoEstimate)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_st__3FF3A116");

                entity.HasOne(d => d.IdSubprogNavigation)
                    .WithMany(p => p.FeoEstimate)
                    .HasForeignKey(d => d.IdSubprog)
                    .HasConstraintName("FK__feo_estim__id_su__27B20331");

                entity.HasOne(d => d.IdSubsidyNavigation)
                    .WithMany(p => p.FeoEstimate)
                    .HasForeignKey(d => d.IdSubsidy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_su__40E7C54F");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoEstimate)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_us__41DBE988");
            });

            modelBuilder.Entity<FeoEstimateDetail>(entity =>
            {
                entity.HasKey(e => e.IdEstimateDetail)
                    .HasName("PK__feo_esti__59797C325E23227B");

                entity.ToTable("feo_estimate_detail");

                entity.Property(e => e.IdEstimateDetail).HasColumnName("id_estimate_detail");

                entity.Property(e => e.DateModify)
                    .HasColumnType("date")
                    .HasColumnName("date_modify")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdEconomClass).HasColumnName("id_econom_class");

                entity.Property(e => e.IdEstimate).HasColumnName("id_estimate");

                entity.Property(e => e.PlanSum)
                    .HasColumnType("money")
                    .HasColumnName("plan_sum");

                entity.Property(e => e.PlanSum1)
                    .HasColumnType("money")
                    .HasColumnName("plan_sum_1");

                entity.Property(e => e.PlanSum2)
                    .HasColumnType("money")
                    .HasColumnName("plan_sum_2");

                entity.HasOne(d => d.IdEconomClassNavigation)
                    .WithMany(p => p.FeoEstimateDetail)
                    .HasForeignKey(d => d.IdEconomClass)
                    .HasConstraintName("FK__feo_estim__id_ec__42D00DC1");

                entity.HasOne(d => d.IdEstimateNavigation)
                    .WithMany(p => p.FeoEstimateDetail)
                    .HasForeignKey(d => d.IdEstimate)
                    .HasConstraintName("FK__feo_estim__id_es__43C431FA");
            });

            modelBuilder.Entity<FeoEstimateMove>(entity =>
            {
                entity.HasKey(e => e.IdEstimateMove)
                    .HasName("PK__feo_esti__FD6C605960FF8F26");

                entity.ToTable("feo_estimate_move");

                entity.Property(e => e.IdEstimateMove).HasColumnName("id_estimate_move");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("date")
                    .HasColumnName("approve_date");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_create")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModify)
                    .HasColumnType("datetime")
                    .HasColumnName("date_modify");

                entity.Property(e => e.DocNumber).HasColumnName("doc_number");

                entity.Property(e => e.Executor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("executor");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdSubprog).HasColumnName("id_subprog");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Letter)
                    .HasColumnType("text")
                    .HasColumnName("letter");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("order_number");

                entity.Property(e => e.PeriodYear)
                    .HasColumnName("period_year")
                    .HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("price");

                entity.Property(e => e.RejectionReason)
                    .HasColumnType("text")
                    .HasColumnName("rejection_reason");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoEstimateMove)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_st__44B85633");

                entity.HasOne(d => d.IdSubprogNavigation)
                    .WithMany(p => p.FeoEstimateMove)
                    .HasForeignKey(d => d.IdSubprog)
                    .HasConstraintName("FK__feo_estim__id_su__28A6276A");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoEstimateMove)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_us__45AC7A6C");
            });

            modelBuilder.Entity<FeoEstimateMoveDetail>(entity =>
            {
                entity.HasKey(e => e.IdEstimateMoveDetail)
                    .HasName("PK__feo_esti__D3F08D2A64D0200A");

                entity.ToTable("feo_estimate_move_detail");

                entity.Property(e => e.IdEstimateMoveDetail).HasColumnName("id_estimate_move_detail");

                entity.Property(e => e.IdAimedmeans).HasColumnName("id_aimedmeans");

                entity.Property(e => e.IdArrangement).HasColumnName("id_arrangement");

                entity.Property(e => e.IdCoatValues).HasColumnName("id_coat_values");

                entity.Property(e => e.IdDirection).HasColumnName("id_direction");

                entity.Property(e => e.IdEconomClass).HasColumnName("id_econom_class");

                entity.Property(e => e.IdEstimateMove).HasColumnName("id_estimate_move");

                entity.Property(e => e.IdPersonalAccount).HasColumnName("id_personal_account");

                entity.Property(e => e.IdSourceFinance).HasColumnName("id_source_finance");

                entity.Property(e => e.IdSubsidy).HasColumnName("id_subsidy");

                entity.Property(e => e.MoveSum)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("move_sum");

                entity.HasOne(d => d.IdAimedmeansNavigation)
                    .WithMany(p => p.FeoEstimateMoveDetail)
                    .HasForeignKey(d => d.IdAimedmeans)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_ai__46A09EA5");

                entity.HasOne(d => d.IdArrangementNavigation)
                    .WithMany(p => p.FeoEstimateMoveDetail)
                    .HasForeignKey(d => d.IdArrangement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_ar__4794C2DE");

                entity.HasOne(d => d.IdCoatValuesNavigation)
                    .WithMany(p => p.FeoEstimateMoveDetail)
                    .HasForeignKey(d => d.IdCoatValues)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_co__4888E717");

                entity.HasOne(d => d.IdDirectionNavigation)
                    .WithMany(p => p.FeoEstimateMoveDetail)
                    .HasForeignKey(d => d.IdDirection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_di__497D0B50");

                entity.HasOne(d => d.IdEconomClassNavigation)
                    .WithMany(p => p.FeoEstimateMoveDetail)
                    .HasForeignKey(d => d.IdEconomClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_ec__4A712F89");

                entity.HasOne(d => d.IdEstimateMoveNavigation)
                    .WithMany(p => p.FeoEstimateMoveDetail)
                    .HasForeignKey(d => d.IdEstimateMove)
                    .HasConstraintName("FK__feo_estim__id_es__4B6553C2");

                entity.HasOne(d => d.IdPersonalAccountNavigation)
                    .WithMany(p => p.FeoEstimateMoveDetail)
                    .HasForeignKey(d => d.IdPersonalAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_pe__4C5977FB");

                entity.HasOne(d => d.IdSourceFinanceNavigation)
                    .WithMany(p => p.FeoEstimateMoveDetail)
                    .HasForeignKey(d => d.IdSourceFinance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_so__4D4D9C34");

                entity.HasOne(d => d.IdSubsidyNavigation)
                    .WithMany(p => p.FeoEstimateMoveDetail)
                    .HasForeignKey(d => d.IdSubsidy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_estim__id_su__4E41C06D");
            });

            modelBuilder.Entity<FeoFhd2016Class>(entity =>
            {
                entity.HasKey(e => e.IdFhd2016Class)
                    .HasName("PK__feo_rema__B6C7E640B0FE9FD1");

                entity.ToTable("feo_fhd2016_class");

                entity.Property(e => e.IdFhd2016Class).HasColumnName("id_fhd2016_class");

                entity.Property(e => e.Code)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FeoFhdmove2016>(entity =>
            {
                entity.HasKey(e => e.IdFhdmove2016)
                    .HasName("PK__feo_fhdm__9CD6252B497BA53C");

                entity.ToTable("feo_fhdmove2016");

                entity.Property(e => e.IdFhdmove2016).HasColumnName("id_fhdmove2016");

                entity.Property(e => e.Comment)
                    .HasMaxLength(2555)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.IdEconomClass).HasColumnName("id_econom_class");

                entity.Property(e => e.IdFhdClass).HasColumnName("id_fhd_class");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.MoveSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("move_sum");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.HasOne(d => d.IdEconomClassNavigation)
                    .WithMany(p => p.FeoFhdmove2016)
                    .HasForeignKey(d => d.IdEconomClass)
                    .HasConstraintName("FK__feo_fhdmo__id_ec__3C18EE91");

                entity.HasOne(d => d.IdMinistryOrdersNavigation)
                    .WithMany(p => p.FeoFhdmove2016)
                    .HasForeignKey(d => d.IdMinistryOrders)
                    .HasConstraintName("FK__feo_fhdmo__id_mi__3B24CA58");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoFhdmove2016)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__feo_fhdmo__id_st__393C81E6");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoFhdmove2016)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_fhdmo__id_us__3A30A61F");
            });

            modelBuilder.Entity<FeoFinPos2016>(entity =>
            {
                entity.HasKey(e => e.IdFinPos2016)
                    .HasName("PK__feo_fin___8DCA29C336B5039A");

                entity.ToTable("feo_fin_pos2016");

                entity.Property(e => e.IdFinPos2016).HasColumnName("id_fin_pos2016");

                entity.Property(e => e.IdFinPos2016Class).HasColumnName("id_fin_pos2016_class");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.Sum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("sum");

                entity.HasOne(d => d.IdFinPos2016ClassNavigation)
                    .WithMany(p => p.FeoFinPos2016)
                    .HasForeignKey(d => d.IdFinPos2016Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_fin_p__id_fi__7B3F4F6D");

                entity.HasOne(d => d.IdMinistryOrdersNavigation)
                    .WithMany(p => p.FeoFinPos2016)
                    .HasForeignKey(d => d.IdMinistryOrders)
                    .HasConstraintName("FK__feo_fin_p__id_mi__7A4B2B34");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoFinPos2016)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__feo_fin_p__id_st__7C3373A6");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoFinPos2016)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_fin_p__id_us__7D2797DF");
            });

            modelBuilder.Entity<FeoFinPos2016Class>(entity =>
            {
                entity.HasKey(e => e.IdFinPos2016Class)
                    .HasName("PK__feo_fin___DF82E26B296F0905");

                entity.ToTable("feo_fin_pos2016_class");

                entity.Property(e => e.IdFinPos2016Class).HasColumnName("id_fin_pos2016_class");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FeoLiabilities>(entity =>
            {
                entity.HasKey(e => e.IdLiabilities)
                    .HasName("PK__feo_liab__44A6B6E5E7E7D680");

                entity.ToTable("feo_liabilities");

                entity.Property(e => e.IdLiabilities).HasColumnName("id_liabilities");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.LiabilitiesDate)
                    .HasColumnType("datetime")
                    .HasColumnName("liabilities_date");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoLiabilities)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_liabi__id_us__2AAE6B6D");
            });

            modelBuilder.Entity<FeoLiabilities2016>(entity =>
            {
                entity.HasKey(e => e.IdLiabilities2016)
                    .HasName("PK__feo_liab__F4ED3BC0F7B1B2E6");

                entity.ToTable("feo_liabilities2016");

                entity.Property(e => e.IdLiabilities2016).HasColumnName("id_liabilities2016");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Liabilities2016Date)
                    .HasColumnType("datetime")
                    .HasColumnName("liabilities2016_date");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.HasOne(d => d.IdMinistryOrdersNavigation)
                    .WithMany(p => p.FeoLiabilities2016)
                    .HasForeignKey(d => d.IdMinistryOrders)
                    .HasConstraintName("FK__feo_liabi__id_mi__4BC54675");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoLiabilities2016)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__feo_liabi__id_st__6CF13016");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoLiabilities2016)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_liabi__id_us__4CB96AAE");
            });

            modelBuilder.Entity<FeoLiabilities2016Detail>(entity =>
            {
                entity.HasKey(e => e.IdLiabilities2016Detail)
                    .HasName("PK__feo_liab__1DD1F96E31245E53");

                entity.ToTable("feo_liabilities2016_detail");

                entity.Property(e => e.IdLiabilities2016Detail).HasColumnName("id_liabilities2016_detail");

                entity.Property(e => e.IdLiabilities2016).HasColumnName("id_liabilities2016");

                entity.Property(e => e.IdLiabilities2016DetailClass).HasColumnName("id_liabilities2016_detail_class");

                entity.Property(e => e.Sum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("sum");

                entity.HasOne(d => d.IdLiabilities2016Navigation)
                    .WithMany(p => p.FeoLiabilities2016Detail)
                    .HasForeignKey(d => d.IdLiabilities2016)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_liabi__id_li__517E1FCB");

                entity.HasOne(d => d.IdLiabilities2016DetailClassNavigation)
                    .WithMany(p => p.FeoLiabilities2016Detail)
                    .HasForeignKey(d => d.IdLiabilities2016DetailClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_liabi__id_li__52724404");
            });

            modelBuilder.Entity<FeoLiabilities2016DetailClass>(entity =>
            {
                entity.HasKey(e => e.IdLiabilities2016DetailClass)
                    .HasName("PK__feo_liab__64612C6BD304107D");

                entity.ToTable("feo_liabilities2016_detail_class");

                entity.Property(e => e.IdLiabilities2016DetailClass).HasColumnName("id_liabilities2016_detail_class");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FeoLiabilitiesDetail>(entity =>
            {
                entity.HasKey(e => e.IdLiabilitiesDetail)
                    .HasName("PK__feo_liab__6606582EF2759E61");

                entity.ToTable("feo_liabilities_detail");

                entity.Property(e => e.IdLiabilitiesDetail).HasColumnName("id_liabilities_detail");

                entity.Property(e => e.IdLiabilities).HasColumnName("id_liabilities");

                entity.Property(e => e.Sum)
                    .HasColumnType("money")
                    .HasColumnName("sum");

                entity.HasOne(d => d.IdLiabilitiesNavigation)
                    .WithMany(p => p.FeoLiabilitiesDetail)
                    .HasForeignKey(d => d.IdLiabilities)
                    .HasConstraintName("FK__feo_liabi__id_li__2C96B3DF");
            });

            modelBuilder.Entity<FeoParams>(entity =>
            {
                entity.ToTable("feo_params");

                entity.HasIndex(e => e.Name, "UQ__feo_para__72E12F1B6A88F960")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<FeoPayGoods2016>(entity =>
            {
                entity.HasKey(e => e.IdPayGoods2016)
                    .HasName("PK__feo_pay___85095D2275E2365C");

                entity.ToTable("feo_pay_goods2016");

                entity.Property(e => e.IdPayGoods2016).HasColumnName("id_pay_goods2016");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdPayGoods2016Class).HasColumnName("id_pay_goods2016_class");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PayFz18i)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("pay_fz18i");

                entity.Property(e => e.PayFz5a)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("pay_fz5a");

                entity.Property(e => e.PaySum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("pay_sum");

                entity.Property(e => e.PayYear).HasColumnName("pay_year");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.HasOne(d => d.IdMinistryOrdersNavigation)
                    .WithMany(p => p.FeoPayGoods2016)
                    .HasForeignKey(d => d.IdMinistryOrders)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_pay_g__id_mi__1BE12929");

                entity.HasOne(d => d.IdPayGoods2016ClassNavigation)
                    .WithMany(p => p.FeoPayGoods2016)
                    .HasForeignKey(d => d.IdPayGoods2016Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_pay_g__id_pa__1AED04F0");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoPayGoods2016)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__feo_pay_g__id_st__6B08E7A4");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoPayGoods2016)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_pay_g__id_us__19F8E0B7");
            });

            modelBuilder.Entity<FeoPayGoods2016Class>(entity =>
            {
                entity.HasKey(e => e.IdPayGoods2016Class)
                    .HasName("PK__feo_pay___EE531A3DB8E2971B");

                entity.ToTable("feo_pay_goods2016_class");

                entity.Property(e => e.IdPayGoods2016Class).HasColumnName("id_pay_goods2016_class");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FeoPayments>(entity =>
            {
                entity.HasKey(e => e.IdPayments)
                    .HasName("PK__feo_paym__E126EF6B14DA2138");

                entity.ToTable("feo_payments");

                entity.Property(e => e.IdPayments).HasColumnName("id_payments");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("order_number");

                entity.Property(e => e.PaymentsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("payments_date");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("price");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoPayments)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__feo_payme__id_us__5D6EF564");
            });

            modelBuilder.Entity<FeoPayments2016>(entity =>
            {
                entity.HasKey(e => e.IdPayments2016)
                    .HasName("PK__feo_paym__A4AF68854A117910");

                entity.ToTable("feo_payments2016");

                entity.Property(e => e.IdPayments2016).HasColumnName("id_payments2016");

                entity.Property(e => e.CapInvest)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("cap_invest");

                entity.Property(e => e.GosQuest)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("gos_quest");

                entity.Property(e => e.IdBudgClass2016).HasColumnName("id_budg_class2016");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdPayments2016Class).HasColumnName("id_payments2016_class");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.OtherSourceGrant)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_source_grant");

                entity.Property(e => e.OtherSourceSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_source_sum");

                entity.Property(e => e.OtherSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_sum");

                entity.Property(e => e.OtherSumDet)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_sum_det");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumFull)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("sum_full");

                entity.HasOne(d => d.IdBudgClass2016Navigation)
                    .WithMany(p => p.FeoPayments2016)
                    .HasForeignKey(d => d.IdBudgClass2016)
                    .HasConstraintName("FK__feo_payme__id_bu__3D421CF4");

                entity.HasOne(d => d.IdMinistryOrdersNavigation)
                    .WithMany(p => p.FeoPayments2016)
                    .HasForeignKey(d => d.IdMinistryOrders)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_payme__id_mi__75BB8041");

                entity.HasOne(d => d.IdPayments2016ClassNavigation)
                    .WithMany(p => p.FeoPayments2016)
                    .HasForeignKey(d => d.IdPayments2016Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_payme__id_pa__74C75C08");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoPayments2016)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__feo_payme__id_st__673856C0");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoPayments2016)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_payme__id_us__73D337CF");
            });

            modelBuilder.Entity<FeoPayments2016Class>(entity =>
            {
                entity.HasKey(e => e.IdPayments2016Class)
                    .HasName("PK__feo_paym__BDFBA2AC846D01CB");

                entity.ToTable("feo_payments2016_class");

                entity.Property(e => e.IdPayments2016Class).HasColumnName("id_payments2016_class");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.IdFhdClass).HasColumnName("id_fhd_class");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FeoPayments2016Detail>(entity =>
            {
                entity.HasKey(e => e.IdPayments2016Detail)
                    .HasName("PK__feo_paym__BCF680D8C8A069EC");

                entity.ToTable("feo_payments2016_detail");

                entity.Property(e => e.IdPayments2016Detail).HasColumnName("id_payments2016_detail");

                entity.Property(e => e.IdFhd2016Class).HasColumnName("id_fhd2016_class");

                entity.Property(e => e.IdPayments2016).HasColumnName("id_payments2016");

                entity.Property(e => e.Sum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("sum");

                entity.HasOne(d => d.IdFhd2016ClassNavigation)
                    .WithMany(p => p.FeoPayments2016Detail)
                    .HasForeignKey(d => d.IdFhd2016Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_payme__id_fh__798C1125");

                entity.HasOne(d => d.IdPayments2016Navigation)
                    .WithMany(p => p.FeoPayments2016Detail)
                    .HasForeignKey(d => d.IdPayments2016)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_payme__id_pa__7897ECEC");
            });

            modelBuilder.Entity<FeoPayments2016Kosgu>(entity =>
            {
                entity.HasKey(e => e.IdPayments2016Kosgu)
                    .HasName("PK__feo_paym__558D8D2F77F04E05");

                entity.ToTable("feo_payments2016_kosgu");

                entity.Property(e => e.IdPayments2016Kosgu).HasColumnName("id_payments2016_kosgu");

                entity.Property(e => e.CapInvest)
                    .HasColumnType("money")
                    .HasColumnName("cap_invest");

                entity.Property(e => e.GosQuest)
                    .HasColumnType("money")
                    .HasColumnName("gos_quest");

                entity.Property(e => e.IdEconomClass).HasColumnName("id_econom_class");

                entity.Property(e => e.IdPayments2016).HasColumnName("id_payments2016");

                entity.Property(e => e.OtherSourceGrant)
                    .HasColumnType("money")
                    .HasColumnName("other_source_grant");

                entity.Property(e => e.OtherSourceSum)
                    .HasColumnType("money")
                    .HasColumnName("other_source_sum");

                entity.HasOne(d => d.IdEconomClassNavigation)
                    .WithMany(p => p.FeoPayments2016Kosgu)
                    .HasForeignKey(d => d.IdEconomClass)
                    .HasConstraintName("FK__feo_payme__id_ec__69DFB941");

                entity.HasOne(d => d.IdPayments2016Navigation)
                    .WithMany(p => p.FeoPayments2016Kosgu)
                    .HasForeignKey(d => d.IdPayments2016)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_payme__id_pa__6AD3DD7A");
            });

            modelBuilder.Entity<FeoPaymentsClass>(entity =>
            {
                entity.HasKey(e => e.IdPaymentsClass)
                    .HasName("PK__feo_paym__7D7FB6DC90864E38");

                entity.ToTable("feo_payments_class");

                entity.Property(e => e.IdPaymentsClass).HasColumnName("id_payments_class");

                entity.Property(e => e.CanEdit).HasColumnName("can_edit");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.Mnemo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mnemo");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.TreeLevel).HasColumnName("tree_level");
            });

            modelBuilder.Entity<FeoPaymentsDetail>(entity =>
            {
                entity.HasKey(e => e.IdPaymentsDetail)
                    .HasName("PK__feo_paym__5CEB300D55421D45");

                entity.ToTable("feo_payments_detail");

                entity.Property(e => e.IdPaymentsDetail).HasColumnName("id_payments_detail");

                entity.Property(e => e.IdPayments).HasColumnName("id_payments");

                entity.Property(e => e.IdPaymentsClass).HasColumnName("id_payments_class");

                entity.Property(e => e.PaymentsSum)
                    .HasColumnType("money")
                    .HasColumnName("payments_sum");

                entity.Property(e => e.PaymentsSum1)
                    .HasColumnType("money")
                    .HasColumnName("payments_sum_1");

                entity.Property(e => e.PaymentsSum2)
                    .HasColumnType("money")
                    .HasColumnName("payments_sum_2");

                entity.HasOne(d => d.IdPaymentsNavigation)
                    .WithMany(p => p.FeoPaymentsDetail)
                    .HasForeignKey(d => d.IdPayments)
                    .HasConstraintName("FK__feo_payme__id_pa__44A3479A");

                entity.HasOne(d => d.IdPaymentsClassNavigation)
                    .WithMany(p => p.FeoPaymentsDetail)
                    .HasForeignKey(d => d.IdPaymentsClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_payme__id_pa__43AF2361");
            });

            modelBuilder.Entity<FeoReceipts>(entity =>
            {
                entity.HasKey(e => e.IdReceipts)
                    .HasName("PK__feo_rece__3F44EAC0AF49E7EC");

                entity.ToTable("feo_receipts");

                entity.Property(e => e.IdReceipts).HasColumnName("id_receipts");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.ReceiptsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("receipts_date");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoReceipts)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_recei__id_us__1983DF6B");
            });

            modelBuilder.Entity<FeoReceipts2016>(entity =>
            {
                entity.HasKey(e => e.IdReceipts2016)
                    .HasName("PK__feo_rece__ACEA30353D1AB484");

                entity.ToTable("feo_receipts2016");

                entity.Property(e => e.IdReceipts2016).HasColumnName("id_receipts2016");

                entity.Property(e => e.CapInvest)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("cap_invest");

                entity.Property(e => e.GosQuest)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("gos_quest");

                entity.Property(e => e.IdBudgClass2016).HasColumnName("id_budg_class2016");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdReceipts2016Class).HasColumnName("id_receipts2016_class");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.OtherSourceGrant)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_source_grant");

                entity.Property(e => e.OtherSourceSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_source_sum");

                entity.Property(e => e.OtherSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_sum");

                entity.Property(e => e.OtherSumDet)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_sum_det");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumFull)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("sum_full");

                entity.HasOne(d => d.IdBudgClass2016Navigation)
                    .WithMany(p => p.FeoReceipts2016)
                    .HasForeignKey(d => d.IdBudgClass2016)
                    .HasConstraintName("FK__feo_recei__id_bu__3E36412D");

                entity.HasOne(d => d.IdMinistryOrdersNavigation)
                    .WithMany(p => p.FeoReceipts2016)
                    .HasForeignKey(d => d.IdMinistryOrders)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_recei__id_mi__676D60EA");

                entity.HasOne(d => d.IdReceipts2016ClassNavigation)
                    .WithMany(p => p.FeoReceipts2016)
                    .HasForeignKey(d => d.IdReceipts2016Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_recei__id_re__62A8ABCD");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoReceipts2016)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__feo_recei__id_st__65500E4E");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoReceipts2016)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_recei__id_us__61B48794");
            });

            modelBuilder.Entity<FeoReceipts2016Class>(entity =>
            {
                entity.HasKey(e => e.IdReceipts2016Class)
                    .HasName("PK__feo_rece__C3844894A659CB94");

                entity.ToTable("feo_receipts2016_class");

                entity.Property(e => e.IdReceipts2016Class).HasColumnName("id_receipts2016_class");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.IdFhdClass).HasColumnName("id_fhd_class");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FeoReceipts2016Detail>(entity =>
            {
                entity.HasKey(e => e.IdReceipts2016Detail)
                    .HasName("PK__feo_rece__979349A9D1256C0F");

                entity.ToTable("feo_receipts2016_detail");

                entity.Property(e => e.IdReceipts2016Detail).HasColumnName("id_receipts2016_detail");

                entity.Property(e => e.IdFhd2016Class).HasColumnName("id_fhd2016_class");

                entity.Property(e => e.IdReceipts2016).HasColumnName("id_receipts2016");

                entity.Property(e => e.Sum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("sum");

                entity.HasOne(d => d.IdFhd2016ClassNavigation)
                    .WithMany(p => p.FeoReceipts2016Detail)
                    .HasForeignKey(d => d.IdFhd2016Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_recei__id_fh__66793CB1");

                entity.HasOne(d => d.IdReceipts2016Navigation)
                    .WithMany(p => p.FeoReceipts2016Detail)
                    .HasForeignKey(d => d.IdReceipts2016)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_recei__id_re__65851878");
            });

            modelBuilder.Entity<FeoReceipts2016Kosgu>(entity =>
            {
                entity.HasKey(e => e.IdReceipts2016Kosgu)
                    .HasName("PK__feo_rece__E0948C8E221BFD1D");

                entity.ToTable("feo_receipts2016_kosgu");

                entity.Property(e => e.IdReceipts2016Kosgu).HasColumnName("id_receipts2016_kosgu");

                entity.Property(e => e.CapInvest)
                    .HasColumnType("money")
                    .HasColumnName("cap_invest");

                entity.Property(e => e.GosQuest)
                    .HasColumnType("money")
                    .HasColumnName("gos_quest");

                entity.Property(e => e.IdEconomClass).HasColumnName("id_econom_class");

                entity.Property(e => e.IdReceipts2016).HasColumnName("id_receipts2016");

                entity.Property(e => e.OtherSourceGrant)
                    .HasColumnType("money")
                    .HasColumnName("other_source_grant");

                entity.Property(e => e.OtherSourceSum)
                    .HasColumnType("money")
                    .HasColumnName("other_source_sum");

                entity.HasOne(d => d.IdEconomClassNavigation)
                    .WithMany(p => p.FeoReceipts2016Kosgu)
                    .HasForeignKey(d => d.IdEconomClass)
                    .HasConstraintName("FK__feo_recei__id_ec__56CCE4CD");

                entity.HasOne(d => d.IdReceipts2016Navigation)
                    .WithMany(p => p.FeoReceipts2016Kosgu)
                    .HasForeignKey(d => d.IdReceipts2016)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_recei__id_re__57C10906");
            });

            modelBuilder.Entity<FeoReceiptsClass>(entity =>
            {
                entity.HasKey(e => e.IdReceiptsClass)
                    .HasName("PK__feo_rece__05981C94E7048D44");

                entity.ToTable("feo_receipts_class");

                entity.Property(e => e.IdReceiptsClass).HasColumnName("id_receipts_class");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FeoReceiptsDetail>(entity =>
            {
                entity.HasKey(e => e.IdReceiptsDetail)
                    .HasName("PK__feo_rece__3F70F7FAFE1BAEA5");

                entity.ToTable("feo_receipts_detail");

                entity.Property(e => e.IdReceiptsDetail).HasColumnName("id_receipts_detail");

                entity.Property(e => e.IdReceipts).HasColumnName("id_receipts");

                entity.Property(e => e.ReceiptsDetailName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("receipts_detail_name");

                entity.Property(e => e.Sum1)
                    .HasColumnType("money")
                    .HasColumnName("sum1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("money")
                    .HasColumnName("sum2");

                entity.Property(e => e.Sum3)
                    .HasColumnType("money")
                    .HasColumnName("sum3");

                entity.Property(e => e.Sum4)
                    .HasColumnType("money")
                    .HasColumnName("sum4");

                entity.Property(e => e.Sum5)
                    .HasColumnType("money")
                    .HasColumnName("sum5");

                entity.HasOne(d => d.IdReceiptsNavigation)
                    .WithMany(p => p.FeoReceiptsDetail)
                    .HasForeignKey(d => d.IdReceipts)
                    .HasConstraintName("FK__feo_recei__id_re__1A7803A4");
            });

            modelBuilder.Entity<FeoReference>(entity =>
            {
                entity.HasKey(e => e.IdReference)
                    .HasName("PK__feo_refe__E4A8676DA7778B52");

                entity.ToTable("feo_reference");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.Property(e => e.April).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.August).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.December).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.February).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.January).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.November).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.October).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.September).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoReference)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_refer__id_us__576C034B");
            });

            modelBuilder.Entity<FeoRemains>(entity =>
            {
                entity.HasKey(e => e.IdRemains)
                    .HasName("PK__feo_rema__D9BD1D53505D2DA0");

                entity.ToTable("feo_remains");

                entity.Property(e => e.IdRemains).HasColumnName("id_remains");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.RemainsName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("remains_name");

                entity.Property(e => e.Sum1)
                    .HasColumnType("money")
                    .HasColumnName("sum1");

                entity.Property(e => e.Sum2)
                    .HasColumnType("money")
                    .HasColumnName("sum2");

                entity.Property(e => e.Sum3)
                    .HasColumnType("money")
                    .HasColumnName("sum3");

                entity.Property(e => e.Sum4)
                    .HasColumnType("money")
                    .HasColumnName("sum4");

                entity.Property(e => e.Sum5)
                    .HasColumnType("money")
                    .HasColumnName("sum5");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoRemains)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_remai__id_us__43450F0D");
            });

            modelBuilder.Entity<FeoRemains2016>(entity =>
            {
                entity.HasKey(e => e.IdRemains2016)
                    .HasName("PK__feo_rema__667A818F0D8EAE80");

                entity.ToTable("feo_remains2016");

                entity.Property(e => e.IdRemains2016).HasColumnName("id_remains2016");

                entity.Property(e => e.CapInvest)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("cap_invest");

                entity.Property(e => e.GosQuest)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("gos_quest");

                entity.Property(e => e.IdBudgClass2016).HasColumnName("id_budg_class2016");

                entity.Property(e => e.IdMinistryOrders).HasColumnName("id_ministry_orders");

                entity.Property(e => e.IdRemains2016Class).HasColumnName("id_remains2016_class");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.OtherSourceGrant)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_source_grant");

                entity.Property(e => e.OtherSourceSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_source_sum");

                entity.Property(e => e.OtherSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_sum");

                entity.Property(e => e.OtherSumDet)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("other_sum_det");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumFull)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("sum_full");

                entity.HasOne(d => d.IdBudgClass2016Navigation)
                    .WithMany(p => p.FeoRemains2016)
                    .HasForeignKey(d => d.IdBudgClass2016)
                    .HasConstraintName("FK__feo_remai__id_bu__3F2A6566");

                entity.HasOne(d => d.IdMinistryOrdersNavigation)
                    .WithMany(p => p.FeoRemains2016)
                    .HasForeignKey(d => d.IdMinistryOrders)
                    .HasConstraintName("FK__feo_remai__id_mi__4F60CD2F");

                entity.HasOne(d => d.IdRemains2016ClassNavigation)
                    .WithMany(p => p.FeoRemains2016)
                    .HasForeignKey(d => d.IdRemains2016Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_remai__id_re__156935C4");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.FeoRemains2016)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__feo_remai__id_st__6367C5DC");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FeoRemains2016)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_remai__id_us__1475118B");
            });

            modelBuilder.Entity<FeoRemains2016Class>(entity =>
            {
                entity.HasKey(e => e.IdRemains2016Class)
                    .HasName("PK__feo_rema__1E38C178FDD67434");

                entity.ToTable("feo_remains2016_class");

                entity.Property(e => e.IdRemains2016Class).HasColumnName("id_remains2016_class");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.IdFhdClass).HasColumnName("id_fhd_class");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FeoRemains2016Detail>(entity =>
            {
                entity.HasKey(e => e.IdRemains2016Detail)
                    .HasName("PK__feo_rema__3A1A97ECD39E70A2");

                entity.ToTable("feo_remains2016_detail");

                entity.Property(e => e.IdRemains2016Detail).HasColumnName("id_remains2016_detail");

                entity.Property(e => e.IdFhd2016Class).HasColumnName("id_fhd2016_class");

                entity.Property(e => e.IdRemains2016).HasColumnName("id_remains2016");

                entity.Property(e => e.Sum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("sum");

                entity.HasOne(d => d.IdFhd2016ClassNavigation)
                    .WithMany(p => p.FeoRemains2016Detail)
                    .HasForeignKey(d => d.IdFhd2016Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_remai__id_re__36CA298F");

                entity.HasOne(d => d.IdRemains2016Navigation)
                    .WithMany(p => p.FeoRemains2016Detail)
                    .HasForeignKey(d => d.IdRemains2016)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feo_remai__id_re__259F9D8D");
            });

            modelBuilder.Entity<FeoSubsidyCode2016>(entity =>
            {
                entity.HasKey(e => e.IdSubsidyCode2016)
                    .HasName("PK__feo_subs__768261A8FD0F4416");

                entity.ToTable("feo_subsidy_code2016");

                entity.Property(e => e.IdSubsidyCode2016).HasColumnName("id_subsidy_code2016");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<KasoF0503121>(entity =>
            {
                entity.ToTable("kaso_f0503121");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.Itogo)
                    .HasColumnType("money")
                    .HasColumnName("itogo");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<KasoF0503121S>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kaso_f0503121_s");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Code2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code2");

                entity.Property(e => e.PokazName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("pokaz_name");
            });

            modelBuilder.Entity<KasoF0503130>(entity =>
            {
                entity.ToTable("kaso_f0503130");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Cr1)
                    .HasColumnType("money")
                    .HasColumnName("cr1");

                entity.Property(e => e.Cr2)
                    .HasColumnType("money")
                    .HasColumnName("cr2");

                entity.Property(e => e.Cr3)
                    .HasColumnType("money")
                    .HasColumnName("cr3");

                entity.Property(e => e.Cr4)
                    .HasColumnType("money")
                    .HasColumnName("cr4");

                entity.Property(e => e.Cr5)
                    .HasColumnType("money")
                    .HasColumnName("cr5");

                entity.Property(e => e.Cr6)
                    .HasColumnType("money")
                    .HasColumnName("cr6");

                entity.Property(e => e.Cr7)
                    .HasColumnType("money")
                    .HasColumnName("cr7");

                entity.Property(e => e.Cr8)
                    .HasColumnType("money")
                    .HasColumnName("cr8");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<KasoF0503130S>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kaso_f0503130_s");

                entity.Property(e => e.AP).HasColumnName("a_p");

                entity.Property(e => e.Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Np)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("np");
            });

            modelBuilder.Entity<Kladr>(entity =>
            {
                entity.HasKey(e => e.IdKladr)
                    .HasName("PK__KLADR__7E18836894DA032F");

                entity.ToTable("KLADR");

                entity.Property(e => e.IdKladr).HasColumnName("ID_KLADR");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Gninmb)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GNINMB");

                entity.Property(e => e.Index)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("INDEX");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Ocatd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OCATD");

                entity.Property(e => e.Socr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SOCR");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Uno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UNO");
            });

            modelBuilder.Entity<McAppealReport>(entity =>
            {
                entity.HasKey(e => e.IdAppealReport)
                    .HasName("PK__mc_appea__02EB06CA731E3F61");

                entity.ToTable("mc_appeal_report");

                entity.Property(e => e.IdAppealReport).HasColumnName("id_appeal_report");

                entity.Property(e => e.IdAppealTheme).HasColumnName("id_appeal_theme");

                entity.Property(e => e.IdAppealTypes).HasColumnName("id_appeal_types");

                entity.Property(e => e.IdReport).HasColumnName("id_report");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.IdAppealThemeNavigation)
                    .WithMany(p => p.McAppealReport)
                    .HasForeignKey(d => d.IdAppealTheme)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_appeal__id_ap__4F35E4A6");

                entity.HasOne(d => d.IdAppealTypesNavigation)
                    .WithMany(p => p.McAppealReport)
                    .HasForeignKey(d => d.IdAppealTypes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_appeal__id_ap__502A08DF");

                entity.HasOne(d => d.IdReportNavigation)
                    .WithMany(p => p.McAppealReport)
                    .HasForeignKey(d => d.IdReport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_appeal__id_re__511E2D18");
            });

            modelBuilder.Entity<McAppealTheme>(entity =>
            {
                entity.HasKey(e => e.IdAppealTheme)
                    .HasName("PK__mc_appea__697B6C5876EED045");

                entity.ToTable("mc_appeal_theme");

                entity.Property(e => e.IdAppealTheme).HasColumnName("id_appeal_theme");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.IdAppealTypes).HasColumnName("id_appeal_types");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdAppealTypesNavigation)
                    .WithMany(p => p.McAppealTheme)
                    .HasForeignKey(d => d.IdAppealTypes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_appeal__id_ap__52125151");
            });

            modelBuilder.Entity<McAppealTypes>(entity =>
            {
                entity.HasKey(e => e.IdAppealTypes)
                    .HasName("PK__mc_appea__DFF77B7779CB3CF0");

                entity.ToTable("mc_appeal_types");

                entity.Property(e => e.IdAppealTypes).HasColumnName("id_appeal_types");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NameShort)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_short");
            });

            modelBuilder.Entity<McCmoFault>(entity =>
            {
                entity.HasKey(e => e.IdCmoFault)
                    .HasName("PK__mc_cmo_f__82C6730A7CA7A99B");

                entity.ToTable("mc_cmo_fault");

                entity.Property(e => e.IdCmoFault).HasColumnName("id_cmo_fault");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<McDuty>(entity =>
            {
                entity.HasKey(e => e.IdDuty)
                    .HasName("PK__mc_duty__9FEB2E207F841646");

                entity.ToTable("mc_duty");

                entity.Property(e => e.IdDuty).HasColumnName("id_duty");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.Employee)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("employee");

                entity.Property(e => e.IdMedOrg).HasColumnName("id_med_org");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdSmo).HasColumnName("id_smo");

                entity.Property(e => e.IsClosed).HasColumnName("is_closed");

                entity.Property(e => e.LastDate)
                    .HasColumnType("date")
                    .HasColumnName("last_date");

                entity.Property(e => e.LastUser)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("last_user");

                entity.Property(e => e.NoReport).HasColumnName("no_report");

                entity.Property(e => e.Quality)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("quality")
                    .IsFixedLength(true);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TimeFrom).HasColumnName("time_from");

                entity.Property(e => e.TimeTo).HasColumnName("time_to");

                entity.Property(e => e.UserCreate)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("user_create");

                entity.HasOne(d => d.IdMedOrgNavigation)
                    .WithMany(p => p.McDuty)
                    .HasForeignKey(d => d.IdMedOrg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_duty__id_med___5306758A");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.McDuty)
                    .HasForeignKey(d => d.IdMo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_duty__id_mo__53FA99C3");

                entity.HasOne(d => d.IdSmoNavigation)
                    .WithMany(p => p.McDuty)
                    .HasForeignKey(d => d.IdSmo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_duty__id_smo__54EEBDFC");
            });

            modelBuilder.Entity<McLimitations>(entity =>
            {
                entity.HasKey(e => e.IdLimitations)
                    .HasName("PK__mc_limit__1BCCAE550354A72A");

                entity.ToTable("mc_limitations");

                entity.Property(e => e.IdLimitations).HasColumnName("id_limitations");

                entity.Property(e => e.IdLimitationsTypes).HasColumnName("id_limitations_types");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdLimitationsTypesNavigation)
                    .WithMany(p => p.McLimitations)
                    .HasForeignKey(d => d.IdLimitationsTypes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_limita__id_li__55E2E235");
            });

            modelBuilder.Entity<McLimitationsCmoReport>(entity =>
            {
                entity.HasKey(e => e.IdLimitationsCmoReport)
                    .HasName("PK__mc_limit__6A2BE99B063113D5");

                entity.ToTable("mc_limitations_cmo_report");

                entity.Property(e => e.IdLimitationsCmoReport).HasColumnName("id_limitations_cmo_report");

                entity.Property(e => e.Arrangements)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("arrangements");

                entity.Property(e => e.Discription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("discription");

                entity.Property(e => e.IdCmoFault).HasColumnName("id_cmo_fault");

                entity.Property(e => e.IdReport).HasColumnName("id_report");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.IdCmoFaultNavigation)
                    .WithMany(p => p.McLimitationsCmoReport)
                    .HasForeignKey(d => d.IdCmoFault)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_limita__id_cm__56D7066E");

                entity.HasOne(d => d.IdReportNavigation)
                    .WithMany(p => p.McLimitationsCmoReport)
                    .HasForeignKey(d => d.IdReport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_limita__id_re__57CB2AA7");
            });

            modelBuilder.Entity<McLimitationsReport>(entity =>
            {
                entity.HasKey(e => e.IdLimitationsReport)
                    .HasName("PK__mc_limit__FC1EA10A090D8080");

                entity.ToTable("mc_limitations_report");

                entity.Property(e => e.IdLimitationsReport).HasColumnName("id_limitations_report");

                entity.Property(e => e.Arrangements)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("arrangements");

                entity.Property(e => e.ArrangementsMo)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("arrangements_mo");

                entity.Property(e => e.Discription)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("discription");

                entity.Property(e => e.IdMoFault).HasColumnName("id_mo_fault");

                entity.Property(e => e.IdReport).HasColumnName("id_report");

                entity.Property(e => e.MakeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("make_date");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.IdMoFaultNavigation)
                    .WithMany(p => p.McLimitationsReport)
                    .HasForeignKey(d => d.IdMoFault)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_limita__id_mo__58BF4EE0");

                entity.HasOne(d => d.IdReportNavigation)
                    .WithMany(p => p.McLimitationsReport)
                    .HasForeignKey(d => d.IdReport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_limita__id_re__59B37319");
            });

            modelBuilder.Entity<McLimitationsTypes>(entity =>
            {
                entity.HasKey(e => e.IdLimitationsTypes)
                    .HasName("PK__mc_limit__314904300CDE1164");

                entity.ToTable("mc_limitations_types");

                entity.Property(e => e.IdLimitationsTypes).HasColumnName("id_limitations_types");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NameShort)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_short");
            });

            modelBuilder.Entity<McMedOrg>(entity =>
            {
                entity.HasKey(e => e.IdMedOrg)
                    .HasName("PK__mc_med_o__D15454E00FBA7E0F");

                entity.ToTable("mc_med_org");

                entity.Property(e => e.IdMedOrg).HasColumnName("id_med_org");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NameShort)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_short");

                entity.Property(e => e.Ogrn)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ogrn");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.McMedOrg)
                    .HasForeignKey(d => d.IdMo)
                    .HasConstraintName("FK__mc_med_or__id_mo__5AA79752");
            });

            modelBuilder.Entity<McMo>(entity =>
            {
                entity.HasKey(e => e.IdMo)
                    .HasName("PK__mc_mo__01488BA71296EABA");

                entity.ToTable("mc_mo");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.IdMrf).HasColumnName("id_mrf");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdMrfNavigation)
                    .WithMany(p => p.McMo)
                    .HasForeignKey(d => d.IdMrf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_mo__id_mrf__5B9BBB8B");
            });

            modelBuilder.Entity<McMoFault>(entity =>
            {
                entity.HasKey(e => e.IdMoFault)
                    .HasName("PK__mc_mo_fa__CEF6719D15735765");

                entity.ToTable("mc_mo_fault");

                entity.Property(e => e.IdMoFault).HasColumnName("id_mo_fault");

                entity.Property(e => e.IdMoFaultTypes).HasColumnName("id_mo_fault_types");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdMoFaultTypesNavigation)
                    .WithMany(p => p.McMoFault)
                    .HasForeignKey(d => d.IdMoFaultTypes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_mo_fau__id_mo__5C8FDFC4");
            });

            modelBuilder.Entity<McMoFaultTypes>(entity =>
            {
                entity.HasKey(e => e.IdMoFaultTypes)
                    .HasName("PK__mc_mo_fa__797113FD184FC410");

                entity.ToTable("mc_mo_fault_types");

                entity.Property(e => e.IdMoFaultTypes).HasColumnName("id_mo_fault_types");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<McMrf>(entity =>
            {
                entity.HasKey(e => e.IdMrf)
                    .HasName("PK__mc_mrf__6C887B1A1B2C30BB");

                entity.ToTable("mc_mrf");

                entity.Property(e => e.IdMrf).HasColumnName("id_mrf");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsTest).HasColumnName("is_test");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.McMrf)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__mc_mrf__id_user__5D8403FD");
            });

            modelBuilder.Entity<McPositive>(entity =>
            {
                entity.HasKey(e => e.IdPositive)
                    .HasName("PK__mc_posit__D65254351E089D66");

                entity.ToTable("mc_positive");

                entity.Property(e => e.IdPositive).HasColumnName("id_positive");

                entity.Property(e => e.ImageTest).HasColumnName("image_test");

                entity.Property(e => e.Images)
                    .HasColumnType("image")
                    .HasColumnName("images");

                entity.Property(e => e.NamePositive)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_positive");
            });

            modelBuilder.Entity<McPositiveReport>(entity =>
            {
                entity.HasKey(e => e.IdPositiveReport)
                    .HasName("PK__mc_posit__CC04204320E50A11");

                entity.ToTable("mc_positive_report");

                entity.Property(e => e.IdPositiveReport).HasColumnName("id_positive_report");

                entity.Property(e => e.Discription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("discription");

                entity.Property(e => e.IdPositive).HasColumnName("id_positive");

                entity.Property(e => e.IdReport).HasColumnName("id_report");

                entity.HasOne(d => d.IdPositiveNavigation)
                    .WithMany(p => p.McPositiveReport)
                    .HasForeignKey(d => d.IdPositive)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_positi__id_po__5E782836");

                entity.HasOne(d => d.IdReportNavigation)
                    .WithMany(p => p.McPositiveReport)
                    .HasForeignKey(d => d.IdReport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_positi__id_re__5F6C4C6F");
            });

            modelBuilder.Entity<McReport>(entity =>
            {
                entity.HasKey(e => e.IdReport)
                    .HasName("PK__mc_repor__D8639F5224B59AF5");

                entity.ToTable("mc_report");

                entity.Property(e => e.IdReport).HasColumnName("id_report");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasColumnName("create_date");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("create_user");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.IdDuty).HasColumnName("id_duty");

                entity.Property(e => e.IdMedOrg).HasColumnName("id_med_org");

                entity.Property(e => e.IdMrf)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("id_mrf");

                entity.Property(e => e.IdSmo).HasColumnName("id_smo");

                entity.Property(e => e.LastDate)
                    .HasColumnType("date")
                    .HasColumnName("last_date");

                entity.Property(e => e.LastUser)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("last_user");

                entity.Property(e => e.Temp).HasColumnName("temp");

                entity.Property(e => e.Test)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("test");

                entity.HasOne(d => d.IdDutyNavigation)
                    .WithMany(p => p.McReport)
                    .HasForeignKey(d => d.IdDuty)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_report__id_du__606070A8");

                entity.HasOne(d => d.IdMedOrgNavigation)
                    .WithMany(p => p.McReport)
                    .HasForeignKey(d => d.IdMedOrg)
                    .HasConstraintName("FK__mc_report__id_me__615494E1");

                entity.HasOne(d => d.IdSmoNavigation)
                    .WithMany(p => p.McReport)
                    .HasForeignKey(d => d.IdSmo)
                    .HasConstraintName("FK__mc_report__id_sm__6248B91A");
            });

            modelBuilder.Entity<McSmo>(entity =>
            {
                entity.HasKey(e => e.IdSmo)
                    .HasName("PK__mc_smo__6D6C6227297A5012");

                entity.ToTable("mc_smo");

                entity.Property(e => e.IdSmo).HasColumnName("id_smo");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsTest).HasColumnName("is_test");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.McSmo)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__mc_smo__id_user__633CDD53");
            });

            modelBuilder.Entity<McTalk>(entity =>
            {
                entity.HasKey(e => e.IdTalk)
                    .HasName("PK__mc_talk__C1D2BE332C56BCBD");

                entity.ToTable("mc_talk");

                entity.Property(e => e.IdTalk).HasColumnName("id_talk");

                entity.Property(e => e.TalkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("talk_date");

                entity.Property(e => e.TalkFile)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("talk_file");

                entity.Property(e => e.TalkText)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("talk_text");

                entity.Property(e => e.TalkUser)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("talk_user");
            });

            modelBuilder.Entity<McUserDate>(entity =>
            {
                entity.HasKey(e => e.IdUserDate)
                    .HasName("PK__mc_user___D60E74682F332968");

                entity.ToTable("mc_user_date");

                entity.Property(e => e.IdUserDate).HasColumnName("id_user_date");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.McUserDate)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mc_user_d__id_us__6431018C");
            });

            modelBuilder.Entity<MsDistrict>(entity =>
            {
                entity.HasKey(e => e.IdDistrict)
                    .HasName("PK__ms_distr__65E6DD953209A6C9");

                entity.ToTable("ms_district");

                entity.Property(e => e.IdDistrict).HasColumnName("id_district");

                entity.Property(e => e.FMPediatrist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("f_m_pediatrist");

                entity.Property(e => e.FMSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("f_m_sum");

                entity.Property(e => e.FMTherapist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("f_m_therapist");

                entity.Property(e => e.FMVop)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("f_m_vop");

                entity.Property(e => e.FVPediatrist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("f_v_pediatrist");

                entity.Property(e => e.FVSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("f_v_sum");

                entity.Property(e => e.FVTherapist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("f_v_therapist");

                entity.Property(e => e.FVVop)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("f_v_vop");

                entity.Property(e => e.IdDistrictClass).HasColumnName("id_district_class");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.JMPediatrist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("j_m_pediatrist");

                entity.Property(e => e.JMSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("j_m_sum");

                entity.Property(e => e.JMTherapist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("j_m_therapist");

                entity.Property(e => e.JMVop)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("j_m_vop");

                entity.Property(e => e.JVPediatrist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("j_v_pediatrist");

                entity.Property(e => e.JVSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("j_v_sum");

                entity.Property(e => e.JVTherapist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("j_v_therapist");

                entity.Property(e => e.JVVop)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("j_v_vop");

                entity.Property(e => e.PeriodMonth).HasColumnName("period_month");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SMPediatrist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("s_m_pediatrist");

                entity.Property(e => e.SMSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("s_m_sum");

                entity.Property(e => e.SMTherapist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("s_m_therapist");

                entity.Property(e => e.SMVop)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("s_m_vop");

                entity.Property(e => e.SVPediatrist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("s_v_pediatrist");

                entity.Property(e => e.SVSum)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("s_v_sum");

                entity.Property(e => e.SVTherapist)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("s_v_therapist");

                entity.Property(e => e.SVVop)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("s_v_vop");

                entity.HasOne(d => d.IdDistrictClassNavigation)
                    .WithMany(p => p.MsDistrict)
                    .HasForeignKey(d => d.IdDistrictClass)
                    .HasConstraintName("FK__ms_distri__id_di__27FCE74B");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.MsDistrict)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__ms_distri__id_st__29E52FBD");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.MsDistrict)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__ms_distri__id_us__28F10B84");
            });

            modelBuilder.Entity<MsDistrictClass>(entity =>
            {
                entity.HasKey(e => e.IdDistrictClass)
                    .HasName("PK__ms_distr__D38B0A4E3AD8C426");

                entity.ToTable("ms_district_class");

                entity.Property(e => e.IdDistrictClass).HasColumnName("id_district_class");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<NormAuto>(entity =>
            {
                entity.HasKey(e => e.IdAuto)
                    .HasName("PK__norm_aut__B191F5E6AD606D21");

                entity.ToTable("norm_auto");

                entity.Property(e => e.IdAuto).HasColumnName("id_auto");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormAuto)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_auto__id_re__18A59522");
            });

            modelBuilder.Entity<NormAutoDetail>(entity =>
            {
                entity.HasKey(e => e.IdAutoDetail)
                    .HasName("PK__norm_aut__A26EBD17A23FF94D");

                entity.ToTable("norm_auto_detail");

                entity.Property(e => e.IdAutoDetail).HasColumnName("id_auto_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdAuto).HasColumnName("id_auto");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdAutoNavigation)
                    .WithMany(p => p.NormAutoDetail)
                    .HasForeignKey(d => d.IdAuto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_auto__id_au__6120560E");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormAutoDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_auto__id_me__62147A47");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormAutoDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_auto__id_st__63089E80");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormAutoDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_auto__id_us__63FCC2B9");
            });

            modelBuilder.Entity<NormComment>(entity =>
            {
                entity.HasKey(e => e.IdComment)
                    .HasName("PK__norm_com__7E14AC852619636A");

                entity.ToTable("norm_comment");

                entity.Property(e => e.IdComment).HasColumnName("id_comment");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdGroup).HasColumnName("id_group");

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.NormComment)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_comm__id_gr__0F071C4F");
            });

            modelBuilder.Entity<NormCommunication>(entity =>
            {
                entity.HasKey(e => e.IdCommunication)
                    .HasName("PK__norm_com__260B33D75D6FAAAB");

                entity.ToTable("norm_communication");

                entity.Property(e => e.IdCommunication).HasColumnName("id_communication");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormCommunication)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_comm__id_re__7A210E02");
            });

            modelBuilder.Entity<NormCommunicationDetail>(entity =>
            {
                entity.HasKey(e => e.IdCommunicationDetail)
                    .HasName("PK__norm_com__0D001178629809CB");

                entity.ToTable("norm_communication_detail");

                entity.Property(e => e.IdCommunicationDetail).HasColumnName("id_communication_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdCommunication).HasColumnName("id_communication");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdWorkposition)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("id_workposition");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoMonthPay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_month_pay")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.MonthPay)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("month_pay");

                entity.Property(e => e.MonthPayInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("month_pay_info");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.Property(e => e.UsePeriod)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("use_period");

                entity.HasOne(d => d.IdCommunicationNavigation)
                    .WithMany(p => p.NormCommunicationDetail)
                    .HasForeignKey(d => d.IdCommunication)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_comm__id_co__1B4CF7A3");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormCommunicationDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_comm__id_me__1C411BDC");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormCommunicationDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_comm__id_st__1D354015");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormCommunicationDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_comm__id_us__1E29644E");
            });

            modelBuilder.Entity<NormComputer>(entity =>
            {
                entity.HasKey(e => e.IdComputer)
                    .HasName("PK__norm_com__04084F02025058E6");

                entity.ToTable("norm_computer");

                entity.Property(e => e.IdComputer).HasColumnName("id_computer");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormComputer)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_comp__id_it__35E0F24E");
            });

            modelBuilder.Entity<NormComputerDetail>(entity =>
            {
                entity.HasKey(e => e.IdComputerDetail)
                    .HasName("PK__norm_com__15F1B0B151A1B394");

                entity.ToTable("norm_computer_detail");

                entity.Property(e => e.IdComputerDetail).HasColumnName("id_computer_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdComputer).HasColumnName("id_computer");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdWorkposition)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("id_workposition");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdComputerNavigation)
                    .WithMany(p => p.NormComputerDetail)
                    .HasForeignKey(d => d.IdComputer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_comp__id_co__5B1276FD");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormComputerDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_comp__id_me__5CFABF6F");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormComputerDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_comp__id_st__5C069B36");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormComputerDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_comp__id_us__5A1E52C4");
            });

            modelBuilder.Entity<NormDetailWorkpositionCross>(entity =>
            {
                entity.HasKey(e => e.IdDetailWorkposition)
                    .HasName("PK__norm_det__548FF848C07B6A42");

                entity.ToTable("norm_detail_workposition_cross");

                entity.Property(e => e.IdDetailWorkposition).HasColumnName("id_detail_workposition");

                entity.Property(e => e.IdAutoDetail).HasColumnName("id_auto_detail");

                entity.Property(e => e.IdCommunicationDetail).HasColumnName("id_communication_detail");

                entity.Property(e => e.IdComputerDetail).HasColumnName("id_computer_detail");

                entity.Property(e => e.IdDocumentsDetail).HasColumnName("id_documents_detail");

                entity.Property(e => e.IdEducationDetail).HasColumnName("id_education_detail");

                entity.Property(e => e.IdEquipmentDetail).HasColumnName("id_equipment_detail");

                entity.Property(e => e.IdEscortPoDetail).HasColumnName("id_escort_po_detail");

                entity.Property(e => e.IdEscortSpsDetail).HasColumnName("id_escort_sps_detail");

                entity.Property(e => e.IdFireDepartmentDetail).HasColumnName("id_fire_department_detail");

                entity.Property(e => e.IdHelicopterDetail).HasColumnName("id_helicopter_detail");

                entity.Property(e => e.IdHouseholdDetail).HasColumnName("id_household_detail");

                entity.Property(e => e.IdInternetDetail).HasColumnName("id_internet_detail");

                entity.Property(e => e.IdItemDetail).HasColumnName("id_item_detail");

                entity.Property(e => e.IdMedicineDetail).HasColumnName("id_medicine_detail");

                entity.Property(e => e.IdOtherDetail).HasColumnName("id_other_detail");

                entity.Property(e => e.IdOverallsDetail).HasColumnName("id_overalls_detail");

                entity.Property(e => e.IdRepairsDetail).HasColumnName("id_repairs_detail");

                entity.Property(e => e.IdSecurityDetail).HasColumnName("id_security_detail");

                entity.Property(e => e.IdTypographicDetail).HasColumnName("id_typographic_detail");

                entity.Property(e => e.IdUtilitiesDetail).HasColumnName("id_utilities_detail");

                entity.Property(e => e.IdWorkposition).HasColumnName("id_workposition");

                entity.Property(e => e.IdWwfWorkDetail).HasColumnName("id_wwf_work_detail");

                entity.HasOne(d => d.IdAutoDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdAutoDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_au__72D4F1F5");

                entity.HasOne(d => d.IdCommunicationDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdCommunicationDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_co__74BD3A67");

                entity.HasOne(d => d.IdComputerDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdComputerDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_co__73C9162E");

                entity.HasOne(d => d.IdDocumentsDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdDocumentsDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_do__75B15EA0");

                entity.HasOne(d => d.IdEducationDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdEducationDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_ed__76A582D9");

                entity.HasOne(d => d.IdEquipmentDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdEquipmentDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_eq__7799A712");

                entity.HasOne(d => d.IdEscortPoDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdEscortPoDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_es__788DCB4B");

                entity.HasOne(d => d.IdEscortSpsDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdEscortSpsDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_es__7981EF84");

                entity.HasOne(d => d.IdFireDepartmentDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdFireDepartmentDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_fi__7A7613BD");

                entity.HasOne(d => d.IdHelicopterDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdHelicopterDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_he__7B6A37F6");

                entity.HasOne(d => d.IdHouseholdDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdHouseholdDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_ho__7C5E5C2F");

                entity.HasOne(d => d.IdInternetDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdInternetDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_in__7D528068");

                entity.HasOne(d => d.IdItemDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdItemDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_it__39F17A54");

                entity.HasOne(d => d.IdMedicineDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdMedicineDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_me__7E46A4A1");

                entity.HasOne(d => d.IdOtherDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdOtherDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_ot__7F3AC8DA");

                entity.HasOne(d => d.IdOverallsDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdOverallsDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_ov__002EED13");

                entity.HasOne(d => d.IdRepairsDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdRepairsDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_re__0123114C");

                entity.HasOne(d => d.IdSecurityDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdSecurityDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_se__02173585");

                entity.HasOne(d => d.IdTypographicDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdTypographicDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_ty__030B59BE");

                entity.HasOne(d => d.IdUtilitiesDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdUtilitiesDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_ut__03FF7DF7");

                entity.HasOne(d => d.IdWorkpositionNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdWorkposition)
                    .HasConstraintName("FK__norm_deta__id_wo__04F3A230");

                entity.HasOne(d => d.IdWwfWorkDetailNavigation)
                    .WithMany(p => p.NormDetailWorkpositionCross)
                    .HasForeignKey(d => d.IdWwfWorkDetail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__norm_deta__id_ww__05E7C669");
            });

            modelBuilder.Entity<NormDocuments>(entity =>
            {
                entity.HasKey(e => e.IdDocuments)
                    .HasName("PK__norm_doc__5D2EE7E1C0B5732D");

                entity.ToTable("norm_documents");

                entity.Property(e => e.IdDocuments).HasColumnName("id_documents");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormDocuments)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_docu__id_re__241747CE");
            });

            modelBuilder.Entity<NormDocumentsDetail>(entity =>
            {
                entity.HasKey(e => e.IdDocumentsDetail)
                    .HasName("PK__norm_doc__9D6A9BB25F7C0DAB");

                entity.ToTable("norm_documents_detail");

                entity.Property(e => e.IdDocumentsDetail).HasColumnName("id_documents_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdDocuments).HasColumnName("id_documents");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdDocumentsNavigation)
                    .WithMany(p => p.NormDocumentsDetail)
                    .HasForeignKey(d => d.IdDocuments)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_docu__id_do__0CFED84C");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormDocumentsDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_docu__id_me__0DF2FC85");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormDocumentsDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_docu__id_st__0EE720BE");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormDocumentsDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_docu__id_us__0FDB44F7");
            });

            modelBuilder.Entity<NormEducation>(entity =>
            {
                entity.HasKey(e => e.IdEducation)
                    .HasName("PK__norm_edu__B4847780BCB99CC4");

                entity.ToTable("norm_education");

                entity.Property(e => e.IdEducation).HasColumnName("id_education");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormEducation)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_educ__id_re__0D33E276");
            });

            modelBuilder.Entity<NormEducationDetail>(entity =>
            {
                entity.HasKey(e => e.IdEducationDetail)
                    .HasName("PK__norm_edu__E7D24D40384F76DD");

                entity.ToTable("norm_education_detail");

                entity.Property(e => e.IdEducationDetail).HasColumnName("id_education_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdEducation).HasColumnName("id_education");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdEducationNavigation)
                    .WithMany(p => p.NormEducationDetail)
                    .HasForeignKey(d => d.IdEducation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_educ__id_ed__7EB0B8F5");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormEducationDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_educ__id_me__37B42C27");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormEducationDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_educ__id_st__7FA4DD2E");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormEducationDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_educ__id_us__00990167");
            });

            modelBuilder.Entity<NormEquipment>(entity =>
            {
                entity.HasKey(e => e.IdEquipment)
                    .HasName("PK__norm_equ__D745C9DF8243191C");

                entity.ToTable("norm_equipment");

                entity.Property(e => e.IdEquipment).HasColumnName("id_equipment");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormEquipment)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_equi__id_re__213ADB23");
            });

            modelBuilder.Entity<NormEquipmentDetail>(entity =>
            {
                entity.HasKey(e => e.IdEquipmentDetail)
                    .HasName("PK__norm_equ__090C444BBF7F3B28");

                entity.ToTable("norm_equipment_detail");

                entity.Property(e => e.IdEquipmentDetail).HasColumnName("id_equipment_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdEquipment).HasColumnName("id_equipment");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdEquipmentNavigation)
                    .WithMany(p => p.NormEquipmentDetail)
                    .HasForeignKey(d => d.IdEquipment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_equi__id_eq__7062999E");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormEquipmentDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_equi__id_me__7156BDD7");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormEquipmentDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_equi__id_st__724AE210");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormEquipmentDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_equi__id_us__733F0649");
            });

            modelBuilder.Entity<NormEscortPo>(entity =>
            {
                entity.HasKey(e => e.IdEscortPo)
                    .HasName("PK__norm_esc__3652914756F6133B");

                entity.ToTable("norm_escort_po");

                entity.Property(e => e.IdEscortPo).HasColumnName("id_escort_po");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormEscortPo)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_esco__id_se__470B7E50");
            });

            modelBuilder.Entity<NormEscortPoDetail>(entity =>
            {
                entity.HasKey(e => e.IdEscortPoDetail)
                    .HasName("PK__norm_esc__9781A085C25C9E4D");

                entity.ToTable("norm_escort_po_detail");

                entity.Property(e => e.IdEscortPoDetail).HasColumnName("id_escort_po_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdEscortPo).HasColumnName("id_escort_po");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdWorkposition)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("id_workposition");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdEscortPoNavigation)
                    .WithMany(p => p.NormEscortPoDetail)
                    .HasForeignKey(d => d.IdEscortPo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_esco__id_es__2669A494");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormEscortPoDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_esco__id_me__275DC8CD");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormEscortPoDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_esco__id_st__2851ED06");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormEscortPoDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_esco__id_us__2946113F");
            });

            modelBuilder.Entity<NormEscortSps>(entity =>
            {
                entity.HasKey(e => e.IdEscortSps)
                    .HasName("PK__norm_esc__5915CDD9E9B07AB7");

                entity.ToTable("norm_escort_sps");

                entity.Property(e => e.IdEscortSps).HasColumnName("id_escort_sps");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormEscortSps)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_esco__id_se__442F11A5");
            });

            modelBuilder.Entity<NormEscortSpsDetail>(entity =>
            {
                entity.HasKey(e => e.IdEscortSpsDetail)
                    .HasName("PK__norm_esc__11CB51F2079D15B2");

                entity.ToTable("norm_escort_sps_detail");

                entity.Property(e => e.IdEscortSpsDetail).HasColumnName("id_escort_sps_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdEscortSps).HasColumnName("id_escort_sps");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.Property(e => e.UseTime).HasColumnName("use_time");

                entity.Property(e => e.UseUnit)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("use_unit");

                entity.HasOne(d => d.IdEscortSpsNavigation)
                    .WithMany(p => p.NormEscortSpsDetail)
                    .HasForeignKey(d => d.IdEscortSps)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_esco__id_es__6A54BA8D");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormEscortSpsDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_esco__id_me__6B48DEC6");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormEscortSpsDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_esco__id_st__6C3D02FF");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormEscortSpsDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_esco__id_us__6D312738");
            });

            modelBuilder.Entity<NormFile>(entity =>
            {
                entity.HasKey(e => e.IdFile)
                    .HasName("PK__norm_fil__648EA6DF874D3E61");

                entity.ToTable("norm_file");

                entity.Property(e => e.IdFile).HasColumnName("id_file");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("file_name");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("file_path");

                entity.Property(e => e.IdItemDetail).HasColumnName("id_item_detail");

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.Property(e => e.IdRow).HasColumnName("id_row");

                entity.Property(e => e.Md5)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("md5")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdItemDetailNavigation)
                    .WithMany(p => p.NormFile)
                    .HasForeignKey(d => d.IdItemDetail)
                    .HasConstraintName("FK__norm_file__id_it__483F99AB");

                entity.HasOne(d => d.IdModuleNavigation)
                    .WithMany(p => p.NormFile)
                    .HasForeignKey(d => d.IdModule)
                    .HasConstraintName("FK__norm_file__id_mo__0063F73D");
            });

            modelBuilder.Entity<NormFireDepartment>(entity =>
            {
                entity.HasKey(e => e.IdFireDepartment)
                    .HasName("PK__norm_fir__4E367C0E6F7D60B8");

                entity.ToTable("norm_fire_department");

                entity.Property(e => e.IdFireDepartment).HasColumnName("id_fire_department");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormFireDepartment)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_fire__id_re__0592C0AE");
            });

            modelBuilder.Entity<NormFireDepartmentDetail>(entity =>
            {
                entity.HasKey(e => e.IdFireDepartmentDetail)
                    .HasName("PK__norm_fir__8B16ACBE0265FA81");

                entity.ToTable("norm_fire_department_detail");

                entity.Property(e => e.IdFireDepartmentDetail).HasColumnName("id_fire_department_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdFireDepartment).HasColumnName("id_fire_department");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdFireDepartmentNavigation)
                    .WithMany(p => p.NormFireDepartmentDetail)
                    .HasForeignKey(d => d.IdFireDepartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_fire__id_fi__429BCEEE");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormFireDepartmentDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_fire__id_me__438FF327");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormFireDepartmentDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_fire__id_st__44841760");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormFireDepartmentDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_fire__id_us__45783B99");
            });

            modelBuilder.Entity<NormGroup>(entity =>
            {
                entity.HasKey(e => e.IdGroup)
                    .HasName("PK__norm_gro__8BE8BA1B73BC759A");

                entity.ToTable("norm_group");

                entity.Property(e => e.IdGroup).HasColumnName("id_group");

                entity.Property(e => e.HaveChild).HasColumnName("have_child");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<NormHelicopter>(entity =>
            {
                entity.HasKey(e => e.IdHelicopter)
                    .HasName("PK__norm_hel__90227DD4E670D8B7");

                entity.ToTable("norm_helicopter");

                entity.Property(e => e.IdHelicopter).HasColumnName("id_helicopter");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormHelicopter)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_heli__id_re__15C92877");
            });

            modelBuilder.Entity<NormHelicopterDetail>(entity =>
            {
                entity.HasKey(e => e.IdHelicopterDetail)
                    .HasName("PK__norm_hel__DAE45E9AE228544D");

                entity.ToTable("norm_helicopter_detail");

                entity.Property(e => e.IdHelicopterDetail).HasColumnName("id_helicopter_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdHelicopter).HasColumnName("id_helicopter");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdHelicopterNavigation)
                    .WithMany(p => p.NormHelicopterDetail)
                    .HasForeignKey(d => d.IdHelicopter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_heli__id_he__597F3446");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormHelicopterDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_heli__id_me__5A73587F");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormHelicopterDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_heli__id_st__5B677CB8");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormHelicopterDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_heli__id_us__5C5BA0F1");
            });

            modelBuilder.Entity<NormHousehold>(entity =>
            {
                entity.HasKey(e => e.IdHousehold)
                    .HasName("PK__norm_hou__B49ECED26DFBE3CF");

                entity.ToTable("norm_household");

                entity.HasIndex(e => e.IdReference, "UQ__norm_hou__E4A8676C8AF96038")
                    .IsUnique();

                entity.Property(e => e.IdHousehold).HasColumnName("id_household");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithOne(p => p.NormHousehold)
                    .HasForeignKey<NormHousehold>(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_hous__id_re__3576DDFA");
            });

            modelBuilder.Entity<NormHouseholdDetail>(entity =>
            {
                entity.HasKey(e => e.IdHouseholdDetail)
                    .HasName("PK__norm_hou__0F19366E704B0E9D");

                entity.ToTable("norm_household_detail");

                entity.Property(e => e.IdHouseholdDetail).HasColumnName("id_household_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdHousehold).HasColumnName("id_household");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdHouseholdNavigation)
                    .WithMany(p => p.NormHouseholdDetail)
                    .HasForeignKey(d => d.IdHousehold)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_hous__id_ho__39476EDE");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormHouseholdDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_hous__id_me__3A3B9317");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormHouseholdDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_hous__id_st__3B2FB750");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormHouseholdDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_hous__id_us__3C23DB89");
            });

            modelBuilder.Entity<NormInternet>(entity =>
            {
                entity.HasKey(e => e.IdInternet)
                    .HasName("PK__norm_int__7178BC91179CD69C");

                entity.ToTable("norm_internet");

                entity.Property(e => e.IdInternet).HasColumnName("id_internet");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormInternet)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_inte__id_re__7CFD7AAD");
            });

            modelBuilder.Entity<NormInternetDetail>(entity =>
            {
                entity.HasKey(e => e.IdInternetDetail)
                    .HasName("PK__norm_int__BBA974B97F5FA80A");

                entity.ToTable("norm_internet_detail");

                entity.Property(e => e.IdInternetDetail).HasColumnName("id_internet_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdInternet).HasColumnName("id_internet");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdWorkposition)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("id_workposition");

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdInternetNavigation)
                    .WithMany(p => p.NormInternetDetail)
                    .HasForeignKey(d => d.IdInternet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_inte__id_in__149FFA14");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormInternetDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_inte__id_st__15941E4D");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormInternetDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_inte__id_us__16884286");
            });

            modelBuilder.Entity<NormItem>(entity =>
            {
                entity.HasKey(e => e.IdItem)
                    .HasName("PK__norm_ite__87C9438B6745EBA2");

                entity.ToTable("norm_item");

                entity.Property(e => e.IdItem).HasColumnName("id_item");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdGroup).HasColumnName("id_group");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.NormItem)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__norm_item__id_gr__69D597A0");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormItem)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_item__id_re__6AC9BBD9");
            });

            modelBuilder.Entity<NormItemDetail>(entity =>
            {
                entity.HasKey(e => e.IdItemDetail)
                    .HasName("PK__norm_ite__A911B785D157D345");

                entity.ToTable("norm_item_detail");

                entity.Property(e => e.IdItemDetail).HasColumnName("id_item_detail");

                entity.Property(e => e.AdminComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("admin_comment");

                entity.Property(e => e.Cancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cancel")
                    .IsFixedLength(true);

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("datetime")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Feature)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("feature");

                entity.Property(e => e.IdItem).HasColumnName("id_item");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdWorkposition)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("id_workposition");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoLifetime)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_lifetime")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPeriodPay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_period_pay")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Lifetime).HasColumnName("lifetime");

                entity.Property(e => e.LifetimeInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("lifetime_info");

                entity.Property(e => e.PeriodPay)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("period_pay");

                entity.Property(e => e.PeriodPayInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("period_pay_info");

                entity.Property(e => e.Periodicity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("periodicity");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.NormItemDetail)
                    .HasForeignKey(d => d.IdItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_item__id_it__352CC537");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormItemDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_item__id_me__3620E970");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormItemDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_item__id_st__37150DA9");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormItemDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_item__id_us__380931E2");
            });

            modelBuilder.Entity<NormKosgu>(entity =>
            {
                entity.HasKey(e => e.IdKosgu)
                    .HasName("PK__norm_kos__FC42E70A72F25731");

                entity.ToTable("norm_kosgu");

                entity.Property(e => e.IdKosgu).HasColumnName("id_kosgu");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.IdKvr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("id_kvr");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<NormKvr>(entity =>
            {
                entity.HasKey(e => e.IdKvr)
                    .HasName("PK__norm_kvr__D496AA47730574AC");

                entity.ToTable("norm_kvr");

                entity.Property(e => e.IdKvr).HasColumnName("id_kvr");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<NormMedicine>(entity =>
            {
                entity.HasKey(e => e.IdMedicine)
                    .HasName("PK__norm_med__1F746A2E74FF74A7");

                entity.ToTable("norm_medicine");

                entity.Property(e => e.IdMedicine).HasColumnName("id_medicine");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormMedicine)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_medi__id_re__02B65403");
            });

            modelBuilder.Entity<NormMedicineDetail>(entity =>
            {
                entity.HasKey(e => e.IdMedicineDetail)
                    .HasName("PK__norm_med__EEAC7C96F8E4C256");

                entity.ToTable("norm_medicine_detail");

                entity.Property(e => e.IdMedicineDetail).HasColumnName("id_medicine_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdMedicine).HasColumnName("id_medicine");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormMedicineDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_medi__id_me__3BEED15F");

                entity.HasOne(d => d.IdMedicineNavigation)
                    .WithMany(p => p.NormMedicineDetail)
                    .HasForeignKey(d => d.IdMedicine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_medi__id_me__3AFAAD26");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormMedicineDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_medi__id_st__3CE2F598");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormMedicineDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_medi__id_us__3DD719D1");
            });

            modelBuilder.Entity<NormModule>(entity =>
            {
                entity.HasKey(e => e.IdModule)
                    .HasName("PK__norm_mod__B2584DEADDD31CAF");

                entity.ToTable("norm_module");

                entity.HasIndex(e => e.ViewName, "UQ__norm_mod__0589543BC252042D")
                    .IsUnique();

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.Property(e => e.Description)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.TableDetailName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("table_detail_name");

                entity.Property(e => e.TableName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("table_name");

                entity.Property(e => e.Title)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.ViewName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("view_name");
            });

            modelBuilder.Entity<NormOther>(entity =>
            {
                entity.HasKey(e => e.IdOther)
                    .HasName("PK__norm_oth__EB6CAE8A1A670B0A");

                entity.ToTable("norm_other");

                entity.Property(e => e.IdOther).HasColumnName("id_other");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormOther)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_othe__id_re__755C58E5");
            });

            modelBuilder.Entity<NormOtherDetail>(entity =>
            {
                entity.HasKey(e => e.IdOtherDetail)
                    .HasName("PK__norm_oth__50EB401065ED9E41");

                entity.ToTable("norm_other_detail");

                entity.Property(e => e.IdOtherDetail).HasColumnName("id_other_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdOther).HasColumnName("id_other");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdWorkposition)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("id_workposition");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.Property(e => e.UsePeriod)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("use_period");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormOtherDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_othe__id_me__28DBFCEB");

                entity.HasOne(d => d.IdOtherNavigation)
                    .WithMany(p => p.NormOtherDetail)
                    .HasForeignKey(d => d.IdOther)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_othe__id_ot__27E7D8B2");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormOtherDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_othe__id_st__29D02124");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormOtherDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_othe__id_us__2AC4455D");
            });

            modelBuilder.Entity<NormOveralls>(entity =>
            {
                entity.HasKey(e => e.IdOveralls)
                    .HasName("PK__norm_ove__BCF1C6E3233C2AEF");

                entity.ToTable("norm_overalls");

                entity.Property(e => e.IdOveralls).HasColumnName("id_overalls");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormOveralls)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_over__id_re__10104F21");
            });

            modelBuilder.Entity<NormOverallsDetail>(entity =>
            {
                entity.HasKey(e => e.IdOverallsDetail)
                    .HasName("PK__norm_ove__1BFDC3ACE2C935C9");

                entity.ToTable("norm_overalls_detail");

                entity.Property(e => e.IdOverallsDetail).HasColumnName("id_overalls_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdOveralls).HasColumnName("id_overalls");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormOverallsDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_over__id_me__4B3114EF");

                entity.HasOne(d => d.IdOverallsNavigation)
                    .WithMany(p => p.NormOverallsDetail)
                    .HasForeignKey(d => d.IdOveralls)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_over__id_ov__4A3CF0B6");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormOverallsDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_over__id_st__4C253928");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormOverallsDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_over__id_us__4D195D61");
            });

            modelBuilder.Entity<NormPartition>(entity =>
            {
                entity.HasKey(e => e.IdPartition)
                    .HasName("PK__norm_par__A30D5C685F31486E");

                entity.ToTable("norm_partition");

                entity.Property(e => e.IdPartition).HasColumnName("id_partition");

                entity.Property(e => e.Description)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PartNum).HasColumnName("part_num");
            });

            modelBuilder.Entity<NormReference>(entity =>
            {
                entity.HasKey(e => e.IdReference)
                    .HasName("PK__norm_ref__E4A8676D69DE8692");

                entity.ToTable("norm_reference");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("date_create")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdGroup).HasColumnName("id_group");

                entity.Property(e => e.IdKvr)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("id_kvr");

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.Property(e => e.IdOkpd)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("id_okpd");

                entity.Property(e => e.IdReferenceType).HasColumnName("id_reference_type");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.StatusComment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("status_comment");

                entity.Property(e => e.UserCreate)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_create");

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.NormReference)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK__norm_refe__id_gr__6CB2044B");

                entity.HasOne(d => d.IdModuleNavigation)
                    .WithMany(p => p.NormReference)
                    .HasForeignKey(d => d.IdModule)
                    .HasConstraintName("FK__norm_refe__id_mo__17E67B13");

                entity.HasOne(d => d.IdReferenceTypeNavigation)
                    .WithMany(p => p.NormReference)
                    .HasForeignKey(d => d.IdReferenceType)
                    .HasConstraintName("FK__norm_refe__id_re__18DA9F4C");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormReference)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__norm_refe__id_st__4543316F");
            });

            modelBuilder.Entity<NormReferenceKvrCross>(entity =>
            {
                entity.HasKey(e => e.IdReferenceKvrCross)
                    .HasName("PK__norm_ref__20871560BD487922");

                entity.ToTable("norm_reference_kvr_cross");

                entity.Property(e => e.IdReferenceKvrCross).HasColumnName("id_reference_kvr_cross");

                entity.Property(e => e.IdKvr).HasColumnName("id_kvr");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdKvrNavigation)
                    .WithMany(p => p.NormReferenceKvrCross)
                    .HasForeignKey(d => d.IdKvr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_refe__id_kv__2C0D6F51");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormReferenceKvrCross)
                    .HasForeignKey(d => d.IdReference)
                    .HasConstraintName("FK__norm_refe__id_re__2B194B18");
            });

            modelBuilder.Entity<NormReferenceOkpdCross>(entity =>
            {
                entity.HasKey(e => e.IdReferenceOkpdCross)
                    .HasName("PK__norm_ref__2D0CC86B9FBFEB6B");

                entity.ToTable("norm_reference_okpd_cross");

                entity.Property(e => e.IdReferenceOkpdCross).HasColumnName("id_reference_okpd_cross");

                entity.Property(e => e.IdOkpd).HasColumnName("id_okpd");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdOkpdNavigation)
                    .WithMany(p => p.NormReferenceOkpdCross)
                    .HasForeignKey(d => d.IdOkpd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_refe__id_ok__08E42EA5");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormReferenceOkpdCross)
                    .HasForeignKey(d => d.IdReference)
                    .HasConstraintName("FK__norm_refe__id_re__09D852DE");
            });

            modelBuilder.Entity<NormReferenceType>(entity =>
            {
                entity.HasKey(e => e.IdReferenceType)
                    .HasName("PK__norm_ref__FE19457828BC63FB");

                entity.ToTable("norm_reference_type");

                entity.Property(e => e.IdReferenceType).HasColumnName("id_reference_type");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<NormRent>(entity =>
            {
                entity.HasKey(e => e.IdRent)
                    .HasName("PK__norm_ren__0F4BF3B05CD3FA10");

                entity.ToTable("norm_rent");

                entity.Property(e => e.IdRent).HasColumnName("id_rent");

                entity.Property(e => e.AppNum).HasColumnName("app_num");

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdModuleNavigation)
                    .WithMany(p => p.NormRent)
                    .HasForeignKey(d => d.IdModule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_rent__id_mo__02EB5E2D");
            });

            modelBuilder.Entity<NormRepairs>(entity =>
            {
                entity.HasKey(e => e.IdRepairs)
                    .HasName("PK__norm_rep__6414CB74E082EB17");

                entity.ToTable("norm_repairs");

                entity.Property(e => e.IdRepairs).HasColumnName("id_repairs");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormRepairs)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_repa__id_re__086F2D59");
            });

            modelBuilder.Entity<NormRepairsDetail>(entity =>
            {
                entity.HasKey(e => e.IdRepairsDetail)
                    .HasName("PK__norm_rep__CB9232AD5302410A");

                entity.ToTable("norm_repairs_detail");

                entity.Property(e => e.IdRepairsDetail).HasColumnName("id_repairs_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdRepairs).HasColumnName("id_repairs");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormRepairsDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_repa__id_me__38A85060");

                entity.HasOne(d => d.IdRepairsNavigation)
                    .WithMany(p => p.NormRepairsDetail)
                    .HasForeignKey(d => d.IdRepairs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_repa__id_re__7803BB66");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormRepairsDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_repa__id_st__78F7DF9F");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormRepairsDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_repa__id_us__79EC03D8");
            });

            modelBuilder.Entity<NormSecurity>(entity =>
            {
                entity.HasKey(e => e.IdSecurity)
                    .HasName("PK__norm_sec__041ECB074DE23FA0");

                entity.ToTable("norm_security");

                entity.Property(e => e.IdSecurity).HasColumnName("id_security");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormSecurity)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_secu__id_re__1E5E6E78");
            });

            modelBuilder.Entity<NormSecurityDetail>(entity =>
            {
                entity.HasKey(e => e.IdSecurityDetail)
                    .HasName("PK__norm_sec__DC10DD48E3AAC291");

                entity.ToTable("norm_security_detail");

                entity.Property(e => e.IdSecurityDetail).HasColumnName("id_security_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdSecurity).HasColumnName("id_security");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormSecurityDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_secu__id_me__0651DABD");

                entity.HasOne(d => d.IdSecurityNavigation)
                    .WithMany(p => p.NormSecurityDetail)
                    .HasForeignKey(d => d.IdSecurity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_secu__id_se__055DB684");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormSecurityDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_secu__id_st__0745FEF6");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormSecurityDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_secu__id_us__083A232F");
            });

            modelBuilder.Entity<NormService>(entity =>
            {
                entity.HasKey(e => e.IdService)
                    .HasName("PK__norm_ser__D06FB5A89E2D5EDB");

                entity.ToTable("norm_service");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.Property(e => e.AppNum).HasColumnName("app_num");

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdModuleNavigation)
                    .WithMany(p => p.NormService)
                    .HasForeignKey(d => d.IdModule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_serv__id_mo__5EADFDB7");
            });

            modelBuilder.Entity<NormTypographic>(entity =>
            {
                entity.HasKey(e => e.IdTypographic)
                    .HasName("PK__norm_typ__B2CD0587285F61F9");

                entity.ToTable("norm_typographic");

                entity.Property(e => e.IdTypographic).HasColumnName("id_typographic");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormTypographic)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_typo__id_re__1B8201CD");
            });

            modelBuilder.Entity<NormTypographicDetail>(entity =>
            {
                entity.HasKey(e => e.IdTypographicDetail)
                    .HasName("PK__norm_typ__6E03A4AB60A83345");

                entity.ToTable("norm_typographic_detail");

                entity.Property(e => e.IdTypographicDetail).HasColumnName("id_typographic_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdTypographic).HasColumnName("id_typographic");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormTypographicDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_typo__id_me__69B59C0F");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormTypographicDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_typo__id_st__6AA9C048");

                entity.HasOne(d => d.IdTypographicNavigation)
                    .WithMany(p => p.NormTypographicDetail)
                    .HasForeignKey(d => d.IdTypographic)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_typo__id_ty__68C177D6");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormTypographicDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_typo__id_us__6B9DE481");
            });

            modelBuilder.Entity<NormUtilities>(entity =>
            {
                entity.HasKey(e => e.IdUtilities)
                    .HasName("PK__norm_uti__B741862866C21FC2");

                entity.ToTable("norm_utilities");

                entity.Property(e => e.IdUtilities).HasColumnName("id_utilities");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormUtilities)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_util__id_re__7FD9E758");
            });

            modelBuilder.Entity<NormUtilitiesDetail>(entity =>
            {
                entity.HasKey(e => e.IdUtilitiesDetail)
                    .HasName("PK__norm_uti__A52A4D67FA246338");

                entity.ToTable("norm_utilities_detail");

                entity.Property(e => e.IdUtilitiesDetail).HasColumnName("id_utilities_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdUtilities).HasColumnName("id_utilities");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormUtilitiesDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_util__id_me__307D1EB3");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormUtilitiesDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_util__id_st__317142EC");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormUtilitiesDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_util__id_us__32656725");

                entity.HasOne(d => d.IdUtilitiesNavigation)
                    .WithMany(p => p.NormUtilitiesDetail)
                    .HasForeignKey(d => d.IdUtilities)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_util__id_ut__2F88FA7A");
            });

            modelBuilder.Entity<NormWork>(entity =>
            {
                entity.HasKey(e => e.IdWork)
                    .HasName("PK__norm_wor__66D4E4BCF52A8921");

                entity.ToTable("norm_work");

                entity.Property(e => e.IdWork).HasColumnName("id_work");

                entity.Property(e => e.AppNum).HasColumnName("app_num");

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdModuleNavigation)
                    .WithMany(p => p.NormWork)
                    .HasForeignKey(d => d.IdModule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_work__id_mo__6FD889B9");
            });

            modelBuilder.Entity<NormWorkposition>(entity =>
            {
                entity.HasKey(e => e.IdWorkposition)
                    .HasName("PK__norm_wor__A16C1814EFBEDEF7");

                entity.ToTable("norm_workposition");

                entity.Property(e => e.IdWorkposition).HasColumnName("id_workposition");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NameIncline)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_incline");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormWorkposition)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__norm_work__id_us__1376CBB1");
            });

            modelBuilder.Entity<NormWwfWork>(entity =>
            {
                entity.HasKey(e => e.IdWwfWork)
                    .HasName("PK__norm_wwf__800B005FBF7C10FC");

                entity.ToTable("norm_wwf_work");

                entity.Property(e => e.IdWwfWork).HasColumnName("id_wwf_work");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.IdReference).HasColumnName("id_reference");

                entity.HasOne(d => d.IdReferenceNavigation)
                    .WithMany(p => p.NormWwfWork)
                    .HasForeignKey(d => d.IdReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_wwf___id_re__12ECBBCC");
            });

            modelBuilder.Entity<NormWwfWorkDetail>(entity =>
            {
                entity.HasKey(e => e.IdWwfWorkDetail)
                    .HasName("PK__norm_wwf__C97CB85B486F96C0");

                entity.ToTable("norm_wwf_work_detail");

                entity.Property(e => e.IdWwfWorkDetail).HasColumnName("id_wwf_work_detail");

                entity.Property(e => e.Comment)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CountInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("count_info");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("date")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdWwfWork).HasColumnName("id_wwf_work");

                entity.Property(e => e.IsNoCount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_count")
                    .IsFixedLength(true);

                entity.Property(e => e.IsNoPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_no_price")
                    .IsFixedLength(true);

                entity.Property(e => e.Justification)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justification");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PriceInfo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("price_info");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.NormWwfWorkDetail)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .HasConstraintName("FK__norm_wwf___id_me__52D236B7");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NormWwfWorkDetail)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_wwf___id_st__53C65AF0");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NormWwfWorkDetail)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_wwf___id_us__54BA7F29");

                entity.HasOne(d => d.IdWwfWorkNavigation)
                    .WithMany(p => p.NormWwfWorkDetail)
                    .HasForeignKey(d => d.IdWwfWork)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__norm_wwf___id_ww__51DE127E");
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRIORITY");

                entity.Property(e => e.IdPriority)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PRIORITY");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<RefDocType>(entity =>
            {
                entity.HasKey(e => e.IdDocType)
                    .HasName("PK__ref_doc___9785B94BA9AD0264");

                entity.ToTable("ref_doc_type");

                entity.Property(e => e.IdDocType).HasColumnName("id_doc_type");

                entity.Property(e => e.DocType).HasColumnName("doc_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<RefProfessions>(entity =>
            {
                entity.HasKey(e => e.IdProfessions)
                    .HasName("PK__ref_prof__F637922BF8E41F44");

                entity.ToTable("ref_professions");

                entity.Property(e => e.IdProfessions).HasColumnName("id_professions");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Refugee>(entity =>
            {
                entity.HasKey(e => e.IdRefugee)
                    .HasName("PK__refugee__FEB9CDE48178975B");

                entity.ToTable("refugee");

                entity.Property(e => e.IdRefugee).HasColumnName("id_refugee");

                entity.Property(e => e.Amount)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("amount");

                entity.Property(e => e.ArrDate)
                    .HasColumnType("date")
                    .HasColumnName("arr_date");

                entity.Property(e => e.ArrTime).HasColumnName("arr_time");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("birth_date");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.DocType).HasColumnName("doc_type");

                entity.Property(e => e.Document)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("document");

                entity.Property(e => e.Electricity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("electricity");

                entity.Property(e => e.Gas)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gas");

                entity.Property(e => e.HouseNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("house_number");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.LeaveDate)
                    .HasColumnType("date")
                    .HasColumnName("leave_date");

                entity.Property(e => e.LeaveTime).HasColumnName("leave_time");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("middle_name");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Region)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("region");

                entity.Property(e => e.Street)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("street");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("surname");

                entity.Property(e => e.Water)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("water");

                entity.Property(e => e.Work)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("work");
            });

            modelBuilder.Entity<ReminderType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REMINDER_TYPE");

                entity.Property(e => e.Cicl)
                    .HasColumnType("datetime")
                    .HasColumnName("CICL");

                entity.Property(e => e.IdReminderType)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_REMINDER_TYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<SmGroupJob>(entity =>
            {
                entity.HasKey(e => e.IdGroupJob)
                    .HasName("PK__sm_group__A5FD40E2320F9613");

                entity.ToTable("sm_group_job");

                entity.HasIndex(e => e.Code, "UQ__sm_group__357D4CF934EC02BE")
                    .IsUnique();

                entity.HasIndex(e => e.OrderNum, "UQ__sm_group__876866AB37C86F69")
                    .IsUnique();

                entity.Property(e => e.IdGroupJob).HasColumnName("id_group_job");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OrderNum).HasColumnName("order_num");

                entity.Property(e => e.Subgroups).HasColumnName("subgroups");
            });

            modelBuilder.Entity<SmJob>(entity =>
            {
                entity.HasKey(e => e.IdJob)
                    .HasName("PK__sm_job__D366B1F73B99004D");

                entity.ToTable("sm_job");

                entity.HasIndex(e => e.Code, "UQ__sm_job__357D4CF93E756CF8")
                    .IsUnique();

                entity.Property(e => e.IdJob).HasColumnName("id_job");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.IdGroupJob).HasColumnName("id_group_job");

                entity.Property(e => e.IdMain).HasColumnName("id_main");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.Is742).HasColumnName("is_742");

                entity.Property(e => e.Is742Cons).HasColumnName("is_742_cons");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OrderNum).HasColumnName("order_num");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.HasOne(d => d.IdGroupJobNavigation)
                    .WithMany(p => p.SmJob)
                    .HasForeignKey(d => d.IdGroupJob)
                    .HasConstraintName("FK__sm_job__id_group__652525C5");
            });

            modelBuilder.Entity<SmMonthSalary>(entity =>
            {
                entity.HasKey(e => e.IdMonthSalary)
                    .HasName("PK__sm_month__41EFC0EC4245FDDC");

                entity.ToTable("sm_month_salary");

                entity.HasIndex(e => new { e.IdUser, e.Month, e.IdSourceFinance }, "UQ__sm_month__31F7D11B45226A87")
                    .IsUnique();

                entity.Property(e => e.IdMonthSalary).HasColumnName("id_month_salary");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.DateApprove)
                    .HasColumnType("datetime")
                    .HasColumnName("date_approve");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_create")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSourceFinance).HasColumnName("id_source_finance");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.RejectionReason)
                    .HasColumnType("text")
                    .HasColumnName("rejection_reason");

                entity.HasOne(d => d.IdSourceFinanceNavigation)
                    .WithMany(p => p.SmMonthSalary)
                    .HasForeignKey(d => d.IdSourceFinance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sm_month___id_so__661949FE");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.SmMonthSalary)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sm_month___id_st__670D6E37");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.SmMonthSalary)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sm_month___id_us__68019270");
            });

            modelBuilder.Entity<SmMonthSalaryDetail>(entity =>
            {
                entity.HasKey(e => e.IdMonthSalaryDetail)
                    .HasName("PK__sm_month__CA684BC348F2FB6B");

                entity.ToTable("sm_month_salary_detail");

                entity.Property(e => e.IdMonthSalaryDetail).HasColumnName("id_month_salary_detail");

                entity.Property(e => e.Annotation)
                    .HasColumnType("text")
                    .HasColumnName("annotation");

                entity.Property(e => e.Bonus)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bonus");

                entity.Property(e => e.Combining)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("combining");

                entity.Property(e => e.FondSalary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fond_salary");

                entity.Property(e => e.HarmfulConditions)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("harmful_conditions");

                entity.Property(e => e.Holidays)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("holidays");

                entity.Property(e => e.IdJob).HasColumnName("id_job");

                entity.Property(e => e.IdMonthSalary).HasColumnName("id_month_salary");

                entity.Property(e => e.LeavePay)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("leave_pay");

                entity.Property(e => e.MaterialHelp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("material_help");

                entity.Property(e => e.OtherInc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("other_inc");

                entity.Property(e => e.OtherPays)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("other_pays");

                entity.Property(e => e.PersonalInc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("personal_inc");

                entity.Property(e => e.PremisesPayComp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("premises_pay_comp");

                entity.Property(e => e.QualifCateg)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qualif_categ");

                entity.Property(e => e.RateApproved)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate_approved")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateAverage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate_average")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RateFact)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate_fact")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rural)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rural");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SalaryTeacher)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salary_teacher");

                entity.Property(e => e.ScienceDegreeInc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("science_degree_inc");

                entity.Property(e => e.ServiceLengthInc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("service_length_inc");

                entity.Property(e => e.SickList)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sick_list");

                entity.Property(e => e.WorkSpecific)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("work_specific");

                entity.HasOne(d => d.IdJobNavigation)
                    .WithMany(p => p.SmMonthSalaryDetail)
                    .HasForeignKey(d => d.IdJob)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sm_month___id_jo__68F5B6A9");

                entity.HasOne(d => d.IdMonthSalaryNavigation)
                    .WithMany(p => p.SmMonthSalaryDetail)
                    .HasForeignKey(d => d.IdMonthSalary)
                    .HasConstraintName("FK__sm_month___id_mo__69E9DAE2");
            });

            modelBuilder.Entity<SmPaymentOrder>(entity =>
            {
                entity.HasKey(e => e.IdPaymentOrder)
                    .HasName("PK__sm_payme__29DB3AB5D017D3AD");

                entity.ToTable("sm_payment_order");

                entity.Property(e => e.IdPaymentOrder).HasColumnName("id_payment_order");

                entity.Property(e => e.AppDate)
                    .HasColumnType("date")
                    .HasColumnName("app_date");

                entity.Property(e => e.AppNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("app_number");

                entity.Property(e => e.BudgControlResult)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("budg_control_result");

                entity.Property(e => e.BudgDistrict)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("budg_district");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("card_number");

                entity.Property(e => e.ChangeDate)
                    .HasColumnType("date")
                    .HasColumnName("change_date");

                entity.Property(e => e.ClassificType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("classific_type");

                entity.Property(e => e.Condition)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("condition");

                entity.Property(e => e.CounterpartyDistrict)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("counterparty_district");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("date")
                    .HasColumnName("creation_date");

                entity.Property(e => e.DocStatuses)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("doc_statuses");

                entity.Property(e => e.FailureReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("failure_reason");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Nds)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nds");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("number");

                entity.Property(e => e.OperationDirection)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("operation_direction");

                entity.Property(e => e.PayDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pay_details");

                entity.Property(e => e.PayOrdDate)
                    .HasColumnType("date")
                    .HasColumnName("pay_ord_date");

                entity.Property(e => e.PayOrdNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pay_ord_number");

                entity.Property(e => e.PayPeriod)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pay_period");

                entity.Property(e => e.PayPriority)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pay_priority");

                entity.Property(e => e.PayType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pay_type");

                entity.Property(e => e.Payer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("payer");

                entity.Property(e => e.PersAccFk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pers_acc_fk");

                entity.Property(e => e.PersAccPayer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pers_acc_payer");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("posting_date");

                entity.Property(e => e.ProcedureType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("procedure_type");

                entity.Property(e => e.RecipInn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("recip_inn");

                entity.Property(e => e.RecipKpp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("recip_kpp");

                entity.Property(e => e.RecipOrgName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("recip_org_name");

                entity.Property(e => e.RecipPayAcc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("recip_pay_acc");

                entity.Property(e => e.RecipPersAccRvs)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("recip_pers_acc_rvs");

                entity.Property(e => e.RecordsTypeOld)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("records_type_old");

                entity.Property(e => e.RegDate)
                    .HasColumnType("date")
                    .HasColumnName("reg_date");

                entity.Property(e => e.RegNum)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("reg_num");

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("reject_reason");

                entity.Property(e => e.RejectReasonText)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("reject_reason_text");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.StoredPayDet)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("stored_pay_det");

                entity.Property(e => e.SubAcc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sub_acc");

                entity.Property(e => e.SumAppNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sum_app_number");

                entity.Property(e => e.Summ)
                    .HasColumnType("money")
                    .HasColumnName("summ");

                entity.Property(e => e.SysFailure)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sys_failure");

                entity.Property(e => e.TaxPayInform)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tax_pay_inform");

                entity.Property(e => e.TreasureAcc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("treasure_acc");

                entity.Property(e => e.Uin)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("uin");

                entity.Property(e => e.UnclimbedControlsList)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("unclimbed_controls_list");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.SmPaymentOrder)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user");
            });

            modelBuilder.Entity<SmPaymentOrderDetail>(entity =>
            {
                entity.HasKey(e => e.IdPaymentOrderDetail)
                    .HasName("PK__sm_payme__23809DC9DE843D65");

                entity.ToTable("sm_payment_order_detail");

                entity.Property(e => e.IdPaymentOrderDetail).HasColumnName("id_payment_order_detail");

                entity.Property(e => e.BudgAllocationCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("budg_allocation_code");

                entity.Property(e => e.BudgControlResult)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("budg_control_result");

                entity.Property(e => e.ClassificType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("classific_type");

                entity.Property(e => e.Classification)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("classification");

                entity.Property(e => e.DateChange)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("date_change");

                entity.Property(e => e.DateCreate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("date_create");

                entity.Property(e => e.Direction)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("direction");

                entity.Property(e => e.DistrictOfTransfert)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("district_of_transfert");

                entity.Property(e => e.DistrictOfTransfertName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("district_of_transfert_name");

                entity.Property(e => e.DocFoundation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("doc_foundation");

                entity.Property(e => e.DocPayerExecution)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("doc_payer_execution");

                entity.Property(e => e.DocType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("doc_type");

                entity.Property(e => e.FundsType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("funds_type");

                entity.Property(e => e.IdPaymentOrder).HasColumnName("id_payment_order");

                entity.Property(e => e.Kosgu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("kosgu");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.NumBudgLiability)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("num_budg_liability");

                entity.Property(e => e.ObjectiveCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("objective_code");

                entity.Property(e => e.Operation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("operation");

                entity.Property(e => e.PoEvent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("po_event");

                entity.Property(e => e.SourceEducation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("source_education");

                entity.Property(e => e.SourceFinance)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("source_finance");

                entity.Property(e => e.SpendingObligationsCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("spending_obligations_code");

                entity.Property(e => e.SubsidyCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("subsidy_code");

                entity.Property(e => e.Summ)
                    .HasColumnType("money")
                    .HasColumnName("summ");

                entity.Property(e => e.TrustFundsCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("trust_funds_code");

                entity.Property(e => e.TypeFinance)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("type_finance");

                entity.HasOne(d => d.IdPaymentOrderNavigation)
                    .WithMany(p => p.SmPaymentOrderDetail)
                    .HasForeignKey(d => d.IdPaymentOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sm_paymen__id_pa__78E205AF");
            });

            modelBuilder.Entity<SmSourceFinance>(entity =>
            {
                entity.HasKey(e => e.IdSourceFinance)
                    .HasName("PK__sm_sourc__FBE26AC24BCF6816");

                entity.ToTable("sm_source_finance");

                entity.Property(e => e.IdSourceFinance).HasColumnName("id_source_finance");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STATUS");

                entity.Property(e => e.IdStatus)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_STATUS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<StcontBg2Svod>(entity =>
            {
                entity.HasKey(e => e.IdBg2Svod)
                    .HasName("PK__stcont_b__62BAEE854F9FF8FA");

                entity.ToTable("stcont_bg2_svod");

                entity.Property(e => e.IdBg2Svod).HasColumnName("id_bg2_svod");

                entity.Property(e => e.IdBg2Char).HasColumnName("id_bg2_char");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumClosedAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_auction");

                entity.Property(e => e.SumClosedCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_competition");

                entity.Property(e => e.SumOpenAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_auction");

                entity.Property(e => e.SumOpenCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_competition");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request");

                entity.Property(e => e.SumSingleNotrades)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_notrades");

                entity.Property(e => e.SumSingleSmall)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_small");

                entity.HasOne(d => d.IdBg2CharNavigation)
                    .WithMany(p => p.StcontBg2Svod)
                    .HasForeignKey(d => d.IdBg2Char)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_bg__id_bg__6ADDFF1B");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontBg2Svod)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_bg__id_pe__6BD22354");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontBg2Svod)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_bg__id_us__6CC6478D");
            });

            modelBuilder.Entity<StcontBg3SmallBusiness>(entity =>
            {
                entity.HasKey(e => e.IdBg3SmallBusiness)
                    .HasName("PK__stcont_b__AEAA1DE5527C65A5");

                entity.ToTable("stcont_bg3_small_business");

                entity.HasIndex(e => new { e.IdBg3Small, e.IdUser, e.IdPeriodType, e.PeriodValue, e.PeriodYear }, "UQ__stcont_b__D3D8342B5558D250")
                    .IsUnique();

                entity.Property(e => e.IdBg3SmallBusiness).HasColumnName("id_bg3_small_business");

                entity.Property(e => e.IdBg3Small).HasColumnName("id_bg3_small");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumTotal)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_total");

                entity.HasOne(d => d.IdBg3SmallNavigation)
                    .WithMany(p => p.StcontBg3SmallBusiness)
                    .HasForeignKey(d => d.IdBg3Small)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_bg__id_bg__6DBA6BC6");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontBg3SmallBusiness)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_bg__id_pe__6EAE8FFF");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontBg3SmallBusiness)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_bg__id_us__6FA2B438");
            });

            modelBuilder.Entity<StcontBg3Svod>(entity =>
            {
                entity.HasKey(e => e.IdBg3Svod)
                    .HasName("PK__stcont_b__CF6C5BED58353EFB");

                entity.ToTable("stcont_bg3_svod");

                entity.Property(e => e.IdBg3Svod).HasColumnName("id_bg3_svod");

                entity.Property(e => e.IdBg3Small).HasColumnName("id_bg3_small");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumClosedAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_auction");

                entity.Property(e => e.SumClosedCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_competition");

                entity.Property(e => e.SumOpenAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_auction");

                entity.Property(e => e.SumOpenCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_competition");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request");

                entity.HasOne(d => d.IdBg3SmallNavigation)
                    .WithMany(p => p.StcontBg3Svod)
                    .HasForeignKey(d => d.IdBg3Small)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_bg__id_bg__7096D871");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontBg3Svod)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_bg__id_pe__718AFCAA");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontBg3Svod)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_bg__id_us__727F20E3");
            });

            modelBuilder.Entity<StcontContractVeg>(entity =>
            {
                entity.HasKey(e => e.IdContractVeg)
                    .HasName("PK__stcont_c__AA6DB4CFA1266EB4");

                entity.ToTable("stcont_contract_veg");

                entity.Property(e => e.IdContractVeg).HasColumnName("id_contract_veg");

                entity.Property(e => e.CostForContract)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cost_for_contract");

                entity.Property(e => e.CostForList)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cost_for_list");

                entity.Property(e => e.DateContract)
                    .HasColumnType("date")
                    .HasColumnName("date_contract");

                entity.Property(e => e.DateSuplly)
                    .HasColumnType("date")
                    .HasColumnName("date_suplly");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.NumberContract)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("number_contract");
            });

            modelBuilder.Entity<StcontFormHistory>(entity =>
            {
                entity.HasKey(e => e.IdFormHistory)
                    .HasName("PK__stcont_f__B1C413B75B11ABA6");

                entity.ToTable("stcont_form_history");

                entity.Property(e => e.IdFormHistory).HasColumnName("id_form_history");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_create")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdFormWorks).HasColumnName("id_form_works");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("text");

                entity.HasOne(d => d.IdFormWorksNavigation)
                    .WithMany(p => p.StcontFormHistory)
                    .HasForeignKey(d => d.IdFormWorks)
                    .HasConstraintName("FK__stcont_fo__id_fo__7373451C");
            });

            modelBuilder.Entity<StcontFormWorks>(entity =>
            {
                entity.HasKey(e => e.IdFormWorks)
                    .HasName("PK__stcont_f__7E369BC85DEE1851");

                entity.ToTable("stcont_form_works");

                entity.Property(e => e.IdFormWorks).HasColumnName("id_form_works");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.IdForms).HasColumnName("id_forms");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.KsStatus).HasColumnName("ks_status");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.HasOne(d => d.IdFormsNavigation)
                    .WithMany(p => p.StcontFormWorks)
                    .HasForeignKey(d => d.IdForms)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_fo__id_fo__74676955");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontFormWorks)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_fo__id_pe__755B8D8E");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.StcontFormWorks)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_fo__id_st__764FB1C7");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontFormWorks)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_fo__id_us__7743D600");
            });

            modelBuilder.Entity<StcontGoods>(entity =>
            {
                entity.HasKey(e => e.IdGoods)
                    .HasName("PK__stcont_g__DB8A682460CA84FC");

                entity.ToTable("stcont_goods");

                entity.HasIndex(e => new { e.IdUser, e.IdPeriodType, e.PeriodValue, e.PeriodYear, e.IdProductionType, e.NumPp, e.FinNextYear }, "UQ__stcont_g__1448003363A6F1A7")
                    .IsUnique();

                entity.Property(e => e.IdGoods).HasColumnName("id_goods");

                entity.Property(e => e.FinNextYear)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdProductionType).HasColumnName("id_production_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.NumPp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("num_pp");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumApproved)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_approved");

                entity.Property(e => e.SumAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction");

                entity.Property(e => e.SumOnlyAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_auction");

                entity.Property(e => e.SumOnlyExecutor)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_executor");

                entity.Property(e => e.SumOnlyQuotes)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_quotes");

                entity.Property(e => e.SumQuotes)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotes");

                entity.Property(e => e.SumSmallVolume)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_small_volume");

                entity.Property(e => e.SumSt55)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_st55");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontGoods)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_go__id_pe__7837FA39");

                entity.HasOne(d => d.IdProductionTypeNavigation)
                    .WithMany(p => p.StcontGoods)
                    .HasForeignKey(d => d.IdProductionType)
                    .HasConstraintName("FK__stcont_go__id_pr__792C1E72");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontGoods)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_go__id_us__7A2042AB");
            });

            modelBuilder.Entity<StcontGoodsAdmin>(entity =>
            {
                entity.HasKey(e => e.IdGoodsAdmin)
                    .HasName("PK__stcont_g__64A053DC66835E52");

                entity.ToTable("stcont_goods_admin");

                entity.HasIndex(e => e.FinNextYear, "i_goods_admin_fin_next_year");

                entity.Property(e => e.IdGoodsAdmin).HasColumnName("id_goods_admin");

                entity.Property(e => e.CalcType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("calc_type")
                    .IsFixedLength(true);

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdProductionType).HasColumnName("id_production_type");

                entity.Property(e => e.IdStateContract).HasColumnName("id_state_contract");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction");

                entity.Property(e => e.SumAuctionOld)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction_old");

                entity.Property(e => e.SumOnlyAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_auction");

                entity.Property(e => e.SumOnlyAuctionOld)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_auction_old");

                entity.Property(e => e.SumOnlyExecutor)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_executor");

                entity.Property(e => e.SumOnlyExecutorOld)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_executor_old");

                entity.Property(e => e.SumOnlyQuotes)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_quotes");

                entity.Property(e => e.SumOnlyQuotesOld)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_quotes_old");

                entity.Property(e => e.SumQuotes)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotes");

                entity.Property(e => e.SumQuotesOld)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotes_old");

                entity.Property(e => e.SumSmallVolume)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_small_volume");

                entity.Property(e => e.SumSmallVolumeOld)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_small_volume_old");

                entity.Property(e => e.SumSt55)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_st55");

                entity.Property(e => e.SumSt55Old)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_st55_old");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontGoodsAdmin)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_go__id_pe__7B1466E4");

                entity.HasOne(d => d.IdProductionTypeNavigation)
                    .WithMany(p => p.StcontGoodsAdmin)
                    .HasForeignKey(d => d.IdProductionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_go__id_pr__7C088B1D");

                entity.HasOne(d => d.IdStateContractNavigation)
                    .WithMany(p => p.StcontGoodsAdmin)
                    .HasForeignKey(d => d.IdStateContract)
                    .HasConstraintName("FK__stcont_go__id_st__7CFCAF56");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontGoodsAdmin)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_go__id_us__7DF0D38F");
            });

            modelBuilder.Entity<StcontGoodsSvod>(entity =>
            {
                entity.HasKey(e => e.IdGoodsSvod)
                    .HasName("PK__stcont_g__1DC21832695FCAFD");

                entity.ToTable("stcont_goods_svod");

                entity.HasIndex(e => new { e.IdProductionType, e.IdPeriodType, e.PeriodValue, e.PeriodYear, e.IdUser, e.FinNextYear }, "UQ__stcont_g__DF3F5D5A6C3C37A8")
                    .IsUnique();

                entity.HasIndex(e => e.FinNextYear, "i_goods_svod_fin_next_year");

                entity.Property(e => e.IdGoodsSvod).HasColumnName("id_goods_svod");

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdProductionType).HasColumnName("id_production_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction");

                entity.Property(e => e.SumOnlyAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_auction");

                entity.Property(e => e.SumOnlyExecutor)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_executor");

                entity.Property(e => e.SumOnlyQuotes)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_only_quotes");

                entity.Property(e => e.SumQuotes)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotes");

                entity.Property(e => e.SumSmallVolume)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_small_volume");

                entity.Property(e => e.SumSt55)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_st55");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontGoodsSvod)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_go__id_pe__7EE4F7C8");

                entity.HasOne(d => d.IdProductionTypeNavigation)
                    .WithMany(p => p.StcontGoodsSvod)
                    .HasForeignKey(d => d.IdProductionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_go__id_pr__7FD91C01");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontGoodsSvod)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_go__id_us__00CD403A");
            });

            modelBuilder.Entity<StcontListContractVeg>(entity =>
            {
                entity.HasKey(e => e.IdListContractVeg)
                    .HasName("PK__stcont_l__ABD744CB547C5D4C");

                entity.ToTable("stcont_list_contract_veg");

                entity.Property(e => e.IdListContractVeg).HasColumnName("id_list_contract_veg");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cost");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.IdContractVeg).HasColumnName("id_contract_veg");

                entity.Property(e => e.IdVeg).HasColumnName("id_veg");

                entity.HasOne(d => d.IdContractVegNavigation)
                    .WithMany(p => p.StcontListContractVeg)
                    .HasForeignKey(d => d.IdContractVeg)
                    .HasConstraintName("FK__stcont_li__id_co__0FBB4966");

                entity.HasOne(d => d.IdVegNavigation)
                    .WithMany(p => p.StcontListContractVeg)
                    .HasForeignKey(d => d.IdVeg)
                    .HasConstraintName("FK__stcont_li__id_ve__0EC7252D");
            });

            modelBuilder.Entity<StcontNp2Svod>(entity =>
            {
                entity.HasKey(e => e.IdNp2Svod)
                    .HasName("PK__stcont_n__3B97988E3E3846E1");

                entity.ToTable("stcont_np2_svod");

                entity.Property(e => e.IdNp2Svod).HasColumnName("id_np2_svod");

                entity.Property(e => e.ElSumCompetitionClose)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("el_sum_competition_close");

                entity.Property(e => e.ElSumCompetitionCloseDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("el_sum_competition_close_double");

                entity.Property(e => e.ElSumCompetitionCloseLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("el_sum_competition_close_limited");

                entity.Property(e => e.ElSumCompetitionOpen)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("el_sum_competition_open");

                entity.Property(e => e.ElSumCompetitionOpenDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("el_sum_competition_open_double");

                entity.Property(e => e.ElSumCompetitionOpenLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("el_sum_competition_open_limited");

                entity.Property(e => e.ElSumProposalRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("el_sum_proposal_request");

                entity.Property(e => e.ElSumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("el_sum_quotation_request");

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdNp2Alone).HasColumnName("id_np2_alone");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumAuctionClose)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction_close");

                entity.Property(e => e.SumAuctionElectron)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction_electron");

                entity.Property(e => e.SumCompetitionClose)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close");

                entity.Property(e => e.SumCompetitionCloseDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close_double");

                entity.Property(e => e.SumCompetitionCloseLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close_limited");

                entity.Property(e => e.SumCompetitionOpen)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open");

                entity.Property(e => e.SumCompetitionOpenDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_double");

                entity.Property(e => e.SumCompetitionOpenLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_limited");

                entity.Property(e => e.SumProposalRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_proposal_request");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request");

                entity.Property(e => e.SumSingleNotrades)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_notrades");

                entity.Property(e => e.SumSingleSmall)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_small");
            });

            modelBuilder.Entity<StcontNp3Svod>(entity =>
            {
                entity.HasKey(e => e.IdNp3Svod)
                    .HasName("PK__stcont_n__805A766A33A2450A");

                entity.ToTable("stcont_np3_svod");

                entity.Property(e => e.IdNp3Svod).HasColumnName("id_np3_svod");

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdNp3Smp).HasColumnName("id_np3_smp");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumAuctionElectron)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction_electron");

                entity.Property(e => e.SumCompetitionOpen)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open");

                entity.Property(e => e.SumCompetitionOpenDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_double");

                entity.Property(e => e.SumCompetitionOpenLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_limited");

                entity.Property(e => e.SumProposalRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_proposal_request");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request");
            });

            modelBuilder.Entity<StcontNp4Svod>(entity =>
            {
                entity.HasKey(e => e.IdNp4Svod)
                    .HasName("PK__stcont_n__15F68B34A446DFE2");

                entity.ToTable("stcont_np4_svod");

                entity.Property(e => e.IdNp4Svod).HasColumnName("id_np4_svod");

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdNp4Pref).HasColumnName("id_np4_pref");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumAuctionClose)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction_close");

                entity.Property(e => e.SumAuctionElectron)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction_electron");

                entity.Property(e => e.SumCompetitionClose)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close");

                entity.Property(e => e.SumCompetitionCloseDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close_double");

                entity.Property(e => e.SumCompetitionCloseLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close_limited");

                entity.Property(e => e.SumCompetitionOpen)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open");

                entity.Property(e => e.SumCompetitionOpenDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_double");

                entity.Property(e => e.SumCompetitionOpenLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_limited");

                entity.Property(e => e.SumProposalRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_proposal_request");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request")
                    .HasDefaultValueSql("((0.00000))");
            });

            modelBuilder.Entity<StcontPayCharge>(entity =>
            {
                entity.HasKey(e => e.IdPayCharge)
                    .HasName("PK__stcont_p__F05E70546F18A453");

                entity.ToTable("stcont_pay_charge");

                entity.Property(e => e.IdPayCharge).HasColumnName("id_pay_charge");

                entity.Property(e => e.DatePay)
                    .HasColumnType("date")
                    .HasColumnName("date_pay");

                entity.Property(e => e.IdPpSourceFinance)
                    .HasColumnName("id_pp_source_finance")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdStateContract).HasColumnName("id_state_contract");

                entity.Property(e => e.NameFull)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.Num)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("num");

                entity.Property(e => e.Summ)
                    .HasColumnType("money")
                    .HasColumnName("summ");

                entity.HasOne(d => d.IdPpSourceFinanceNavigation)
                    .WithMany(p => p.StcontPayCharge)
                    .HasForeignKey(d => d.IdPpSourceFinance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pa__id_pp__02B588AC");

                entity.HasOne(d => d.IdStateContractNavigation)
                    .WithMany(p => p.StcontPayCharge)
                    .HasForeignKey(d => d.IdStateContract)
                    .HasConstraintName("FK__stcont_pa__id_st__01C16473");
            });

            modelBuilder.Entity<StcontPlaceModeCharacteristic>(entity =>
            {
                entity.HasKey(e => e.IdPlaceModeCharacteristic)
                    .HasName("PK__stcont_p__A9B1EF0E307C535C");

                entity.ToTable("stcont_place_mode_characteristic");

                entity.HasIndex(e => new { e.IdUser, e.IdPeriodType, e.PeriodYear, e.PeriodValue, e.IdPlaceForm, e.FinNextYear }, "u_stcont_place_mode_char")
                    .IsUnique();

                entity.Property(e => e.IdPlaceModeCharacteristic).HasColumnName("id_place_mode_characteristic");

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdPlaceForm).HasColumnName("id_place_form");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumAucClosed)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auc_closed");

                entity.Property(e => e.SumAucElectron)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auc_electron");

                entity.Property(e => e.SumComLimitedOpen)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_com_limited_open");

                entity.Property(e => e.SumCompClosed)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_comp_closed");

                entity.Property(e => e.SumCompClosedLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_comp_closed_limited");

                entity.Property(e => e.SumCompClosedTwostage)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_comp_closed_twostage");

                entity.Property(e => e.SumCompOpen)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_comp_open");

                entity.Property(e => e.SumCompOpenRepeated)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_comp_open_repeated");

                entity.Property(e => e.SumCompTwostage)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_comp_twostage");

                entity.Property(e => e.SumOffer)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_offer");

                entity.Property(e => e.SumQuotation)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation");

                entity.Property(e => e.SumSingleWithoutConcur)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_without_concur");

                entity.Property(e => e.SumSmallVolume)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_small_volume");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontPlaceModeCharacteristic)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stcont_pl_id_period_type");

                entity.HasOne(d => d.IdPlaceFormNavigation)
                    .WithMany(p => p.StcontPlaceModeCharacteristic)
                    .HasForeignKey(d => d.IdPlaceForm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pl__id_pl__32649BCE");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontPlaceModeCharacteristic)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_stcont_pl_id_user");
            });

            modelBuilder.Entity<StcontPlacing>(entity =>
            {
                entity.HasKey(e => e.IdPlacing)
                    .HasName("PK__stcont_p__43EEF2EF71F510FE");

                entity.ToTable("stcont_placing");

                entity.HasIndex(e => new { e.IdPlacingOrder, e.IdUser, e.IdPeriodType, e.PeriodValue, e.PeriodYear }, "UQ__stcont_p__D4AF2CB974D17DA9")
                    .IsUnique();

                entity.Property(e => e.IdPlacing).HasColumnName("id_placing");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdPlacingOrder).HasColumnName("id_placing_order");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumClosedAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_auction");

                entity.Property(e => e.SumClosedCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_competition");

                entity.Property(e => e.SumOpenAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_auction");

                entity.Property(e => e.SumOpenCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_competition");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request");

                entity.Property(e => e.SumSingleLaw)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_law");

                entity.Property(e => e.SumSingleOther)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_other");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontPlacing)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pl__id_pe__03A9ACE5");

                entity.HasOne(d => d.IdPlacingOrderNavigation)
                    .WithMany(p => p.StcontPlacing)
                    .HasForeignKey(d => d.IdPlacingOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pl__id_pl__049DD11E");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontPlacing)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pl__id_us__0591F557");
            });

            modelBuilder.Entity<StcontPlacingSvod>(entity =>
            {
                entity.HasKey(e => e.IdPlacingSvod)
                    .HasName("PK__stcont_p__7035D24077ADEA54");

                entity.ToTable("stcont_placing_svod");

                entity.HasIndex(e => new { e.IdPlacingOrder, e.IdUser, e.IdPeriodType, e.PeriodValue, e.PeriodYear, e.FinNextYear }, "UQ__stcont_p__9363E2427A8A56FF")
                    .IsUnique();

                entity.HasIndex(e => e.FinNextYear, "i_placing_order_fin_next_year");

                entity.Property(e => e.IdPlacingSvod).HasColumnName("id_placing_svod");

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdPlacingOrder).HasColumnName("id_placing_order");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumClosedAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_auction");

                entity.Property(e => e.SumClosedCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_competition");

                entity.Property(e => e.SumOpenAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_auction");

                entity.Property(e => e.SumOpenCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_competition");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request");

                entity.Property(e => e.SumSingle1113)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_11_13");

                entity.Property(e => e.SumSingle89)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_8_9");

                entity.Property(e => e.SumSingleLaw)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_law");

                entity.Property(e => e.SumSingleOther)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_other");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontPlacingSvod)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pl__id_pe__06861990");

                entity.HasOne(d => d.IdPlacingOrderNavigation)
                    .WithMany(p => p.StcontPlacingSvod)
                    .HasForeignKey(d => d.IdPlacingOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pl__id_pl__077A3DC9");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontPlacingSvod)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pl__id_us__086E6202");
            });

            modelBuilder.Entity<StcontPlacingSvodOld>(entity =>
            {
                entity.HasKey(e => e.IdPlacingSvod)
                    .HasName("PK__stcont_p__7035D2407D66C3AA");

                entity.ToTable("stcont_placing_svod_old");

                entity.HasIndex(e => new { e.IdPlacingOrder, e.IdUser, e.IdPeriodType, e.PeriodValue, e.PeriodYear, e.FinNextYear }, "UQ__stcont_p__9363E24200433055")
                    .IsUnique();

                entity.HasIndex(e => e.FinNextYear, "i_placing_order_old_fin_next_year");

                entity.Property(e => e.IdPlacingSvod).HasColumnName("id_placing_svod");

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdPlacingOrder).HasColumnName("id_placing_order");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumClosedAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_auction");

                entity.Property(e => e.SumClosedCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_competition");

                entity.Property(e => e.SumOpenAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_auction");

                entity.Property(e => e.SumOpenCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_competition");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request");

                entity.Property(e => e.SumSingle1113)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_11_13");

                entity.Property(e => e.SumSingle89)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_8_9");

                entity.Property(e => e.SumSingleLaw)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_law");

                entity.Property(e => e.SumSingleOther)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_other");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontPlacingSvodOld)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pl__id_pe__0962863B");

                entity.HasOne(d => d.IdPlacingOrderNavigation)
                    .WithMany(p => p.StcontPlacingSvodOld)
                    .HasForeignKey(d => d.IdPlacingOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pl__id_pl__0A56AA74");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontPlacingSvodOld)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pl__id_us__0B4ACEAD");
            });

            modelBuilder.Entity<StcontProductionList>(entity =>
            {
                entity.HasKey(e => e.IdProductionList)
                    .HasName("PK__stcont_p__0FA10529031F9D00");

                entity.ToTable("stcont_production_list");

                entity.Property(e => e.IdProductionList).HasColumnName("id_production_list");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.IdMeasureUnit).HasColumnName("id_measure_unit");

                entity.Property(e => e.IdProductionType).HasColumnName("id_production_type");

                entity.Property(e => e.IdStateContract).HasColumnName("id_state_contract");

                entity.Property(e => e.Name)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Okpd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("okpd");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Summ)
                    .HasColumnType("money")
                    .HasColumnName("summ");

                entity.Property(e => e.TotalSum)
                    .HasColumnType("money")
                    .HasColumnName("total_sum");

                entity.HasOne(d => d.IdMeasureUnitNavigation)
                    .WithMany(p => p.StcontProductionList)
                    .HasForeignKey(d => d.IdMeasureUnit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_pr__id_me__0C3EF2E6");

                entity.HasOne(d => d.IdProductionTypeNavigation)
                    .WithMany(p => p.StcontProductionList)
                    .HasForeignKey(d => d.IdProductionType)
                    .HasConstraintName("FK__stcont_pr__id_pr__0D33171F");

                entity.HasOne(d => d.IdStateContractNavigation)
                    .WithMany(p => p.StcontProductionList)
                    .HasForeignKey(d => d.IdStateContract)
                    .HasConstraintName("FK__stcont_pr__id_st__0E273B58");
            });

            modelBuilder.Entity<StcontSbStatistic>(entity =>
            {
                entity.HasKey(e => e.IdSbStatistic)
                    .HasName("PK__stcont_s__5BA4E9E105FC09AB");

                entity.ToTable("stcont_sb_statistic");

                entity.HasIndex(e => new { e.IdSmallBusiness, e.IdUser, e.IdPeriodType, e.PeriodValue, e.PeriodYear }, "UQ__stcont_s__CCBF35FD08D87656")
                    .IsUnique();

                entity.Property(e => e.IdSbStatistic).HasColumnName("id_sb_statistic");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSmallBusiness).HasColumnName("id_small_business");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumClosedAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_auction");

                entity.Property(e => e.SumClosedCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_competition");

                entity.Property(e => e.SumOpenAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_auction");

                entity.Property(e => e.SumOpenCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_competition");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request");

                entity.Property(e => e.SumSingleLaw)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_law");

                entity.Property(e => e.SumSingleOther)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_other");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontSbStatistic)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_sb__id_pe__0F1B5F91");

                entity.HasOne(d => d.IdSmallBusinessNavigation)
                    .WithMany(p => p.StcontSbStatistic)
                    .HasForeignKey(d => d.IdSmallBusiness)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_sb__id_sm__100F83CA");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontSbStatistic)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_sb__id_us__1103A803");
            });

            modelBuilder.Entity<StcontSbSvod>(entity =>
            {
                entity.HasKey(e => e.IdSbSvod)
                    .HasName("PK__stcont_s__7597E4F50BB4E301");

                entity.ToTable("stcont_sb_svod");

                entity.HasIndex(e => new { e.IdSbSvod, e.IdUser, e.IdPeriodType, e.PeriodValue, e.PeriodYear, e.FinNextYear }, "UQ__stcont_s__21D8587C0E914FAC")
                    .IsUnique();

                entity.HasIndex(e => e.FinNextYear, "i_sb_svod_fin_next_year");

                entity.Property(e => e.IdSbSvod).HasColumnName("id_sb_svod");

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSmallBusiness).HasColumnName("id_small_business");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumClosedAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_auction");

                entity.Property(e => e.SumClosedCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_closed_competition");

                entity.Property(e => e.SumOpenAuction)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_auction");

                entity.Property(e => e.SumOpenCompetition)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_open_competition");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request");

                entity.Property(e => e.SumSingle1113)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_11_13");

                entity.Property(e => e.SumSingle89)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_8_9");

                entity.Property(e => e.SumSingleLaw)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_law");

                entity.Property(e => e.SumSingleOther)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_other");

                entity.HasOne(d => d.IdPeriodTypeNavigation)
                    .WithMany(p => p.StcontSbSvod)
                    .HasForeignKey(d => d.IdPeriodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_sb__id_pe__11F7CC3C");

                entity.HasOne(d => d.IdSmallBusinessNavigation)
                    .WithMany(p => p.StcontSbSvod)
                    .HasForeignKey(d => d.IdSmallBusiness)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_sb__id_sm__12EBF075");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontSbSvod)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_sb__id_us__13E014AE");
            });

            modelBuilder.Entity<StcontSd2Svod>(entity =>
            {
                entity.HasKey(e => e.IdSd2Svod)
                    .HasName("PK__stcont_s__06E7BD591C191A41");

                entity.ToTable("stcont_sd2_svod");

                entity.Property(e => e.IdSd2Svod).HasColumnName("id_sd2_svod");

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSd2Alone).HasColumnName("id_sd2_alone");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumAuctionClose)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction_close");

                entity.Property(e => e.SumAuctionElectron)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction_electron");

                entity.Property(e => e.SumCompetitionClose)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close");

                entity.Property(e => e.SumCompetitionCloseDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close_double");

                entity.Property(e => e.SumCompetitionCloseLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close_limited");

                entity.Property(e => e.SumCompetitionOpen)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open");

                entity.Property(e => e.SumCompetitionOpenDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_double");

                entity.Property(e => e.SumCompetitionOpenLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_limited");

                entity.Property(e => e.SumCompetitionOpenRepeat)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_repeat");

                entity.Property(e => e.SumProposalRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_proposal_request");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request");

                entity.Property(e => e.SumSingleNotrades)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_notrades");

                entity.Property(e => e.SumSingleSmall)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_single_small");
            });

            modelBuilder.Entity<StcontSd3Svod>(entity =>
            {
                entity.HasKey(e => e.IdSd3Svod)
                    .HasName("PK__stcont_s__3BB5348B9ED2DEE9");

                entity.ToTable("stcont_sd3_svod");

                entity.Property(e => e.IdSd3Svod).HasColumnName("id_sd3_svod");

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSd3Smp).HasColumnName("id_sd3_smp");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumAuctionElectron)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction_electron");

                entity.Property(e => e.SumCompetitionOpen)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open");

                entity.Property(e => e.SumCompetitionOpenDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_double");

                entity.Property(e => e.SumCompetitionOpenLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_limited");

                entity.Property(e => e.SumProposalRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_proposal_request");

                entity.Property(e => e.SumQuotationRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_quotation_request");
            });

            modelBuilder.Entity<StcontSd4Svod>(entity =>
            {
                entity.HasKey(e => e.IdSd4Svod)
                    .HasName("PK__stcont_s__059FAF5382B86A4F");

                entity.ToTable("stcont_sd4_svod");

                entity.Property(e => e.IdSd4Svod).HasColumnName("id_sd4_svod");

                entity.Property(e => e.FinNextYear)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.IdSd4Pref).HasColumnName("id_sd4_pref");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.SumAuctionClose)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction_close");

                entity.Property(e => e.SumAuctionElectron)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_auction_electron");

                entity.Property(e => e.SumCompetitionClose)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close");

                entity.Property(e => e.SumCompetitionCloseDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close_double");

                entity.Property(e => e.SumCompetitionCloseLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_close_limited");

                entity.Property(e => e.SumCompetitionOpen)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open");

                entity.Property(e => e.SumCompetitionOpenDouble)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_double");

                entity.Property(e => e.SumCompetitionOpenLimited)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_limited");

                entity.Property(e => e.SumCompetitionOpenRepeat)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_competition_open_repeat");

                entity.Property(e => e.SumProposalRequest)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("sum_proposal_request");
            });

            modelBuilder.Entity<StcontStateContract>(entity =>
            {
                entity.HasKey(e => e.IdStateContract)
                    .HasName("PK__stcont_s__8835031D116DBC57");

                entity.ToTable("stcont_state_contract");

                entity.Property(e => e.IdStateContract).HasColumnName("id_state_contract");

                entity.Property(e => e.AllowedAllCnt).HasColumnName("allowed_all_cnt");

                entity.Property(e => e.AllowedBydocumentsCnt).HasColumnName("allowed_bydocuments_cnt");

                entity.Property(e => e.AllowedBypriceCnt).HasColumnName("allowed_byprice_cnt");

                entity.Property(e => e.AllowedMissedCnt).HasColumnName("allowed_missed_cnt");

                entity.Property(e => e.ChangesCnt).HasColumnName("changes_cnt");

                entity.Property(e => e.ChangesSum)
                    .HasColumnType("money")
                    .HasColumnName("changes_sum");

                entity.Property(e => e.ChangesSumMinus)
                    .HasColumnType("money")
                    .HasColumnName("changes_sum_minus");

                entity.Property(e => e.CheaterCnt).HasColumnName("cheater_cnt");

                entity.Property(e => e.ComplaintDate)
                    .HasColumnType("date")
                    .HasColumnName("complaint_date");

                entity.Property(e => e.ComplaintsCnt).HasColumnName("complaints_cnt");

                entity.Property(e => e.ComplaintsProvedCnt).HasColumnName("complaints_proved_cnt");

                entity.Property(e => e.DateAction)
                    .HasColumnType("date")
                    .HasColumnName("date_action");

                entity.Property(e => e.DateCancel)
                    .HasColumnType("date")
                    .HasColumnName("date_cancel");

                entity.Property(e => e.DateConclusion)
                    .HasColumnType("date")
                    .HasColumnName("date_conclusion");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end");

                entity.Property(e => e.DateSupplAgree)
                    .HasColumnType("date")
                    .HasColumnName("date_suppl_agree");

                entity.Property(e => e.DeliveryDayz).HasColumnName("delivery_dayz");

                entity.Property(e => e.DeliveryFrom)
                    .HasColumnType("date")
                    .HasColumnName("delivery_from");

                entity.Property(e => e.DeliveryTo)
                    .HasColumnType("date")
                    .HasColumnName("delivery_to");

                entity.Property(e => e.DisablePersonCnt).HasColumnName("disable_person_cnt");

                entity.Property(e => e.DomesticCnt).HasColumnName("domestic_cnt");

                entity.Property(e => e.FinNextYear)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdArrangement).HasColumnName("id_arrangement");

                entity.Property(e => e.IdBadReason).HasColumnName("id_bad_reason");

                entity.Property(e => e.IdOrderState).HasColumnName("id_order_state");

                entity.Property(e => e.IdPlaceMode).HasColumnName("id_place_mode");

                entity.Property(e => e.IdSourceFinance).HasColumnName("id_source_finance");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("id_status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");

                entity.Property(e => e.IdTerminatedReason).HasColumnName("id_terminated_reason");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdentityCost)
                    .HasColumnType("money")
                    .HasColumnName("identity_cost");

                entity.Property(e => e.InnovativeProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("innovative_product")
                    .IsFixedLength(true);

                entity.Property(e => e.InvalidPlacingDate)
                    .HasColumnType("date")
                    .HasColumnName("invalid_placing_date");

                entity.Property(e => e.Is10percent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_10percent")
                    .IsFixedLength(true);

                entity.Property(e => e.IsAdvanceStatement)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_advance_statement")
                    .IsFixedLength(true);

                entity.Property(e => e.IsAlienProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_alien_product")
                    .IsFixedLength(true);

                entity.Property(e => e.IsArmenProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_armen_product")
                    .IsFixedLength(true);

                entity.Property(e => e.IsBadReason)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_bad_reason")
                    .IsFixedLength(true);

                entity.Property(e => e.IsBelorusProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_belorus_product")
                    .IsFixedLength(true);

                entity.Property(e => e.IsDisablePerson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_disable_person")
                    .IsFixedLength(true);

                entity.Property(e => e.IsDomestic)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_domestic")
                    .IsFixedLength(true);

                entity.Property(e => e.IsEis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_eis")
                    .IsFixedLength(true);

                entity.Property(e => e.IsInvalidPlacing)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_invalid_placing")
                    .IsFixedLength(true);

                entity.Property(e => e.IsKazahProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_kazah_product")
                    .IsFixedLength(true);

                entity.Property(e => e.IsRusProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_rus_product")
                    .IsFixedLength(true);

                entity.Property(e => e.IsSmallSubject)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_small_subject")
                    .IsFixedLength(true);

                entity.Property(e => e.IsSono)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_sono")
                    .IsFixedLength(true);

                entity.Property(e => e.IsSubSono)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_sub_sono")
                    .IsFixedLength(true);

                entity.Property(e => e.IsSupplierAgreement)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_supplier_agreement")
                    .IsFixedLength(true);

                entity.Property(e => e.IsTradeCanceled)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_trade_canceled")
                    .IsFixedLength(true);

                entity.Property(e => e.IsUis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_uis")
                    .IsFixedLength(true);

                entity.Property(e => e.IsViolationPlanned)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_violation_planned")
                    .IsFixedLength(true);

                entity.Property(e => e.IsViolationUnplanned)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_violation_unplanned")
                    .IsFixedLength(true);

                entity.Property(e => e.IsVitalGoods)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_vital_goods")
                    .IsFixedLength(true);

                entity.Property(e => e.IsWinner)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_winner")
                    .IsFixedLength(true);

                entity.Property(e => e.LotDate)
                    .HasColumnType("date")
                    .HasColumnName("lot_date");

                entity.Property(e => e.LotNum)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("lot_num");

                entity.Property(e => e.Member25lowerCnt).HasColumnName("member_25lower_cnt");

                entity.Property(e => e.MemberAppropriateCnt).HasColumnName("member_appropriate_cnt");

                entity.Property(e => e.MemberFullProductCnt).HasColumnName("member_full_product_cnt");

                entity.Property(e => e.MemberInappropriateCnt).HasColumnName("member_inappropriate_cnt");

                entity.Property(e => e.MemberRecallCnt).HasColumnName("member_recall_cnt");

                entity.Property(e => e.MemberVitalGoodsCnt).HasColumnName("member_vital_goods_cnt");

                entity.Property(e => e.NotallowedBydocumentsCnt).HasColumnName("notallowed_bydocuments_cnt");

                entity.Property(e => e.NotallowedBymoneyCnt).HasColumnName("notallowed_bymoney_cnt");

                entity.Property(e => e.NotallowedByrequirementsCnt).HasColumnName("notallowed_byrequirements_cnt");

                entity.Property(e => e.NotallowedByssCnt).HasColumnName("notallowed_byss_cnt");

                entity.Property(e => e.Num)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("num");

                entity.Property(e => e.PaymentDayz).HasColumnName("payment_dayz");

                entity.Property(e => e.ProtocolDate)
                    .HasColumnType("date")
                    .HasColumnName("protocol_date");

                entity.Property(e => e.ProtocolNum)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("protocol_num");

                entity.Property(e => e.ReestrNum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("reestr_num");

                entity.Property(e => e.ResponsibleFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("responsible_fio");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("subject");

                entity.Property(e => e.Summ)
                    .HasColumnType("money")
                    .HasColumnName("summ");

                entity.Property(e => e.SummFact)
                    .HasColumnType("money")
                    .HasColumnName("summ_fact");

                entity.Property(e => e.SummStart)
                    .HasColumnType("money")
                    .HasColumnName("summ_start");

                entity.Property(e => e.SummStartYearAfter)
                    .HasColumnType("money")
                    .HasColumnName("summ_start_year_after");

                entity.Property(e => e.SummStartYearNext)
                    .HasColumnType("money")
                    .HasColumnName("summ_start_year_next");

                entity.Property(e => e.SummStartYearThis)
                    .HasColumnType("money")
                    .HasColumnName("summ_start_year_this");

                entity.Property(e => e.SummYearAfter)
                    .HasColumnType("money")
                    .HasColumnName("summ_year_after");

                entity.Property(e => e.SummYearNext)
                    .HasColumnType("money")
                    .HasColumnName("summ_year_next");

                entity.Property(e => e.SummYearThis)
                    .HasColumnType("money")
                    .HasColumnName("summ_year_this");

                entity.Property(e => e.SystemLow)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("system_low");

                entity.Property(e => e.Together)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("together")
                    .IsFixedLength(true);

                entity.Property(e => e.UisCnt).HasColumnName("uis_cnt");

                entity.Property(e => e.Winners25lowerCnt).HasColumnName("winners_25lower_cnt");

                entity.Property(e => e.WinnersCnt).HasColumnName("winners_cnt");

                entity.HasOne(d => d.IdArrangementNavigation)
                    .WithMany(p => p.StcontStateContract)
                    .HasForeignKey(d => d.IdArrangement)
                    .HasConstraintName("FK__stcont_st__id_ar__14D438E7");

                entity.HasOne(d => d.IdBadReasonNavigation)
                    .WithMany(p => p.StcontStateContract)
                    .HasForeignKey(d => d.IdBadReason)
                    .HasConstraintName("FK__stcont_st__id_ba__15C85D20");

                entity.HasOne(d => d.IdOrderStateNavigation)
                    .WithMany(p => p.StcontStateContract)
                    .HasForeignKey(d => d.IdOrderState)
                    .HasConstraintName("FK__stcont_st__id_or__16BC8159");

                entity.HasOne(d => d.IdPlaceModeNavigation)
                    .WithMany(p => p.StcontStateContract)
                    .HasForeignKey(d => d.IdPlaceMode)
                    .HasConstraintName("FK__stcont_st__id_pl__17B0A592");

                entity.HasOne(d => d.IdSourceFinanceNavigation)
                    .WithMany(p => p.StcontStateContract)
                    .HasForeignKey(d => d.IdSourceFinance)
                    .HasConstraintName("FK__stcont_st__id_so__18A4C9CB");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.StcontStateContract)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_st__id_st__1998EE04");

                entity.HasOne(d => d.IdSupplierNavigation)
                    .WithMany(p => p.StcontStateContract)
                    .HasForeignKey(d => d.IdSupplier)
                    .HasConstraintName("FK__stcont_st__id_su__1A8D123D");

                entity.HasOne(d => d.IdTerminatedReasonNavigation)
                    .WithMany(p => p.StcontStateContract)
                    .HasForeignKey(d => d.IdTerminatedReason)
                    .HasConstraintName("FK__stcont_st__id_te__1B813676");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontStateContract)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stcont_st__id_us__1C755AAF");
            });

            modelBuilder.Entity<StcontSupplierUser>(entity =>
            {
                entity.HasKey(e => e.IdSupplierUser)
                    .HasName("PK__stcont_s__B35B1029EFA3BA6A");

                entity.ToTable("stcont_supplier_user");

                entity.HasIndex(e => new { e.IdSupplier, e.IdUser }, "UQ__stcont_s__9BE862843EAFF23A")
                    .IsUnique();

                entity.Property(e => e.IdSupplierUser).HasColumnName("id_supplier_user");

                entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdSupplierNavigation)
                    .WithMany(p => p.StcontSupplierUser)
                    .HasForeignKey(d => d.IdSupplier)
                    .HasConstraintName("FK__stcont_su__id_su__10056229");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.StcontSupplierUser)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__stcont_su__id_us__10F98662");
            });

            modelBuilder.Entity<StcontVeg>(entity =>
            {
                entity.HasKey(e => e.IdVeg)
                    .HasName("PK__stcont_v__6DADAB80D7F97801");

                entity.ToTable("stcont_veg");

                entity.Property(e => e.IdVeg).HasColumnName("id_veg");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cost");

                entity.Property(e => e.DateOfManufacture)
                    .HasColumnType("date")
                    .HasColumnName("date_of_manufacture");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Name)
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.SerialNumber).HasColumnName("serial_number");
            });

            modelBuilder.Entity<Streets>(entity =>
            {
                entity.HasKey(e => e.IdStreets)
                    .HasName("PK__STREETS__9E8FA077FDE400EE");

                entity.ToTable("STREETS");

                entity.Property(e => e.IdStreets).HasColumnName("ID_STREETS");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Gninmb)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GNINMB");

                entity.Property(e => e.Index)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("INDEX");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Ocatd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OCATD");

                entity.Property(e => e.Socr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SOCR");

                entity.Property(e => e.Uno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UNO");
            });

            modelBuilder.Entity<SysBase>(entity =>
            {
                entity.HasKey(e => e.IdBase)
                    .HasName("PK__sys_base__DF51D5BE153E4D3B");

                entity.ToTable("sys_base");

                entity.Property(e => e.IdBase).HasColumnName("id_base");

                entity.Property(e => e.ConnectionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("connectionName");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SysChanges>(entity =>
            {
                entity.HasKey(e => e.IdChanges)
                    .HasName("PK__sys_chan__5349DDAA2E59D087");

                entity.ToTable("sys_changes");

                entity.Property(e => e.IdChanges).HasColumnName("id_changes");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.Property(e => e.Text)
                    .IsUnicode(false)
                    .HasColumnName("text");

                entity.HasOne(d => d.IdModuleNavigation)
                    .WithMany(p => p.SysChanges)
                    .HasForeignKey(d => d.IdModule)
                    .HasConstraintName("FK__sys_chang__id_mo__5CA5B9B4");
            });

            modelBuilder.Entity<SysLog>(entity =>
            {
                entity.HasKey(e => e.IdLog)
                    .HasName("PK__sys_log__6CC851FE181AB9E6");

                entity.ToTable("sys_log");

                entity.Property(e => e.IdLog).HasColumnName("id_log");

                entity.Property(e => e.AppName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("app_name_")
                    .HasDefaultValueSql("(app_name())");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("column_name");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupUniq).HasColumnName("group_uniq");

                entity.Property(e => e.HostName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("host_name_")
                    .HasDefaultValueSql("(host_name())")
                    .IsFixedLength(true);

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.Property(e => e.IdRec).HasColumnName("id_rec");

                entity.Property(e => e.IudType).HasColumnName("iud_type");

                entity.Property(e => e.NewValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("new_value");

                entity.Property(e => e.OldValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("old_value");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("table_name");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_name_")
                    .HasDefaultValueSql("(suser_sname())");

                entity.HasOne(d => d.IdModuleNavigation)
                    .WithMany(p => p.SysLog)
                    .HasForeignKey(d => d.IdModule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sys_log__id_modu__1D697EE8");
            });

            modelBuilder.Entity<SysModule>(entity =>
            {
                entity.HasKey(e => e.IdModule)
                    .HasName("PK__sys_modu__B2584DEA1AF72691");

                entity.ToTable("sys_module");

                entity.HasIndex(e => new { e.NameController, e.NameView }, "UQ__sys_modu__073031AF1DD3933C")
                    .IsUnique();

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.NameController)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_controller");

                entity.Property(e => e.NameFull)
                    .HasMaxLength(501)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.NameShort)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("name_short");

                entity.Property(e => e.NameView)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_view");

                entity.Property(e => e.Orderby).HasColumnName("orderby");

                entity.Property(e => e.ToView).HasColumnName("to_view");

                entity.HasOne(d => d.IdParentNavigation)
                    .WithMany(p => p.InverseIdParentNavigation)
                    .HasForeignKey(d => d.IdParent)
                    .HasConstraintName("FK__sys_modul__id_pa__1E5DA321");
            });

            modelBuilder.Entity<SysNews>(entity =>
            {
                entity.HasKey(e => e.IdNews)
                    .HasName("PK__sys_news__389F1DA920AFFFE7");

                entity.ToTable("sys_news");

                entity.HasIndex(e => new { e.NewsDate, e.IdSys }, "sys_news_idx");

                entity.Property(e => e.IdNews).HasColumnName("id_news");

                entity.Property(e => e.IdSys)
                    .HasColumnName("id_sys")
                    .HasComment("0-all system\r\n1-BudgRec \r\n2-StCont");

                entity.Property(e => e.NewsAutor)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("news_autor");

                entity.Property(e => e.NewsDate)
                    .HasColumnType("date")
                    .HasColumnName("news_date");

                entity.Property(e => e.NewsHeader)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("news_header");

                entity.Property(e => e.NewsText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("news_text");

                entity.Property(e => e.NewsType).HasColumnName("news_type");
            });

            modelBuilder.Entity<SysPeriodType>(entity =>
            {
                entity.HasKey(e => e.IdPeriodType)
                    .HasName("PK__sys_peri__EB8EA0AC238C6C92");

                entity.ToTable("sys_period_type");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.Adjective)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("adjective");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SysRole>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK__sys_role__3D48441D2668D93D");

                entity.ToTable("sys_role");

                entity.HasIndex(e => e.NameShort, "UQ__sys_role__64534B6D294545E8")
                    .IsUnique();

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.NameFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.NameShort)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_short");
            });

            modelBuilder.Entity<SysRoleModule>(entity =>
            {
                entity.HasKey(e => e.IdRoleModule)
                    .HasName("PK__sys_role__D384D4492C21B293");

                entity.ToTable("sys_role_module");

                entity.HasIndex(e => new { e.IdRole, e.IdModule }, "UQ__sys_role__866DC0C22EFE1F3E")
                    .IsUnique();

                entity.Property(e => e.IdRoleModule).HasColumnName("id_role_module");

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.PermissionEdit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("permission_edit")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdModuleNavigation)
                    .WithMany(p => p.SysRoleModule)
                    .HasForeignKey(d => d.IdModule)
                    .HasConstraintName("FK__sys_role___id_mo__1F51C75A");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.SysRoleModule)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK__sys_role___id_ro__2045EB93");
            });

            modelBuilder.Entity<SysTalFileLoads>(entity =>
            {
                entity.HasKey(e => e.IdTalFileLoads)
                    .HasName("PK__sys_tal___5BD6954F31DA8BE9");

                entity.ToTable("sys_tal_file_loads");

                entity.HasIndex(e => e.IdMo, "sys_tal_file_loads_idx");

                entity.HasIndex(e => new { e.IdPeriodType, e.PeriodValue, e.PeriodYear }, "sys_tal_file_loads_idx2");

                entity.HasIndex(e => e.Lstatus, "sys_tal_file_loads_idx3");

                entity.Property(e => e.IdTalFileLoads).HasColumnName("id_tal_file_loads");

                entity.Property(e => e.FileDate)
                    .HasColumnType("datetime")
                    .HasColumnName("file_date");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdPeriodType).HasColumnName("id_period_type");

                entity.Property(e => e.LoadedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("loaded_time");

                entity.Property(e => e.Lstatus).HasColumnName("lstatus");

                entity.Property(e => e.PeriodValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("period_value");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__sys_user__D2D1463734B6F894");

                entity.ToTable("sys_user");

                entity.HasIndex(e => e.Login, "i_user_login")
                    .IsUnique();

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdBase).HasColumnName("id_base");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.IdPlanSumParent).HasColumnName("id_plan_sum_parent");

                entity.Property(e => e.IdUserGroup).HasColumnName("id_user_group");

                entity.Property(e => e.IsLoggedin).HasColumnName("is_loggedin");

                entity.Property(e => e.IsLogin2).HasColumnName("is_login2");

                entity.Property(e => e.LastModule).HasColumnName("last_module");

                entity.Property(e => e.LoggedinTime)
                    .HasColumnType("datetime")
                    .HasColumnName("loggedin_time");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.NameFull)
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.NameShort)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_short");

                entity.Property(e => e.NewsReadTime)
                    .HasColumnType("datetime")
                    .HasColumnName("news_read_time");

                entity.Property(e => e.OrderNum).HasColumnName("order_num");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("pass");

                entity.HasOne(d => d.IdBaseNavigation)
                    .WithMany(p => p.SysUser)
                    .HasForeignKey(d => d.IdBase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sys_user__id_bas__213A0FCC");

                entity.HasOne(d => d.IdMoNavigation)
                    .WithMany(p => p.SysUser)
                    .HasForeignKey(d => d.IdMo)
                    .HasConstraintName("FK__sys_user__id_mo__222E3405");

                entity.HasOne(d => d.IdParentNavigation)
                    .WithMany(p => p.InverseIdParentNavigation)
                    .HasForeignKey(d => d.IdParent)
                    .HasConstraintName("FK__sys_user__id_par__2322583E");

                entity.HasOne(d => d.IdUserGroupNavigation)
                    .WithMany(p => p.SysUser)
                    .HasForeignKey(d => d.IdUserGroup)
                    .HasConstraintName("FK__sys_user__id_use__24167C77");

                entity.HasOne(d => d.LastModuleNavigation)
                    .WithMany(p => p.SysUser)
                    .HasForeignKey(d => d.LastModule)
                    .HasConstraintName("FK__sys_user__last_m__250AA0B0");
            });

            modelBuilder.Entity<SysUserGroup>(entity =>
            {
                entity.HasKey(e => e.IdUserGroup)
                    .HasName("PK__sys_user__53DE20CC3793653F");

                entity.ToTable("sys_user_group");

                entity.Property(e => e.IdUserGroup).HasColumnName("id_user_group");

                entity.Property(e => e.NameFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.NameShort)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("name_short");

                entity.Property(e => e.OrderNum).HasColumnName("order_num");
            });

            modelBuilder.Entity<SysUserLogin>(entity =>
            {
                entity.HasKey(e => e.IdUserLogin)
                    .HasName("PK__sys_user__F3C0ABEF2FDEE151");

                entity.ToTable("sys_user_login");

                entity.Property(e => e.IdUserLogin).HasColumnName("id_user_login");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Login2)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("login2");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.SysUserLogin)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__sys_user___id_us__0AD698B8");
            });

            modelBuilder.Entity<SysUserNews>(entity =>
            {
                entity.HasKey(e => e.IdUserNews)
                    .HasName("PK__sys_user__DA8B79F2BCA5BC8C");

                entity.ToTable("sys_user_news");

                entity.Property(e => e.IdUserNews).HasColumnName("id_user_news");

                entity.Property(e => e.IdNews).HasColumnName("id_news");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.SysUserNews)
                    .HasForeignKey(d => d.IdNews)
                    .HasConstraintName("FK__sys_user___id_ne__6D070A06");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.SysUserNews)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__sys_user___id_us__6C12E5CD");
            });

            modelBuilder.Entity<SysUserRole>(entity =>
            {
                entity.HasKey(e => e.IdUserRole)
                    .HasName("PK__sys_user__4FD2ABB33A6FD1EA");

                entity.ToTable("sys_user_role");

                entity.HasIndex(e => new { e.IdUser, e.IdRole }, "UQ__sys_user__1105C2773D4C3E95")
                    .IsUnique();

                entity.Property(e => e.IdUserRole).HasColumnName("id_user_role");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.SysUserRole)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK__sys_user___id_ro__25FEC4E9");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.SysUserRole)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__sys_user___id_us__26F2E922");
            });

            modelBuilder.Entity<SzpAccord>(entity =>
            {
                entity.HasKey(e => e.IdAccord)
                    .HasName("PK__szp_acco__3ED4110751C143B4");

                entity.ToTable("szp_accord");

                entity.Property(e => e.IdAccord).HasColumnName("id_accord");

                entity.Property(e => e.Hide)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hide")
                    .IsFixedLength(true);

                entity.Property(e => e.IdRows).HasColumnName("id_rows");

                entity.Property(e => e.IdUserGroup).HasColumnName("id_user_group");

                entity.Property(e => e.Version)
                    .HasColumnType("decimal(18, 10)")
                    .HasColumnName("version");
            });

            modelBuilder.Entity<SzpPresident>(entity =>
            {
                entity.HasKey(e => e.IdPresident)
                    .HasName("PK__szp_pres__9076A817C7A6DDC2");

                entity.ToTable("szp_president");

                entity.Property(e => e.IdPresident).HasColumnName("id_president");

                entity.Property(e => e.FromXml)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("from_xml")
                    .IsFixedLength(true);

                entity.Property(e => e.IdJob).HasColumnName("id_job");

                entity.Property(e => e.IdPayroll).HasColumnName("id_payroll");

                entity.Property(e => e.IdRows).HasColumnName("id_rows");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.LastMonthNzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("last_month_nzp");

                entity.Property(e => e.LastMonthSsc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("last_month_ssc");

                entity.Property(e => e.LastMonthSzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("last_month_szp");

                entity.Property(e => e.PeriodMonth).HasColumnName("period_month");

                entity.Property(e => e.PeriodNzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("period_nzp");

                entity.Property(e => e.PeriodNzpSs)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("period_nzp_ss");

                entity.Property(e => e.PeriodNzpVs)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("period_nzp_vs");

                entity.Property(e => e.PeriodSrSs)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("period_sr_ss");

                entity.Property(e => e.PeriodSrVs)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("period_sr_vs");

                entity.Property(e => e.PeriodSsc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("period_ssc");

                entity.Property(e => e.PeriodSzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("period_szp");

                entity.Property(e => e.PeriodSzpSs)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("period_szp_ss");

                entity.Property(e => e.PeriodSzpVs)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("period_szp_vs");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.PrelastMonthNzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("prelast_month_nzp");

                entity.Property(e => e.PrelastMonthSsc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("prelast_month_ssc");

                entity.Property(e => e.PrelastMonthSzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("prelast_month_szp");

                entity.Property(e => e.RecomSsNzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("recom_ss_nzp");

                entity.Property(e => e.RecomSsSsc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("recom_ss_ssc");

                entity.Property(e => e.RecomSsSzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("recom_ss_szp");

                entity.Property(e => e.RecomVsNzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("recom_vs_nzp");

                entity.Property(e => e.RecomVsSsc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("recom_vs_ssc");

                entity.Property(e => e.RecomVsSzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("recom_vs_szp");

                entity.Property(e => e.RejectSsNzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("reject_ss_nzp");

                entity.Property(e => e.RejectSsSsc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("reject_ss_ssc");

                entity.Property(e => e.RejectSsSzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("reject_ss_szp");

                entity.Property(e => e.RejectVsNzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("reject_vs_nzp");

                entity.Property(e => e.RejectVsSsc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("reject_vs_ssc");

                entity.Property(e => e.RejectVsSzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("reject_vs_szp");

                entity.Property(e => e.WaitSsNzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("wait_ss_nzp");

                entity.Property(e => e.WaitSsSsc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("wait_ss_ssc");

                entity.Property(e => e.WaitSsSzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("wait_ss_szp");

                entity.Property(e => e.WaitSumNzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("wait_sum_nzp");

                entity.Property(e => e.WaitSumSsc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("wait_sum_ssc");

                entity.Property(e => e.WaitSumSzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("wait_sum_szp");

                entity.Property(e => e.WaitVsNzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("wait_vs_nzp");

                entity.Property(e => e.WaitVsSsc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("wait_vs_ssc");

                entity.Property(e => e.WaitVsSzp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("wait_vs_szp");

                entity.HasOne(d => d.IdJobNavigation)
                    .WithMany(p => p.SzpPresident)
                    .HasForeignKey(d => d.IdJob)
                    .HasConstraintName("FK__szp_presi__id_jo__52282B41");

                entity.HasOne(d => d.IdPayrollNavigation)
                    .WithMany(p => p.SzpPresident)
                    .HasForeignKey(d => d.IdPayroll)
                    .HasConstraintName("FK__szp_presi__id_pa__531C4F7A");

                entity.HasOne(d => d.IdRowsNavigation)
                    .WithMany(p => p.SzpPresident)
                    .HasForeignKey(d => d.IdRows)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__szp_presi__id_ro__51340708");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.SzpPresident)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__szp_presi__id_st__550497EC");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.SzpPresident)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__szp_presi__id_us__541073B3");
            });

            modelBuilder.Entity<SzpReport>(entity =>
            {
                entity.HasKey(e => e.IdReport)
                    .HasName("PK__szp_repo__D8639F52704CF34F");

                entity.ToTable("szp_report");

                entity.Property(e => e.IdReport).HasColumnName("id_report");

                entity.Property(e => e.Mnemo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mnemo");

                entity.Property(e => e.Table)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("table");
            });

            modelBuilder.Entity<SzpRows>(entity =>
            {
                entity.HasKey(e => e.IdRows)
                    .HasName("PK__szp_rows__3D49398593A4E713");

                entity.ToTable("szp_rows");

                entity.Property(e => e.IdRows).HasColumnName("id_rows");

                entity.Property(e => e.Hide)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("hide")
                    .IsFixedLength(true);

                entity.Property(e => e.IdReport).HasColumnName("id_report");

                entity.Property(e => e.ItemNum).HasColumnName("item_num");

                entity.Property(e => e.Mnemo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mnemo");

                entity.HasOne(d => d.IdReportNavigation)
                    .WithMany(p => p.SzpRows)
                    .HasForeignKey(d => d.IdReport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__szp_rows__id_rep__489EC107");
            });

            modelBuilder.Entity<SzpToMrot>(entity =>
            {
                entity.HasKey(e => e.IdToMrot)
                    .HasName("PK__szp_to_m__64757CE426676ACF");

                entity.ToTable("szp_to_mrot");

                entity.Property(e => e.IdToMrot).HasColumnName("id_to_mrot");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PeriodMonth).HasColumnName("period_month");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.Property(e => e.ToMrot11k)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("to_mrot_11k");

                entity.Property(e => e.ToMrot9k)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("to_mrot_9k");

                entity.Property(e => e.WorkCount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("work_count");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.SzpToMrot)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__szp_to_mr__id_st__3497C85A");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.SzpToMrot)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__szp_to_mr__id_us__33A3A421");
            });

            modelBuilder.Entity<TablesIds>(entity =>
            {
                entity.HasKey(e => e.IdOrdersIds)
                    .HasName("PK__TABLES_I__611E17ED20FA18AA");

                entity.ToTable("TABLES_IDS");

                entity.Property(e => e.IdOrdersIds).HasColumnName("id_orders_ids");

                entity.Property(e => e.TableId).HasColumnName("table_id");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("table_name");
            }); */

            modelBuilder.Entity<TsqlLicence>(entity =>
            {
                entity.HasKey(e => e.IdLicence)
                    .HasName("PK__tsql_lic__5A2E03BF7B276583");

                entity.ToTable("tsql_licence");

                entity.HasIndex(e => e.Inn, "tsql_licence_inn_unique")
                    .IsUnique();

                entity.Property(e => e.IdLicence).HasColumnName("id_licence");

                entity.Property(e => e.Deadline)
                    .HasColumnType("datetime")
                    .HasColumnName("deadline");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Inn)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.Kpp)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("kpp");

                entity.Property(e => e.Ogrn)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ogrn");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("org_name");

                entity.Property(e => e.RequestEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("request_email");

                entity.Property(e => e.RequestFile)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("request_file");

                entity.Property(e => e.RequestRoles)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("request_roles");

                entity.Property(e => e.RequestWorkCnt).HasColumnName("request_work_cnt");

                entity.Property(e => e.Roles)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("roles");

                entity.Property(e => e.Sent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sent")
                    .IsFixedLength(true);

                entity.Property(e => e.Sql)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("sql");

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tel");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("type")
                    .IsFixedLength(true);

                entity.Property(e => e.WorkCnt).HasColumnName("work_cnt");
            });

            modelBuilder.Entity<TsqlLog>(entity =>
            {
                entity.HasKey(e => e.IdLog)
                    .HasName("PK__tsql_log__6CC851FE5DBB3E79");

                entity.ToTable("tsql_log");

                entity.Property(e => e.IdLog).HasColumnName("id_log");

                entity.Property(e => e.ChangeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("change_time");

                entity.Property(e => e.Inn)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.LogText)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("log_text");
            });

         /*   modelBuilder.Entity<TsqlRole>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK__tsql_rol__3D48441DCC7BF93B");

                entity.ToTable("tsql_role");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.LoginRoleName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("login_role_name");

                entity.Property(e => e.Roles)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("roles");
            });

            modelBuilder.Entity<UmpVolunteer>(entity =>
            {
                entity.HasKey(e => e.IdVolunteer)
                    .HasName("PK__voluntee__7F3AB620E66BAB1E");

                entity.ToTable("ump_volunteer");

                entity.Property(e => e.IdVolunteer).HasColumnName("id_volunteer");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("datetime")
                    .HasColumnName("birth_date");

                entity.Property(e => e.Fio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fio");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdVolunteerClass).HasColumnName("id_volunteer_class");

                entity.Property(e => e.IdVolunteerMo).HasColumnName("id_volunteer_mo");

                entity.Property(e => e.PeriodYear).HasColumnName("period_year");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.UmpVolunteer)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK__volunteer__id_st__4B511080");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UmpVolunteer)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__volunteer__id_us__4A5CEC47");

                entity.HasOne(d => d.IdVolunteerClassNavigation)
                    .WithMany(p => p.UmpVolunteer)
                    .HasForeignKey(d => d.IdVolunteerClass)
                    .HasConstraintName("FK__volunteer__id_vo__4874A3D5");

                entity.HasOne(d => d.IdVolunteerMoNavigation)
                    .WithMany(p => p.UmpVolunteer)
                    .HasForeignKey(d => d.IdVolunteerMo)
                    .HasConstraintName("FK__volunteer__id_vo__4968C80E");
            });

            modelBuilder.Entity<UmpVolunteerClass>(entity =>
            {
                entity.HasKey(e => e.IdVolunteerClass)
                    .HasName("PK__voluntee__3741C48682B5887D");

                entity.ToTable("ump_volunteer_class");

                entity.Property(e => e.IdVolunteerClass).HasColumnName("id_volunteer_class");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<UmpVolunteerMo>(entity =>
            {
                entity.HasKey(e => e.IdVolunteerMo)
                    .HasName("PK__voluntee__77126F62BED98081");

                entity.ToTable("ump_volunteer_mo");

                entity.Property(e => e.IdVolunteerMo).HasColumnName("id_volunteer_mo");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USERS");

                entity.Property(e => e.Admin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN_")
                    .HasDefaultValueSql("(N'0')")
                    .IsFixedLength(true);

                entity.Property(e => e.Author)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AUTHOR")
                    .HasDefaultValueSql("(N'0')")
                    .IsFixedLength(true);

                entity.Property(e => e.Blocked)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BLOCKED")
                    .HasDefaultValueSql("(N'0')")
                    .IsFixedLength(true);

                entity.Property(e => e.Boss)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BOSS")
                    .HasDefaultValueSql("(N'0')")
                    .IsFixedLength(true);

                entity.Property(e => e.Executor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXECUTOR")
                    .HasDefaultValueSql("(N'0')")
                    .IsFixedLength(true);

                entity.Property(e => e.IdDepartment).HasColumnName("ID_DEPARTMENT");

                entity.Property(e => e.IdUsers)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_USERS");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("LOGIN");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("NAME");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("PASS");
            });

            modelBuilder.Entity<ViewAssets2016NameCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_assets2016_name_code");

                entity.Property(e => e.AssName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ass_name");

                entity.Property(e => e.IdAssets2016Class)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_assets2016_class");
            });

            modelBuilder.Entity<ViewBcCcodeMainFundsGrbs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_bc_ccode_main_funds_grbs");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.GrbsCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("grbs_code");

                entity.Property(e => e.IdBcCcodeMainFundsGrbs).HasColumnName("id_bc_ccode_main_funds_grbs");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewDictbrUserInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_dictbr_user_info");

                entity.Property(e => e.AddressDoc)
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("address_doc");

                entity.Property(e => e.AddressFact)
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("address_fact");

                entity.Property(e => e.Bank)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bank");

                entity.Property(e => e.Bik)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("bik");

                entity.Property(e => e.BuhEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("buh_email");

                entity.Property(e => e.BuhFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("buh_fio");

                entity.Property(e => e.BuhTel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("buh_tel");

                entity.Property(e => e.IdBcIcodeMainAdmin).HasColumnName("id_bc_icode_main_admin");

                entity.Property(e => e.IdDictbrUserInfo).HasColumnName("id_dictbr_user_info");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdUserGroup).HasColumnName("id_user_group");

                entity.Property(e => e.Inn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.Kpp)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("kpp");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Ls)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ls");

                entity.Property(e => e.ManagerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("manager_email");

                entity.Property(e => e.ManagerFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("manager_fio");

                entity.Property(e => e.ManagerTel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("manager_tel");

                entity.Property(e => e.MoDeputyFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mo_deputy_fio");

                entity.Property(e => e.MoMainEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("mo_main_email");

                entity.Property(e => e.MoMainFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mo_main_fio");

                entity.Property(e => e.MoMainIoFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mo_main_io_fio");

                entity.Property(e => e.MoMainTel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mo_main_tel");

                entity.Property(e => e.NameFull)
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.NameShort)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_short");

                entity.Property(e => e.Okato)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("okato");

                entity.Property(e => e.Okpo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("okpo");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("pass");

                entity.Property(e => e.RespEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("resp_email");

                entity.Property(e => e.RespFio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("resp_fio");

                entity.Property(e => e.RespPost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("resp_post");

                entity.Property(e => e.RespTel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("resp_tel");

                entity.Property(e => e.Rs)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rs");
            });

            modelBuilder.Entity<ViewDictscUserInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_dictsc_user_info");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdUserGroup).HasColumnName("id_user_group");

                entity.Property(e => e.IdUserInfo).HasColumnName("id_user_info");

                entity.Property(e => e.Inn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.Kpp)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("kpp");

                entity.Property(e => e.Locality)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("locality");

                entity.Property(e => e.NameFull)
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("name_full");

                entity.Property(e => e.NameShort)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name_short");

                entity.Property(e => e.OkopfOkfs)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("okopf_okfs");

                entity.Property(e => e.Okpo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("okpo");

                entity.Property(e => e.Oktmo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("oktmo");

                entity.Property(e => e.PublicLegal)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("public_legal");

                entity.Property(e => e.Street)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("street");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("zip_code");
            });

            modelBuilder.Entity<ViewMcAppealThemeTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_mc_appeal_theme_types");

                entity.Property(e => e.IdAppealTheme).HasColumnName("id_appeal_theme");

                entity.Property(e => e.IdAppealTypes).HasColumnName("id_appeal_types");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.TypesName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("types_name");

                entity.Property(e => e.TypesNameShort)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("types_name_short");
            });

            modelBuilder.Entity<ViewMcMedorgMoMrf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_mc_medorg_mo_mrf");

                entity.Property(e => e.IdMedOrg).HasColumnName("id_med_org");

                entity.Property(e => e.IdMo).HasColumnName("id_mo");

                entity.Property(e => e.IdMrf).HasColumnName("id_mrf");

                entity.Property(e => e.MedOrgCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("med_org_code");

                entity.Property(e => e.MedOrgName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("med_org_name");

                entity.Property(e => e.MedOrgNameShort)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("med_org_name_short");

                entity.Property(e => e.MedOrgOgrn)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("med_org_ogrn");

                entity.Property(e => e.MoCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mo_code");

                entity.Property(e => e.MoName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mo_name");

                entity.Property(e => e.MrfCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mrf_code");

                entity.Property(e => e.MrfName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mrf_name");
            });

            modelBuilder.Entity<ViewMcMrfSysUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_mc_mrf_sys_user");

                entity.Property(e => e.IdMrf).HasColumnName("id_mrf");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewMcSmoSysUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_mc_smo_sys_user");

                entity.Property(e => e.IdSmo).HasColumnName("id_smo");

                entity.Property(e => e.SmoIdUser).HasColumnName("smo_id_user");

                entity.Property(e => e.SmoName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("smo_name");

                entity.Property(e => e.SysIdParent).HasColumnName("sys_id_parent");
            });

            modelBuilder.Entity<ViewNormGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_norm_group");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewPaymentOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_payment_order");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.IdPersonalAccount).HasColumnName("id_personal_account");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PersAccPayer)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("pers_acc_payer");
            });

            modelBuilder.Entity<ViewPayments2016NameCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_payments2016_name_code");

                entity.Property(e => e.IdPayments2016Class)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_payments2016_class");

                entity.Property(e => e.PayName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pay_name");
            });

            modelBuilder.Entity<ViewReceipts2016NameCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_receipts2016_name_code");

                entity.Property(e => e.IdReceipts2016Class)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_receipts2016_class");

                entity.Property(e => e.RecName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rec_name");
            });

            modelBuilder.Entity<ViewRemains2016NameCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_remains2016_name_code");

                entity.Property(e => e.IdRemains2016Class)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_remains2016_class");

                entity.Property(e => e.RemName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rem_name");
            });

            modelBuilder.Entity<ViewStateContract>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_state_contract");

                entity.Property(e => e.AllowedBypriceCnt).HasColumnName("allowed_byprice_cnt");

                entity.Property(e => e.AllowedMissedCnt).HasColumnName("allowed_missed_cnt");

                entity.Property(e => e.ChangesCnt).HasColumnName("changes_cnt");

                entity.Property(e => e.ChangesSum)
                    .HasColumnType("money")
                    .HasColumnName("changes_sum");

                entity.Property(e => e.ChangesSumMinus)
                    .HasColumnType("money")
                    .HasColumnName("changes_sum_minus");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.ComplaintDate)
                    .HasColumnType("date")
                    .HasColumnName("complaint_date");

                entity.Property(e => e.ComplaintsCnt).HasColumnName("complaints_cnt");

                entity.Property(e => e.ComplaintsProvedCnt).HasColumnName("complaints_proved_cnt");

                entity.Property(e => e.DateCancel)
                    .HasColumnType("date")
                    .HasColumnName("date_cancel");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end");

                entity.Property(e => e.DateSupplAgree)
                    .HasColumnType("date")
                    .HasColumnName("date_suppl_agree");

                entity.Property(e => e.DeliveryDayz).HasColumnName("delivery_dayz");

                entity.Property(e => e.DeliveryFrom)
                    .HasColumnType("date")
                    .HasColumnName("delivery_from");

                entity.Property(e => e.DeliveryTo)
                    .HasColumnType("date")
                    .HasColumnName("delivery_to");

                entity.Property(e => e.DisablePersonCnt).HasColumnName("disable_person_cnt");

                entity.Property(e => e.DomesticCnt).HasColumnName("domestic_cnt");

                entity.Property(e => e.FinNextYear)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fin_next_year")
                    .IsFixedLength(true);

                entity.Property(e => e.IdBadReason).HasColumnName("id_bad_reason");

                entity.Property(e => e.IdOrderState).HasColumnName("id_order_state");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.IdStateContract).HasColumnName("id_state_contract");

                entity.Property(e => e.IdTerminatedReason).HasColumnName("id_terminated_reason");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdUserGroup).HasColumnName("id_user_group");

                entity.Property(e => e.InnovativeProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("innovative_product")
                    .IsFixedLength(true);

                entity.Property(e => e.InvalidPlacingDate)
                    .HasColumnType("date")
                    .HasColumnName("invalid_placing_date");

                entity.Property(e => e.IsAdvanceStatement)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_advance_statement")
                    .IsFixedLength(true);

                entity.Property(e => e.IsAlienProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_alien_product")
                    .IsFixedLength(true);

                entity.Property(e => e.IsArmenProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_armen_product")
                    .IsFixedLength(true);

                entity.Property(e => e.IsBadReason)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_bad_reason")
                    .IsFixedLength(true);

                entity.Property(e => e.IsBelorusProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_belorus_product")
                    .IsFixedLength(true);

                entity.Property(e => e.IsDisablePerson)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_disable_person")
                    .IsFixedLength(true);

                entity.Property(e => e.IsDomestic)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_domestic")
                    .IsFixedLength(true);

                entity.Property(e => e.IsInvalidPlacing)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_invalid_placing")
                    .IsFixedLength(true);

                entity.Property(e => e.IsKazahProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_kazah_product")
                    .IsFixedLength(true);

                entity.Property(e => e.IsRusProduct)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_rus_product")
                    .IsFixedLength(true);

                entity.Property(e => e.IsSubSono)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_sub_sono")
                    .IsFixedLength(true);

                entity.Property(e => e.IsSupplierAgreement)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_supplier_agreement")
                    .IsFixedLength(true);

                entity.Property(e => e.IsTradeCanceled)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_trade_canceled")
                    .IsFixedLength(true);

                entity.Property(e => e.IsUis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_uis")
                    .IsFixedLength(true);

                entity.Property(e => e.IsVitalGoods)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("is_vital_goods")
                    .IsFixedLength(true);

                entity.Property(e => e.Member25lowerCnt).HasColumnName("member_25lower_cnt");

                entity.Property(e => e.MemberAppropriateCnt).HasColumnName("member_appropriate_cnt");

                entity.Property(e => e.MemberFullProductCnt).HasColumnName("member_full_product_cnt");

                entity.Property(e => e.MemberInappropriateCnt).HasColumnName("member_inappropriate_cnt");

                entity.Property(e => e.MemberRecallCnt).HasColumnName("member_recall_cnt");

                entity.Property(e => e.MemberVitalGoodsCnt).HasColumnName("member_vital_goods_cnt");

                entity.Property(e => e.NotallowedBydocumentsCnt).HasColumnName("notallowed_bydocuments_cnt");

                entity.Property(e => e.NotallowedBymoneyCnt).HasColumnName("notallowed_bymoney_cnt");

                entity.Property(e => e.NotallowedByrequirementsCnt).HasColumnName("notallowed_byrequirements_cnt");

                entity.Property(e => e.NotallowedByssCnt).HasColumnName("notallowed_byss_cnt");

                entity.Property(e => e.PaymentDayz).HasColumnName("payment_dayz");

                entity.Property(e => e.PmName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("pm_name");

                entity.Property(e => e.ReestrNum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("reestr_num");

                entity.Property(e => e.Summ)
                    .HasColumnType("money")
                    .HasColumnName("summ");

                entity.Property(e => e.SummFact)
                    .HasColumnType("money")
                    .HasColumnName("summ_fact");

                entity.Property(e => e.SummStart)
                    .HasColumnType("money")
                    .HasColumnName("summ_start");

                entity.Property(e => e.SummStartYearAfter)
                    .HasColumnType("money")
                    .HasColumnName("summ_start_year_after");

                entity.Property(e => e.SummStartYearNext)
                    .HasColumnType("money")
                    .HasColumnName("summ_start_year_next");

                entity.Property(e => e.SummStartYearThis)
                    .HasColumnType("money")
                    .HasColumnName("summ_start_year_this");

                entity.Property(e => e.SummYearAfter)
                    .HasColumnType("money")
                    .HasColumnName("summ_year_after");

                entity.Property(e => e.SummYearNext)
                    .HasColumnType("money")
                    .HasColumnName("summ_year_next");

                entity.Property(e => e.SummYearThis)
                    .HasColumnType("money")
                    .HasColumnName("summ_year_this");

                entity.Property(e => e.UisCnt).HasColumnName("uis_cnt");

                entity.Property(e => e.Winners25lowerCnt).HasColumnName("winners_25lower_cnt");

                entity.Property(e => e.WinnersCnt).HasColumnName("winners_cnt");

                entity.Property(e => e.ДатаДействия)
                    .HasColumnType("date")
                    .HasColumnName("Дата действия");

                entity.Property(e => e.ДатаЗаклЯ)
                    .HasColumnType("date")
                    .HasColumnName("Дата закл-я");

                entity.Property(e => e.ДатаПротокола)
                    .HasColumnType("date")
                    .HasColumnName("Дата протокола");

                entity.Property(e => e.Заказчик)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Исполнитель)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Номер)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.СмпИСоно)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("СМП и СОНО")
                    .IsFixedLength(true);

                entity.Property(e => e.СпособРазмещения)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Способ размещения");

                entity.Property(e => e.Фз)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ФЗ");

                entity.Property(e => e.ЦенаКонтракта)
                    .HasColumnType("money")
                    .HasColumnName("Цена контракта");

                entity.Property(e => e.ЦенаПоПп)
                    .HasColumnType("money")
                    .HasColumnName("Цена (по ПП)");

                entity.Property(e => e.ЦенаПоПродукции)
                    .HasColumnType("money")
                    .HasColumnName("Цена (по продукции)");
            });

            modelBuilder.Entity<ViewSysLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_sys_log");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("column_name");

                entity.Property(e => e.DateConclusion)
                    .HasColumnType("date")
                    .HasColumnName("date_conclusion");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_");

                entity.Property(e => e.GroupUniq).HasColumnName("group_uniq");

                entity.Property(e => e.IdRec).HasColumnName("id_rec");

                entity.Property(e => e.NewValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("new_value");

                entity.Property(e => e.Num)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("num");

                entity.Property(e => e.OldValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("old_value");

                entity.Property(e => e.PlacingMode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("placing_mode");

                entity.Property(e => e.ProtocolDate)
                    .HasColumnType("date")
                    .HasColumnName("protocol_date");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<ViewSysRoleModule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_sys_role_module");

                entity.Property(e => e.IdModule).HasColumnName("id_module");

                entity.Property(e => e.IdParent).HasColumnName("id_parent");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.IdRoleModule).HasColumnName("id_role_module");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("module_name");

                entity.Property(e => e.NameController)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_controller");

                entity.Property(e => e.NameView)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_view");

                entity.Property(e => e.PermissionEdit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("permission_edit")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleShort)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("role_short");
            });

            modelBuilder.Entity<ViewSysUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_sys_user_role");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdUserRole).HasColumnName("id_user_role");

                entity.Property(e => e.RoleShort)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("role_short");

                entity.Property(e => e.UserShort)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_short");
            });

            modelBuilder.Entity<ViewVfkMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_vfk_map");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.KosguId).HasColumnName("kosgu_id");

                entity.Property(e => e.KvrCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kvr_code")
                    .IsFixedLength(true);

                entity.Property(e => e.KvrId).HasColumnName("kvr_id");

                entity.Property(e => e.KvrName)
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("kvr_name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2550)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });
          */
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
