using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using ProjectQ.Data;
using ProjectQ.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectQ.Pages
{
    public class StocksModel : PageModel
    {
        private readonly AppDbContext _context;

        public StocksModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Stock> StockList { get; set; }

        [BindProperty]
        public Stock NewStock { get; set; }

        public async Task OnGetAsync()
        {
            StockList = _context.Stocks.OrderByDescending(s => s.Date).ToList();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || string.IsNullOrWhiteSpace(NewStock.Ticker))
                return RedirectToPage();

            NewStock.Date = DateTime.Today;
            _context.Stocks.Add(NewStock);
            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}
