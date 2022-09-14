using ConsoleAppCategorizeTrades.Trades;
using System;

namespace ConsoleAppCategorizeTrades
{
    interface IRisk
    {
        TypeRisk Type { get; }
        bool GetRisk(ITrade trade, DateTime ReferenceDate);
    }
}
