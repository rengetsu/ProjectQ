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

        /// <summary>
        /// Delete financial record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var record = await _context.FinancialRecords.FindAsync(id);

            if (record != null)
            {
                _context.FinancialRecords.Remove(record);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

    }
}
