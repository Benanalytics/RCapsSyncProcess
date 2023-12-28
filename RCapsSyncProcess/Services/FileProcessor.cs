using ExcelDataReader;
using ExcelMapper;
using Microsoft.EntityFrameworkCore;
using RCapsSyncProcess.DataContext;
using RCapsSyncProcess.Models;
using Serilog;
using System.Text;

namespace RCapsSyncProcess.Services;
public class FileProcessor
{
    private readonly ApplicationDbContext _context;
    private readonly EmailService _emailService;

    public FileProcessor(ApplicationDbContext context, EmailService emailService)
    {
        _context = context;
        _emailService = emailService;
    }
    public void ProcessFiles()
    {
        Log.Information("Process Start ");
        var projectRoot = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
        try
        {
            if (projectRoot != null)
            {
                var folderPath = Path.GetFullPath(Path.Combine(projectRoot, "..", "..", "..", "..", "..", "..", ConstantVariable.OneDriveFile));


                if (Directory.Exists(folderPath))
                {
                    var filesInFolder = Directory.GetFiles(folderPath, "*.xlsx");
                    foreach (var file in filesInFolder)
                    {
                        var fileName = Path.GetFileName(file);
                        if (fileName != null)
                        {
                            var fileExists = _context.UserFiles.FirstOrDefault(a => a.FileName == fileName);
                            if (fileExists != null)
                            {
                                Log.Information("FileExists {0}", ConstantVariable.FileExist);
                                Console.WriteLine($"{fileName} {ConstantVariable.FileExist}");
                            }
                            else
                            {
                                var newUserFile = new UserFiles { FileName = fileName, AddedDate = DateTime.Now };
                                _context.UserFiles.Add(newUserFile);
                                _context.SaveChanges();
                                if (fileName.Contains("Lending_Plan"))
                                {
                                    Log.Information("FileName {0}", fileName);
                                    SaveLendingPlan(file, fileName);
                                }
                                else if (fileName.Contains("Lending_Approvals"))
                                {
                                    Log.Information("FileName {0}", fileName);
                                    SaveLendingApproval(file, fileName);
                                }
                                else if (fileName.Contains("Portfolio"))
                                {
                                    Log.Information("FileName {0}", fileName);
                                    SavePortfolioData(file, fileName);
                                }
                                else if (fileName.Contains("IOP_Pipeline"))
                                {
                                    Log.Information("FileName {0}", fileName);
                                    SaveIOP_PipelineData(file, fileName);
                                }
                            }
                        }
                        else
                        {
                            Log.Error("InvalidFileName {0}", ConstantVariable.InvalidFileName);
                            Console.WriteLine(ConstantVariable.InvalidFileName);
                        }
                    }
                }
                else
                {
                    Log.Error("FolderPath {0} {1}", folderPath, ConstantVariable.DirectoryExists);
                    Console.WriteLine($"{folderPath}{ConstantVariable.DirectoryExists}");
                }
            }
            else
            {
                Log.Error("WrongDirectory {0}", ConstantVariable.WrongDirectory);
                Console.WriteLine(ConstantVariable.WrongDirectory);
            }
        }
        catch (Exception ex)
        {
            Log.Error("Process Error {0}", ex.StackTrace);
        }
    }
    public void SaveLendingPlan(string filePath, string fileName)
    {
        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding = Encoding.GetEncoding("ISO-8859-1");
            var config = new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true,
                }
            };
            using var stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            using var importer = new ExcelImporter(stream);
            ExcelSheet sheet = importer.ReadSheet();
            List<LendingPlan> lendingPlans = sheet.ReadRows<LendingPlan>().ToList();
            int failedRecordCount = 0;
            foreach (var plan in lendingPlans)
            {
                try
                {
                    plan.Id = Guid.NewGuid();
                    var existingPlan = _context.LendingPlans.AsNoTracking().FirstOrDefault(p => p.Id == plan.Id);
                    if (existingPlan != null)
                    {
                        _context.Entry(existingPlan).CurrentValues.SetValues(plan);
                    }
                    else
                    {
                        _context.LendingPlans.Add(plan);
                    }
                }
                catch (Exception ex)
                {
                    failedRecordCount++;
                    Log.Error($"{failedRecordCount} {ConstantVariable.FailedMessage}");
                    Log.Error(ex.ToString());
                }
            }
            _context.SaveChanges();
            _emailService.SendEmail(fileName, lendingPlans.Count, failedRecordCount);
            Log.Information($"File '{fileName}' {ConstantVariable.Success}");
            Log.Information($"{lendingPlans.Count}{ConstantVariable.Countmessage}");
            Log.Information($"{ConstantVariable.EmailSuccess} '{fileName}'");

        }
        catch (Exception ex)
        {
            Log.Information(ex.Message);
        }
    }
    public void SaveLendingApproval(string filePath, string fileName)
    {
        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding = Encoding.GetEncoding("ISO-8859-1");
            var config = new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true,
                }
            };
            using var stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            using var importer = new ExcelImporter(stream);
            ExcelSheet sheet = importer.ReadSheet();
            List<LendingApprovals> lendingApprovals = sheet.ReadRows<LendingApprovals>().ToList();
            int failedRecordCount = 0;
            foreach (var approvals in lendingApprovals)
            {
                try
                {
                    approvals.Id = Guid.NewGuid();
                    var existingPlan = _context.LendingApprovals.AsNoTracking().FirstOrDefault(p => p.Id == approvals.Id);
                    if (existingPlan != null)
                    {
                        _context.Entry(existingPlan).CurrentValues.SetValues(approvals);
                    }
                    else
                    {
                        _context.LendingApprovals.Add(approvals);
                    }

                }
                catch (Exception ex)
                {
                    failedRecordCount++;

                    Log.Error($"{failedRecordCount} {ConstantVariable.FailedMessage}");
                    Log.Error(ex.ToString());
                }
            }
            _context.SaveChanges();
            _emailService.SendEmail(fileName, lendingApprovals.Count, failedRecordCount);
            Log.Information($"File '{fileName}'{ConstantVariable.Success} ");
            Log.Information($"{lendingApprovals.Count} {ConstantVariable.Countmessage}");
            Log.Information($"{ConstantVariable.EmailSuccess} '{fileName}'");


        }
        catch (Exception ex)
        {
            Log.Information(ex.Message); ;
        }
    }
    public void SavePortfolioData(string filePath, string fileName)
    {
        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding = Encoding.GetEncoding("ISO-8859-1");
            var config = new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true,
                }
            };
            using var stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            using var importer = new ExcelImporter(stream);
            ExcelSheet sheet = importer.ReadSheet();
            List<Portfolio> portfolios = sheet.ReadRows<Portfolio>().ToList();
            int failedRecordCount = 0;
            foreach (var portfolio in portfolios)
            {
                try
                {

                    portfolio.Id = Guid.NewGuid();

                    var existingPlan = _context.Portfolios.AsNoTracking().FirstOrDefault(p => p.Id == portfolio.Id);

                    if (existingPlan != null)
                    {
                        _context.Entry(existingPlan).CurrentValues.SetValues(portfolio);
                    }
                    else
                    {
                        _context.Portfolios.Add(portfolio);
                    }

                }
                catch (Exception ex)
                {
                    failedRecordCount++;
                    Log.Error($"{failedRecordCount}{ConstantVariable.FailedMessage}.");
                    Log.Error(ex.ToString());
                }
            }

            _context.SaveChanges();
            _emailService.SendEmail(fileName, portfolios.Count, failedRecordCount);
            Log.Information($"File '{fileName}'{ConstantVariable.Success} ");
            Log.Information($"{portfolios.Count} {ConstantVariable.Countmessage}");
            Log.Information($"{ConstantVariable.EmailSuccess} '{fileName}'");
        }
        catch (Exception ex)
        {
            Log.Information(ex.Message);
        }
    }

    public void SaveIOP_PipelineData(string filePath, string fileName)
    {
        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding = Encoding.GetEncoding("ISO-8859-1");
            var config = new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true,
                }
            };
            using var stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            using var importer = new ExcelImporter(stream);
            ExcelSheet sheet = importer.ReadSheet();
            List<IOP_Pipeline> iOP_Pipelines = sheet.ReadRows<IOP_Pipeline>().ToList();
            int failedRecordCount = 0;
            foreach (var iOP_Pipeline in iOP_Pipelines)
            {
                try
                {

                    iOP_Pipeline.Id = Guid.NewGuid();

                    var existingPlan = _context.IOP_Pipelines.AsNoTracking().FirstOrDefault(p => p.Id == iOP_Pipeline.Id);

                    if (existingPlan != null)
                    {
                        _context.Entry(existingPlan).CurrentValues.SetValues(iOP_Pipeline);
                    }
                    else
                    {
                        _context.IOP_Pipelines.Add(iOP_Pipeline);
                    }

                }
                catch (Exception ex)
                {
                    failedRecordCount++;
                    Log.Error($"{failedRecordCount}{ConstantVariable.FailedMessage}.");
                    Log.Error(ex.ToString());
                }
            }

            _context.SaveChanges();
            _emailService.SendEmail(fileName, iOP_Pipelines.Count, failedRecordCount);
            Log.Information($"File '{fileName}'{ConstantVariable.Success} ");
            Log.Information($"{iOP_Pipelines.Count} {ConstantVariable.Countmessage}");
            Log.Information($"{ConstantVariable.EmailSuccess} '{fileName}'");
        }
        catch (Exception ex)
        {
            Log.Information(ex.Message);
        }
    }
}