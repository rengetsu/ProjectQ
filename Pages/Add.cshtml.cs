using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectQ.Models;
using ProjectQ.Data;

namespace ProjectQ.Pages
{
    public class AddModel : PageModel
    {
        private readonly AppDbContext _context;

        public AddModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FinancialRecord Record { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Record.Date = DateTime.Today;

            _context.FinancialRecords.Add(Record);
            _context.SaveChanges();

            return RedirectToPage("Financials");
        }
    }
}
