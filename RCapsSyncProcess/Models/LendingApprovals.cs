using ExcelMapper;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RCapsSyncProcess.Models;
public class LendingApprovals
{

    [Key]
    [ExcelIgnore]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? Id { get; set; }
    [ExcelColumnName("Country")]
    public string? Country { get; set; }

    [ExcelColumnName("Project Title ")]
    public string? ProjectTitle { get; set; }

    [ExcelColumnName("Resolution No.")]
    public string? ResolutionNo { get; set; }

    [ExcelColumnName("Document Code")]
    public string? DocumentCode { get; set; }

    [ExcelColumnName("Approval date Year Trend")]
    public string? ApprovalDateYear { get; set; }

    [ExcelColumnName("Borrower")]
    public string? Borrower { get; set; }

    [ExcelColumnName("Sector Dept.")]
    public string? SectorDept { get; set; }

    [ExcelColumnName("Regional Dept.")]
    public string? RegionalDept { get; set; }

    [ExcelColumnName("Sector board")]
    public string? SectorBoard { get; set; }

    [ExcelColumnName("Financing Source_LEN")]
    public string? FinancingSource_LEN { get; set; }

    [ExcelColumnName("Instrument")]
    public string? Instrument { get; set; }

    [ExcelColumnName("Currency")]
    public string? Currency { get; set; }

    [ExcelColumnName("Amount")]
    public decimal? Amount { get; set; }

    [ExcelColumnName("Approved Amount_UA Equivalent")]
    public decimal? ApprovedAmount_UAEquivalent { get; set; }

    [ExcelColumnName("SAP Code")]
    public string? SAPCode { get; set; }

    [ExcelColumnName("SAP No.")]
    public string? SAPNo { get; set; }

    [ExcelColumnName("Approval Mode")]
    public string? ApprovalMode { get; set; }

    [ExcelColumnName("Financing Source ")]
    public string? FinancingSource { get; set; }

    [ExcelColumnName("Group Key 1_Sector Key")]
    public string? GroupKey1_SectorKey { get; set; }

    [ExcelColumnName("COUNTRY CLASSIFICATION")]
    public string? CountryClassification { get; set; }

    [ExcelColumnName("Transaition vs Non-Transition States")]
    public string? TransitionVsNonTransitionStates { get; set; }

    [ExcelColumnName("De Facto and Non-De Facto Countries")]
    public string? DeFactoAndNonDeFactoCountries { get; set; }

    [ExcelColumnName("African region")]
    public string? AfricanRegion { get; set; }

    [ExcelColumnName("Sector  Analysis ")]
    public string? SectorAnalysis { get; set; }

    [ExcelColumnName("Feed Africa ")]
    public double? FeedAfrica { get; set; }

    [ExcelColumnName("Light Up And Power Africa ")]
    public double? LightUpAndPowerAfrica { get; set; }

    [ExcelColumnName("Industrialize Africa ")]
    public double? IndustrializeAfrica { get; set; }

    [ExcelColumnName("Integrate Africa ")]
    public double? IntegrateAfrica { get; set; }

    [ExcelColumnName("Improve Quality Of Life ")]
    public double? ImproveQualityOfLife { get; set; }

    [ExcelColumnName("Total HI5")]
    public double? TotalHI5 { get; set; }

    [ExcelColumnName("Check")]
    public bool? Check { get; set; }

    [ExcelColumnName("Financing Instrument_USED")]
    public string? FinancingInstrument_USED { get; set; }

    [ExcelColumnName("Financing Instrument")]
    public string? FinancingInstrument { get; set; }

    [ExcelColumnName("Column2")]
    public string? Column2 { get; set; }

    [ExcelColumnName("Infrastructure vs Sector")]
    public string? InfrastructureVsSector { get; set; }

    [ExcelColumnName("Infrastructure vs Sector_NOT USED")]
    public string? InfrastructureVsSector_NOT_USED { get; set; }

    [ExcelColumnName("SECTOR DEPARTMENT ")]
    public string? SectorDepartment { get; set; }

    [ExcelColumnName("Complex")]
    public string? Complex { get; set; }

    [ExcelColumnName("Operations Key")]
    public string? OperationsKey { get; set; }

    [ExcelColumnName("Operations Type")]
    public string? OperationsType { get; set; }

    [ExcelColumnName("NUMBER OF PROJECT")]
    public string? NumberOfProjects { get; set; }

    [ExcelColumnName("Amount in UA Million")]
    public string?  AmountInUAMillion { get; set; }

    [ExcelColumnName("Approved Amount_USDEquivalent")]
    public string?  ApprovedAmount_USDEquivalent { get; set; }

    [ExcelColumnName("Selectivity (UA 10 M)")]
    public string?  Selectivity_UA10M { get; set; }

    [ExcelColumnName("Selectivity (UA 20 M)")]
    public string? Selectivity_UA20M { get; set; }

    [ExcelColumnName("Selectivity (UA 40 M)")]
    public string? Selectivity_UA40M { get; set; }

    [ExcelColumnName("Selectivity (UA 50>300 M)")]
    public string? Selectivity_UA50_300M { get; set; }

    [ExcelColumnName("Column1")]
    public string? Column1 { get; set; }

    [ExcelColumnName("Approval Month and Yrs")]
    public string? ApprovalMonthsAndYears { get; set; }

    [ExcelColumnName("Dec'2015")]
    public double? Dec2015 { get; set; }

    [ExcelColumnName("Dec'2016")]
    public double? Dec2016 { get; set; }

    [ExcelColumnName("Dec'2017")]
    public double? Dec2017 { get; set; }

    [ExcelColumnName("Dec'2018")]
    public double? Dec2018 { get; set; }

    [ExcelColumnName("Dec'2019")]
    public double? Dec2019 { get; set; }

    [ExcelColumnName("Dec'2020")]
    public double? Dec2020 { get; set; }

    [ExcelColumnName("Dec'2021")]
    public double? Dec2021 { get; set; }

    [ExcelColumnName("Dec'2022")]
    public double? Dec2022 { get; set; }

    [ExcelColumnName("Jun'2023")]
    public double? Jun2023 { get; set; }


    [ExcelColumnName("Implementation Status")]
    public string? ImplementationStatus { get; set; }

    [ExcelColumnName("Implementation Status.")]
    public string? ImplementationStatus_ { get; set; }
}
