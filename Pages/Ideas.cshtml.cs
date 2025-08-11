using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectQ.Data;
using ProjectQ.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectQ.Pages
{
    public class IdeasModel : PageModel
    {
        private readonly AppDbContext _context;

        public IdeasModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TradeIdea NewIdea { get; set; }

        public IList<TradeIdea> Ideas { get; set; }

        public async Task OnGetAsync()
        {
            Ideas = await _context.TradeIdeas.OrderByDescending(i => i.DateAdded).ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.TradeIdeas.Add(NewIdea);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}
