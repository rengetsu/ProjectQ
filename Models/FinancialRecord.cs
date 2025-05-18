using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectQ.Models
{
    [Table("FinancialRecords", Schema = "Yahoo")]
    public class FinancialRecord
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
