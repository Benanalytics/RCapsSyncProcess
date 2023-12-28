using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCapsSyncProcess.Models
{
    public class ConstantVariable
    {
        public const string OneDriveFile = "SaveFileOneDrive";
        public const string InvalidFileName= "Invalid file name.";
        public const string WrongDirectory = "Unable to determine the project's root directory.";
        public const string IOP_Pipeline = "1-IOP_Pipeline.xlsx";
        public const string LendingPlan = "2-Lending_Plan_RCAPS.xlsx";
        public const string LendingApprovals = "3-Lending_Approval_ RCAPS.xlsx";
        public const string Portfolio = "4-Portfolio_RCAPS.xlsx";
        public const string FailedMessage = "records failed to process and were not saved in the database.";
        public const string Success = "Processed Successfully";
        public const string Countmessage = "records were processed in total.";
        public const string FileExist = "already exists";
        public const string DirectoryExists = "Directory does not exist";
        
    }
}
