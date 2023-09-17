using Alpaca.Markets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBot.Application.Interfaces
{
    public interface IMarketDataService
    {
        Task<IQuote> GetLatestMarketDataAsync(string ticker);
    }
}
