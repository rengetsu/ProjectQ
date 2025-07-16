using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectQ.Models
{
    [Table("Stocks", Schema = "Yahoo")]
    public class Stock
    {
        public int Id { get; set; }

        [Required]
        public string Ticker { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public decimal LastPrice { get; set; }
    }
}
