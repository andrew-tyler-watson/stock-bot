using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBot.Domain.Entities.Order
{
    public class Order
    {
        /// <summary>
        /// Gets unique server-side order identifier.
        /// </summary>
        
        public Guid OrderId { get; set; }

        /// <summary>
        /// Gets client-side (user specified) order identifier. Client Order IDs must be unique.
        /// </summary>
        
        public String? ClientOrderId { get; set; }

        /// <summary>
        /// Gets order creation timestamp in UTC.
        /// </summary>
        
        public DateTime? CreatedAtUtc { get; set; }

        /// <summary>
        /// Gets last order update timestamp in UTC.
        /// </summary>
        
        public DateTime? UpdatedAtUtc { get; set; }

        /// <summary>
        /// Gets order submission timestamp in UTC.
        /// </summary>
        
        public DateTime? SubmittedAtUtc { get; set; }

        /// <summary>
        /// Gets order fill timestamp in UTC.
        /// </summary>
        
        public DateTime? FilledAtUtc { get; set; }

        /// <summary>
        /// Gets order expiration timestamp in UTC.
        /// </summary>
        
       public  DateTime? ExpiredAtUtc { get; set; }

        /// <summary>
        /// Gets order cancellation timestamp in UTC.
        /// </summary>
        
        public DateTime? CancelledAtUtc { get; set; }

        /// <summary>
        /// Gets order rejection timestamp in UTC.
        /// </summary>
        
        public DateTime? FailedAtUtc { get; set; }

        /// <summary>
        /// Gets order replacement timestamp in UTC.
        /// </summary>
        
        public DateTime? ReplacedAtUtc { get; set; }

        /// <summary>
        /// Gets unique asset identifier.
        /// </summary>
        
        public Guid AssetId { get; set; }

        /// <summary>
        /// Gets asset symbol.
        /// </summary>
        
        public String Symbol { get; set; }

        /// <summary>
        /// Gets original notional order quantity (with the fractional part).
        /// </summary>
        public Decimal? Notional { get; set; }

        /// <summary>
        /// Gets original fractional order quantity (with the fractional part).
        /// </summary>
        public Decimal? Quantity { get; set; }

        /// <summary>
        /// Gets filled order quantity (with the fractional part).
        /// </summary>
        
        public Decimal FilledQuantity { get; set; }

        /// <summary>
        /// Gets original order quantity (rounded to the nearest integer).
        /// </summary>
        
        public Int64 IntegerQuantity { get; set; }

        /// <summary>
        /// Gets filled order quantity (rounded to the nearest integer).
        /// </summary>
        
        public Int64 IntegerFilledQuantity { get; set; }

        public bool IsSale { get; set; }

        /// <summary>
        /// Gets order duration.
        /// </summary>

        public string TimeInForce { get; set; }

        /// <summary>
        /// Gets order average fill price.
        /// </summary>
        
        public Decimal? AverageFillPrice { get; set; }

        /// <summary>
        /// Gets current order status.
        /// </summary>
        
        public string OrderStatus { get; set; }
    }
}
