using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectQ.Data;
using ProjectQ.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void OnGet()
        {
            Holdings = _context.Portfolio
                .OrderByDescending(p => p.DateAdded)
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
