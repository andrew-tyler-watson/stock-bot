using Alpaca.Markets;
using StockBot.Domain.Entities.BuyRequest;
using StockBot.Domain.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBot.Application.Interfaces;

public interface ITradingService
{
    Task<Order> SendMarketBuyOrderAsync(string ticker, double numberOfShares, string timeInForce);
    Task<IQuote> GetLatestMarketDataAsync(string ticker);
}
