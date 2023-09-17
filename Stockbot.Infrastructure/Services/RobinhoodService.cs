using StockBot.Application.Interfaces;
using StockBot.Domain.Entities.BuyRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockbot.Infrastructure.Services
{
    public class RobinhoodService 
    {

        public RobinhoodService() { }
        public Task<MarketBuyRequest> SendMarketBuyOrder(string ticker, double numberOfShares, double price)
        {
            throw new NotImplementedException();
        }
    }
}
