using MediatR;
using StockBot.Application.Interfaces;
using StockBot.Domain.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StockBot.Application.BuyRequests.Commands
{
    public class CreateMarketBuyRequestByNumberOfSharesCommand : IRequest<Order>
    {
        public string Ticker { get; set; }
        public double NumberOfShares { get; set; }
        public string OrderTime { get; set; } = "Day";
    }
    public class CreateMarketBuyRequestByNumberOfSharesCommandHandler : IRequestHandler<CreateMarketBuyRequestByNumberOfSharesCommand, Order>
    {
        private readonly ITradingService _tradingService;

        public CreateMarketBuyRequestByNumberOfSharesCommandHandler(ITradingService tradingService)
        {
            _tradingService = tradingService;
        }

        public Task<Order> Handle(CreateMarketBuyRequestByNumberOfSharesCommand request, CancellationToken cancellationToken)
        {
            return _tradingService.SendMarketBuyOrderAsync(request.Ticker, request.NumberOfShares, request.OrderTime);
        }
    }
}
