using Alpaca.Markets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockbot.Infrastructure.Extensions
{
    public static class EnumMappers
    {
        public static TimeInForce ToTimeInForce(this string enumString)
        {
            switch(enumString)
            {
                case "day":
                    return TimeInForce.Day;
                case "gtc":
                    return TimeInForce.Gtc;
                case "opg":
                    return TimeInForce.Opg;
                case "ioc":
                    return TimeInForce.Ioc;
                case "fok":
                    return TimeInForce.Fok;
                case "cls":
                    return TimeInForce.Cls;
                default: return TimeInForce.Day;
            }
        }
    }
}
