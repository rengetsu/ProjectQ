using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectQ.Data;
using ProjectQ.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectQ.Pages
{
    public class EquitiesModel : PageModel
    {
        private readonly AppDbContext _context;

        public EquitiesModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Equity> EquityList { get; set; }

        public async Task OnGetAsync()
        {
            EquityList = await _context.Set<Equity>().ToListAsync();
        }
    }
}
