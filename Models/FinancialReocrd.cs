using System.ComponentModel.DataAnnotations;

namespace ProjectQ.Models
{
    public class FinancialReocrd
    {
        public int Id { get; set; }

        [Required]
        public string Ticker { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string TimePeriod { get; set; }

        public decimal Revenue { get; set; }

        public decimal EPS { get; set; }

        public decimal EBIT { get; set; }

        public decimal EBITDA { get; set; }

        public decimal GrossProfit { get; set; }
    }
}
