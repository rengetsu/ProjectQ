using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectQ.Models;
using ProjectQ.Data;
using System;

namespace ProjectQ.Pages
{
    public class FinancialsModel : PageModel
    {
        private readonly AppDbContext _context;

        public FinancialsModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<FinancialRecord> Records { get; set; }

        public async Task OnGetAsync()
        {
            Records = await _context.FinancialRecords.ToListAsync();
        }
    }
}
