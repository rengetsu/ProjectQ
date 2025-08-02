using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectQ.Models
{
    [Table("equities", Schema = "polygon")]
    public class Equity
    {
        [Key]
        public string Ticker { get; set; }

        public string Name { get; set; }
        public string Market { get; set; }
        public string Locale { get; set; }
        public string PrimaryExchange { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public string CurrencyName { get; set; }
        public string Cik { get; set; }
        public string CompositeFigi { get; set; }
        public string ShareClassFigi { get; set; }
        public string PhoneNumber { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Description { get; set; }
        public string SicCode { get; set; }
        public string SicDescription { get; set; }
        public string TickerRoot { get; set; }
        public string HomepageUrl { get; set; }
        public int? TotalEmployees { get; set; }
        public DateTime? ListDate { get; set; }
        public string LogoUrl { get; set; }
        public string IconUrl { get; set; }
        public long? ShareClassSharesOutstanding { get; set; }
        public long? WeightedSharesOutstanding { get; set; }
        public int? RoundLot { get; set; }

        [Column("image_svg")]
        public string ImageSvg { get; set; }
    }
}
