using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectQ.Models;
using ProjectQ.Data;

namespace ProjectQ.Pages
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;

        public EditModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FinancialRecord Record { get; set; }

        public IActionResult OnGet(int id)
        {
            Record = _context.FinancialRecords.FirstOrDefault(r => r.Id == id);

            if (Record == null)
            {
                return RedirectToPage("Financials");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FinancialRecords.Update(Record);
            _context.SaveChanges();

            return RedirectToPage("Financials");
        }
    }
}
