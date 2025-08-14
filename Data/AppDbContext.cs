using ProjectQ.Data;
using ProjectQ.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectQ.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public DbSet<FinancialRecord> FinancialRecords { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<HoldingAllocation> HoldingAllocations { get; set; }

        public DbSet<PortfolioEntry> Portfolio { get; set; }
        public DbSet<PortfolioGrowthPoint> PortfolioGrowthPoints { get; set; }

        public DbSet<Equity> Equities { get; set; }
        public DbSet<TradeIdea> TradeIdeas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TradeIdea>().ToTable("TradeIdeas", schema: "Intranet");
        }


    }
}
