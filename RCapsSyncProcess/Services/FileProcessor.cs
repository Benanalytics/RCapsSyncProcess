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
        var projectRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        if (projectRoot != null)
        {
            var folderPath = Path.Combine(projectRoot,ConstantVariable.OneDriveFile);
            if (Directory.Exists(folderPath))
            {
                var filesInFolder = Directory.GetFiles(folderPath, "*.xlsx");
                foreach (var file in filesInFolder)
                {
                    var fileName = Path.GetFileName(file).ToLower();
                    if (fileName != null)
                    {
                        var fileExists = _context.UserFiles.FirstOrDefault(a => a.FileName == fileName);
                        if (fileExists != null)
                        {
                            Console.WriteLine($"{fileName} {ConstantVariable.FileExist}");
                        }
                        else
                        {
                            var newUserFile = new UserFiles { FileName = fileName, AddedDate = DateTime.Now };
                            _context.UserFiles.Add(newUserFile);
                            _context.SaveChanges();
                            if (fileName == ConstantVariable.LendingPlan.ToLower())
                            {
                                SaveLendingPlan(file, fileName);
                            }
                            else if (fileName == ConstantVariable.LendingApprovals.ToLower())
                            {
                                SaveLendingApproval(file, fileName);
                            }
                            else if (fileName == ConstantVariable.Portfolio.ToLower())
                            {
                                SavePortfolioData(file, fileName);
                            }
                            if (fileName==ConstantVariable.IOP_Pipeline.ToLower())
                            {
                                SaveIOP_PipelineData(file, fileName);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(ConstantVariable.InvalidFileName);
                    }
                }
            }
            else
            {
                Console.WriteLine($"{folderPath}{ConstantVariable.DirectoryExists }");
            }
        }
        else
        {
            Console.WriteLine(ConstantVariable.WrongDirectory);
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
                    var existingPlan =  _context.LendingPlans.AsNoTracking().FirstOrDefault(p => p.Id == plan.Id);
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
                    Log.Information($"{failedRecordCount} {ConstantVariable.FailedMessage}");
                    Log.Information(ex.ToString());
                }
            }
            _context.SaveChanges();
            _emailService.SendEmail(fileName, lendingPlans.Count, failedRecordCount);
            Log.Information($"File '{fileName}' {ConstantVariable.Success}");
            Log.Information($"{lendingPlans.Count}{ConstantVariable.Countmessage}");

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
                    var existingPlan =  _context.LendingApprovals.AsNoTracking().FirstOrDefault(p => p.Id == approvals.Id);
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

                    Log.Information($"{failedRecordCount}{ConstantVariable.FailedMessage}");
                    Log.Information(ex.ToString());
                }
            }
             _context.SaveChanges();
            _emailService.SendEmail(fileName, lendingApprovals.Count, failedRecordCount);
            Log.Information($"{lendingApprovals.Count} {ConstantVariable.Countmessage}");

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

                    var existingPlan =  _context.Portfolios.AsNoTracking().FirstOrDefault(p => p.Id == portfolio.Id);

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
                    Log.Information($"{failedRecordCount}{ConstantVariable.FailedMessage}.");
                    Log.Information(ex.ToString());
                }
            }

             _context.SaveChanges();
            _emailService.SendEmail(fileName, portfolios.Count, failedRecordCount);
            Log.Information($"File '{fileName}'{ConstantVariable.Success} ");
            Log.Information($"{portfolios.Count} {ConstantVariable.Countmessage}");
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

                    var existingPlan = _context.iOP_Pipelines.AsNoTracking().FirstOrDefault(p => p.Id == iOP_Pipeline.Id);

                    if (existingPlan != null)
                    {
                        _context.Entry(existingPlan).CurrentValues.SetValues(iOP_Pipeline);
                    }
                    else
                    {
                        _context.iOP_Pipelines.Add(iOP_Pipeline);
                    }

                }
                catch (Exception ex)
                {
                    failedRecordCount++;
                    Log.Information($"{failedRecordCount}{ConstantVariable.FailedMessage}.");
                    Log.Information(ex.ToString());
                }
            }

            _context.SaveChanges();
            _emailService.SendEmail(fileName, iOP_Pipelines.Count, failedRecordCount);
            Log.Information($"File '{fileName}'{ConstantVariable.Success} ");
            Log.Information($"{iOP_Pipelines.Count} {ConstantVariable.Countmessage}");
        }
        catch (Exception ex)
        {
            Log.Information(ex.Message);
        }
    }
}

