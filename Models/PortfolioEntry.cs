using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectQ.Models
{
    [Table("Portfolio", Schema = "Revolut")]
    public class PortfolioEntry
    {
        public int Id { get; set; }

        [Column("TradeDate")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        [Required]
        public string Ticker { get; set; }

        public int Quantity { get; set; }

        public decimal TradedValue { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OperationDateTime { get; set; }

        public decimal Fees { get; set; }

        public decimal TotalCost { get; set; }

        public string TradeId { get; set; }

        public string ISIN { get; set; }

        public string Currency { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }
    }
}
