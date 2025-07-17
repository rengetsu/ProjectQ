using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectQ.Models
{
    [Table("Portfolio", Schema = "Revolut")]
    public class PortfolioEntry
    {
        public int Id { get; set; }

        [Required]
        public string Ticker { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal AvgBuyPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
    }
}
