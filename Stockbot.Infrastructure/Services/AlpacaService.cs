using Alpaca.Markets;
using StockBot.Domain.Entities.Order;
using Stockbot.Infrastructure.Extensions;
using StockBot.Application.Interfaces;

namespace Stockbot.Infrastructure.Services
{
    public class AlpacaService : ITradingService
    {
        private readonly IAlpacaTradingClient _alpacaTradingClient;
        private readonly IAlpacaDataClient _alpacaDataClient;

        public AlpacaService(IAlpacaTradingClient client, IAlpacaDataClient alpacaDataClient)
        {
            _alpacaTradingClient = client;
            _alpacaDataClient = alpacaDataClient;
        }
        public async Task<Order> SendMarketBuyOrderAsync(string ticker, double numberOfShares, string timeInForce)
        {

            NewOrderRequest req = new NewOrderRequest(ticker,
                                                      OrderQuantity.Fractional((decimal)numberOfShares),
                                                      OrderSide.Buy,
                                                      OrderType.Market,
                                                      timeInForce.ToTimeInForce());

            var order = await _alpacaTradingClient.PostOrderAsync(req);

            return order.Map();
        }

        public async Task<IQuote> GetLatestMarketDataAsync(string ticker)
        {
            var request = new LatestMarketDataRequest(ticker);

            return await _alpacaDataClient.GetLatestQuoteAsync(request);
        }
    }
}
