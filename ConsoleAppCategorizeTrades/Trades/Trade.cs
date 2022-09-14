using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCategorizeTrades.Trades
{
    class Trade : ITrade
    {
        private static int tradeID = 1;
        public double Value { get; set; }
        public string ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }       
    }
}
