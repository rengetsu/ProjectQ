using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectQ.Models
{
    public class TradeIdea
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string LongTicker { get; set; }

        [MaxLength(50)]
        public string ShortTicker { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    }
}
