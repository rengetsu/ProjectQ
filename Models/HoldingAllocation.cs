using Microsoft.EntityFrameworkCore;

namespace ProjectQ.Models
{
    [Keyless]
    public class HoldingAllocation
    {
        public string Ticker { get; set; }
        public decimal TotalCost { get; set; }
    }
}
