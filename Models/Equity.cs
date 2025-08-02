using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectQ.Models
{
    [Table("Equities", Schema = "Polygon")]
    public class Equity
    {
        [Key]
        [Column("ticker")]
        public string Ticker { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("market")]
        public string Market { get; set; }

        [Column("locale")]
        public string Locale { get; set; }

        [Column("primary_exchange")]
        public string PrimaryExchange { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        [Column("currency_name")]
        public string CurrencyName { get; set; }

        [Column("cik")]
        public string Cik { get; set; }

        [Column("composite_figi")]
        public string CompositeFigi { get; set; }

        [Column("share_class_figi")]
        public string ShareClassFigi { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Column("address1")]
        public string Address1 { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("state")]
        public string State { get; set; }

        [Column("postal_code")]
        public string PostalCode { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("sic_code")]
        public string SicCode { get; set; }

        [Column("sic_description")]
        public string SicDescription { get; set; }

        [Column("ticker_root")]
        public string TickerRoot { get; set; }

        [Column("homepage_url")]
        public string HomepageUrl { get; set; }

        [Column("total_employees")]
        public int? TotalEmployees { get; set; }

        [Column("list_date")]
        public DateTime? ListDate { get; set; }

        [Column("logo_url")]
        public string LogoUrl { get; set; }

        [Column("icon_url")]
        public string IconUrl { get; set; }

        [Column("share_class_shares_outstanding")]
        public long? ShareClassSharesOutstanding { get; set; }

        [Column("weighted_shares_outstanding")]
        public long? WeightedSharesOutstanding { get; set; }

        [Column("round_lot")]
        public int? RoundLot { get; set; }

        [Column("image_svg")]
        public string ImageSvg { get; set; }
    }
}
