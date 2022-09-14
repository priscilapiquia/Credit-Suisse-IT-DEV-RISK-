using ConsoleAppCategorizeTrades.Trades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCategorizeTrades
{
    class IPortifolio
    {
        DateTime ReferenceDate { get; set; }
        int NumberOfTrades { get; set; }
        List<Trade> Trades { get; set; }
    }
}
