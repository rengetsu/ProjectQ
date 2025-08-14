using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjectQ.Models
{
    [Keyless]
    public class PortfolioGrowthPoint
    {
        public DateTime Date { get; set; }
        public decimal PortfolioValue { get; set; }
    }
}