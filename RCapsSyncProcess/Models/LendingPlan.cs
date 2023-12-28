using ExcelMapper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RCapsSyncProcess.Models;
public class LendingPlan
{
    [Key]
    [ExcelIgnore]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? Id { get; set; }
    [ExcelColumnName("SAP CODE")]
    public string? SapCode { get; set; }

    [ExcelColumnName("sector")]      
    public string? Sector { get; set; }

    [ExcelColumnName("Projected or ESIA Categorisation")]
    public string? EsiaCategorization { get; set; }
    [ExcelColumnName("ESIA Categoriation Done")]
    public string? EsiaCategorizationDone { get; set; }
    [ExcelColumnName("BOARD DATE")]
    public string? BoardDate { get; set; }
    [ExcelColumnName("READINESS BPPS")]
    public string? ReadinessBpps { get; set; }
    [ExcelColumnName("INSTRUMENT")]
    public string? Instrument { get; set; }
    [ExcelColumnName("COMPLEX")]
    public string? Complex { get; set; }

    [ExcelColumnName("COUNTRY")]
    public string? Country { get; set; }

    [ExcelColumnName("PROJECT NAME")]
    public string? ProjectName { get; set; }

    [ExcelColumnName("ADB Public")]
    public string? AdbPublic { get; set; }

    [ExcelColumnName("ADB Private")]
    public string? AdbPrivate { get; set; }

    [ExcelColumnName("ADF Loan")]
    public string? AdfLoan { get; set; }

    [ExcelColumnName("ADF Grant")]
    public string? AdfGrant { get; set; }

    [ExcelColumnName("ADF RO")]
    public string? AdfRo { get; set; }

    [ExcelColumnName("TSF")]
    public string? Tsf { get; set; }

    [ExcelColumnName("ADF")]
    public string? Adf { get; set; }

    [ExcelColumnName("NTF")]
    public string? Ntf { get; set; }

    [ExcelColumnName("Total Projected Approval_UA ")]
    public string? TotalProjectedApprovalUa { get; set; }

    [ExcelColumnName("Financing source")]
    public string? FinancingSource { get; set; }

    [ExcelColumnName("REGION")]
    public string? Region { get; set; }

    [ExcelColumnName("Sector department")]
    public string? SectorDepartment { get; set; }

    [ExcelColumnName("Total Projected Approval_USD")]
    public string? TotalProjectedApprovalUsd { get; set; }

    [ExcelColumnName("Total Projected Approval_UA M")]
    public string? TotalProjectedApprovalUaM { get; set; }

    [ExcelColumnName("Total Projected Approval_USD2")]
    public string? TotalProjectedApprovalUsd2 { get; set; }

    [ExcelColumnName("Feed Africa PTLY")]
    public string? FeedAfricaPtly { get; set; }

    [ExcelColumnName("Light Up And Power Africa PTLY")]
    public string? LightUpAndPowerAfricaPtly { get; set; }

    [ExcelColumnName("Industrialize Africa PTLY")]
    public string? IndustrializeAfricaPtly { get; set; }

    [ExcelColumnName("Integrate Africa PTLY")]
    public string? IntegrateAfricaPtly { get; set; }

    [ExcelColumnName("Improve Quality Of Life PTLY")]
    public string? ImproveQualityOfLifePtly { get; set; }

    [ExcelColumnName("Feed Africa")]
    public string? FeedAfrica { get; set; }

    [ExcelColumnName("Light Up And Power Africa")]
    public string? LightUpAndPowerAfrica { get; set; }

    [ExcelColumnName("Industrialize Africa")]
    public string? IndustrializeAfrica { get; set; }

    [ExcelColumnName("Integrate Africa")]
    public string? IntegrateAfrica { get; set; }

    [ExcelColumnName("Improve Quality Of Life")]
    public string? ImproveQualityOfLife { get; set; }

    [ExcelColumnName("Hi5s")]
    public string? Hi5s { get; set; }

    [ExcelColumnName("Chech Hi5s")]
    public bool? ChechHi5s { get; set; }

    [ExcelColumnName("Operations")]
    public string? Operations { get; set; }

    [ExcelColumnName("COUNTRY CLASSIFICATION")]
    public string? CountryClassification { get; set; }

    [ExcelColumnName("Transaition vs Non-Transition States")]
    public string? TransitionVsNonTransitionStates { get; set; }

    [ExcelColumnName("African region")]
    public string? AfricanRegion { get; set; }

    [ExcelColumnName("De Facto and Non-De Facto Countries")]
    public string? DeFactoAndNonDeFactoCountries { get; set; }

    [ExcelColumnName("Financing Instrument")]
    public string? FinancingInstrument { get; set; }

    [ExcelColumnName("Sector Key")]
    public string? SectorKey { get; set; }

    [ExcelColumnName("Sector full")]
    public string? SectorFull { get; set; }

    [ExcelColumnName("Sector Vs Infrastructure")]
    public string? SectorVsInfrastructure { get; set; }

    [ExcelColumnName("CSP Status")]
    public string? CspStatus { get; set; }

    [ExcelColumnName("Period")]
    public string? Period { get; set; }

    [ExcelColumnName("Type")]
    public string? Type { get; set; }

    [ExcelColumnName("Countries with a strategy vacuum in their lending operations")]
    public string? CountriesWithStrategyVacuum { get; set; }

    [ExcelColumnName("BOARD QUARTER")]
    public string? BoardQuarter { get; set; }

    [ExcelColumnName("Report Date")]
    public string? ReportDate { get; set; }

    [ExcelColumnName("Report Date Type")]
    public string? ReportDateType { get; set; }

    [ExcelColumnName("Number of Project")]
    public string? NumberOfProjects { get; set; }

    [ExcelColumnName("ESIA Cat")]
    public string? EsiaCat { get; set; }

    [ExcelColumnName("ESIA Cat-Actual")]
    public string? EsiaCatActual { get; set; }

    [ExcelColumnName("Whether ESIA Disclosed (Y/N)")]
    public string? EsiaDisclosed { get; set; }

    [ExcelColumnName("UA Million")]
    public string? UaMillion { get; set; }

    [ExcelColumnName("Selectivity (UA 10 M)")]
    public string? SelectivityUa10M { get; set; }

    [ExcelColumnName("Selectivity (UA 20 M)")]
    public string? SelectivityUa20M { get; set; }

    [ExcelColumnName("INSTRUMENT2")]
    public string? Instrument2 { get; set; }

    [ExcelColumnName("Selectivity (UA 30 M)")]
    public string? SelectivityUa30M { get; set; }

    [ExcelColumnName("Selectivity (UA 40 M)")]
    public string? SelectivityUa40M { get; set; }

    [ExcelColumnName("Selectivity (UA 50>300 M)")]
    public string? SelectivityUa50To300M { get; set; }

    [ExcelColumnName("Date Period")]
    public string? DatePeriod { get; set; }

    [ExcelColumnName("Task Manager")]
    public string? TaskManager { get; set; }

    [ExcelColumnName("Checking if in the Pipeline")]
    public string? CheckingInPipeline { get; set; }

    [ExcelColumnName("Is a poject brief prepared and filed in SAP?")]
    public string? IsProjectBriefPreparedAndFiled { get; set; }

    [ExcelColumnName("Has a official financing request received ?")]
    public string? IsOfficialFinancingRequestReceived { get; set; }

    [ExcelColumnName("is a Task Manager assigned in SAP?")]
    public string? IsTaskManagerAssigned { get; set; }

    [ExcelColumnName("Is an E&S officer assigned ?")]
    public string? IsEsOfficerAssigned { get; set; }

    [ExcelColumnName("Technical studies, including E&S studies, completed or scheduled to be finalized within 6 months")]
    public string? TechnicalStudiesCompletedOrScheduled { get; set; }

    [ExcelColumnName("Has a board date proposed in BPPS in consultation between Sectors and Regions?")]
    public string? IsBoardDateProposed { get; set; }

    [ExcelColumnName("Is the E&S categorization posted in SAP ?")]
    public string? IsEsCategorizationPosted { get; set; }

    [ExcelColumnName("Delivery date for the PCN by CT or Opscom?")]
    public string? DeliveryDateForPcn { get; set; }

    [ExcelColumnName("Column1")]
    public string? Column1 { get; set; }

    [ExcelColumnName("1. Project Initiation in SAP")]
    public string? ProjectInitiationInSAP { get; set; }
   
    [ExcelColumnName("2. Project Scheduling in BPPS")]
    public string? ProjectSchedulingInBPPS { get; set; }
    [ExcelColumnName("3. Resource Allocation")]
    public string? ResourceAllocation { get; set; }
    [ExcelColumnName("4. Studies and Preparatory Activities")]
    public string? StudiesAndPreparatoryActivities { get; set; }
    [ExcelColumnName("1. Project Initiation in SAP I")]
    public string? ProjectInitiationInSAP1 { get; set; }
    [ExcelColumnName("2. Project Scheduling in BPPS II")]
    public string? ProjectSchedulingInBPPS2 { get; set; }
    [ExcelColumnName("3. Resource Allocation II")]
    public string? ResourceAllocation2 { get; set; }
    [ExcelColumnName("4. Studies and Preparatory Activities2")]
    public string? StudiesAndPreparatoryActivities2 { get; set; }

}
