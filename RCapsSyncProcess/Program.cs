using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RCapsSyncProcess.DataContext;
using RCapsSyncProcess.Services;
using Serilog;
using System.Reflection;

class Program
{
    static void Main()
    {
        string myExeDir = new FileInfo(Assembly.GetEntryAssembly().Location).Directory.ToString();
        string currentDtTm = DateTime.UtcNow.ToString("MM-dd-yyyy");

        Log.Logger = new LoggerConfiguration()
         .MinimumLevel.Debug()
         .WriteTo.Console()
         .WriteTo.File(Path.Combine(Directory.GetCurrentDirectory(), @"RCAPSLogsFile\\log" + currentDtTm + ".txt"))
     .CreateLogger();
        var folder = Path.Combine(Directory.GetCurrentDirectory());
        Log.Information("GetCurrentDirectory {0}", folder);
        try
        {
            Log.Information("Application Start");
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            var serviceProvider = new ServiceCollection()
                .AddLogging(builder => builder.AddSerilog())
                .AddDbContext<ApplicationDbContext>()
                .AddScoped<FileProcessor>()
                .AddScoped<EmailService>()
                .AddSingleton<IConfiguration>(configuration)
                .BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                var EmailService = scope.ServiceProvider.GetRequiredService<EmailService>();
                var emailSettingsSection = configuration.GetSection("EmailSettings");
                var senderEmail = emailSettingsSection["SenderEmail"];
                Log.Information("EmailSettings:SenderEmail {0}", senderEmail);
                var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                var fileProcessor = scope.ServiceProvider.GetRequiredService<FileProcessor>();
                fileProcessor.ProcessFiles();
            }
        }
        catch (Exception ex)
        {
            Log.Error("{0}", ex.StackTrace);
        }
    }
}