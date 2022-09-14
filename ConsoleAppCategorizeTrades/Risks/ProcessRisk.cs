using System;

namespace ConsoleAppCategorizeTrades
{
    class ProcessRisk
    {
        public static IRisk Create(TypeRisk risk)
        {
            switch (risk)
            {
                case TypeRisk.Expired:
                    return new ExpiredRisk();
                case TypeRisk.MediumRisk:
                    return new MediumRisk();
                case TypeRisk.HighRisk:
                    return new HighRisk();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
