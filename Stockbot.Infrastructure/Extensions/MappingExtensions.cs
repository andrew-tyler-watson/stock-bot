using Alpaca.Markets;
using StockBot.Domain.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockbot.Infrastructure.Extensions
{
    public static class MappingExtensions
    {
        public static Order Map(this IOrder order)
        {
            return new Order()
            {
                OrderId = order.OrderId , 
                ClientOrderId = order.ClientOrderId , 
                CreatedAtUtc = order.CreatedAtUtc , 
                UpdatedAtUtc = order.UpdatedAtUtc , 
                SubmittedAtUtc = order.SubmittedAtUtc , 
                FilledAtUtc = order.FilledAtUtc , 
                ExpiredAtUtc = order.ExpiredAtUtc , 
                CancelledAtUtc = order.CancelledAtUtc , 
                FailedAtUtc = order.FailedAtUtc , 
                ReplacedAtUtc = order.ReplacedAtUtc , 
                AssetId = order.AssetId , 
                Symbol = order.Symbol , 
                Notional = order.Notional , 
                Quantity = order.Quantity , 
                FilledQuantity = order.FilledQuantity , 
                IntegerQuantity = order.IntegerQuantity , 
                IntegerFilledQuantity = order.IntegerFilledQuantity , 
                IsSale = order.OrderSide == OrderSide.Sell, 
                TimeInForce = order.TimeInForce.ToString(), 
                AverageFillPrice = order.AverageFillPrice , 
                OrderStatus = order.OrderStatus.ToString(), 
            };
        }
    }
}
