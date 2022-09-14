using ConsoleAppCategorizeTrades.Categories;
using ConsoleAppCategorizeTrades.Trades;
using System;
using System.Collections.Generic;

namespace ConsoleAppCategorizeTrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Portifolio portfolio = new Portifolio();
            portfolio.NumberOfTrades = 4;
            portfolio.ReferenceDate = new DateTime(2020, 12, 11);
            portfolio.Trades = new List<Trade>();
            portfolio.Trades.Add(new Trade { Value = 2000000, ClientSector = "Private", NextPaymentDate = new DateTime(2025, 12, 29) });
            portfolio.Trades.Add(new Trade { Value = 400000, ClientSector = "Public", NextPaymentDate = new DateTime(2020, 07, 01) });
            portfolio.Trades.Add(new Trade { Value = 5000000, ClientSector = "Public", NextPaymentDate = new DateTime(2024, 01, 02) });
            portfolio.Trades.Add(new Trade { Value = 3000000, ClientSector = "Public", NextPaymentDate = new DateTime(2023, 10, 26) });

            List<TypeRisk> listCategories = Category.GetCategories(portfolio);

            Console.Title = "Categories of Trades";
            Console.WriteLine("Input:\n");
            Console.WriteLine("Reference Date: {0} ", portfolio.ReferenceDate.ToString("dd/MM/yyyyy"));
            Console.WriteLine("Number Of Trades: {0} ", portfolio.NumberOfTrades);
            foreach (ITrade trade in portfolio.Trades)
            {
                Console.WriteLine("Value = {0}, ClientSector = \"{1}\"", trade.Value, trade.ClientSector);
            }
            Console.WriteLine("\n Trade Categories \n");
            foreach (var typeRisk in listCategories)
            {
                Console.WriteLine("Value = {0}", typeRisk.ToString());
            }
            Console.ReadKey();
        }
    }
}
