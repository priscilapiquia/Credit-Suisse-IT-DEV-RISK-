using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleAppCategorizeTrades
{
    public enum TypeRisk
    {
        [Description("EXPIRED")]
        Expired,
        [Description("MEDIUMRISK")]
        MediumRisk,
        [Description("HIGHRISK")]
        HighRisk,
        [Description("NONE")]
        None
    }
}
