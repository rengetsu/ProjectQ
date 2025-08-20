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
        public class StockHistoryPoint
        {
            public DateTime Date { get; set; }
            public decimal LastPrice { get; set; }
        }

        private readonly AppDbContext _context;

        public StocksModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Stock> StockList { get; set; }
        public Dictionary<string, List<StockHistoryPoint>> ChartDataByTicker { get; set; }

        [BindProperty]
        public Stock NewStock { get; set; }

        // ? Pagination
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        private const int PageSize = 10;

        public void OnGet(int page = 1)
        {
            CurrentPage = page;

            int totalCount = _context.Stocks.Count();
            TotalPages = (int)Math.Ceiling(totalCount / (double)PageSize);

            StockList = _context.Stocks
                .OrderByDescending(s => s.Date)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            ChartDataByTicker = StockList
                .GroupBy(s => s.Ticker)
                .ToDictionary(
                    g => g.Key,
                    g => g.OrderBy(s => s.Date)
                          .Select(s => new StockHistoryPoint
                          {
                              Date = s.Date,
                              LastPrice = s.LastPrice
                          })
                          .ToList()
                );
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
