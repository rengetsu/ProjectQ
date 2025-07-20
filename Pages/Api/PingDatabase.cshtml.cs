using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectQ.Data;
using System.Threading.Tasks;

namespace ProjectQ.Pages.Api
{
    public class PingDatabaseModel : PageModel
    {
        private readonly AppDbContext _context;

        public PingDatabaseModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                // Harmless query
                await _context.Database.ExecuteSqlRawAsync("SELECT 1");
                return new JsonResult(new { status = "Online" });
            }
            catch
            {
                return new JsonResult(new { status = "Sleeping or Unreachable" });
            }
        }
    }
}
