using ExcelMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCapsSyncProcess.Models
{
    public class IOP_Pipeline
    {
        [Key]
        [ExcelIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? Id { get; set; }

        [ExcelColumnName("SAP ID")]
        public string? SapId { get; set; }

        [ExcelColumnName("Project Name")]
        public string? ProjectName { get; set; }

        [ExcelColumnName("Country Name")]
        public string? CountryName { get; set; }

        [ExcelColumnName("Status")]
        public string? Status { get; set; }

        [ExcelColumnName("Approval Year")]
        public int ApprovalYear { get; set; }

        [ExcelColumnName("Responsible Cost Center")]
        public string? ResponsibleCostCenter { get; set; }

        [ExcelColumnName("Fund Center")]
        public string? FundCenter { get; set; }

        [ExcelColumnName("WPA")]
        public string? WPA { get; set; }

        [ExcelColumnName("Operation Type")]
        public string? OperationType { get; set; }

        [ExcelColumnName("Region Department")]
        public string? RegionDepartment { get; set; }

        [ExcelColumnName("Sector Department")]
        public string? SectorDepartment { get; set; }

        [ExcelColumnName("ADB Public")]
        public double? AdbPublic { get; set; }

        [ExcelColumnName("ADB Private")]
        public double? AdbPrivate { get; set; }

        [ExcelColumnName("ADF Loan")]
        public double? AdfLoan { get; set; }

        [ExcelColumnName("ADF Grant")]
        public double? AdfGrant { get; set; }

        [ExcelColumnName("MIC")]
        public double? Mic { get; set; }

        [ExcelColumnName("TSF")]
        public double? Tsf { get; set; }

        [ExcelColumnName("ADF Inclduing TSF")]
        public double? AdfIncludingTsf { get; set; }

        [ExcelColumnName("NTF")]
        public double? Ntf { get; set; }

        [ExcelColumnName("Co Financing")]
        public double? CoFinancing { get; set; }

        [ExcelColumnName("Trust Fund")]
        public double? TrustFund { get; set; }

        [ExcelColumnName("Total")]
        public double? Total { get; set; }

        [ExcelColumnName("Financing Source ")]
        public string? FinancingSource { get; set; }

        [ExcelColumnName("Feed Africa")]
        public double? FeedAfrica { get; set; }

        [ExcelColumnName("Light Up And Power Africa")]
        public double? LightUpAndPowerAfrica { get; set; }

        [ExcelColumnName("Industrialize Africa")]
        public double? IndustrializeAfrica { get; set; }

        [ExcelColumnName("Integrate Africa")]
        public double? IntegrateAfrica { get; set; }

        [ExcelColumnName("Improve Quality Of Life")]
        public double? ImproveQualityOfLife { get; set; }

        [ExcelColumnName("TOTAL HI")]
        public double? TotalHi { get; set; }

        [ExcelColumnName("Confirm")]
        public bool? Confirm { get; set; }

        [ExcelColumnName("Feed Africa-II")]
        public double? FeedAfricaII { get; set; }

        [ExcelColumnName("Light Up And Power Africa_II")]
        public double? LightUpAndPowerAfricaII { get; set; }

        [ExcelColumnName("Industrialize Africa_II")]
        public double? IndustrializeAfricaII { get; set; }

        [ExcelColumnName("Integrate Africa_II")]
        public double? IntegrateAfricaII { get; set; }

        [ExcelColumnName("Improve Quality Of Life_II")]
        public double? ImproveQualityOfLifeII { get; set; }

        [ExcelColumnName("Report Date")]
        public string? ReportDate { get; set; }

        [ExcelColumnName("Report Type")]
        public string? ReportType { get; set; }

        [ExcelColumnName("High-Fives-Improve sector")]
        public string? HighFivesImproveSector { get; set; }

        [ExcelColumnName("Sector Analysis ")]
        public string? SectorAnalysis { get; set; }

        [ExcelColumnName("African Region")]
        public string? AfricanRegion { get; set; }

        [ExcelColumnName("Selectivity_UA 50_300 M")]
        public string? SelectivityUa50_300M { get; set; }

        [ExcelColumnName("COUNTRY CLASSIFICATION")]
        public string? CountryClassification { get; set; }

        [ExcelColumnName("Transaition vs Non-Transition States")]
        public string? TransitionVsNonTransitionStates { get; set; }

        [ExcelColumnName("De Facto and Non-De Facto Countries")]
        public string? DeFactoAndNonDeFactoCountries { get; set; }

        [ExcelColumnName("Infrastructure vs Sector")]
        public string? InfrastructureVsSector { get; set; }

        [ExcelColumnName("Complex")]
        public string? Complex { get; set; }


    }
}
