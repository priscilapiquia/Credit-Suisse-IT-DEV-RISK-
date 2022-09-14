using ConsoleAppCategorizeTrades.Trades;
using System.Collections.Generic;

namespace ConsoleAppCategorizeTrades.Categories
{
    class Category
    {
        public static List<TypeRisk> GetCategories(Portifolio portifolio)
        {
            List<IRisk> listRisks = new List<IRisk> {
                ProcessRisk.Create(TypeRisk.Expired),
                ProcessRisk.Create(TypeRisk.MediumRisk),
                ProcessRisk.Create(TypeRisk.HighRisk)
            };

            List<TypeRisk> listTypeOfRisk = new List<TypeRisk>();

            foreach (Trade trade in portifolio.Trades)
            {
                TypeRisk typeRisk = TypeRisk.None;
                foreach (IRisk risk in listRisks)
                {
                    if (risk.GetRisk(trade, portifolio.ReferenceDate))
                    {
                        typeRisk = risk.Type;
                        break;
                    }
                }
                listTypeOfRisk.Add(typeRisk);
            }
            return listTypeOfRisk;
        }
    }
}
