using ConsoleAppCategorizeTrades.Trades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCategorizeTrades
{
    class Portifolio : IPortifolio
    {
        public DateTime ReferenceDate { get; set; }
        public int NumberOfTrades { get; set; }
        public List<Trade> Trades { get; set; }
    }
}
