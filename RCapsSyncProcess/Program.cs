using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RCapsSyncProcess.DataContext;
using RCapsSyncProcess.Services;
using Serilog;

class Program
{
    static  void Main()
    {
        var logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "logs", "log.txt");
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day)
            .CreateLogger();
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
            var EmailService=scope.ServiceProvider.GetRequiredService<EmailService>();
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
            var fileProcessor = scope.ServiceProvider.GetRequiredService<FileProcessor>();
            fileProcessor.ProcessFiles();
        }
    }
}
