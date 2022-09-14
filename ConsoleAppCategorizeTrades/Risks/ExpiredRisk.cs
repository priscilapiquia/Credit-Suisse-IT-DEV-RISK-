using ConsoleAppCategorizeTrades.Trades;
using System;

namespace ConsoleAppCategorizeTrades
{
    class ExpiredRisk : IRisk
    {
        public TypeRisk Type { get; private set; }
        public bool GetRisk(ITrade trade, DateTime ReferenceDate)
        {
            if (trade.NextPaymentDate.Subtract(ReferenceDate).Days <= 30)
            {
                Type = TypeRisk.Expired;
                return true;
            }
            else
                return false;
        }
    }
}
