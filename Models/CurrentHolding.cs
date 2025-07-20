using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectQ.Models
{
    [Table("CurrentHoldings", Schema = "Revolut")]
    public class CurrentHolding
    {
        public string Ticker { get; set; }
        public int NetQuantity { get; set; }
    }
}
