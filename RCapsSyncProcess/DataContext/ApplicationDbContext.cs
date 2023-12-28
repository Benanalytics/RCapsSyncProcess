using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RCapsSyncProcess.Models;

namespace RCapsSyncProcess.DataContext;
public class ApplicationDbContext : DbContext
{
    public DbSet<LendingPlan> LendingPlans { get; set; }
    public DbSet<UserFiles> UserFiles { get; set; }
    public DbSet<LendingApprovals> LendingApprovals { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<IOP_Pipeline> IOP_Pipelines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            string strSqlServerConnection = builder.Build().GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(strSqlServerConnection)
                          .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
