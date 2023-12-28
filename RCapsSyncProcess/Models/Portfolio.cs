using ExcelMapper;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RCapsSyncProcess.Models;
public class Portfolio
{
    [Key]
    [ExcelIgnore]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? Id { get; set; }

    [ExcelColumnName("SAP Code")]
    public string? SapCode { get; set; }

    [ExcelColumnName("Loan Number")]
    public string? LoanNumber { get; set; }

    [ExcelColumnName("Country")]
    public string? Country { get; set; }

    [ExcelColumnName("Borrower Category")]
    public string? BorrowerCategory { get; set; }

    [ExcelColumnName("Long Name")]
    public string? LongName { get; set; }

    [ExcelColumnName("Division")]
    public string? Division { get; set; }

    [ExcelColumnName("Group Key 1")]
    public string? GroupKey1 { get; set; }

    [ExcelColumnName("Sector Name")]
    public string? SectorName { get; set; }

    [ExcelColumnName("Group Key 2")]
    public string? GroupKey2 { get; set; }

    [ExcelColumnName("Sub Sector Name")]
    public string? SubSectorName { get; set; }

    [ExcelColumnName("Group Key 3")]
    public string? GroupKey3 { get; set; }

    [ExcelColumnName("Sub-Sub Sector Name")]
    public string? SubSubSectorName { get; set; }

    [ExcelColumnName("Company Code")]
    public string? CompanyCode { get; set; }

    [ExcelColumnName("Loan Type")]
    public string? LoanType { get; set; }

    [ExcelColumnName("Status of Project")]
    public string? StatusOfProject { get; set; }

    [ExcelColumnName("Approval date")]
    public string? ApprovalDate { get; set; }

    [ExcelColumnName("Commitment date")]
    public string? CommitmentDate { get; set; }

    [ExcelColumnName("Planned final Disb.  date")]
    public string? PlannedFinalDisbursementDate { get; set; }

    [ExcelColumnName("Effective 1st disb")]
    public string? EffectiveFirstDisbursement { get; set; }

    [ExcelColumnName("Entry into force")]
    public string? EntryIntoForce { get; set; }

    [ExcelColumnName("Actual First disbursement")]
    public string? ActualFirstDisbursement { get; set; }

    [ExcelColumnName("Latest Disbursment")]
    public string? LatestDisbursement { get; set; }

    [ExcelColumnName("Currency")]
    public string? Currency { get; set; }

    [ExcelColumnName("Capital applied for")]
    public double? CapitalAppliedFor { get; set; }

    [ExcelColumnName("Contract capital")]
    public double? ContractCapital { get; set; }

    [ExcelColumnName("Capital Reduction")]
    public double? CapitalReduction { get; set; }

    [ExcelColumnName("Disbursement obligation")]
    public double? DisbursementObligation { get; set; }

    [ExcelColumnName("Value-Dated Capital")]
    public double? ValueDatedCapital { get; set; }

    [ExcelColumnName("Netloan")]
    public double? NetLoan { get; set; }

    [ExcelColumnName("Disbursement Ratio")]
    public double? DisbursementRatio { get; set; }

    [ExcelColumnName("TOTAL COMMITMENT FOR THE LOAN")]
    public double? TotalCommitmentForTheLoan { get; set; }

    [ExcelColumnName("TOTAL CONTRACT DISBURSMENT")]
    public double? TotalContractDisbursement { get; set; }

    [ExcelColumnName("TOTAL UNDISB CONTRACT")]
    public double? TotalUndisbursedContract { get; set; }

    [ExcelColumnName("TSK MANAGER NAME")]
    public string? TskManagerName { get; set; }

    [ExcelColumnName("Old Loan Agreement Number")]
    public string? OldLoanAgreementNumber { get; set; }

    [ExcelColumnName("Type of supervision Summary")]
    public string? TypeOfSupervisionSummary { get; set; }

    [ExcelColumnName("Serial No SUpervision summary")]
    public double? SerialNoSupervisionSummary { get; set; }

    [ExcelColumnName("Executing Agency")]
    public string? ExecutingAgency { get; set; }

    [ExcelColumnName("Main Borrower")]
    public string? MainBorrower { get; set; }

    [ExcelColumnName("Guarantor")]
    public string? Guarantor { get; set; }
    [ExcelColumnName("Date Rcv'd by Bank")]
    public string? DateReceivedByBank { get; set; }

    [ExcelColumnName("Audit Due Date")]
    public string? AuditDueDate { get; set; }

    [ExcelColumnName("last supervision Mission")]
    public string? LastSupervisionMission { get; set; }

    [ExcelColumnName("Last supervision mission end date")]
    public string? LastSupervisionMissionEndDate { get; set; }

    [ExcelColumnName("Current expected COMPLETION date")]
    public string? CurrentExpectedCompletionDate { get; set; }

    [ExcelColumnName("Number of contract for the project")]
    public double? NumberOfContracts { get; set; }

    [ExcelColumnName("Number of amendments for the project")]
    public double? NumberOfAmendments { get; set; }

    [ExcelColumnName("Planned project completion date")]
    public string? PlannedProjectCompletionDate { get; set; }

    [ExcelColumnName("Project cost")]
    public double? ProjectCost { get; set; }

    [ExcelColumnName("PROJECT Currency")]
    public string? ProjectCurrency { get; set; }
    [ExcelColumnName("Purpose of Loan")]
    public string? PurposeOfLoan { get; set; }

    [ExcelColumnName("User Status")]
    public string? UserStatus { get; set; }

    [ExcelColumnName("ADF FUND NUMBER")]
    public string? ADFFundNumber { get; set; }

    [ExcelColumnName("INT4")]
    public double? INT4 { get; set; }

    [ExcelColumnName("Regional Dept")]
    public string? RegionalDepartment { get; set; }

    [ExcelColumnName("Region")]
    public string? Region { get; set; }

    [ExcelColumnName("Status")]
    public string? Status { get; set; }

    [ExcelColumnName("Loans Exchange Rate Date")]
    public string? LoansExchangeRateDate { get; set; }

    [ExcelColumnName("Complex to which mission belongs")]
    public string? MissionComplex { get; set; }

    [ExcelColumnName("Sector Dept")]
    public string? SectorDepartment { get; set; }

    [ExcelColumnName("Basic dates duration")]
    public double? BasicDatesDuration { get; set; }

    [ExcelColumnName("Internal UoM")]
    public string? InternalUoM { get; set; }

    [ExcelColumnName("Window")]
    public string? Window { get; set; }

    [ExcelColumnName("Amount For Window")]
    public double? AmountForWindow { get; set; }

    [ExcelColumnName("Company Name")]
    public string? CompanyName { get; set; }

    [ExcelColumnName("Description")]
    public string? Description { get; set; }

    [ExcelColumnName("Description2")]
    public string? Description2 { get; set; }

    [ExcelColumnName("Description3")]
    public string? Description3 { get; set; }

    [ExcelColumnName("DELAY NO SPVS (Month)")]
    public double? DelayNoSPVS { get; set; }

    [ExcelColumnName("DELAY_SIGN_MONTH")]
    public double? DelaySignMonth { get; set; }

    [ExcelColumnName("DELAY_EFF_MONTH")]
    public double? DelayEffMonth { get; set; }

    [ExcelColumnName("DELAY_DISB_MONTH")]
    public double? DelayDisbMonth { get; set; }

    [ExcelColumnName("DELAY_CLOS_M")]
    public double? DelayClosMonth { get; set; }

    [ExcelColumnName("IP (Impl.Progress)")]
    public string? ImplementationProgress { get; set; }

    [ExcelColumnName("DO (Dev. Objectives)")]
    public string? DevelopmentObjectives { get; set; }


    [ExcelColumnName("PFI STATUS")]
    public string? PFIStatus { get; set; }

    [ExcelColumnName("Project Age in YEARS")]
    public double? ProjectAgeInYears { get; set; }

    [ExcelColumnName("Description4")]
    public string? Description4 { get; set; }

    [ExcelColumnName("Original Closing Date")]
    public string? OriginalClosingDate { get; set; }

    [ExcelColumnName("Nbre extension Date")]
    public double? NumberOfExtensions { get; set; }

    [ExcelColumnName("Duree extension final disb date")]
    public string? DurationExtensionFinalDisbursementDate { get; set; }

    [ExcelColumnName("Country Involved")]
    public string? CountryInvolved { get; set; }

    [ExcelColumnName("Business Partner for BO")]
    public string? BusinessPartnerForBO { get; set; }

    [ExcelColumnName("BO Text")]
    public string? BOText { get; set; }

    [ExcelColumnName("Business Partner for GU")]
    public string? BusinessPartnerForGU { get; set; }

    [ExcelColumnName("GU Text")]
    public string? GUTex { get; set; }

    [ExcelColumnName("YEAR TREND")]
    public string? YearTrend { get; set; }

    [ExcelColumnName("Age iof Project Cal Yr")]
    public double? AgeOfProjectCalendarYear { get; set; }

    [ExcelColumnName("Status_Project")]
    public string? StatusProject { get; set; }

    [ExcelColumnName("Number of Project")]
    public double? NumberOfProject { get; set; }

    [ExcelColumnName("Financing Instrument")]
    public string? FinancingInstrument { get; set; }

    [ExcelColumnName("Type of Operations")]
    public string? TypeOfOperations { get; set; }

    [ExcelColumnName("Age Spectrum")]
    public string? AgeSpectrum { get; set; }

    [ExcelColumnName("Refine Country")]
    public string? RefineCountry { get; set; }

    [ExcelColumnName("Country2")]
    public string? Country2 { get; set; }

    [ExcelColumnName("SNDR")]
    public string? SNDR { get; set; }

    [ExcelColumnName("Sector Used")]
    public string? SectorUsed { get; set; }

    [ExcelColumnName("Confirmed Age")]
    public string? ConfirmedAge { get; set; }

    [ExcelColumnName("days between the approval and completion dates")]
    public double? DaysBetweenApprovalAndCompletion { get; set; }

    [ExcelColumnName("calculate the average of these durations.")]
    public double? AverageApprovalCompletionDurations { get; set; }

    [ExcelColumnName("days between the approval and Effectiveness dates")]
    public double? DaysBetweenApprovalAndEffectiveness { get; set; }

    [ExcelColumnName("calculate the average of these durations.2")]
    public double? AverageApprovalEffectivenessDurations { get; set; }

    [ExcelColumnName("Absolute Age Range")]
    public string? AbsoluteAgeRange { get; set; }

    [ExcelColumnName("Disbursment ratio")]
    public double? Disbursement_Ratio { get; set; }

    [ExcelColumnName("Amt in UA Million")]
    public double? AmountInUAMillion { get; set; }

    [ExcelColumnName("Amt in USD Million")]
    public double? AmountInUSDMillion { get; set; }

    [ExcelColumnName("Amt Disbusred in UA Million")]
    public double? AmountDisbursedInUAMillion { get; set; }

    [ExcelColumnName("Disbusred Bal in UA Million")]
    public double? DisbursedBalanceInUAMillion { get; set; }

    [ExcelColumnName("Fin Window")]
    public string? FinancialWindow { get; set; }

    [ExcelColumnName("Yrs")]
    public string? Years { get; set; }

    [ExcelColumnName("Operations Type")]
    public string? OperationsType { get; set; }

    [ExcelColumnName("African Region")]
    public string? AfricanRegion { get; set; }

    [ExcelColumnName("Transition Vs Non-Transitaion States")]
    public string? TransitionVsNonTransitionalStates { get; set; }

    [ExcelColumnName("De Facto and Non-De Facto Countries")]
    public string? DeFactoAndNonDeFactoCountries { get; set; }

    [ExcelColumnName("Complex")]
    public string? Complex { get; set; }

    [ExcelColumnName("Dibsursment ratio Spectrum")]
    public string? DisbursementRatioSpectrum { get; set; }

    [ExcelColumnName("Disbursement ratio Spectrum(4 Range)")]
    public string? DisbursementRatioSpectrumFourRange { get; set; }

    [ExcelColumnName("Selectivity (UA 10 M)")]
    public string? SelectivityUA10M { get; set; }

    [ExcelColumnName("Selectivity (UA 20 M)")]
    public string? SelectivityUA20M { get; set; }

    [ExcelColumnName("Selectivity (UA 30 M)")]
    public string? SelectivityUA30M { get; set; }

    [ExcelColumnName("Selectivity (UA 40 M)")]
    public string? SelectivityUA40M { get; set; }

    [ExcelColumnName("Selectivity (UA 50>300 M)")]
    public string? SelectivityUA50To300M { get; set; }

    [ExcelColumnName("MTR Condition")]
    public string? MTRCondition { get; set; }

    [ExcelColumnName("Total Contract Proc Amount")]
    public double? TotalContractProcAmount { get; set; }

    [ExcelColumnName("Total Alert")]
    public string? TotalAlert { get; set; }

    [ExcelColumnName("Type Alert")]
    public string? TypeAlert { get; set; }

    [ExcelColumnName("Explanation 1st Indicator")]
    public string? ExplanationFirstIndicator { get; set; }

    [ExcelColumnName("Refined Type Alert")]
    public string? RefinedTypeAlert { get; set; }

    [ExcelColumnName("Reasons for Delay: ")]
    public string? ReasonsForDelay { get; set; }

    [ExcelColumnName("Recommendations")]
    public string? Recommendations { get; set; }

    [ExcelColumnName("Key Delay Indicators")]
    public string? KeyDelayIndicators { get; set; }

    [ExcelColumnName("Key Recommended Actions")]
    public string? KeyRecommendedActions { get; set; }

    [ExcelColumnName("Status of Project Implemenation for the Aged/Aging Projects")]
    public string? StatusOfProjectImplementationForAgedProjects { get; set; }

    [ExcelColumnName("Phase of Implementaion ")]
    public string? PhaseOfImplementation { get; set; }

    [ExcelColumnName("Expected Completion Date")]
    public string? ExpectedCompletionDate { get; set; }


    [ExcelColumnName("PCR date")]
    public string? PCRDate { get; set; }

    [ExcelColumnName("PCR Due date")]
    public string? PCRDueDate { get; set; }

    [ExcelColumnName("PCR Timeliness")]
    public string? PCRTimeliness { get; set; }

    [ExcelColumnName("First IPR 2023")]
    public string? FirstIPR2023 { get; set; }

    [ExcelColumnName("Second IPR 2023")]
    public string? SecondIPR2023 { get; set; }

    [ExcelColumnName("First IPR 2022")]
    public string? FirstIPR2022 { get; set; }

    [ExcelColumnName("Second IPR 2022")]
    public string? SecondIPR2022 { get; set; }

    [ExcelColumnName("IPF Status 2023")]
    public string? IPFStatus2023 { get; set; }

    [ExcelColumnName("AgeData(10yrs)")]
    public string? AgeData10Years { get; set; }

    [ExcelColumnName("Env Cat")]
    public string? EnvironmentCategory { get; set; }

    [ExcelColumnName("Env Cat2")]
    public string? EnvironmentCategory2 { get; set; }

    [ExcelColumnName("Env Cat Type")]
    public string? EnvironmentCategoryType { get; set; }

}
