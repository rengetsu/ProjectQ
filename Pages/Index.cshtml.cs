using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjectQ.Data;
using ProjectQ.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectQ.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Property to expose data to Razor page
        public List<CurrentHolding> HoldingsPieData { get; set; } = new List<CurrentHolding>();

        public async Task OnGetAsync()
        {
            try
            {
                HoldingsPieData = await _context.Set<CurrentHolding>().ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load current holdings for pie chart.");
            }
        }
    }
}
