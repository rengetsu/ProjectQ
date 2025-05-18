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
    }
}
