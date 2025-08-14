using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectQ.Data;
using ProjectQ.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace ProjectQ.Pages
{
    public class PortfolioModel : PageModel
    {
        private readonly AppDbContext _context;

        public PortfolioModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<PortfolioEntry> Holdings { get; set; }

        [BindProperty]
        public PortfolioEntry NewTrade { get; set; }

        //  Dynamic allocations for the portfolio
        public List<HoldingAllocation> Allocations { get; set; } = new();

        //  Dynamic growth points for the portfolio
        public List<PortfolioGrowthPoint> GrowthPoints { get; set; } = new();


        public void OnGet()
        {
            Holdings = _context.Portfolio
                .OrderByDescending(p => p.DateAdded)
                .ToList();

            Allocations = _context.Set<HoldingAllocation>()
                .FromSqlRaw("SELECT * FROM Revolut.vw_PortfolioHoldingsAllocation")
                .ToList();

            GrowthPoints = _context.Set<PortfolioGrowthPoint>()
                .FromSqlRaw("SELECT * FROM Revolut.vw_PortfolioGrowth")
                .OrderBy(p => p.Date)
                .ToList();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || string.IsNullOrWhiteSpace(NewTrade.Ticker))
                return Page();

            NewTrade.DateAdded = DateTime.Now;

            _context.Portfolio.Add(NewTrade);
            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}
