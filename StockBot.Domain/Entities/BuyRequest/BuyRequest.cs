using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBot.Domain.Entities.BuyRequest
{
    public class MarketBuyRequest
    {
        public string Ticker { get; set; }
        public double? BuyAmountInShares { get; set; }
        public double? BuyAmountInDollars { get; set; }
        public double MarketPrice { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
