using ConsoleAppCategorizeTrades.Client;
using ConsoleAppCategorizeTrades.Trades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCategorizeTrades
{
    class HighRisk : IRisk
    {
        public TypeRisk Type { get; private set; }
        public bool GetRisk(ITrade trade, DateTime ReferenceDate)
        {
            if (trade.Value > 1000000 && trade.ClientSector.Equals(TypeClientSector.Private.ToString()))
            {
                Type = TypeRisk.HighRisk;
                return true;
            }
            else
                return false;
        }
    }
}
