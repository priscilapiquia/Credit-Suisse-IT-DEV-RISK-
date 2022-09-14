using ConsoleAppCategorizeTrades.Client;
using ConsoleAppCategorizeTrades.Trades;
using System;

namespace ConsoleAppCategorizeTrades
{
    class MediumRisk : IRisk
    {
        public TypeRisk Type { get; private set; }
        public bool GetRisk(ITrade trade, DateTime ReferenceDate)
        {
            if (trade.Value > 1000000 && trade.ClientSector.Equals(TypeClientSector.Public.ToString()))
            {
                Type = TypeRisk.MediumRisk;
                return true;
            }
            else
                return false;
        }
    }
}
