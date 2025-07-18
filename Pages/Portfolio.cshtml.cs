using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectQ.Models;
using ProjectQ.Data;
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

        public void OnGet()
        {
            Holdings = _context.Portfolio
                .OrderByDescending(p => p.DateAdded)
                .ToList();
        }
    }
}
